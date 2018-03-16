namespace LibraryMngmt
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._lib_dbDataSet = new LibraryMngmt._lib_dbDataSet();
            this.lib_booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lib_booksTableAdapter = new LibraryMngmt._lib_dbDataSetTableAdapters.lib_booksTableAdapter();
            this.tableAdapterManager = new LibraryMngmt._lib_dbDataSetTableAdapters.TableAdapterManager();
            this.lib_studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lib_studentsTableAdapter = new LibraryMngmt._lib_dbDataSetTableAdapters.lib_studentsTableAdapter();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bookidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookauthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookeditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookpagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookborrowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.studidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studcourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studyrlevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studguardianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lib_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bree Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(54, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Management System";
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "About";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 50;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(549, 499);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.MistyRose;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(217, 56);
            this.bunifuFlatButton3.TabIndex = 106;
            this.bunifuFlatButton3.Text = "About";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Raleway", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 30;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "x";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Raleway", 20F);
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuThinButton23.IdleBorderThickness = 2;
            this.bunifuThinButton23.IdleCornerRadius = 30;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.Gray;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton23.Location = new System.Drawing.Point(780, -4);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(26, 32);
            this.bunifuThinButton23.TabIndex = 105;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "New Book";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 40;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(549, 128);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.MistyRose;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(217, 56);
            this.bunifuFlatButton2.TabIndex = 23;
            this.bunifuFlatButton2.Text = "New Book";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Raleway", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "New Student";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 20;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(549, 66);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.MistyRose;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(217, 56);
            this.bunifuFlatButton1.TabIndex = 22;
            this.bunifuFlatButton1.Text = "New Student";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Raleway", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::LibraryMngmt.Properties.Resources.searchpink;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(480, 91);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 32);
            this.button5.TabIndex = 21;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::LibraryMngmt.Properties.Resources.issuebookpink;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(49, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 28);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::LibraryMngmt.Properties.Resources.studpink1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 28);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryMngmt.Properties.Resources.books3;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.lib_booksBindingSource.CurrentChanged += new System.EventHandler(this.lib_booksBindingSource_CurrentChanged);
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
            this.tableAdapterManager.lib_studentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = LibraryMngmt._lib_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lib_studentsBindingSource
            // 
            this.lib_studentsBindingSource.DataMember = "lib-students";
            this.lib_studentsBindingSource.DataSource = this._lib_dbDataSet;
            // 
            // lib_studentsTableAdapter
            // 
            this.lib_studentsTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            this.bunifuCustomDataGrid1.AllowUserToOrderColumns = true;
            this.bunifuCustomDataGrid1.AllowUserToResizeColumns = false;
            this.bunifuCustomDataGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookidDataGridViewTextBoxColumn,
            this.booknameDataGridViewTextBoxColumn,
            this.bookauthorDataGridViewTextBoxColumn,
            this.bookeditionDataGridViewTextBoxColumn,
            this.bookpriceDataGridViewTextBoxColumn,
            this.bookpagesDataGridViewTextBoxColumn,
            this.book_status,
            this.bookborrowerDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid1.DataSource = this.lib_booksBindingSource;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(12, 129);
            this.bunifuCustomDataGrid1.MultiSelect = false;
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.bunifuCustomDataGrid1.RowHeadersVisible = false;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.ShowEditingIcon = false;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(504, 262);
            this.bunifuCustomDataGrid1.TabIndex = 107;
            this.bunifuCustomDataGrid1.VirtualMode = true;
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // bookidDataGridViewTextBoxColumn
            // 
            this.bookidDataGridViewTextBoxColumn.DataPropertyName = "book_id";
            this.bookidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.bookidDataGridViewTextBoxColumn.Name = "bookidDataGridViewTextBoxColumn";
            this.bookidDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookidDataGridViewTextBoxColumn.Width = 25;
            // 
            // booknameDataGridViewTextBoxColumn
            // 
            this.booknameDataGridViewTextBoxColumn.DataPropertyName = "book_name";
            this.booknameDataGridViewTextBoxColumn.HeaderText = "Book Name";
            this.booknameDataGridViewTextBoxColumn.Name = "booknameDataGridViewTextBoxColumn";
            this.booknameDataGridViewTextBoxColumn.ReadOnly = true;
            this.booknameDataGridViewTextBoxColumn.Width = 150;
            // 
            // bookauthorDataGridViewTextBoxColumn
            // 
            this.bookauthorDataGridViewTextBoxColumn.DataPropertyName = "book_author";
            this.bookauthorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.bookauthorDataGridViewTextBoxColumn.Name = "bookauthorDataGridViewTextBoxColumn";
            this.bookauthorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookeditionDataGridViewTextBoxColumn
            // 
            this.bookeditionDataGridViewTextBoxColumn.DataPropertyName = "book_edition";
            this.bookeditionDataGridViewTextBoxColumn.HeaderText = "Ed";
            this.bookeditionDataGridViewTextBoxColumn.Name = "bookeditionDataGridViewTextBoxColumn";
            this.bookeditionDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookeditionDataGridViewTextBoxColumn.Width = 30;
            // 
            // bookpriceDataGridViewTextBoxColumn
            // 
            this.bookpriceDataGridViewTextBoxColumn.DataPropertyName = "book_price";
            this.bookpriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.bookpriceDataGridViewTextBoxColumn.Name = "bookpriceDataGridViewTextBoxColumn";
            this.bookpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookpriceDataGridViewTextBoxColumn.Width = 70;
            // 
            // bookpagesDataGridViewTextBoxColumn
            // 
            this.bookpagesDataGridViewTextBoxColumn.DataPropertyName = "book_pages";
            this.bookpagesDataGridViewTextBoxColumn.HeaderText = "Page#";
            this.bookpagesDataGridViewTextBoxColumn.Name = "bookpagesDataGridViewTextBoxColumn";
            this.bookpagesDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookpagesDataGridViewTextBoxColumn.Width = 40;
            // 
            // book_status
            // 
            this.book_status.DataPropertyName = "book_status";
            this.book_status.HeaderText = "Status";
            this.book_status.Name = "book_status";
            this.book_status.ReadOnly = true;
            this.book_status.Width = 40;
            // 
            // bookborrowerDataGridViewTextBoxColumn
            // 
            this.bookborrowerDataGridViewTextBoxColumn.DataPropertyName = "book_borrower";
            this.bookborrowerDataGridViewTextBoxColumn.HeaderText = "Borrower";
            this.bookborrowerDataGridViewTextBoxColumn.Name = "bookborrowerDataGridViewTextBoxColumn";
            this.bookborrowerDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookborrowerDataGridViewTextBoxColumn.Width = 45;
            // 
            // bunifuCustomDataGrid2
            // 
            this.bunifuCustomDataGrid2.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid2.AllowUserToDeleteRows = false;
            this.bunifuCustomDataGrid2.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid2.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(12, 407);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.ReadOnly = true;
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid2.RowHeadersVisible = false;
            this.bunifuCustomDataGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(437, 150);
            this.bunifuCustomDataGrid2.TabIndex = 108;
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
            // searchbox
            // 
            this.searchbox.BackColor = System.Drawing.Color.MistyRose;
            this.searchbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.searchbox.Location = new System.Drawing.Point(272, 97);
            this.searchbox.MinimumSize = new System.Drawing.Size(0, 25);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(202, 22);
            this.searchbox.TabIndex = 17;
            this.searchbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 30;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Borrow Book";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuThinButton21.IdleBorderThickness = 2;
            this.bunifuThinButton21.IdleCornerRadius = 30;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(549, 247);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(217, 45);
            this.bunifuThinButton21.TabIndex = 146;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
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
            this.bunifuThinButton22.ButtonText = "Return Book";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuThinButton22.IdleBorderThickness = 2;
            this.bunifuThinButton22.IdleCornerRadius = 30;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuThinButton22.Location = new System.Drawing.Point(549, 291);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(217, 45);
            this.bunifuThinButton22.TabIndex = 147;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(55)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(806, 577);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.bunifuCustomDataGrid2);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lib_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lib_studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private _lib_dbDataSet _lib_dbDataSet;
        private System.Windows.Forms.BindingSource lib_booksBindingSource;
        private _lib_dbDataSetTableAdapters.lib_booksTableAdapter lib_booksTableAdapter;
        private _lib_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource lib_studentsBindingSource;
        private _lib_dbDataSetTableAdapters.lib_studentsTableAdapter lib_studentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookauthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookeditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookpagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookborrowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studcourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studyrlevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studguardianDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox searchbox;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        public Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        public Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
    }
}