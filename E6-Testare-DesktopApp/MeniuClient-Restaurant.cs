using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E6_Testare_DesktopApp
{
    public partial class MeniuClient_Restaurant : Form
    {
        object ContClient;
        int counter = 1;
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        public MeniuClient_Restaurant(object idCont)
        {
            InitializeComponent();
            ContClient = idCont;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MeniuClient = new MeniuClient_Restaurant_Meniu(ContClient);
            MeniuClient.ShowDialog();
            this.Close();
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MeniuClient = new MeniuClient(ContClient);
            MeniuClient.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MeniuClient = new MeniuClient_Restaurant_Rezervari(ContClient);
            MeniuClient.ShowDialog();
            this.Close();
        }

        private void MeniuClient_Restaurant_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            string[] images = Directory.GetFiles("Img/Restaurant");

            if (counter > images.Length - 1)
            {
                counter = 0;
            }
            Image.Image = System.Drawing.Image.FromFile(images[counter]);
        }
    }
}
