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
using System.Data.Common;

namespace WindowsFormsApp_final_proj_PA
{
    public partial class AddPeriod : Form
    {
        SqlConnection myCon = new SqlConnection();
        DataSet dsPer;
        DataSet dsTip;
        public AddPeriod()
        {
            InitializeComponent();
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenut\source\repos\WindowsFormsApp_final_proj_PA\WindowsFormsApp_final_proj_PA\Database1.mdf;Integrated Security=True";
            myCon.Open();
            dsPer = new DataSet();
            dsTip = new DataSet();

            textBoxid.Visible = false;

            SqlDataAdapter daPer = new SqlDataAdapter("SELECT * FROM PerioadaTrasee", myCon);
            daPer.Fill(dsPer, "PerioadaTrasee");
            SqlDataAdapter daTip = new SqlDataAdapter("SELECT * FROM TipTrasee", myCon);
            daTip.Fill(dsTip, "TipTrasee");

            foreach (DataRow dr in dsTip.Tables["TipTrasee"].Rows)
            {
                String nameTip = dr.ItemArray.GetValue(1).ToString();
                comboBoxTipTr.Items.Add(nameTip);
            }

            myCon.Close();
        }

        private void comboBoxTipTr_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxid.Clear();
            String tipid = comboBoxTipTr.SelectedItem.ToString();
            foreach (DataRow dr in dsTip.Tables["TipTrasee"].Rows)
            {
                if (tipid == dr.ItemArray.GetValue(1).ToString())
                {
                    textBoxid.Text = dr.ItemArray.GetValue(0).ToString();
                    
                }
            }
        }

        private void buttonAddper_Click(object sender, EventArgs e)
        {
            myCon.Open();
            SqlDataAdapter adPer = new SqlDataAdapter();
            try
            {

                // Clasa DbCommand implementează metode de interacțiune primară cu baza de date.
                SqlCommand command = new SqlCommand("INSERT INTO PerioadaTrasee( Perioada, IdTip) VALUES(@Perioada, @IdTip)", myCon);
                
                command.Parameters.Add("@Perioada", SqlDbType.Text).Value =
                textBoxPerNoua.Text;
                command.Parameters.Add("@IdTip", SqlDbType.Int).Value =
                int.Parse(textBoxid.Text);

                // DataAdapter permite interschimbarea datelor între data set şi baza de date
                

                if (textBoxPerNoua.Text == "")
                {
                    throw new Exception("Nu a fost completatat nici o perioada");
                        }
                else {

                    adPer.InsertCommand = command;
                    adPer.InsertCommand.ExecuteNonQuery();

                    MessageBox.Show("Perioada a fost adaugata! ");
                        };

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            myCon.Close(); //inchidem conexiunea la db
            textBoxPerNoua.Text = "";
            comboBoxTipTr.Items.Clear();
            textBoxid.Text = "";
        }
    }
}
