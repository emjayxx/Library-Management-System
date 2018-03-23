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
    public partial class Signup : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ACER\Desktop\5th Year\2nd Sem\VB Net\LibraryMngmtSys(P)\Library-Management-System\LibraryMngmt\lib-db.accdb");
        int count = 0;

        public Signup()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (count >= 2)
            { 
                OleDbCommand cmd = conn.CreateCommand();

                cmd.CommandText = "INSERT INTO `lib-admin` (`username`, `admin_name`, `admin_pword`, `secquestion`, `answer`) VALUES('" + uname.Text + "', '" + name.Text + "', '" + pword.Text + "', '" + label3.Text + "', '" + secanswer.Text + "' )";
                cmd.Parameters.AddWithValue("@username", this.uname.Text);
                cmd.Parameters.AddWithValue("@admin_name", this.name.Text);
                cmd.Parameters.AddWithValue("@admin_pword", this.pword.Text);
                cmd.Parameters.AddWithValue("@secquestion", this.label3.Text);
                cmd.Parameters.AddWithValue("@answer", this.secanswer.Text);

                cmd.ExecuteNonQuery();
                this.Validate();
                MessageBox.Show("New Admin, " + name.Text + " has been Registered.");
                conn.Close();


                LogIn login = new LogIn();
                this.Hide();
                login.ShowDialog();
                this.Close();
            } else
            {
                MessageBox.Show("Please accomplish the form correctly!");
            }
        }

        private void confirmpw_TextChanged(object sender, EventArgs e)
        {
            if (pword.Text != null && confirmpw.Text != null)
            {

                if (pword.Text == confirmpw.Text)
                {
                    this.Refresh();
                    confirmpwlabel.Text = "Password confirmed.";
                    confirmpwlabel.ForeColor = Color.DarkSeaGreen;
                    count = count + 1;
                }
                else
                {
                    this.Refresh();
                    confirmpwlabel.Text = "Please confirm password";
                    confirmpwlabel.ForeColor = Color.Tomato;
                }
            }
            else
            {
                this.Refresh();
                confirmpwlabel.Text = "Please confirm password";
                confirmpwlabel.ForeColor = Color.Tomato;
            }
        }

        private void pword_TextChanged(object sender, EventArgs e)
        {
            if (pword.TextLength < 8)
            {
                this.Refresh();
                confirmpwlabel.Text = "Password should be more than or equal to 8 characters";
                confirmpwlabel.ForeColor = Color.Tomato;
            } else
            {
                this.Refresh();
                confirmpwlabel.Text = "Please confirm password";
                confirmpwlabel.ForeColor = Color.Tomato;
            }
        }

        private void uname_TextChanged(object sender, EventArgs e)
        {
            if (uname.Text != null)
            {
                conn.Open();
                int result = 0;
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM `lib-admin` WHERE username = '" + uname.Text + "' ";
                result = (int)cmd.ExecuteScalar();

                if (result > 0)
                {
                    usernamecheck.Text = "Username already used.";
                    usernamecheck.ForeColor = Color.Tomato;
                    conn.Close();
                }
                else
                {
                    usernamecheck.Text = " ";
                    count = count + 1;
                    conn.Close();
                }
            } else {
                usernamecheck.Text = " ";
            }

        }

        private void Signup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_lib_dbDataSet._lib_sec' table. You can move, or remove it, as needed.
            //this.lib_secTableAdapter.Fill(this._lib_dbDataSet._lib_sec);
            
            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM `lib-sec`";

            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                secquestion.Items.Add(reader["secu_q"].ToString());
            }
            conn.Close();
            
        }

        private void secquestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selected = this.secquestion.GetItemText(this.secquestion.SelectedItem);
            conn.Open();
            using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM `lib-sec` WHERE secu_q = '" + selected.ToString() + "' ", conn))
            {
                OleDbDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    label3.Text = read["sec_id"].ToString();
                }
            }
            conn.Close();
        }
    }
}
