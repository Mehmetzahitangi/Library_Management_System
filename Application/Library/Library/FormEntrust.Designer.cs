
namespace Library
{
    partial class FormEntrust
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntrust));
            this.gbReader = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReader = new System.Windows.Forms.TextBox();
            this.dgReader = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbBooks = new System.Windows.Forms.GroupBox();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgBook = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblWriter = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblRNumber = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnEntrust = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.gbReader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReader)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBook)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbReader
            // 
            this.gbReader.BackColor = System.Drawing.Color.Transparent;
            this.gbReader.Controls.Add(this.label1);
            this.gbReader.Controls.Add(this.txtReader);
            this.gbReader.Controls.Add(this.dgReader);
            this.gbReader.Controls.Add(this.tableLayoutPanel1);
            this.gbReader.Controls.Add(this.gbBooks);
            this.gbReader.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbReader.Location = new System.Drawing.Point(16, 15);
            this.gbReader.Margin = new System.Windows.Forms.Padding(4);
            this.gbReader.Name = "gbReader";
            this.gbReader.Padding = new System.Windows.Forms.Padding(4);
            this.gbReader.Size = new System.Drawing.Size(959, 438);
            this.gbReader.TabIndex = 0;
            this.gbReader.TabStop = false;
            this.gbReader.Text = "Reader";
            this.gbReader.Enter += new System.EventHandler(this.gbReader_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(647, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // txtReader
            // 
            this.txtReader.Location = new System.Drawing.Point(709, 15);
            this.txtReader.Margin = new System.Windows.Forms.Padding(4);
            this.txtReader.Name = "txtReader";
            this.txtReader.Size = new System.Drawing.Size(240, 22);
            this.txtReader.TabIndex = 3;
            this.txtReader.TextChanged += new System.EventHandler(this.txtReader_TextChanged);
            // 
            // dgReader
            // 
            this.dgReader.AllowUserToAddRows = false;
            this.dgReader.AllowUserToResizeRows = false;
            this.dgReader.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgReader.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReader.Location = new System.Drawing.Point(324, 47);
            this.dgReader.Margin = new System.Windows.Forms.Padding(4);
            this.dgReader.MultiSelect = false;
            this.dgReader.Name = "dgReader";
            this.dgReader.ReadOnly = true;
            this.dgReader.RowHeadersWidth = 51;
            this.dgReader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReader.Size = new System.Drawing.Size(627, 155);
            this.dgReader.TabIndex = 1;
            this.dgReader.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgReader_CellClick);
            this.dgReader.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgReader_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 47);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(308, 117);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSurname, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblPrice, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(119, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(185, 109);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(4, 9);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSurname.Location = new System.Drawing.Point(4, 45);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(75, 18);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(4, 81);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(114, 18);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price of Delay";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbBooks
            // 
            this.gbBooks.Controls.Add(this.txtBook);
            this.gbBooks.Controls.Add(this.label12);
            this.gbBooks.Controls.Add(this.dgBook);
            this.gbBooks.Controls.Add(this.tableLayoutPanel3);
            this.gbBooks.Location = new System.Drawing.Point(12, 209);
            this.gbBooks.Margin = new System.Windows.Forms.Padding(4);
            this.gbBooks.Name = "gbBooks";
            this.gbBooks.Padding = new System.Windows.Forms.Padding(4);
            this.gbBooks.Size = new System.Drawing.Size(947, 229);
            this.gbBooks.TabIndex = 1;
            this.gbBooks.TabStop = false;
            this.gbBooks.Text = "Books";
            // 
            // txtBook
            // 
            this.txtBook.Location = new System.Drawing.Point(697, 21);
            this.txtBook.Margin = new System.Windows.Forms.Padding(4);
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(240, 22);
            this.txtBook.TabIndex = 6;
            this.txtBook.TextChanged += new System.EventHandler(this.txtBook_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(635, 25);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Search";
            // 
            // dgBook
            // 
            this.dgBook.AllowUserToAddRows = false;
            this.dgBook.AllowUserToResizeRows = false;
            this.dgBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBook.Location = new System.Drawing.Point(312, 53);
            this.dgBook.Margin = new System.Windows.Forms.Padding(4);
            this.dgBook.MultiSelect = false;
            this.dgBook.Name = "dgBook";
            this.dgBook.ReadOnly = true;
            this.dgBook.RowHeadersWidth = 51;
            this.dgBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBook.Size = new System.Drawing.Size(627, 167);
            this.dgBook.TabIndex = 4;
            this.dgBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBook_CellClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.89954F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.10046F));
            this.tableLayoutPanel3.Controls.Add(this.lblBookName, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblWriter, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblRegister, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblRNumber, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 53);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(292, 117);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lblBookName
            // 
            this.lblBookName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(114, 50);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(20, 17);
            this.lblBookName.TabIndex = 5;
            this.lblBookName.Text = "...";
            // 
            // lblWriter
            // 
            this.lblWriter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWriter.AutoSize = true;
            this.lblWriter.Location = new System.Drawing.Point(114, 89);
            this.lblWriter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWriter.Name = "lblWriter";
            this.lblWriter.Size = new System.Drawing.Size(20, 17);
            this.lblWriter.TabIndex = 4;
            this.lblWriter.Text = "...";
            // 
            // lblRegister
            // 
            this.lblRegister.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRegister.Location = new System.Drawing.Point(4, 1);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(99, 36);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "Registration Id";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(4, 88);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Writer";
            // 
            // lblRNumber
            // 
            this.lblRNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRNumber.AutoSize = true;
            this.lblRNumber.Location = new System.Drawing.Point(114, 11);
            this.lblRNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRNumber.Name = "lblRNumber";
            this.lblRNumber.Size = new System.Drawing.Size(20, 17);
            this.lblRNumber.TabIndex = 1;
            this.lblRNumber.Text = "...";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(4, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Name";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.BtnEntrust, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnReceive, 1, 0);
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(713, 460);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(261, 48);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // BtnEntrust
            // 
            this.BtnEntrust.BackColor = System.Drawing.Color.Salmon;
            this.BtnEntrust.FlatAppearance.BorderSize = 0;
            this.BtnEntrust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntrust.Location = new System.Drawing.Point(4, 4);
            this.BtnEntrust.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEntrust.Name = "BtnEntrust";
            this.BtnEntrust.Size = new System.Drawing.Size(120, 40);
            this.BtnEntrust.TabIndex = 0;
            this.BtnEntrust.Text = "Entrust";
            this.BtnEntrust.UseVisualStyleBackColor = false;
            this.BtnEntrust.Click += new System.EventHandler(this.BtnEntrust_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.BackColor = System.Drawing.Color.Salmon;
            this.btnReceive.FlatAppearance.BorderSize = 0;
            this.btnReceive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceive.Location = new System.Drawing.Point(134, 4);
            this.btnReceive.Margin = new System.Windows.Forms.Padding(4);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(121, 40);
            this.btnReceive.TabIndex = 2;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = false;
            // 
            // FormEntrust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.entrusted_book;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.gbReader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEntrust";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEntrust";
            this.Load += new System.EventHandler(this.FormEntrust_Load);
            this.gbReader.ResumeLayout(false);
            this.gbReader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReader)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbBooks.ResumeLayout(false);
            this.gbBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBook)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReader;
        private System.Windows.Forms.GroupBox gbBooks;
        private System.Windows.Forms.DataGridView dgReader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReader;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgBook;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblWriter;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblRNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button BtnEntrust;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Label lblPrice;
    }
}