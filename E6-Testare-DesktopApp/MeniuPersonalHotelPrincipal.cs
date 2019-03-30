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

namespace E6_Testare_DesktopApp
{
    public partial class MeniuPersonalHotelPrincipal : Form
    {
        ConectareBD conectare = new ConectareBD();
        OleDbConnection conn;
        object cont;
        public MeniuPersonalHotelPrincipal(object idCont)
        {
            InitializeComponent();
            cont = idCont;
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
            var vizualizareCont = new VizualizareContPersonal(cont);
            vizualizareCont.ShowDialog();
            this.Close();
        }

        private void MeniuPersonalHotelPrincipal_Load(object sender, EventArgs e)
        {
            conn = conectare.ConectareBazDate();
            conn = conectare.ConectareBazDate();

            OleDbCommand cmdSelect;

            OleDbDataReader reader;
            conn.Open();
            // verificarea existentei user-ului
            cmdSelect = new OleDbCommand("SELECT Nume FROM DetaliiCont where DetaliiCont.idCont = @idCont", conn);
            cmdSelect.Parameters.AddWithValue("@idClient", this.cont);
            reader = cmdSelect.ExecuteReader();

            reader.Read();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MeniuPersonalHotelPrincipal = new Start();
            MeniuPersonalHotelPrincipal.ShowDialog();
            this.Close();
        }

        private void rezerva_o_camera_Click(object sender, EventArgs e)
        {

            this.Hide();
            var MeniuPersonalHotelPrincipal = new MeniuPersonalHotel(cont);
            MeniuPersonalHotelPrincipal.ShowDialog();
            this.Close();
           

        }

        private void verifica_disponibilitate_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MeniuPersonalHotelPrincipal = new MeniuPersonalHotelVerificaDisponibilitatea(cont);
            MeniuPersonalHotelPrincipal.ShowDialog();
            this.Close();

        }
    }
}
