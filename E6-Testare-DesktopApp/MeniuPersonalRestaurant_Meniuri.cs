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
    public partial class MeniuPersonalRestaurant_Meniuri : Form
    {
        ConectareBD conectare = new ConectareBD();
        OleDbConnection conn;
        object ContPersonal;
        public MeniuPersonalRestaurant_Meniuri(object idCont)
        {
            InitializeComponent();
            ContPersonal = idCont;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var MeniuPersonal = new MeniuPersonalRestaurant_VizualizareMeniu(ContPersonal);
            MeniuPersonal.ShowDialog();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var AdaugaMeniuPersonal = new MeniuPersonalRestaurant_AdaugareMeniu(ContPersonal);
            AdaugaMeniuPersonal.ShowDialog();
            this.Close();
        }

        private void MeniuPersonalRestaurant_Meniuri_Load(object sender, EventArgs e)
        {
            conectare.ConectareBazDate();
            conn = conectare.ConectareBazDate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var AdaugaMeniuPersonal = new MeniuPersonalRestaurant(ContPersonal);
            AdaugaMeniuPersonal.ShowDialog();
            this.Close();
        }
    }
}
