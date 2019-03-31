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


    public partial class MeniuPersonalRestaurant : Form
    {
        ConectareBD conectare = new ConectareBD();
        OleDbConnection conn;
        object cont;
        public MeniuPersonalRestaurant(object idCont)
        {
            InitializeComponent();
            cont = idCont;
        }

        private void MeniuPersonalRestaurant_Load(object sender, EventArgs e)
        {
            conectare.ConectareBazDate();
            conn = conectare.ConectareBazDate();

            OleDbCommand cmdSelect;

            OleDbDataReader reader;
            conn.Open();
            // verificarea existentei user-ului
            cmdSelect = new OleDbCommand("SELECT Nume FROM DetaliiCont where DetaliiCont.idCont = @idCont", conn);
            cmdSelect.Parameters.AddWithValue("@idClient", this.cont);
            reader = cmdSelect.ExecuteReader();

            reader.Read();
            lblNume.Text = Convert.ToString(reader.GetValue(0));
        }

     
           


        private void btn_preparate_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var vizualizareMeniu = new MeniuPersonalRestaurant_Preparate();
            vizualizareMeniu.ShowDialog();
            this.Close();

        }

        private void btn_meniuri_Click_1(object sender, EventArgs e)
            {
                this.Hide();
                var vizualizareMeniu = new MeniuPersonalRestaurant_Meniuri();
                vizualizareMeniu.ShowDialog();
                this.Close();
            }

        private void btnCont_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var vizualizareCont = new VizualizareContPersonal(cont);
            vizualizareCont.ShowDialog();
            this.Close();
        }

        private void btnInapoi_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var Start = new Start();
            Start.ShowDialog();
            this.Close();
        }
    }
}
