using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E6_Testare_DesktopApp
{
    public partial class MeniuClient_Hotel : Form
    {
        Object ContClient;
        public MeniuClient_Hotel(object idCont)
        {
            ContClient = idCont;
            InitializeComponent();
        }

        private void btnCamere_Click(object sender, EventArgs e)
        {

            this.Hide();
            var MeniuClient = new MeniuClient_Camere(ContClient);
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

        private void btnRezervari_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MeniuClient = new MeniuClient_RezervareCamera(ContClient);
            MeniuClient.ShowDialog();
            this.Close();
        }
    }
}
