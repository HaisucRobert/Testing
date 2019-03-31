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
    public partial class MeniuClient_RezervareCamera : Form
    {
        ConectareBD conectarestr = new ConectareBD();
        OleDbConnection conn = new OleDbConnection();
        object ContClient;
        public MeniuClient_RezervareCamera(object idCont)
        {
            InitializeComponent();
            ContClient = idCont;
        }

        private void MeniuClient_RezervareCamera_Load(object sender, EventArgs e)
        {
            conn = conectarestr.ConectareBazDate();
            conn.Open();
            OleDbCommand cmdSelect;
            OleDbDataReader reader;
            cmdSelect = new OleDbCommand("Select NrCamera, NrPaturi, Detalii, PretCamera from Camere", conn);
            reader = cmdSelect.ExecuteReader();

            while (reader.Read())
            {
                cboCamera.Items.Add(reader.GetValue(0).ToString());
            }
            conn.Close();

        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (cboCamera.Text == "")
            {
                MessageBox.Show("Selecteaza o camera");
            }
            else
            {
                conn = conectarestr.ConectareBazDate();
                conn.Open();

                Boolean disponibil = true;

                if (DateTime.Compare(checkIn.Value, DateTime.Today) < 0 || DateTime.Compare(checkOut.Value, DateTime.Today) < 0)
                {
                    MessageBox.Show("Datele de check in si check out trebuie sa fie mai mari decat data curenta" + DateTime.Today.Date.ToString());
                }
                else
                {
                    if (DateTime.Compare(checkIn.Value, checkOut.Value) >= 0)
                    {
                        MessageBox.Show("Data de check out trebuie sa fie mai mare decat cea de check in");
                    }
                    else
                    {


                        OleDbCommand cmdSelect;
                        OleDbDataReader reader;
                        cmdSelect = new OleDbCommand("Select NrCamera, DataStart, DataStop from RezervariCamere where RezervariCamere.NrCamera= @camera ", conn);
                        cmdSelect.Parameters.AddWithValue("@camera", this.cboCamera.Text);
                        
                     
                        reader = cmdSelect.ExecuteReader();
                        while (reader.Read())
                        {
                            if ((DateTime.Compare(checkIn.Value, Convert.ToDateTime(reader.GetValue(1))) < 0 && DateTime.Compare(checkOut.Value, Convert.ToDateTime(reader.GetValue(1))) > 0) || (DateTime.Compare(checkIn.Value, Convert.ToDateTime(reader.GetValue(1))) > 0 && DateTime.Compare(checkIn.Value, Convert.ToDateTime(reader.GetValue(2))) < 0))
                            {
                                MessageBox.Show("Camera " + cboCamera.Text + " nu este disponibila in perioada selectata");
                                disponibil = false;
                            }

                        }
                        if (disponibil == true)
                        {
                            label4.Visible = true;
                            txtPret.Visible = true;
                            button2.Visible = true;

                            OleDbCommand cmdSelect2;
                            OleDbDataReader reader2;
                            cmdSelect2 = new OleDbCommand("Select NrCamera, NrPaturi, Detalii, PretCamera from Camere where Camere.NrCamera= @Camera ", conn);
                            cmdSelect2.Parameters.AddWithValue("@Camera", this.cboCamera.SelectedItem);
                            reader2 = cmdSelect2.ExecuteReader();
                            reader2.Read();
                            txtPret.Text = Convert.ToString(Convert.ToInt32(((TimeSpan)(checkOut.Value - checkIn.Value)).Days * Convert.ToInt32(reader2.GetValue(3))));
                        }
                    }
                }

                conn.Close();
            }
            // pentru rezervare :
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();

            string insert = " INSERT INTO RezervariCamere([NrCamera],[DataStart],[DataStop],[Specificatii],[Pret],[IdCont]) Values( '" + cboCamera.Text + "','" + checkIn.Value + "','" + checkOut.Value + "','" + txtSpecificatii.Text + "','" + txtPret.Text + "','" + ContClient + "')";
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

        private void checkIn_ValueChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            txtPret.Visible = false;
            button2.Visible = false;

        }

        private void checkOut_ValueChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            txtPret.Visible = false;
            button2.Visible = false;

        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MeniuClient = new MeniuClient_Hotel(ContClient);
            MeniuClient.ShowDialog();
            this.Close();
        }

        private void cboCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MeniuClient = new MeniuClient_Camere(ContClient);
            MeniuClient.ShowDialog();
            this.Close();
        }
    }
}
