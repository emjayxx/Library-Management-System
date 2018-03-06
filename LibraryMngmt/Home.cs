using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LibraryMngmt
{
    public partial class Home : Form
    {
        //declare new variable named dt as New Datatable
        DataTable dt = new DataTable();
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ACER\Desktop\5th Year\2nd Sem\VB Net\LibraryMngmtSys(P)\Library-Management-System\LibraryMngmt\lib-db.accdb");

        public Home()
        {
            InitializeComponent();         
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            New_Student newstd = new New_Student();
            this.Hide();
            newstd.ShowDialog();
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            NewBook newbk = new NewBook();
            this.Hide();
            newbk.ShowDialog();
            this.Close();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lib_booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lib_booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._lib_dbDataSet);

        }

        private void lib_booksBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.lib_booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._lib_dbDataSet);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //Update
            this.lib_booksTableAdapter.Update(this._lib_dbDataSet._lib_books);
            this.lib_studentsTableAdapter.Update(this._lib_dbDataSet._lib_students);

            //Fill
            this.lib_studentsTableAdapter.Fill(this._lib_dbDataSet._lib_students);
            this.lib_booksTableAdapter.Fill(this._lib_dbDataSet._lib_books);
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dt = new DataTable();
            string sql = "SELECT * FROM `lib-books` WHERE book_name LIKE '%" + searchbox.Text.ToString() + "%' OR book_author LIKE '%" + searchbox.Text.ToString() + "%' OR book_status LIKE '" + searchbox.Text.ToString() + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
            da.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            searchbox.Show();
            button5.Enabled = true;
        }
    }
}

