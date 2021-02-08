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
    public partial class FormAddBook : Form
    {
        int bookId = 0;
        public FormAddBook()
        {
            InitializeComponent();
            showBooks();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (bookId > 0) updateBook();
            else addBook();

        }

        private void FormAddBook_Load(object sender, EventArgs e)
        {
            fillComBomboxes();

        }
        void fillComBomboxes()
        {
            foreach (DataRow row in IDataBase.DataToDataTable("select * from Type").Rows)
            {
                cbType.Items.Add(row["Name"].ToString());
            }
           foreach (DataRow row in IDataBase.DataToDataTable("select * from Writers").Rows)
            {
                cbWriter.Items.Add(row["Name"].ToString());
            }
            foreach (DataRow row in IDataBase.DataToDataTable("select * from Publisher").Rows)
            {
                cbPublisher.Items.Add(row["Name"].ToString());
            }
        }
        int getRegistrationNumber()
        {
            foreach (DataRow row in IDataBase.DataToDataTable("select ISNULL(MAX(RegistrationNumber),0)+1 from Books where IsActive=1").Rows)
            { return Convert.ToInt32(row[0]); }
            return 1;
        }
        void addBook()
        {
            int rno = getRegistrationNumber();
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@RegistrationNumber", SqlDbType.Int) { Value = rno });
            parameters.Add(new SqlParameter("@BookName", SqlDbType.NVarChar) { Value = tbBookName.Text});
            parameters.Add(new SqlParameter("@PublicationDate", SqlDbType.NVarChar) { Value = tbPublishDate.Text });
            parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar) { Value = cbType.Text });
            parameters.Add(new SqlParameter("@Publisher", SqlDbType.NVarChar) { Value = cbPublisher.Text });
            parameters.Add(new SqlParameter("@Comment", SqlDbType.NVarChar) { Value = tbComment.Text });
            parameters.Add(new SqlParameter("@Writer", SqlDbType.NVarChar) { Value = cbWriter.Text });
            IDataBase.executeNonQuery("insert into Books(RegistrationNumber,BookName,PublicationDate,Type,Publisher,Comment,Writer) " +
                "values " +
                "(@RegistrationNumber,@BookName,@PublicationDate,@Type,@Publisher,@Comment,@Writer)", parameters);
            tbRegisterNo.Text = rno.ToString();
            
            MessageBox.Show("Successfully");


        }
        void showBooks()
        {
            dgBooks.DataSource = IDataBase.DataToDataTable("select * from Books where IsActive=1 and Writer +' '+BookName like @search",
                new SqlParameter("@search",SqlDbType.NVarChar) { Value=string.Format("%{0}%",tbSearch.Text) });
            dgBooks.Columns["Id"].Visible = false;
        }

        void updateBook()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = bookId });
            parameters.Add(new SqlParameter("@BookName", SqlDbType.NVarChar) { Value = tbBookName.Text });
            parameters.Add(new SqlParameter("@PublicationDate", SqlDbType.NVarChar) { Value = tbPublishDate.Text });
            parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar) { Value = cbType.Text });
            parameters.Add(new SqlParameter("@Publisher", SqlDbType.NVarChar) { Value = cbPublisher.Text });
            parameters.Add(new SqlParameter("@Comment", SqlDbType.NVarChar) { Value = tbComment.Text });
            parameters.Add(new SqlParameter("@Writer", SqlDbType.NVarChar) { Value = cbWriter.Text });
            IDataBase.executeNonQuery("update Books set BookName=@BookName,PublicationDate=@PublicationDate,Type=@Type,Publisher=@Publisher,Comment=@Comment,Writer=@Writer where Id=@Id", parameters);

            showBooks();
            MessageBox.Show("Successfully");



        }
        // select * from Books where IsActive=1 and Writer +' '+BookName like %deneme% 

        void deleteBooks()
        {
            IDataBase.executeNonQuery("update Books set IsActive=0 where Id=@id",new SqlParameter("@id", SqlDbType.Int) { Value = bookId});

            showBooks();
            clearAll();
            MessageBox.Show("Successfully");

        }

        void clearAll()
        {
            foreach(var item in tableLayoutPanel1.Controls)
            {
                bookId = 0;
                if (item is TextBox)
                {
                    ((TextBox)item).Text="";

                }
                if (item is ComboBox)

                {
                    ((ComboBox)item).Text = "";

                }


            }

        }
        private void dgBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                bookId = Convert.ToInt32(dgBooks.Rows[e.RowIndex].Cells["Id"].Value);

                foreach (DataRow row in IDataBase.DataToDataTable("select * from Books where IsActive = 1 and Id = @id" , new SqlParameter("@id", SqlDbType.Int){ Value = bookId }).Rows){
                    tbRegisterNo.Text = row["RegistrationNumber"].ToString();
                    tbBookName.Text = row["BookName"].ToString();
                    tbPublishDate.Text = row["PublicationDate"].ToString();
                    cbType.Text = row["Type"].ToString();
                    cbPublisher.Text = row["Publisher"].ToString();
                    tbComment.Text = row["Comment"].ToString();
                    cbWriter.Text=  row["Writer"].ToString();

                }

        } }

        private void button3_Click(object sender, EventArgs e)
        {
           if(bookId>0) {
                DialogResult dr = MessageBox.Show("Are you sure", "", MessageBoxButtons.YesNo);
               
                if(dr==DialogResult.Yes)deleteBooks();


            }

            else MessageBox.Show("Choose a book please!");
            


        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            showBooks();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
