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
    public partial class forgotpw : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ACER\Desktop\5th Year\2nd Sem\VB Net\LibraryMngmtSys(P)\Library-Management-System\LibraryMngmt\lib-db.accdb");
        int count = 0;

        public forgotpw()
        {
            InitializeComponent();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM `lib-admin` WHERE username LIKE '"+usersearch.Text+"' ";

            OleDbDataReader reader = cmd.ExecuteReader();

            if(reader.Read())
            {
                name.Text = reader["admin_name"].ToString();
                
                cmd.CommandText = "SELECT * FROM `lib-sec` WHERE sec_id LIKE '" + reader["secquestion"].ToString() + "' ";
                conn.Close();
                conn.Open();
                OleDbDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    secquestion.Text = read["secu_q"].ToString();
                }
                conn.Close();

            } else
            {
                MessageBox.Show("No such username found.");
                usersearch.Text = String.Empty;
                name.Text = String.Empty;
                secquestion.Text = String.Empty;
                usersearch.Focus();
            }
            
            conn.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM `lib-admin` WHERE username LIKE '" + usersearch.Text + "' ";

            OleDbDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                String useranswer = reader["answer"].ToString();

                if (useranswer.Equals(secanswer.Text, StringComparison.InvariantCultureIgnoreCase))
                {
                    cmd.CommandText = "UPDATE `lib-admin` SET admin_pword = '"+newpw.Text+"' WHERE username LIKE '" + usersearch.Text + "' ";
                    conn.Close();
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    this.Validate();
                    conn.Close();

                    MessageBox.Show(name.Text+": your password has been successfully changed.");

                    LogIn login = new LogIn();
                    this.Hide();
                    login.ShowDialog();
                    this.Close();
                } else
                {
                    MessageBox.Show("Your answer is incorrect, please try again.");
                    secanswer.Text = String.Empty;
                    newpw.Text = String.Empty;
                    textBox1.Text = String.Empty;
                    secanswer.Focus();
                }
            }

            conn.Close();
        }

        private void newpw_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(newpw.Text, @"^[\sa-zA-Z0-9]*$")) return;

            newpw.Text = String.Empty;
            MessageBox.Show("Special characters are not allowed.");

            if (newpw.TextLength > 7)
            {
                this.Refresh();
                pwcorrect.Text = "OK";
                pwcorrect.ForeColor = Color.DarkSeaGreen;
            }
            else
            {
                this.Refresh();
                pwcorrect.Text = "X";
                pwcorrect.ForeColor = Color.Tomato;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"^[\sa-zA-Z0-9]*$")) return;

            textBox1.Text = String.Empty;
            MessageBox.Show("Special characters are not allowed.");

            if (newpw.Text != null && textBox1.Text != null)
            {

                if (newpw.Text == textBox1.Text)
                {
                    this.Refresh();
                    confirmcorrect.Text = "OK";
                    confirmcorrect.ForeColor = Color.DarkSeaGreen;
                    count = count + 1;
                }
                else
                {
                    this.Refresh();
                    confirmcorrect.Text = "X";
                    confirmcorrect.ForeColor = Color.Tomato;
                }
            }
            else
            {
                this.Refresh();
                confirmcorrect.Text = "X";
                confirmcorrect.ForeColor = Color.Tomato;
            }
        }

        private void usersearch_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(usersearch.Text, @"^[\sa-zA-Z0-9]*$")) return;

            usersearch.Text = String.Empty;
            MessageBox.Show("Special characters are not allowed.");
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(name.Text, @"^[\sa-zA-Z]*$")) return;

            name.Text = String.Empty;
            MessageBox.Show("Special characters are not allowed.");
        }

        private void secanswer_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(secanswer.Text, @"^[\sa-zA-Z0-9]*$")) return;

            secanswer.Text = String.Empty;
            MessageBox.Show("Special characters are not allowed.");
        }
    }
}
