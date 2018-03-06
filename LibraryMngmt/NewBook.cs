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

namespace LibraryMngmt
{
    public partial class NewBook : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ACER\Desktop\5th Year\2nd Sem\VB Net\LibraryMngmtSys(P)\Library-Management-System\lib-db.accdb");

        public NewBook()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_lib_dbDataSet._lib_books' table. You can move, or remove it, as needed.

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            conn.Open();

            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO `lib-books` (`book_name`, `book_author`, `book_edition`, `book_price`, `book_pages`, `book_status`, `book_borrower`) VALUES('" + bookname.Text + "', '" + bookauthor.Text + "', '" + bookedition.Text + "', '" + bookprice.Text + "', '" + bookpages.Text + "', 'onhand', '0')";
            cmd.Parameters.AddWithValue("@book_name", this.bookname.Text);
            cmd.Parameters.AddWithValue("@book_author", this.bookauthor.Text);
            cmd.Parameters.AddWithValue("@book_edition", this.bookedition.Text);
            cmd.Parameters.AddWithValue("@book_price", this.bookprice.Text);
            cmd.Parameters.AddWithValue("@book_pages", this.bookpages.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("New Book has been Added to Database");

            Home home = new Home();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

    }
}
