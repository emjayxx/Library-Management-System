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
    public partial class LogIn : Form
    {
        //add connection to DB
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ACER\Desktop\5th Year\2nd Sem\VB Net\LibraryMngmtSys(P)\Library-Management-System\LibraryMngmt\lib-db.accdb");

        public LogIn()
        {
            InitializeComponent();
        }

        

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            int result = 0;
            string cmdText = "SELECT COUNT(*) FROM `lib-admin` WHERE username = '" + uname.Text+"' AND admin_pword = '"+pword.Text+"' ";
            using (OleDbCommand cmd = new OleDbCommand(cmdText, conn))
            {
                conn.Open();
                result = (int)cmd.ExecuteScalar();

                if (result > 0)
                {
                    using (OleDbCommand Command = new OleDbCommand("SELECT * FROM `lib-admin` WHERE username = '"+ uname.Text +"' ", conn))
                    {
                        OleDbDataReader DB_Reader = Command.ExecuteReader();

                        if (DB_Reader.Read())
                        {
                            Home home = new Home();
                            this.Hide();
                            home.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Login Error.");

                            uname.Text = String.Empty;
                            pword.Text = String.Empty;
                            uname.Focus();
                        }
                        DB_Reader.Close();
                        conn.Close();
                    }
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Invalid log-in. Please try again.");
                    uname.Text = String.Empty;
                    pword.Text = String.Empty;
                    uname.Focus();

                }

            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Signup sign = new Signup();
            this.Hide();
            sign.ShowDialog();
            this.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            forgotpw forgotpw = new forgotpw();
            this.Hide();
            forgotpw.ShowDialog();
            this.Close();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
