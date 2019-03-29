using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
namespace E6_Testare_DesktopApp
{
    public partial class MeniuClient : Form
    {
        ConectareBD conectare = new ConectareBD();
        int counter = 1;
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        OleDbConnection conn;
        object ContClient;
       
        public MeniuClient(object idCont)
        {
            InitializeComponent();
            // DialogResult result = fbd.ShowDialog();
            
            timer1.Start();
            ContClient = idCont;

        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Start = new Start();
            Start.ShowDialog();
            this.Close();
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            this.Hide();
            var vizualizareContClient = new VizualizareContClient(ContClient);
            vizualizareContClient.ShowDialog();
            this.Close();
        }

        private void MeniuClient_Load(object sender, EventArgs e)
        {
            conectare.ConectareBazDate();
            conn = conectare.ConectareBazDate();

            OleDbCommand cmdSelect;

            OleDbDataReader reader;
            conn.Open();
            // verificarea existentei user-ului
            cmdSelect = new OleDbCommand("SELECT Nume FROM DetaliiCont where DetaliiCont.idCont = @idCont", conn);
            cmdSelect.Parameters.AddWithValue("@idClient", this.ContClient);
            reader = cmdSelect.ExecuteReader();

            reader.Read();
            lblNume.Text = Convert.ToString( reader.GetValue(0));
            

        }
 

        private void Inregistrare_Click(object sender, EventArgs e)
        {
            this.Hide();
            var inregistrare = new Inregistrare();
            inregistrare.ShowDialog();
            this.Close();
        }

        private void Image_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            counter++;
            string[] images = Directory.GetFiles("Img/Slideshow1");

            if (counter > images.Length - 1)
            {
                counter = 0;
            }
            Image.Image = System.Drawing.Image.FromFile(images[counter]);
        }

        private void btnEvenimente_Click(object sender, EventArgs e)
        {
            this.Hide();
            var meniu = new MeniuClient_Evenimente(ContClient);
            meniu.ShowDialog();
            this.Close();
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {

            this.Hide();
            var MeniuClient = new MeniuClient_Hotel(ContClient);
            MeniuClient.ShowDialog();
            this.Close();
        }

        private void btnRestaurant_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MeniuClient = new MeniuClient_Restaurant(ContClient);
            MeniuClient.ShowDialog();
            this.Close();
        }

        private void btnRecenzii_Click(object sender, EventArgs e)
        {
            this.Hide();
            var recenzie = new MeniuClient_Recenzii(ContClient);
            recenzie.ShowDialog();
            this.Close();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MeniuClient = new Contact(ContClient);
            MeniuClient.ShowDialog();
            this.Close();
        }
    }
}
