using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Database;

namespace Library
{
    public partial class FormEntrust : Form
    {
        public FormEntrust()
        {
            InitializeComponent();
        }
         int readerId = 0;
        int bookId = 0;
       
        private void FormEntrust_Load(object sender, EventArgs e)
        {
            loadReaders();
            loadBooks();
        }
        void getReader()
        {

            pictureBox1.ImageLocation = Helper.fotoPath(0);
            lblName.Text = "";
            lblSurname.Text = "";
            lblPrice.Text = "0";
            foreach (DataRow row in IDataBase.DataToDataTable("select * from Readers where IsActive=1 and Id=@Id", new SqlParameter("@Id", SqlDbType.Int) { Value = readerId }).Rows)
            {
                pictureBox1.ImageLocation = Helper.fotoPath(readerId);
                lblName.Text = row["Name"].ToString();
                lblSurname.Text = row["Surname"].ToString();
                lblPrice.Text = "0";
            }
            int delayTL = delayPrice();
            if (delayTL > 0)
            {
                lblPrice.Text = string.Format("{0:C}", delayTL);
                lblPrice.BackColor = Color.Red;

            }
            else
            {
                lblPrice.Text = "0";
                lblPrice.BackColor = Color.Transparent;

            }
            bookId = getEntrustId();
            getBook();
        }
        void getBook()
        {
            lblRNumber.Text="" ;
            lblBookName.Text="" ;
            lblWriter.Text ="";

            foreach (DataRow row in IDataBase.DataToDataTable("select * from Books where IsActive=1 and Id=@Id", new SqlParameter("@Id", SqlDbType.Int) { Value = bookId }).Rows)
            {
                lblRNumber.Text = row["RegistrationNumber"].ToString();
                lblBookName.Text = row["BookName"].ToString();
                lblWriter.Text = row["Writer"].ToString();

            }
        }

        private void dgReader_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void loadReaders()
        {
            dgReader.DataSource = IDataBase.DataToDataTable(
                "select * from Readers where IsActive=1 and Name +'' +Surname like @search ",
                new SqlParameter("@search", SqlDbType.NVarChar) { Value=string.Format("%{0}%",txtReader.Text)});
        }
        void loadBooks()
        {
            dgBook.DataSource = IDataBase.DataToDataTable(
                "select * from Books where  IsActive=1 and Status=1 and BookName like @search ",
                new SqlParameter("@search", SqlDbType.NVarChar) { Value = string.Format("%{0}%", txtBook.Text) });
        }

        private void txtReader_TextChanged(object sender, EventArgs e)
        {
            loadReaders();
        }

        private void txtBook_TextChanged(object sender, EventArgs e)
        {
            loadBooks();
        }

        void entrustBook()
        {
            if (readerId == 0 || bookId == 0)
            {
                MessageBox.Show("Select book or reader!");
                return;
            }
            if (getEntrustId() > 0)
            {
                MessageBox.Show("This reader has also estrusted book.");
                return;
            }
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@BookId", SqlDbType.Int) { Value = bookId });
            parameters.Add(new SqlParameter("@ReaderId", SqlDbType.Int) { Value = readerId });
            parameters.Add(new SqlParameter("@EntrustDate", SqlDbType.Date) { Value = DateTime.Now });
            parameters.Add(new SqlParameter("@AcceptedDate", SqlDbType.Date) { Value = DateTime.Now.AddDays(30) });


            IDataBase.executeNonQuery("update Books set Status=0 where Id=@BookId "+
                                      "insert into EntrustBook (BookId,ReaderId,EntrustDate,AcceptedDate) values (@BookId,@ReaderId,@EntrustDate,@AcceptedDate) "
               , parameters);

        }
        int delayPrice()
        {
            int dp = 1;
            int gun = 0;
            foreach (DataRow row in IDataBase.DataToDataTable("select * from EntrustBook where ReaderId= @Id and Status=0 and IsActive=1",
               new SqlParameter("Id", SqlDbType.Int) { Value = readerId }).Rows)
            {
                TimeSpan timeSpan = DateTime.Now - Convert.ToDateTime((row["AcceptedDate"]));
                gun = timeSpan.Days; }
                if (gun > 0) return gun * dp;
           
            return 0;
        }
        int getEntrustId()
        {
            foreach (DataRow row in IDataBase.DataToDataTable("select * from EntrustBook where ReaderId= @Id and Status=0 and IsActive=1",
                new SqlParameter("Id", SqlDbType.Int) { Value = readerId }).Rows)
            {
                return Convert.ToInt32(row["BookId"]);
            }
            return 0;
        }
        private void dgReader_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                readerId = Convert.ToInt32(dgReader.Rows[e.RowIndex].Cells["Id"].Value);
                getReader();
            }
        }

        private void gbReader_Enter(object sender, EventArgs e)
        {

        }

        private void BtnEntrust_Click(object sender, EventArgs e)
        {
            entrustBook();
        }

        private void dgBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                bookId = Convert.ToInt32(dgBook.Rows[e.RowIndex].Cells["Id"].Value);
                getBook();
            }
        }
    }
}
