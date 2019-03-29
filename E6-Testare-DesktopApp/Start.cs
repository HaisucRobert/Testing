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


// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace E6_Testare_DesktopApp
{
    public partial class Start : Form
    {
        int counter = 1;
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        bool PLAYING = false;
        public Start()
        {
            InitializeComponent();
           // DialogResult result = fbd.ShowDialog();
            timer1.Start();

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            string[] images = Directory.GetFiles("Img/Slideshow1");

            if(counter > images.Length-1)
            {
                counter = 0;
            }
            Image.Image = System.Drawing.Image.FromFile(images[counter]);
            
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

        private void btnConectare_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Conectare = new Conectare();
            Conectare.ShowDialog();
            this.Close();
        }
    }
}
