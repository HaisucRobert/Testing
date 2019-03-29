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
    public partial class MeniuAdministrator : Form
    {
        ConectareBD conectare = new ConectareBD();
        int counter = 1;
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        OleDbConnection conn;
        object ContAdministrator;
        public MeniuAdministrator(object idCont)
        {
            ContAdministrator = idCont;
            InitializeComponent();
        }

        private void MeniuAdministrator_Load(object sender, EventArgs e)
        {
            
            conectare.ConectareBazDate();
            conn = conectare.ConectareBazDate();

            OleDbCommand cmdSelect;

            OleDbDataReader reader;
            conn.Open();
            // verificarea existentei user-ului
            cmdSelect = new OleDbCommand("SELECT Nume FROM DetaliiCont where DetaliiCont.idCont = @idCont", conn);
            cmdSelect.Parameters.AddWithValue("@idClient", this.ContAdministrator);
            reader = cmdSelect.ExecuteReader();
            reader.Read();
            lblNume.Text = Convert.ToString(reader.GetValue(0));
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblCamera_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRapoarte_Click(object sender, EventArgs e)
        {
            this.Hide();
            var rapoarte = new FormularRapoarte(ContAdministrator);
            rapoarte.ShowDialog();
            this.Close();
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            this.Hide();
            var vizualizareContClient = new VizualizareContPersonal(ContAdministrator);
            vizualizareContClient.ShowDialog();
            this.Close();
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Start = new Start();
            Start.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var vizualizareInregPersonal = new MeniuAdministrator_AdaugarePersoanl(ContAdministrator);
            vizualizareInregPersonal.ShowDialog();
            this.Close();
        }
    }
}
