using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace LibraryMngmt
{
    public partial class borrow : Form
    {
        //declare new variable named dt as New Datatable
        DataTable dt = new DataTable();
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ACER\Desktop\5th Year\2nd Sem\VB Net\LibraryMngmtSys(P)\Library-Management-System\LibraryMngmt\lib-db.accdb");

        public borrow()
        {
            InitializeComponent();
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

        private void borrow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_lib_dbDataSet._lib_students' table. You can move, or remove it, as needed.
            this.lib_studentsTableAdapter.Fill(this._lib_dbDataSet._lib_students);
            // TODO: This line of code loads data into the '_lib_dbDataSet._lib_books' table. You can move, or remove it, as needed.
            this.lib_booksTableAdapter.Fill(this._lib_dbDataSet._lib_books);

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(searchbox.Text, @"^[\sa-zA-Z0-9]*$")) return;

            searchbox.Text = String.Empty;
            MessageBox.Show("Special characters are not allowed.");

            dt = new DataTable();
            string sql = "SELECT * FROM `lib-students` WHERE stud_name LIKE '%" + searchbox.Text.ToString() + "%' OR stud_course LIKE '%" + searchbox.Text.ToString() + "%' OR stud_yrlevel LIKE '" + searchbox.Text.ToString() + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
            da.Fill(dt);
            bunifuCustomDataGrid2.DataSource = dt;
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

            String studentid = bunifuCustomDataGrid2.CurrentRow.Cells[0].Value.ToString();
            String studentname = bunifuCustomDataGrid2.CurrentRow.Cells[1].Value.ToString();

            DialogResult diagres = MessageBox.Show("The Book: " + book_nameTextBox.Text + " will be BORROWED by " + studentname + ".", "Confirm?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (diagres == DialogResult.Yes)
            {
                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE `lib-books` SET book_borrower='" + studentid + "', book_status='out' WHERE book_name='" + book_nameTextBox.Text + "'";
                cmd.ExecuteNonQuery();
                this.Validate();
                conn.Close();

                MessageBox.Show("The Book: " + book_nameTextBox.Text + " has been Borrowed by " + studentname + ".");

                Home backhome = new Home();
                this.Hide();
                backhome.ShowDialog();
                this.Close();
                
            }
        }
    }
}
