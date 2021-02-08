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
    public partial class FormSettings : Form
    {
        int rowId=0;

        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {

        }
        /*Publisher
        Type
        Writer*/
        string getTableName()
        {
            switch (cbTable.SelectedIndex)
            {
                case 0: return "Publisher";
                case 1:
                    return "Type";
                case 2:
                    return "Writers";
                default:  return "";

            }
        }
        void tableLoad()
        {
            dataGridView1.DataSource = IDataBase.DataToDataTable(" select * from " + getTableName());
        }

        private void cbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableLoad();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
             
                rowId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                tbName.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].ToString();

            }
        }
        void add()
        {
            IDataBase.executeNonQuery("insert into" + getTableName() + " (Name) values (@Name)", new SqlParameter("@Name", SqlDbType.NVarChar) { Value = tbName.Text });
            
            MessageBox.Show(getTableName() + " is added.");
            tableLoad();    
        }
        void update()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar) { Value = tbName.Text });
            parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value =rowId });
            IDataBase.executeNonQuery("UPDATE "+getTableName()+" set Name=@Name where Id=@Id",parameters);
            MessageBox.Show(getTableName() + " is updated.");

            tableLoad();


        }
        void delete()
        {
            IDataBase.executeNonQuery("delete" + getTableName() + " where Id=@Id", new SqlParameter("@Id", SqlDbType.Int) { Value = rowId });
            clear();
            tableLoad();
        }
        void clear()
        {
            rowId = 0;
            tbName.Text = "";
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        { 
            if (string.IsNullOrEmpty(getTableName())){
                MessageBox.Show("Choose the table name please.");
                return;
            }
            
            if (rowId > 0)
            {
                string table = getTableName();
                List<SqlParameter> parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar) { Value = tbName.Text });
                parameters.Add(new SqlParameter("@id", SqlDbType.Int) { Value = rowId });
                IDataBase.executeNonQuery("update" + table + " set Name=@name , Id=@id", parameters);
                tableLoad();
            }
            }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(getTableName())){
                MessageBox.Show("Choose the table name please.");
                return;
            }
            if (rowId > 0) { update(); }
            else add();

           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rowId > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this row ","Delete",MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    delete();
                    clear();
            tableLoad();
                }
            }
            MessageBox.Show("Select the row to be deleted ");


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

  
    }

