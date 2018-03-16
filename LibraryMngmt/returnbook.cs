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
    public partial class returnbook : Form
    {
        //declare new variable named dt as New Datatable
        DataTable dt = new DataTable();
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ACER\Desktop\5th Year\2nd Sem\VB Net\LibraryMngmtSys(P)\Library-Management-System\LibraryMngmt\lib-db.accdb");

        public returnbook()
        {
            InitializeComponent();
        }

        private void Returnbook_Load(object sender, EventArgs e)
        {
        }

        private void book_editionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void book_nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void book_authorTextBox_TextChanged(object sender, EventArgs e)
        {

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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            String studentname = label10.Text;

            DialogResult diagres = MessageBox.Show("The Book: " + book_nameTextBox.Text + " will be RETURNED by " + studentname + ".", "Confirm?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (diagres == DialogResult.Yes)
            {
                conn.Open();

                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE `lib-books` SET book_borrower='0', book_status='in' WHERE book_name='" + book_nameTextBox.Text + "'";
                cmd.ExecuteNonQuery();
                this.Validate();

                MessageBox.Show("The Book: " + book_nameTextBox.Text + " has been RETURNED by " + studentname + ".");

                Home backhome = new Home();
                this.Hide();
                backhome.ShowDialog();
                this.Close();
            }
        }
    }
}
