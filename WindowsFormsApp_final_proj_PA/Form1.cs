using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
namespace WindowsFormsApp_final_proj_PA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void interogareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interogare Ask = new Interogare();
            Ask.Show();
        }

        private void adaugareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adaugare Add = new Adaugare();
            Add.Show();

        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StergeTraseu Dt = new StergeTraseu();
            Dt.Show();
        }

        private void rezervariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rezervari Rz = new Rezervari();
            Rz.Show();
        }
    }
}
