using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E6_Testare_DesktopApp
{
    public partial class MeniuClient_Restaurant_Rezervari : Form
    {
        object ContClient;
        ConectareBD conectare = new ConectareBD();
        OleDbConnection conn;
        public MeniuClient_Restaurant_Rezervari(object idCont)
        {
            InitializeComponent();
            ContClient = idCont;
        }

        private void Rezerva_Click(object sender, EventArgs e)
        {
            conn = conectare.ConectareBazDate();
            conn.Open();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            if(DateTime.Compare(dateTimePicker1.Value, DateTime.Today)<0)
            {
                MessageBox.Show("Data si ora introduse trebuie sa fie mai mari decat data si ora curente");
            }
            else
            {
                if(textBox1.Text=="")
                {
                    MessageBox.Show("Introduceti numarul persoanelor");
                }
                else
                { 
                OleDbCommand cmdSelect;
                OleDbDataReader reader;
                int suma=0;

                cmdSelect = new OleDbCommand("select NrPersoane, Data from RezervariRestaurant where Data between @Start and @Stop", conn);
                cmdSelect.Parameters.AddWithValue("@Start", dateTimePicker1.Value.ToString());
                cmdSelect.Parameters.AddWithValue("@Stop", dateTimePicker1.Value.AddHours(1).ToString());
                reader = cmdSelect.ExecuteReader();
                while(reader.Read())
                {
                    suma = suma + Convert.ToInt32(reader.GetValue(0));
                }

                    if (suma >= 150)
                    {
                        MessageBox.Show("Nu mai avem locuri disponibile pentru acest interval orar");
                    }
                    else
                    {
                        string insert = "Insert into RezervariRestaurant([idCont],[Data],[NrPersoane]) values ('" + ContClient.ToString() + "','" + dateTimePicker1.Value + "','" + textBox1.Text + "')";
                        OleDbCommand cmdInsert;
                        OleDbDataAdapter adapter = new OleDbDataAdapter();

                        cmdInsert = new OleDbCommand(insert, conn);

                        try
                        {
                            // inserarea in conturi

                            adapter.InsertCommand = new OleDbCommand(insert, conn);
                            adapter.InsertCommand.ExecuteNonQuery();
                            cmdInsert.Dispose();
                            MessageBox.Show("Rezervarea dumneavoastra a fost inregistrata");

                        }
                        catch (OleDbException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void MeniuClient_Restaurant_Rezervari_Load(object sender, EventArgs e)
        {

        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MeniuClient = new MeniuClient_Restaurant(ContClient);
            MeniuClient.ShowDialog();
            this.Close();
        }
    }
}
