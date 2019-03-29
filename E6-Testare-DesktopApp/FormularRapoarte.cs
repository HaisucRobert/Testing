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

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Show();
            chart1.Hide();
            dgvRapoarte.Show();
            conectare.ConectareBazDate();
            conn = conectare.ConectareBazDate();
            conn.Open();

            var q = "SELECT TOP 5 DataStart, COUNT(DataStart) AS NrRezervari FROM RezervariCamere GROUP BY DataStart ORDER BY COUNT(DataStart) DESC";
            var cmd = new OleDbCommand(q, conn);
            var da = new OleDbDataAdapter(q, conn);
            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            var ds = new DataSet();
            da.Fill(ds, "Detalii cont");
            dgvRapoarte.DataMember = "Detalii cont";
            dgvRapoarte.DataSource = ds;
        }

        private void FormularRapoarte_Load(object sender, EventArgs e)
        {
            button3.Hide();
        }

        private void btnMeniuriSucces_Click(object sender, EventArgs e)
        {
            button3.Show();
            chart1.Hide();
            dgvRapoarte.Show();
            conectare.ConectareBazDate();
            conn = conectare.ConectareBazDate();
            conn.Open();

            var q = "SELECT Meniu.[idMeniu], Meniu.[NumeMeniu], Meniu.[Pret] FROM Meniu ";
            var cmd = new OleDbCommand(q, conn);
            var da = new OleDbDataAdapter(q, conn);
            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            var ds = new DataSet();
            da.Fill(ds, "Detalii cont");
            dgvRapoarte.DataMember = "Detalii cont";
            dgvRapoarte.DataSource = ds;
        }

        private void btnEvenimente_Click(object sender, EventArgs e)
        {
            button3.Show();
            chart1.Hide();
            dgvRapoarte.Show();
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
            dgvRapoarte.DataMember = "Detalii cont";
            dgvRapoarte.DataSource = ds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Show();
            chart1.Hide();
            dgvRapoarte.Show();
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
            dgvRapoarte.DataMember = "Detalii cont";
            dgvRapoarte.DataSource = ds;
        }

        private void btnIncasariCamera_Click(object sender, EventArgs e)
        {
            button3.Show();
            chart1.Hide();
            dgvRapoarte.Show();
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
            dgvRapoarte.DataMember = "Detalii cont";
            dgvRapoarte.DataSource = ds;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            button3.Hide();
            chart1.Show();
            chart1.Visible = true;
            dgvRapoarte.Show();
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
                chart1.Series["Series1"].Points.AddXY(reader["AnRezervare"].ToString(), reader["Total"].ToString());

            }
            reader.Close();
            cmd.Dispose();

            da.Fill(ds, "Detalii cont");
            dgvRapoarte.DataMember = "Detalii cont";
            dgvRapoarte.DataSource = ds;


        }

        private void button3_Click(object sender, EventArgs e)
        {

            // creare aplicatie Excel  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creare Workbook
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating sheet nou

            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            app.Visible = true;


            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // schimbare denumire sheet
            worksheet.Name = "Exportat din aplicatie";
            // preluare header din grid
            for (int i = 1; i < dgvRapoarte.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvRapoarte.Columns[i - 1].HeaderText;
            }
            // stocare rand si coloane pe headerurile respective
            for (int i = 0; i < dgvRapoarte.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvRapoarte.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvRapoarte.Rows[i].Cells[j].Value.ToString();
                }
            }
            // salvare aplicatie 
            //workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // iesire aplicatie
            //  app.Quit();
            workbook.Saved = true;
            workbook.SaveCopyAs(System.IO.Directory.GetCurrentDirectory() +"\\output.xls");
            workbook.Close(true, System.IO.Directory.GetCurrentDirectory() + "h:\\output.xls", Type.Missing);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Start = new MeniuAdministrator(contAdministrator);
            Start.ShowDialog();
            this.Close();
        }
    }
}
