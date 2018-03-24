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
    public partial class New_Student : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ACER\Desktop\5th Year\2nd Sem\VB Net\LibraryMngmtSys(P)\Library-Management-System\LibraryMngmt\lib-db.accdb");

        public New_Student()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void New_Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_lib_dbDataSet._lib_students' table. You can move, or remove it, as needed.

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            conn.Open();

            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO `lib-students` (`stud_name`, `stud_guardian`, `stud_course`, `stud_yrlevel`) VALUES('" + stuname.Text + "', '" + stuguardian.Text + "', '" + stucourse.Text + "', '" + stuyrlevel.Text + "')";
            cmd.Parameters.AddWithValue("@stud_name", this.stuname.Text);
            cmd.Parameters.AddWithValue("@stud_guardian", this.stuguardian.Text);
            cmd.Parameters.AddWithValue("@stud_yrlevel", this.stuyrlevel.Text);
            cmd.Parameters.AddWithValue("@stud_course", this.stucourse.Text);
            
            cmd.ExecuteNonQuery();
            this.Validate();
            MessageBox.Show("New Student has been Added to Database");


            Home home = new Home();
            home.bunifuCustomDataGrid1.Refresh();
            home.bunifuCustomDataGrid2.Refresh();


            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void stuname_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(stuname.Text, @"^[\sa-zA-Z]*$")) return;

            stuname.Text = String.Empty;
            MessageBox.Show("Special characters are not allowed.");
        }

        private void stucourse_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(stucourse.Text, @"^[\sa-zA-Z0-9]*$")) return;

            stucourse.Text = String.Empty;
            MessageBox.Show("Special characters are not allowed.");
        }

        private void stuyrlevel_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(stuyrlevel.Text, @"^[0-9]*$")) return;

            stuyrlevel.Text = String.Empty;
            MessageBox.Show("Special characters are not allowed.");
        }

        private void stuguardian_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(stuguardian.Text, @"^[\sa-zA-Z0-9]*$")) return;

            stuguardian.Text = String.Empty;
            MessageBox.Show("Special characters are not allowed.");
        }
    }
}
