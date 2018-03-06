using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMngmt
{
    public partial class Home : Form
    {
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
            // TODO: This line of code loads data into the '_lib_dbDataSet._lib_books' table. You can move, or remove it, as needed.
            this.lib_booksTableAdapter.Fill(this._lib_dbDataSet._lib_books);
        }
    }
}

