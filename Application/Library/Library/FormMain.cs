using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Database;

namespace Library
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormReader addReader = new FormReader();
            addReader.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormEntrust entrust = new FormEntrust();
            entrust.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            FormAddBook newAddBook = new FormAddBook();
            newAddBook.Show();

            
            
        }

        private void btnIst_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FormSettings editForm = new FormSettings();
            editForm.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
          
        }
        void dgViewLoad(){
            dgEntrusted.DataSource = IDataBase.DataToDataTable("select * from Books where IsActive=1 and Status=1");
            dgBooks.DataSource=IDataBase.DataToDataTable("select * from Books where IsActive=1 and Status=0");
            dgReaders.DataSource = IDataBase.DataToDataTable("select * from Readers where IsActive=1 ");
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            dgViewLoad();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeDate.Text = DateTime.Now.ToString();
        }
    }
}
