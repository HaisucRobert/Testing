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

            this.QRzervariTableAdapter.Fill(this.TestareBDDataSet4.QRzervari);
            this.reportViewer1.RefreshReport();
        }
        
        private void FormularRapoarte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TestareBDDataSet4.QRzervari' table. You can move, or remove it, as needed.
            this.QRzervariTableAdapter.Fill(this.TestareBDDataSet4.QRzervari);
            // TODO: This line of code loads data into the 'TestareBDDataSet4.RezervariRestaurant' table. You can move, or remove it, as needed.
            this.RezervariRestaurantTableAdapter.Fill(this.TestareBDDataSet4.RezervariRestaurant);
            // TODO: This line of code loads data into the 'TestareBDDataSet4.QRzervari' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'TestareBDDataSet4.QRzervari' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'TestareBDDataSet4.QRzervari' table. You can move, or remove it, as needed.

            this.reportViewer1.RefreshReport();
        }

        private void btnMeniuriSucces_Click(object sender, EventArgs e)
        {
            

           // reportViewer1.Clear();
           // this.RezervariRestaurantTableAdapter.Fill(this.TestareBDDataSet4.RezervariRestaurant);
           // DataSet ds = GetDataSet();
            //ReportDataSource rds = new ReportDataSource("RezervariRestaurant", RezervariRestaurantTableAdapter);
            //ReportViewer1.LocalReport.DataSources.Clear();
           // ReportViewer1.LocalReport.DataSources.Add(rds);
           // ReportViewer1.LocalReport.Refresh();

        }

        private void btnEvenimente_Click(object sender, EventArgs e)
        {
            
            conectare.ConectareBazDate();
            conn = conectare.ConectareBazDate();
            conn.Open();

            var q = "SELECT TOP 5 month(SolicitariEvenimente.Data) AS Luna, Count(Data) AS Numar_de_evenimente FROM SolicitariEvenimente GROUP BY month(SolicitariEvenimente.Data) ORDER BY Count(Data) DESC";
            var cmd = new OleDbCommand(q, conn);
            var da = new OleDbDataAdapter(q, conn);
            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            var ds = new DataSet();
            da.Fill(ds, "Detalii cont");
           
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

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {
                    }
    }
}
