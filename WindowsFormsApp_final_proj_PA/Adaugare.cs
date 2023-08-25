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


namespace WindowsFormsApp_final_proj_PA
{
    public partial class Adaugare : Form
    {
        SqlConnection myCon = new SqlConnection();
        DataSet dsTip;
        DataSet dsTras;
        DataSet dsPerT;
        public Adaugare()
        {
            InitializeComponent();
            
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenut\source\repos\WindowsFormsApp_final_proj_PA\WindowsFormsApp_final_proj_PA\Database1.mdf;Integrated Security=True";
            cmbdisp();
            myCon.Open();
            dsTip = new DataSet();
            dsTras = new DataSet();
            dsPerT = new DataSet();

            textBoxidTip.Visible = false;
            textBoxIdPer.Visible = false;

            SqlDataAdapter daTip = new SqlDataAdapter("SELECT * FROM TipTrasee", myCon);
            daTip.Fill(dsTip, "TipTrasee");
            SqlDataAdapter daTras = new SqlDataAdapter("SELECT * FROM Trasee", myCon);
            daTras.Fill(dsTras, "Trasee");
            SqlDataAdapter daPerT = new SqlDataAdapter("SELECT * FROM PerioadaTrasee", myCon);
            daPerT.Fill(dsPerT, "PerioadaTrasee");
            myCon.Close();
        }


        public void cmbdisp()
        {
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenut\source\repos\WindowsFormsApp_final_proj_PA\WindowsFormsApp_final_proj_PA\Database1.mdf;Integrated Security=True";
            string q = "select * from TipTrasee";
            SqlCommand cmd = new SqlCommand(q, myCon);
            SqlDataReader dr;
            try
            {
                myCon.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String sName = dr.GetString(1);
                    comboBoxTipT.Items.Add(sName);
                }
                myCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxTipT_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPer.Items.Clear();
            int code = 0;
            String tipid = comboBoxTipT.SelectedItem.ToString();
            foreach (DataRow dr in dsTip.Tables["TipTrasee"].Rows)
            {
                if (tipid == dr.ItemArray.GetValue(1).ToString())
                {
                    textBoxidTip.Text = dr.ItemArray.GetValue(0).ToString();
                    code = Convert.ToInt16(dr.ItemArray.GetValue(0));

                }
            }

            foreach (DataRow dr in dsPerT.Tables["PerioadaTrasee"].Rows)
            {
                if (code == Convert.ToInt16(dr.ItemArray.GetValue(2)))
                {
                    String Per = dr.ItemArray.GetValue(1).ToString();
                    comboBoxPer.Items.Add(Per);
                }
            }

        }

        private void buttonAdaug_Click(object sender, EventArgs e)
        {
            myCon.Open();
            SqlDataAdapter adTras = new SqlDataAdapter();
            try
            {

                // Clasa DbCommand implementează metode de interacțiune primară cu baza de date.
                SqlCommand command = new SqlCommand("INSERT INTO Trasee(IdTrasee, Denumire_Traseu, IdTip) VALUES(@IdTrasee, @Denumire_Traseu, @IdTip)", myCon);
                command.Parameters.Add("@IdTrasee", SqlDbType.Int).Value =
                int.Parse(textBoxid.Text);
                command.Parameters.Add("@Denumire_Traseu", SqlDbType.Text).Value =
                textBoxDenT.Text;
                command.Parameters.Add("@IdTip", SqlDbType.Int).Value =
                int.Parse(textBoxidTip.Text);

                // DataAdapter permite interschimbarea datelor între data set şi baza de date
                adTras.InsertCommand = command;
                adTras.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            SqlDataAdapter adDisp = new SqlDataAdapter();
                try
                {

                    // Clasa DbCommand implementează metode de interacțiune primară cu baza de date.
                    
                    SqlCommand command2 = new SqlCommand("INSERT INTO Disponibile(IdTrasee, IdPerioada, Pret) VALUES(@IdTrasee, @IdPerioada, @Pret)", myCon);
                    command2.Parameters.Add("@IdTrasee", SqlDbType.Int).Value =
                    int.Parse(textBoxid.Text);
                    command2.Parameters.Add("@IdPerioada", SqlDbType.Int).Value =
                    int.Parse(textBoxIdPer.Text);
                    command2.Parameters.Add("@Pret", SqlDbType.Text).Value =
                    textBoxpret.Text;

                    // DataAdapter permite interschimbarea datelor între data set şi baza de date
                    adTras.InsertCommand = command2;
                    adTras.InsertCommand.ExecuteNonQuery();


                    MessageBox.Show("Traseul a fost adaugat cu succes ! ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            myCon.Close(); //inchidem conexiunea la db
            textBoxid.Text = "";
            textBoxDenT.Text = "";
            comboBoxTipT.Items.Clear();
            comboBoxPer.Items.Clear();
            textBoxidTip.Text = "";
            textBoxIdPer.Text = "";
            textBoxpret.Text = "";

        }

        private void comboBoxPer_SelectedIndexChanged(object sender, EventArgs e)
        {
            String perid = comboBoxPer.SelectedItem.ToString();
            foreach (DataRow dr in dsPerT.Tables["PerioadaTrasee"].Rows)
            {
                if (perid == dr.ItemArray.GetValue(1).ToString())
                {
                    textBoxIdPer.Text = dr.ItemArray.GetValue(0).ToString();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Interogare Ask = new Interogare();
            Ask.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPeriod newPer = new AddPeriod();
            newPer.Show();
        }
    }
}
