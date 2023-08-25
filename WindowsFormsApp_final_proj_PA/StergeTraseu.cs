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
    public partial class StergeTraseu : Form
    {
        SqlConnection myCon = new SqlConnection();
        DataSet dsTip;
        DataSet dsTras;
        DataSet dsPer;
        public StergeTraseu()
        {
            InitializeComponent();
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenut\source\repos\WindowsFormsApp_final_proj_PA\WindowsFormsApp_final_proj_PA\Database1.mdf;Integrated Security=True";
            myCon.Open();
            dsTip = new DataSet();
            dsTras = new DataSet();
            dsPer = new DataSet();

            textBoxidper.Visible = false;

            SqlDataAdapter daTip = new SqlDataAdapter("SELECT * FROM TipTrasee", myCon);
            daTip.Fill(dsTip, "TipTrasee");
            SqlDataAdapter daTras = new SqlDataAdapter("SELECT * FROM Trasee", myCon);
            daTras.Fill(dsTras, "Trasee");
            SqlDataAdapter daPer = new SqlDataAdapter("SELECT * FROM PerioadaTrasee", myCon);
            daPer.Fill(dsPer, "PerioadaTrasee");

            foreach (DataRow dr in dsTras.Tables["Trasee"].Rows)
            {
                String nameTraseu = dr.ItemArray.GetValue(1).ToString();
                listBoxDen.Items.Add(nameTraseu);
            }

            foreach (DataRow dr in dsPer.Tables["PerioadaTrasee"].Rows)
            {
                String Per = dr.ItemArray.GetValue(1).ToString();
                listBoxPer.Items.Add(Per);
            }

            myCon.Close();
        }

        private void listBoxDen_SelectedIndexChanged(object sender, EventArgs e)
        {          
            String trasname = listBoxDen.SelectedItem.ToString();
            foreach (DataRow dr in dsTras.Tables["Trasee"].Rows)
            {
                if (trasname == dr.ItemArray.GetValue(1).ToString())
                {
                    textBoxIDT.Text = dr.ItemArray.GetValue(0).ToString();
                }
            }
        }
        private void listBoxPer_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Perioada = listBoxPer.SelectedItem.ToString();
            foreach (DataRow dr in dsPer.Tables["PerioadaTrasee"].Rows)
            {
                if (Perioada == dr.ItemArray.GetValue(1).ToString())
                {
                    textBoxidper.Text = dr.ItemArray.GetValue(0).ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myCon.Open();
            try
            {
                SqlDataAdapter deleteDisp = new SqlDataAdapter();
                SqlCommand command3 = new SqlCommand("Delete from Disponibile where IdTrasee = @IdTrasee ", myCon);

                command3.Parameters.Add("@IdTrasee", SqlDbType.Int).Value = int.Parse(textBoxIDT.Text);
                //command.Parameters.AddWithValue("@id",textBox_id.Text);
                deleteDisp.DeleteCommand = command3;
                deleteDisp.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("S-a sters disponibilitatea traseului");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            try
            {
                SqlDataAdapter adTras = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("Delete from Trasee where IdTrasee = @IdTrasee ", myCon);

                command.Parameters.Add("@IdTrasee", SqlDbType.Int).Value = int.Parse(textBoxIDT.Text);
                //command.Parameters.AddWithValue("@id",textBox_id.Text);
                adTras.DeleteCommand = command;
                adTras.DeleteCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            myCon.Close();
            MessageBox.Show("Traseul a fost sters! ");
        }

        private void buttonStPer_Click(object sender, EventArgs e)
        {
            myCon.Open();
            try
            {
                SqlDataAdapter deleteDisp = new SqlDataAdapter();
                SqlCommand command5 = new SqlCommand("Delete from Disponibile where IdPerioada = @IdPerioada ", myCon);

                command5.Parameters.Add("@IdPerioada", SqlDbType.Int).Value = int.Parse(textBoxidper.Text);
                //command.Parameters.AddWithValue("@id",textBox_id.Text);
                deleteDisp.DeleteCommand = command5;
                deleteDisp.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("S-a sters disponibilitatea perioadei");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            try
            {
                SqlDataAdapter adTras = new SqlDataAdapter();
                SqlCommand command6 = new SqlCommand("Delete from PerioadaTrasee where IdPerioada = @IdPerioada ", myCon);

                command6.Parameters.Add("@IdPerioada", SqlDbType.Int).Value = int.Parse(textBoxidper.Text);
                //command.Parameters.AddWithValue("@id",textBox_id.Text);
                adTras.DeleteCommand = command6;
                adTras.DeleteCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            myCon.Close();
            MessageBox.Show("Perioada indicata a fost stearsa! ");
        }

        
    }
}
