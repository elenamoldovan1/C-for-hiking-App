using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_final_proj_PA
{
    public partial class Summar : Form
    {
        public Summar()
        {
            InitializeComponent();
        }

        private void Summar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet2.Rez2' table. You can move, or remove it, as needed.
            this.rez2TableAdapter2.Fill(this.database1DataSet2.Rez2);
            // TODO: This line of code loads data into the 'database1DataSet1.Rez2' table. You can move, or remove it, as needed.
            this.rez2TableAdapter1.Fill(this.database1DataSet1.Rez2);
            // TODO: This line of code loads data into the 'database1DataSet.Rez2' table. You can move, or remove it, as needed.
            this.rez2TableAdapter.Fill(this.database1DataSet.Rez2);
            // TODO: This line of code loads data into the 'database1DataSet.Rez2' table. You can move, or remove it, as needed.
            this.rez2TableAdapter.Fill(this.database1DataSet.Rez2);

        }
    }
}
