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
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void txtpassw2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtName.Text)
                || string.IsNullOrEmpty(txtSurname.Text)
                || string.IsNullOrEmpty(txtuname.Text)
                || string.IsNullOrEmpty(txtpassw1.Text)
                || string.IsNullOrEmpty(txtpassw2.Text))
            {
                MessageBox.Show("Invalid entry, empty field");
                return;

            }
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar) { Value=txtName.Text});
            parameters.Add(new SqlParameter("@surname", SqlDbType.NVarChar) { Value = txtSurname.Text });

            parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar) { Value = txtuname.Text });

            parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar) { Value = txtpassw1.Text });
            IDataBase.executeNonQuery("insert into Users (Name,Surname,Username,Password) values (@name,@surname,@username,@password)", parameters);
            FormSignIn newIn = new FormSignIn();
            newIn.Show();
            this.Hide();


        }
    }
}
