using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Database;

namespace Library
{
    public partial class FormReader : Form
    {
        int readerId = 0;
        public FormReader()
        {
            InitializeComponent();
        }
        void addReaders()
        {
            
           
            List<SqlParameter> parameters = new List<SqlParameter>();
            String gender = "";
            if (rbMale.Checked) { gender = rbMale.Text; }
            else if (rbFemale.Checked) { gender = rbFemale.Text; }
            parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar) { Value = txtName.Text });
            parameters.Add(new SqlParameter("@Surname", SqlDbType.NVarChar) { Value = txtSurname.Text });
            parameters.Add(new SqlParameter("@Gender", SqlDbType.NVarChar) { Value = gender });
            parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar) { Value = maskedPhone.Text });
            parameters.Add(new SqlParameter("@Adress", SqlDbType.NVarChar) { Value = lblAdress.Text });
            object value= IDataBase.executeScalar(
                "insert into Readers(Name,Surname,Gender,Phone,Adress) values (@Name,@Surname,@Gender,@Phone,@Adress) select @@IDENTITY", parameters);
            readerId = Convert.ToInt32(value);
            saveFoto();
            loadReaders();

        }
        void loadReaders()
        {
            dataGridView1.DataSource = IDataBase.DataToDataTable("select * from Readers where IsActive=1 and Name +''+ Surname like @search",
                new SqlParameter("@search", SqlDbType.NVarChar) { Value=string.Format("%{0}%",txtSearch.Text)});
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["IsActive"].Visible = false;

        }
        void showReaders()
        {
            dataGridView1.DataSource = IDataBase.DataToDataTable("select * from Readers where IsActive=1 and Name +' '+Surname like @search",
                new SqlParameter("@search", SqlDbType.NVarChar) { Value = string.Format("%{0}%", txtSearch.Text) });
            dataGridView1.Columns["Name"].Visible = false;
        }

        void updateReaders()
        {


            List<SqlParameter> parameters = new List<SqlParameter>();
            String gender = "";
            if (rbMale.Checked) { gender = rbMale.Text; }
            else if (rbFemale.Checked) { gender = rbFemale.Text; }
            parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar) { Value = txtName.Text });
            parameters.Add(new SqlParameter("@Surname", SqlDbType.NVarChar) { Value = txtSurname.Text });
            parameters.Add(new SqlParameter("@Gender", SqlDbType.NVarChar) { Value = gender });
            parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar) { Value = maskedPhone.Text });
            parameters.Add(new SqlParameter("@Adress", SqlDbType.NVarChar) { Value = tbAdress.Text });
            parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = readerId });


            object value = IDataBase.executeScalar(
                "update Readers set Name=@Name,Surname=@Surname,Gender=@Gender,Phone=@Phone,Adress=@Adress where Id=@Id", parameters);
            readerId = Convert.ToInt32(value);
            saveFoto();
            loadReaders();

        }

        void deleteReader()
        {
            IDataBase.executeNonQuery(" update Readers set IsActive=0 where Id=@Id ",new SqlParameter("@Id", SqlDbType.Int) {Value=readerId });
            loadReaders();
        }

        void clearAll()
        {
            readerId = 0;
            foto = "";
            pictureBox1.ImageLocation = Helper.fotoPath(0);
            rbFemale.Checked = false;
            rbMale.Checked = false;

            foreach (var item in tableLayoutPanel1.Controls)
            {
               
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";

                }
                if (item is ComboBox)

                {
                    ((ComboBox)item).Text = "";

                }
                if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Text = "";

                }

                if (item is RadioButton)
                {
                    ((RadioButton)item).Text = "";

                }



            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void FormReader_Load(object sender, EventArgs e)
        {
            loadReaders();
        }

        private void btnSave_Click(object sender, EventArgs e)
        { if (readerId > 0) updateReaders();
          else addReaders();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {

                    readerId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                    pictureBox1.ImageLocation = Helper.fotoPath(readerId);
                
                foreach (DataRow row in IDataBase.DataToDataTable("select * from Readers where IsActive=1 and Id=@Id",
                    new SqlParameter("@Id", SqlDbType.Int) { Value = readerId }).Rows)
                {
                    
                    txtName.Text = row["Name"].ToString();
                    txtSurname.Text = row["Surname"].ToString();


                    String gender = row["Gender"].ToString();
                        if (gender==rbFemale.Text) {rbFemale.Checked=true; }
                  else if (gender == rbMale.Text) { rbMale.Checked=true; }
                    gender = row["Gender"].ToString();
                    maskedTextBox1.Text = row["Phone"].ToString();
                    tbAdress.Text = row["Adress"].ToString();

                }
            }
        }
       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (readerId>0)
            {
                DialogResult dr = MessageBox.Show("Are you sure", "Delete", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {

                    deleteReader();
                    clearAll();
                }
            }

            else MessageBox.Show("Choose a reader please!");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            loadReaders();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        String foto = "";
        private void btnPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*jpg)| .jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foto = openFileDialog1.FileName;
                pictureBox1.ImageLocation = foto;

            }
        }
        void saveFoto()
        {
            if (!string.IsNullOrEmpty(foto))
            {
                File.Copy(foto, Application.StartupPath + "/pictures/"+readerId+".png",true);
            }
        }
    } 
}
