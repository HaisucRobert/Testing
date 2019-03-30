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
    public partial class MeniuPersonalHotelVerificaDisponibilitatea : Form
    {
        ConectareBD conectare = new ConectareBD();
        OleDbConnection conn;
        object cont;
        public MeniuPersonalHotelVerificaDisponibilitatea(object idCont)
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

        private void MeniuPersonalHotelVerificaDisponibilitatea_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCamere.Camere' table. You can move, or remove it, as needed.
            this.camereTableAdapter.Fill(this.dataSetCamere.Camere);

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
            var MeniuPersonalHotelVerificaDisponibilitatea = new MeniuPersonalHotelPrincipal(cont);
            MeniuPersonalHotelVerificaDisponibilitatea.ShowDialog();
            this.Close();
        }

        private void queryToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.camereTableAdapter.Query(this.dataSetCamere.Camere);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void lblBuna_Click(object sender, EventArgs e)
        {

        }
    }
}
