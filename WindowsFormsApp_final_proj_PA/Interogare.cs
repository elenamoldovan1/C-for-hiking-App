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

namespace WindowsFormsApp_final_proj_PA
{
    public partial class Interogare : Form
    {
        SqlConnection myCon = new SqlConnection();
        DataSet dsTip;
        DataSet dsTraseu;
        DataSet dsPerioada;
        DataSet dsDisp;

        public Interogare()
        {
            InitializeComponent();
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenut\source\repos\WindowsFormsApp_final_proj_PA\WindowsFormsApp_final_proj_PA\Database1.mdf;Integrated Security=True";
            myCon.Open();
            dsTip = new DataSet();
            dsTraseu = new DataSet();
            dsPerioada = new DataSet();
            dsDisp = new DataSet();

            textBoxidP.Visible = false;
            textBoxidT.Visible = false;

            SqlDataAdapter daTip = new SqlDataAdapter("SELECT * FROM TipTrasee", myCon);
            daTip.Fill(dsTip, "TipTrasee");
            SqlDataAdapter daTraseu = new SqlDataAdapter("SELECT * FROM Trasee ", myCon);
            daTraseu.Fill(dsTraseu, "Trasee");
            SqlDataAdapter daPerioada = new SqlDataAdapter("SELECT * FROM PerioadaTrasee ", myCon);
            daPerioada.Fill(dsPerioada, "PerioadaTrasee");
            SqlDataAdapter daDisp = new SqlDataAdapter("SELECT * FROM Disponibile ", myCon);
            daDisp.Fill(dsDisp, "Disponibile");

            foreach (DataRow dr in dsTip.Tables["TipTrasee"].Rows)
            {
                String nameTip = dr.ItemArray.GetValue(1).ToString();
                listBoxTip.Items.Add(nameTip);
            }

            myCon.Close();
        }

        private void listBoxTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxDisp.Items.Clear();
            listBoxPer.Items.Clear();
            int code1 = 0;
            String tipname = listBoxTip.SelectedItem.ToString();
            foreach (DataRow dr in dsTip.Tables["TipTrasee"].Rows)
            {
                if (tipname == dr.ItemArray.GetValue(1).ToString())
                {
                    textBoxDurata.Text = dr.ItemArray.GetValue(2).ToString();
                    code1 = Convert.ToInt16(dr.ItemArray.GetValue(0));

                }
            }
            foreach (DataRow dr in dsTraseu.Tables["Trasee"].Rows)
            {
                if (code1 == Convert.ToInt16(dr.ItemArray.GetValue(2)))
                {
                    String nameTras = dr.ItemArray.GetValue(1).ToString();
                    listBoxDisp.Items.Add(nameTras);
                }
            }
            foreach (DataRow dr in dsPerioada.Tables["PerioadaTrasee"].Rows)
            {
                if (code1 == Convert.ToInt16(dr.ItemArray.GetValue(2)))
                {
                    String Perioada = dr.ItemArray.GetValue(1).ToString();
                    listBoxPer.Items.Add(Perioada);
                }
            }

        }

        private void listBoxDisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            String trname = listBoxDisp.SelectedItem.ToString();
            foreach (DataRow dr in dsTraseu.Tables["Trasee"].Rows)
            {
                if (trname == dr.ItemArray.GetValue(1).ToString())
                {
                    textBoxidT.Text = dr.ItemArray.GetValue(0).ToString();            
                }
            }
         
        }

        private void listBoxPer_SelectedIndexChanged(object sender, EventArgs e)
        {
            String prname = listBoxPer.SelectedItem.ToString();
            foreach (DataRow dr in dsPerioada.Tables["PerioadaTrasee"].Rows)
            {
                if (prname == dr.ItemArray.GetValue(1).ToString())
                {
                    textBoxidP.Text = dr.ItemArray.GetValue(0).ToString();
                }
            }

            String codeTr = textBoxidT.Text;
            String codePr = textBoxidP.Text;

            foreach (DataRow dr in dsDisp.Tables["Disponibile"].Rows)
            {
                if (codeTr == dr.ItemArray.GetValue(1).ToString() && codePr == dr.ItemArray.GetValue(2).ToString())
                {
                    textBoxPret.Text = dr.ItemArray.GetValue(3).ToString();
                }
            }

        }
    }
}
