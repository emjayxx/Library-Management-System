namespace LibraryMngmt
{
    partial class borrow
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
            System.Windows.Forms.Label book_idLabel;
            System.Windows.Forms.Label book_nameLabel;
            System.Windows.Forms.Label book_authorLabel;
            System.Windows.Forms.Label book_editionLabel;
            System.Windows.Forms.Label book_priceLabel;
            System.Windows.Forms.Label book_pagesLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(borrow));
            this.label1 = new System.Windows.Forms.Label();
            this._lib_dbDataSet = new LibraryMngmt._lib_dbDataSet();
            this.lib_booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lib_booksTableAdapter = new LibraryMngmt._lib_dbDataSetTableAdapters.lib_booksTableAdapter();
            this.tableAdapterManager = new LibraryMngmt._lib_dbDataSetTableAdapters.TableAdapterManager();
            this.lib_studentsTableAdapter = new LibraryMngmt._lib_dbDataSetTableAdapters.lib_studentsTableAdapter();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.lib_studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.studidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studcourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studyrlevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studguardianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.book_idLabel1 = new System.Windows.Forms.Label();
            this.book_nameTextBox = new System.Windows.Forms.TextBox();
            this.book_authorTextBox = new System.Windows.Forms.TextBox();
            this.book_editionTextBox = new System.Windows.Forms.TextBox();
            this.book_priceTextBox = new System.Windows.Forms.TextBox();
            this.book_pagesTextBox = new System.Windows.Forms.TextBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            book_idLabel = new System.Windows.Forms.Label();
            book_nameLabel = new System.Windows.Forms.Label();
            book_authorLabel = new System.Windows.Forms.Label();
            book_editionLabel = new System.Windows.Forms.Label();
            book_priceLabel = new System.Windows.Forms.Label();
            book_pagesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._lib_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // book_idLabel
            // 
            book_idLabel.AutoSize = true;
            book_idLabel.Font = new System.Drawing.Font("Raleway", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            book_idLabel.ForeColor = System.Drawing.Color.White;
            book_idLabel.Location = new System.Drawing.Point(12, 104);
            book_idLabel.Name = "book_idLabel";
            book_idLabel.Size = new System.Drawing.Size(96, 26);
            book_idLabel.TabIndex = 148;
            book_idLabel.Text = "Book ID:";
            // 
            // book_nameLabel
            // 
            book_nameLabel.AutoSize = true;
            book_nameLabel.Font = new System.Drawing.Font("Raleway", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            book_nameLabel.ForeColor = System.Drawing.Color.White;
            book_nameLabel.Location = new System.Drawing.Point(12, 138);
            book_nameLabel.Name = "book_nameLabel";
            book_nameLabel.Size = new System.Drawing.Size(60, 26);
            book_nameLabel.TabIndex = 150;
            book_nameLabel.Text = "Title:";
            // 
            // book_authorLabel
            // 
            book_authorLabel.AutoSize = true;
            book_authorLabel.Font = new System.Drawing.Font("Raleway", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            book_authorLabel.ForeColor = System.Drawing.Color.White;
            book_authorLabel.Location = new System.Drawing.Point(12, 172);
            book_authorLabel.Name = "book_authorLabel";
            book_authorLabel.Size = new System.Drawing.Size(85, 26);
            book_authorLabel.TabIndex = 152;
            book_authorLabel.Text = "Author:";
            // 
            // book_editionLabel
            // 
            book_editionLabel.AutoSize = true;
            book_editionLabel.Font = new System.Drawing.Font("Raleway", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            book_editionLabel.ForeColor = System.Drawing.Color.White;
            book_editionLabel.Location = new System.Drawing.Point(12, 206);
            book_editionLabel.Name = "book_editionLabel";
            book_editionLabel.Size = new System.Drawing.Size(85, 26);
            book_editionLabel.TabIndex = 154;
            book_editionLabel.Text = "Edition:";
            // 
            // book_priceLabel
            // 
            book_priceLabel.AutoSize = true;
            book_priceLabel.Font = new System.Drawing.Font("Raleway", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            book_priceLabel.ForeColor = System.Drawing.Color.White;
            book_priceLabel.Location = new System.Drawing.Point(12, 240);
            book_priceLabel.Name = "book_priceLabel";
            book_priceLabel.Size = new System.Drawing.Size(68, 26);
            book_priceLabel.TabIndex = 156;
            book_priceLabel.Text = "Price:";
            // 
            // book_pagesLabel
            // 
            book_pagesLabel.AutoSize = true;
            book_pagesLabel.Font = new System.Drawing.Font("Raleway", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            book_pagesLabel.ForeColor = System.Drawing.Color.White;
            book_pagesLabel.Location = new System.Drawing.Point(13, 274);
            book_pagesLabel.Name = "book_pagesLabel";
            book_pagesLabel.Size = new System.Drawing.Size(80, 26);
            book_pagesLabel.TabIndex = 158;
            book_pagesLabel.Text = "Pages:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bree Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 40);
            this.label1.TabIndex = 2;
            // 
            // _lib_dbDataSet
            // 
            this._lib_dbDataSet.DataSetName = "_lib_dbDataSet";
            this._lib_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lib_booksBindingSource
            // 
            this.lib_booksBindingSource.DataMember = "lib-books";
            this.lib_booksBindingSource.DataSource = this._lib_dbDataSet;
            // 
            // lib_booksTableAdapter
            // 
            this.lib_booksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.lib_adminTableAdapter = null;
            this.tableAdapterManager.lib_booksTableAdapter = this.lib_booksTableAdapter;
            this.tableAdapterManager.lib_secTableAdapter = null;
            this.tableAdapterManager.lib_studentsTableAdapter = this.lib_studentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = LibraryMngmt._lib_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lib_studentsTableAdapter
            // 
            this.lib_studentsTableAdapter.ClearBeforeFill = true;
            // 
            // searchbox
            // 
            this.searchbox.BackColor = System.Drawing.Color.MistyRose;
            this.searchbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.searchbox.Location = new System.Drawing.Point(134, 372);
            this.searchbox.MinimumSize = new System.Drawing.Size(0, 25);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(202, 22);
            this.searchbox.TabIndex = 22;
            this.searchbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // lib_studentsBindingSource
            // 
            this.lib_studentsBindingSource.DataMember = "lib-students";
            this.lib_studentsBindingSource.DataSource = this._lib_dbDataSet;
            // 
            // bunifuCustomDataGrid2
            // 
            this.bunifuCustomDataGrid2.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid2.AllowUserToDeleteRows = false;
            this.bunifuCustomDataGrid2.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MistyRose;
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid2.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studidDataGridViewTextBoxColumn,
            this.studnameDataGridViewTextBoxColumn,
            this.studcourseDataGridViewTextBoxColumn,
            this.studyrlevelDataGridViewTextBoxColumn,
            this.studguardianDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid2.DataSource = this.lib_studentsBindingSource;
            this.bunifuCustomDataGrid2.DoubleBuffered = true;
            this.bunifuCustomDataGrid2.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(28, 403);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.ReadOnly = true;
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid2.RowHeadersVisible = false;
            this.bunifuCustomDataGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(437, 185);
            this.bunifuCustomDataGrid2.TabIndex = 109;
            this.bunifuCustomDataGrid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid2_CellContentClick);
            // 
            // studidDataGridViewTextBoxColumn
            // 
            this.studidDataGridViewTextBoxColumn.DataPropertyName = "stud_id";
            this.studidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.studidDataGridViewTextBoxColumn.Name = "studidDataGridViewTextBoxColumn";
            this.studidDataGridViewTextBoxColumn.ReadOnly = true;
            this.studidDataGridViewTextBoxColumn.Width = 30;
            // 
            // studnameDataGridViewTextBoxColumn
            // 
            this.studnameDataGridViewTextBoxColumn.DataPropertyName = "stud_name";
            this.studnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.studnameDataGridViewTextBoxColumn.Name = "studnameDataGridViewTextBoxColumn";
            this.studnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.studnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // studcourseDataGridViewTextBoxColumn
            // 
            this.studcourseDataGridViewTextBoxColumn.DataPropertyName = "stud_course";
            this.studcourseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.studcourseDataGridViewTextBoxColumn.Name = "studcourseDataGridViewTextBoxColumn";
            this.studcourseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studyrlevelDataGridViewTextBoxColumn
            // 
            this.studyrlevelDataGridViewTextBoxColumn.DataPropertyName = "stud_yrlevel";
            this.studyrlevelDataGridViewTextBoxColumn.HeaderText = "Year";
            this.studyrlevelDataGridViewTextBoxColumn.Name = "studyrlevelDataGridViewTextBoxColumn";
            this.studyrlevelDataGridViewTextBoxColumn.ReadOnly = true;
            this.studyrlevelDataGridViewTextBoxColumn.Width = 50;
            // 
            // studguardianDataGridViewTextBoxColumn
            // 
            this.studguardianDataGridViewTextBoxColumn.DataPropertyName = "stud_guardian";
            this.studguardianDataGridViewTextBoxColumn.HeaderText = "Guardian";
            this.studguardianDataGridViewTextBoxColumn.Name = "studguardianDataGridViewTextBoxColumn";
            this.studguardianDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bree Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(151, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 40);
            this.label2.TabIndex = 110;
            this.label2.Text = "Book Borrowing ";
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::LibraryMngmt.Properties.Resources.searchpink;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(342, 366);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 32);
            this.button5.TabIndex = 23;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bree Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(49, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 33);
            this.label4.TabIndex = 161;
            this.label4.Text = "Student\'s Details:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bree Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(49, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 33);
            this.label3.TabIndex = 160;
            this.label3.Text = "Book Details:";
            // 
            // book_idLabel1
            // 
            this.book_idLabel1.Font = new System.Drawing.Font("Raleway", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_idLabel1.ForeColor = System.Drawing.Color.White;
            this.book_idLabel1.Location = new System.Drawing.Point(129, 102);
            this.book_idLabel1.Name = "book_idLabel1";
            this.book_idLabel1.Size = new System.Drawing.Size(100, 23);
            this.book_idLabel1.TabIndex = 149;
            this.book_idLabel1.Text = "label2";
            // 
            // book_nameTextBox
            // 
            this.book_nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.book_nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.book_nameTextBox.Enabled = false;
            this.book_nameTextBox.Font = new System.Drawing.Font("Raleway", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_nameTextBox.ForeColor = System.Drawing.Color.White;
            this.book_nameTextBox.Location = new System.Drawing.Point(134, 138);
            this.book_nameTextBox.Name = "book_nameTextBox";
            this.book_nameTextBox.Size = new System.Drawing.Size(351, 26);
            this.book_nameTextBox.TabIndex = 151;
            // 
            // book_authorTextBox
            // 
            this.book_authorTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.book_authorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.book_authorTextBox.Enabled = false;
            this.book_authorTextBox.Font = new System.Drawing.Font("Raleway", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_authorTextBox.ForeColor = System.Drawing.Color.White;
            this.book_authorTextBox.Location = new System.Drawing.Point(134, 172);
            this.book_authorTextBox.Name = "book_authorTextBox";
            this.book_authorTextBox.Size = new System.Drawing.Size(351, 26);
            this.book_authorTextBox.TabIndex = 153;
            // 
            // book_editionTextBox
            // 
            this.book_editionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.book_editionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.book_editionTextBox.Enabled = false;
            this.book_editionTextBox.Font = new System.Drawing.Font("Raleway", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_editionTextBox.ForeColor = System.Drawing.Color.White;
            this.book_editionTextBox.Location = new System.Drawing.Point(134, 204);
            this.book_editionTextBox.Name = "book_editionTextBox";
            this.book_editionTextBox.Size = new System.Drawing.Size(47, 26);
            this.book_editionTextBox.TabIndex = 155;
            // 
            // book_priceTextBox
            // 
            this.book_priceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.book_priceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.book_priceTextBox.Enabled = false;
            this.book_priceTextBox.Font = new System.Drawing.Font("Raleway", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_priceTextBox.ForeColor = System.Drawing.Color.White;
            this.book_priceTextBox.Location = new System.Drawing.Point(134, 240);
            this.book_priceTextBox.Name = "book_priceTextBox";
            this.book_priceTextBox.Size = new System.Drawing.Size(64, 26);
            this.book_priceTextBox.TabIndex = 157;
            // 
            // book_pagesTextBox
            // 
            this.book_pagesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.book_pagesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.book_pagesTextBox.Enabled = false;
            this.book_pagesTextBox.Font = new System.Drawing.Font("Raleway", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_pagesTextBox.ForeColor = System.Drawing.Color.White;
            this.book_pagesTextBox.Location = new System.Drawing.Point(134, 274);
            this.book_pagesTextBox.Name = "book_pagesTextBox";
            this.book_pagesTextBox.Size = new System.Drawing.Size(64, 26);
            this.book_pagesTextBox.TabIndex = 159;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 30;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "x";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Raleway", 20F);
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuThinButton21.IdleBorderThickness = 2;
            this.bunifuThinButton21.IdleCornerRadius = 30;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Gray;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.Location = new System.Drawing.Point(470, -3);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(26, 32);
            this.bunifuThinButton21.TabIndex = 166;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 30;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuThinButton23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Borrow";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuThinButton23.IdleBorderThickness = 2;
            this.bunifuThinButton23.IdleCornerRadius = 30;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuThinButton23.Location = new System.Drawing.Point(117, 605);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(121, 45);
            this.bunifuThinButton23.TabIndex = 165;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 30;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Back";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuThinButton22.IdleBorderThickness = 2;
            this.bunifuThinButton22.IdleCornerRadius = 30;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuThinButton22.Location = new System.Drawing.Point(252, 605);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(121, 45);
            this.bunifuThinButton22.TabIndex = 164;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::LibraryMngmt.Properties.Resources.newstudentpink;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(17, 327);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 163;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::LibraryMngmt.Properties.Resources.returnbookpink;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(17, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 162;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LibraryMngmt.Properties.Resources.returnbookpink;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(104, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(497, 657);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(book_idLabel);
            this.Controls.Add(this.book_idLabel1);
            this.Controls.Add(book_nameLabel);
            this.Controls.Add(this.book_nameTextBox);
            this.Controls.Add(book_authorLabel);
            this.Controls.Add(this.book_authorTextBox);
            this.Controls.Add(book_editionLabel);
            this.Controls.Add(this.book_editionTextBox);
            this.Controls.Add(book_priceLabel);
            this.Controls.Add(this.book_priceTextBox);
            this.Controls.Add(book_pagesLabel);
            this.Controls.Add(this.book_pagesTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuCustomDataGrid2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "borrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "borrow";
            this.Load += new System.EventHandler(this.borrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this._lib_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private _lib_dbDataSet _lib_dbDataSet;
        private System.Windows.Forms.BindingSource lib_booksBindingSource;
        private _lib_dbDataSetTableAdapters.lib_booksTableAdapter lib_booksTableAdapter;
        private _lib_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private _lib_dbDataSetTableAdapters.lib_studentsTableAdapter lib_studentsTableAdapter;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.BindingSource lib_studentsBindingSource;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn studidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studcourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studyrlevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studguardianDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        public System.Windows.Forms.TextBox book_nameTextBox;
        public System.Windows.Forms.TextBox book_authorTextBox;
        public System.Windows.Forms.TextBox book_editionTextBox;
        public System.Windows.Forms.TextBox book_priceTextBox;
        public System.Windows.Forms.TextBox book_pagesTextBox;
        public System.Windows.Forms.Label book_idLabel1;
    }
}