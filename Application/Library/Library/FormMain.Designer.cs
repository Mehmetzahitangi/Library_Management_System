
namespace Library
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnAddReader = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnEntrust = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.TbControl = new System.Windows.Forms.TabControl();
            this.tpEntrusted = new System.Windows.Forms.TabPage();
            this.dgEntrusted = new System.Windows.Forms.DataGridView();
            this.tpAvailableBooks = new System.Windows.Forms.TabPage();
            this.dgBooks = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgReaders = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timeDate = new System.Windows.Forms.Label();
            this.TbControl.SuspendLayout();
            this.tpEntrusted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrusted)).BeginInit();
            this.tpAvailableBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBooks)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReaders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddReader
            // 
            this.btnAddReader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddReader.BackgroundImage = global::Library.Properties.Resources.Users_Add_User_icon;
            this.btnAddReader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddReader.FlatAppearance.BorderSize = 0;
            this.btnAddReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReader.Location = new System.Drawing.Point(10, 28);
            this.btnAddReader.Name = "btnAddReader";
            this.btnAddReader.Size = new System.Drawing.Size(95, 68);
            this.btnAddReader.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnAddReader, "Add Reader");
            this.btnAddReader.UseVisualStyleBackColor = false;
            this.btnAddReader.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddBook.BackgroundImage = global::Library.Properties.Resources.Science_Courses_icon;
            this.btnAddBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddBook.FlatAppearance.BorderSize = 0;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Location = new System.Drawing.Point(10, 102);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(95, 78);
            this.btnAddBook.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnAddBook, "Add Book");
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnEntrust
            // 
            this.btnEntrust.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEntrust.BackgroundImage = global::Library.Properties.Resources.Messaging_Send_File_icon;
            this.btnEntrust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEntrust.FlatAppearance.BorderSize = 0;
            this.btnEntrust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrust.Location = new System.Drawing.Point(10, 186);
            this.btnEntrust.Name = "btnEntrust";
            this.btnEntrust.Size = new System.Drawing.Size(95, 65);
            this.btnEntrust.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnEntrust, "Entrust Book");
            this.btnEntrust.UseVisualStyleBackColor = false;
            this.btnEntrust.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSettings.BackgroundImage = global::Library.Properties.Resources.Settings_Window_icon;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(10, 257);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(95, 73);
            this.btnSettings.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnSettings, "Settings");
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // TbControl
            // 
            this.TbControl.Controls.Add(this.tpEntrusted);
            this.TbControl.Controls.Add(this.tpAvailableBooks);
            this.TbControl.Controls.Add(this.tabPage3);
            this.TbControl.Location = new System.Drawing.Point(142, 28);
            this.TbControl.Name = "TbControl";
            this.TbControl.SelectedIndex = 0;
            this.TbControl.Size = new System.Drawing.Size(627, 403);
            this.TbControl.TabIndex = 6;
            // 
            // tpEntrusted
            // 
            this.tpEntrusted.Controls.Add(this.dgEntrusted);
            this.tpEntrusted.Location = new System.Drawing.Point(4, 22);
            this.tpEntrusted.Name = "tpEntrusted";
            this.tpEntrusted.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpEntrusted.Size = new System.Drawing.Size(619, 377);
            this.tpEntrusted.TabIndex = 0;
            this.tpEntrusted.Text = "Entrusted Books";
            this.tpEntrusted.UseVisualStyleBackColor = true;
            this.tpEntrusted.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dgEntrusted
            // 
            this.dgEntrusted.AllowUserToAddRows = false;
            this.dgEntrusted.AllowUserToDeleteRows = false;
            this.dgEntrusted.AllowUserToResizeRows = false;
            this.dgEntrusted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEntrusted.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgEntrusted.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgEntrusted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntrusted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgEntrusted.Location = new System.Drawing.Point(3, 3);
            this.dgEntrusted.MultiSelect = false;
            this.dgEntrusted.Name = "dgEntrusted";
            this.dgEntrusted.ReadOnly = true;
            this.dgEntrusted.RowHeadersVisible = false;
            this.dgEntrusted.RowHeadersWidth = 51;
            this.dgEntrusted.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEntrusted.Size = new System.Drawing.Size(613, 371);
            this.dgEntrusted.TabIndex = 0;
            this.dgEntrusted.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tpAvailableBooks
            // 
            this.tpAvailableBooks.Controls.Add(this.dgBooks);
            this.tpAvailableBooks.Location = new System.Drawing.Point(4, 22);
            this.tpAvailableBooks.Name = "tpAvailableBooks";
            this.tpAvailableBooks.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpAvailableBooks.Size = new System.Drawing.Size(619, 377);
            this.tpAvailableBooks.TabIndex = 1;
            this.tpAvailableBooks.Text = "Available Books";
            this.tpAvailableBooks.UseVisualStyleBackColor = true;
            this.tpAvailableBooks.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dgBooks
            // 
            this.dgBooks.AllowUserToAddRows = false;
            this.dgBooks.AllowUserToDeleteRows = false;
            this.dgBooks.AllowUserToResizeRows = false;
            this.dgBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgBooks.Location = new System.Drawing.Point(3, 3);
            this.dgBooks.MultiSelect = false;
            this.dgBooks.Name = "dgBooks";
            this.dgBooks.ReadOnly = true;
            this.dgBooks.RowHeadersVisible = false;
            this.dgBooks.RowHeadersWidth = 51;
            this.dgBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBooks.Size = new System.Drawing.Size(613, 371);
            this.dgBooks.TabIndex = 0;
            this.dgBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgReaders);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(619, 377);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Readers";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dgReaders
            // 
            this.dgReaders.AllowUserToAddRows = false;
            this.dgReaders.AllowUserToDeleteRows = false;
            this.dgReaders.AllowUserToResizeRows = false;
            this.dgReaders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgReaders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgReaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgReaders.Location = new System.Drawing.Point(3, 3);
            this.dgReaders.MultiSelect = false;
            this.dgReaders.Name = "dgReaders";
            this.dgReaders.ReadOnly = true;
            this.dgReaders.RowHeadersVisible = false;
            this.dgReaders.RowHeadersWidth = 51;
            this.dgReaders.Size = new System.Drawing.Size(613, 371);
            this.dgReaders.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeDate
            // 
            this.timeDate.AutoSize = true;
            this.timeDate.Location = new System.Drawing.Point(28, 7);
            this.timeDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeDate.Name = "timeDate";
            this.timeDate.Size = new System.Drawing.Size(78, 13);
            this.timeDate.TabIndex = 7;
            this.timeDate.Text = "Time And Date";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timeDate);
            this.Controls.Add(this.TbControl);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnEntrust);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnAddReader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Activated += new System.EventHandler(this.FormMain_Activated);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.TbControl.ResumeLayout(false);
            this.tpEntrusted.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrusted)).EndInit();
            this.tpAvailableBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBooks)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgReaders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddReader;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnEntrust;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.TabControl TbControl;
        private System.Windows.Forms.TabPage tpEntrusted;
        private System.Windows.Forms.DataGridView dgEntrusted;
        private System.Windows.Forms.TabPage tpAvailableBooks;
        private System.Windows.Forms.DataGridView dgBooks;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgReaders;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeDate;
    }
}