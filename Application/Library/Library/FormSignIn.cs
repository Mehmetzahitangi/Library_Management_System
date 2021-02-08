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
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar){ Value=txtUsername.Text});
            parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar) { Value = txtPassword.Text });
            DataTable datatable = IDataBase.DataToDataTable(
                "select *from Users where IsActive=1 and Username=@username and Password=@password ", parameters);
            if (datatable.Rows.Count>0) {
                foreach(DataRow dataRow in datatable.Rows)
                {
                    Helper.userId = Convert.ToInt32(dataRow["Id"]);
                    FormMain mf = new FormMain();
                    mf.Show();
                    this.Hide();
                }
            }
            else {
                MessageBox.Show("Invalid entry");
            
            }




        }

        private void FormSignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
