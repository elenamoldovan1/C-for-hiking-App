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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp_final_proj_PA
{
    public partial class Rezervari : Form
    {
        SqlConnection myCon = new SqlConnection();
        DataSet dsTip;
        DataSet dsTraseu;
        DataSet dsDisp;
        DataSet dsPer;

        public Rezervari()
        {
            InitializeComponent();
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenut\source\repos\WindowsFormsApp_final_proj_PA\WindowsFormsApp_final_proj_PA\Database1.mdf;Integrated Security=True";
            myCon.Open();
            dsTip = new DataSet();
            dsTraseu = new DataSet();
            dsDisp = new DataSet();
            dsPer = new DataSet();

            textBoxcheckTip.Visible = false;
            textBoxcheckTr.Visible = false;
            textBoxcheckPer.Visible = false;
            textBoxDis.Visible = false;

            SqlDataAdapter daTip = new SqlDataAdapter("SELECT * FROM TipTrasee", myCon);
            daTip.Fill(dsTip, "TipTrasee");
            SqlDataAdapter daTraseu = new SqlDataAdapter("SELECT * FROM Trasee ", myCon);
            daTraseu.Fill(dsTraseu, "Trasee");
            SqlDataAdapter daDisp = new SqlDataAdapter("SELECT * FROM Disponibile ", myCon);
            daDisp.Fill(dsDisp, "Disponibile");
            SqlDataAdapter daPer = new SqlDataAdapter("SELECT * FROM PerioadaTrasee ", myCon);
            daPer.Fill(dsPer, "PerioadaTrasee");

            foreach (DataRow dr in dsTip.Tables["TipTrasee"].Rows)
            {
                String nameTip = dr.ItemArray.GetValue(1).ToString();
                comboBoxTipTr.Items.Add(nameTip);
            }
            
            myCon.Close();
        }

        private void comboBoxTipTr_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTrasee.Items.Clear();
            comboBoxPer.Items.Clear();
            int code1 = 0;
            String tipname = comboBoxTipTr.SelectedItem.ToString();
            foreach (DataRow dr in dsTip.Tables["TipTrasee"].Rows)
            {
                if (tipname == dr.ItemArray.GetValue(1).ToString())
                {
                    code1 = Convert.ToInt16(dr.ItemArray.GetValue(0));
                    textBoxcheckTip.Text = dr.ItemArray.GetValue(0).ToString();
                    
                }
            }
            foreach (DataRow dr in dsTraseu.Tables["Trasee"].Rows)
            {
                              
                if (code1 == Convert.ToInt16(dr.ItemArray.GetValue(2)))
                {
                    String nameTras = dr.ItemArray.GetValue(1).ToString();
                    comboBoxTrasee.Items.Add(nameTras);
                }
            }
            foreach (DataRow dr in dsPer.Tables["PerioadaTrasee"].Rows)
            {
                if (code1 == Convert.ToInt16(dr.ItemArray.GetValue(2)))
                {
                    String Per = dr.ItemArray.GetValue(1).ToString();
                    comboBoxPer.Items.Add(Per);
                }
            }

        }

        private void comboBoxTrasee_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = comboBoxTrasee.SelectedItem.ToString();
            foreach (DataRow dr in dsTraseu.Tables["Trasee"].Rows)
            {
                if (name == dr.ItemArray.GetValue(1).ToString())
                {
                    textBoxcheckTr.Text = dr.ItemArray.GetValue(0).ToString();
                }
            }
        }

        private void comboBoxPer_SelectedIndexChanged(object sender, EventArgs e)
        {
            String perioada = comboBoxPer.SelectedItem.ToString();
            foreach (DataRow dr in dsPer.Tables["PerioadaTrasee"].Rows)
            {
                if (perioada == dr.ItemArray.GetValue(1).ToString())
                {
                    textBoxcheckPer.Text = dr.ItemArray.GetValue(0).ToString();
                }
            }

            
            String codeTr = textBoxcheckTr.Text;
            String codePr = textBoxcheckPer.Text;
            /*textBoxDis.Text = codePr.ToString();*/

            
            foreach (DataRow dr in dsDisp.Tables["Disponibile"].Rows)
            {
                if (codeTr == dr.ItemArray.GetValue(1).ToString() && codePr == dr.ItemArray.GetValue(2).ToString())
                {
                    textBoxDis.Text=dr.ItemArray.GetValue(0).ToString();
                    textBoxPret.Text = dr.ItemArray.GetValue(3).ToString();
                }
            }

        }

        private void buttonSaveR_Click(object sender, EventArgs e)
        {
            myCon.Open();
            SqlDataAdapter adRez = new SqlDataAdapter();
            try
            {

                // Clasa DbCommand implementează metode de interacțiune primară cu baza de date.
                SqlCommand command = new SqlCommand("INSERT INTO Rezervari(IdRez, Nume_Prenume, IdTip, IdTrasee,IdDisp) VALUES(@IdRez, @Nume_Prenume, @IdTip, @IdTrasee, @IdDisp)", myCon);

                command.Parameters.Add("@IdRez", SqlDbType.Int).Value = int.Parse(textBoxIdR.Text);
                command.Parameters.Add("@Nume_Prenume", SqlDbType.Text).Value = textBoxNPRez.Text;
                command.Parameters.Add("@IdTip", SqlDbType.Int).Value = int.Parse(textBoxcheckTip.Text);
                command.Parameters.Add("@IdTrasee", SqlDbType.Int).Value = int.Parse(textBoxcheckTr.Text);
                command.Parameters.Add("@IdDisp", SqlDbType.Int).Value = int.Parse(textBoxDis.Text);

                // DataAdapter permite interschimbarea datelor între data set şi baza de date
                adRez.InsertCommand = command;
                adRez.InsertCommand.ExecuteNonQuery();



                MessageBox.Show("Rezervarea a fost adaugata! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            myCon.Close(); //inchidem conexiunea la db
            textBoxIdR.Text = "";
            textBoxNPRez.Text = "";
            textBoxPret.Text = "";
            comboBoxTipTr.Items.Clear();
            comboBoxTrasee.Items.Clear();
            comboBoxPer.Items.Clear();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Summar Sm = new Summar();
            Sm.Show();
        }
    }
}
