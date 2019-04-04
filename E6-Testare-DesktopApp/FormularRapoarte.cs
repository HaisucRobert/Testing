using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.WinForms;
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
using Warning = Microsoft.Reporting.Map.WebForms.BingMaps.Warning;

namespace E6_Testare_DesktopApp
{
    public partial class FormularRapoarte : Form
    {
        ConectareBD conectare = new ConectareBD();
        int counter = 1;
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        OleDbConnection conn;
        private object contAdministrator;
        object cont;

        public FormularRapoarte(object idCont)
        {
            InitializeComponent();

            contAdministrator = idCont;
        }
        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource();


        private void button4_Click(object sender, EventArgs e)
        {
          
            reportViewer3.Visible = false;
            reportViewer2.Visible = false;
            reportViewer1.Visible = true;
            this.QRzervariTableAdapter.Fill(this.TestareBDDataSet4.QRzervari);
            this.reportViewer1.RefreshReport();
        }
        
        private void FormularRapoarte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TestareBDDataSet5.QRezervariEvenimente' table. You can move, or remove it, as needed.
            this.QRezervariEvenimenteTableAdapter.Fill(this.TestareBDDataSet5.QRezervariEvenimente);
            // TODO: This line of code loads data into the 'TestareBDDataSet4.RezervariRestaurant' table. You can move, or remove it, as needed.
            this.RezervariRestaurantTableAdapter.Fill(this.TestareBDDataSet4.RezervariRestaurant);
            reportViewer1.Visible = false;
            reportViewer2.Visible = false;
            reportViewer3.Visible = false;

        }

        private void btnMeniuriSucces_Click(object sender, EventArgs e)
        {
            reportViewer3.Visible = false;
            reportViewer2.Visible = true;
            reportViewer1.Visible = false;
            this.RezervariRestaurantTableAdapter.Fill(this.TestareBDDataSet4.RezervariRestaurant);
            this.reportViewer2.RefreshReport();
          

        }

        private void btnEvenimente_Click(object sender, EventArgs e)
        {
            reportViewer3.Visible = true;
            reportViewer2.Visible = false;
            reportViewer1.Visible = false;
   
            this.QRezervariEvenimenteTableAdapter.Fill(this.TestareBDDataSet5.QRezervariEvenimente);
            this.reportViewer3.RefreshReport();

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            conectare.ConectareBazDate();
            conn = conectare.ConectareBazDate();
            conn.Open();

            var q = "SELECT DetaliiCont.[idDC], DetaliiCont.[Nume], DetaliiCont.[Prenume], DetaliiCont.[Telefon], DetaliiCont.[Email], DetaliiCont.[Adresa], DetaliiCont.[Functia] FROM DetaliiCont ";
            var cmd = new OleDbCommand(q, conn);
            var da = new OleDbDataAdapter(q, conn);
            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            var ds = new DataSet();
            da.Fill(ds, "Detalii cont");
            
        }

        private void btnIncasariCamera_Click(object sender, EventArgs e)
        {
           
            conectare.ConectareBazDate();
            conn = conectare.ConectareBazDate();
            conn.Open();

            var q = "SELECT RezervariCamere.[NrCamera], Sum(RezervariCamere.Pret) AS CastiguriTotalePeCamera FROM RezervariCamere GROUP BY RezervariCamere.[NrCamera]";
            var cmd = new OleDbCommand(q, conn);
            var da = new OleDbDataAdapter(q, conn);
            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            var ds = new DataSet();
            da.Fill(ds, "Detalii cont");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            conectare.ConectareBazDate();
            conn = conectare.ConectareBazDate();
            conn.Open();

            var q = "SELECT year(DataStart) AS AnRezervare, SUM(Pret) AS Total FROM RezervariCamere GROUP BY RezervariCamere.[DataStart] ";

            var cmd = new OleDbCommand(q, conn);
            var da = new OleDbDataAdapter(q, conn);
            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            var ds = new DataSet();

            while (reader.Read())
            {
               // chart1.Series["Series1"].Points.AddXY(reader["AnRezervare"].ToString(), reader["Total"].ToString());

            }
            reader.Close();
            cmd.Dispose();

            da.Fill(ds, "Detalii cont");
           


        }

        private void button3_Click(object sender, EventArgs e)
        {

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Start = new MeniuAdministrator(contAdministrator);
            Start.ShowDialog();
            this.Close();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (reportViewer1.Visible == true)
            {
            }
            else
            {
                if (reportViewer2.Visible == true)
                {
                   
                }
                else
                {
                    if (reportViewer3.Visible == true)
                    {
                        
                    }
                }
            }
        }
    }
}
