using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace E6_Testare_DesktopApp
{
    public partial class MeniuClient_Camere : Form
    {
        ConectareBD conectarestr = new ConectareBD();
        OleDbConnection conn = new OleDbConnection();
        object ContClient;
        int counter = 1;
        public MeniuClient_Camere(object idCont)
        {

           ContClient = idCont;
       
            InitializeComponent();
            
        }

        private void MeniuClient_Camere_Load(object sender, EventArgs e)
        {
            
            conn = conectarestr.ConectareBazDate();
            conn.Open();
            OleDbCommand cmdSelect;
            OleDbDataReader reader;
            cmdSelect = new OleDbCommand("Select NrCamera, NrPaturi, Detalii, PretCamera from Camere", conn);
            reader = cmdSelect.ExecuteReader();

            while(reader.Read())
            {
                cboCamera.Items.Add(reader.GetValue(0).ToString());
            }
            conn.Close();
        }

        private void cboCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
           


            conn = conectarestr.ConectareBazDate();
            conn.Open();
            OleDbCommand cmdSelect;
            OleDbDataReader reader;
            cmdSelect = new OleDbCommand("Select NrCamera, NrPaturi, Detalii, PretCamera from Camere where Camere.NrCamera = @Camera", conn);
            cmdSelect.Parameters.AddWithValue("@Camera", this.cboCamera.SelectedItem);
            reader = cmdSelect.ExecuteReader();

            reader.Read();

            txtPaturi.Text = reader.GetValue(1).ToString();
            txtPret.Text = reader.GetValue(3).ToString();
            txtSpecificatii.Text = reader.GetValue(2).ToString();
            conn.Close();
            this.image_Click( sender,  e);


        }

        private void image_Click(object sender, EventArgs e)
        {
            counter++;

            if (cboCamera.Text == "1")
            {
                string[] images = Directory.GetFiles("Img/Camera1");

                if (counter > images.Length - 1)
                {
                    counter = 0;
                }
                imagePXB.Image = System.Drawing.Image.FromFile(images[counter]);

            }
            else
            {
                if (cboCamera.Text == "2")
                {
                    string[] images = Directory.GetFiles("Img/Camera2");
                    if (counter > images.Length - 1)
                    {
                        counter = 0;
                    }
                    imagePXB.Image = System.Drawing.Image.FromFile(images[counter]);
                }
                else
                {
                    if (cboCamera.Text == "3")
                    {
                        string[] images = Directory.GetFiles("Img/Camera3");
                        if (counter > images.Length - 1)
                        {
                            counter = 0;
                        }
                        imagePXB.Image = System.Drawing.Image.FromFile(images[counter]);
                    }
                }
            }
           




        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {

            this.Hide();
            var MeniuClient = new MeniuClient_Hotel(ContClient);
            MeniuClient.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MeniuClient = new MeniuClient_RezervareCamera(ContClient);
            MeniuClient.ShowDialog();
            this.Close();
        }
    }
}
