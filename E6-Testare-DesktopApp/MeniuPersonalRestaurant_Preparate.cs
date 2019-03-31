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
    public partial class MeniuPersonalRestaurant_Preparate : Form
    {
        ConectareBD conectare = new ConectareBD();
        OleDbConnection conn;
        object ContPersonal;

        public MeniuPersonalRestaurant_Preparate(object idCont)
        {
            InitializeComponent();
            ContPersonal = idCont;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var MeniuPersonal = new MeniuPersonalRestaurant_VizualizeazaPreparate();
            MeniuPersonal.ShowDialog();
            this.Close();
        }

        private void Image_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var AdaugaMeniuPersonal = new MeniuPersonalRestaurant_AdaugaPreparat(ContPersonal);
            AdaugaMeniuPersonal.ShowDialog();
            this.Close();

        }

        private void MeniuPersonalRestaurant_Preparate_Load(object sender, EventArgs e)
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
