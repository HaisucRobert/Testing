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
    public partial class MeniuResponsabilEvenimente : Form
    {
        ConectareBD conectare = new ConectareBD();
        object cont;
        OleDbConnection conn;
        public MeniuResponsabilEvenimente(object idCont)
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

        private void MeniuResponsabilEvenimente_Load(object sender, EventArgs e)
        {
            conn=conectare.ConectareBazDate();
            conn.Open();
            OleDbCommand cmdSelectNume;

            OleDbDataReader readerNume;
           
            // verificarea existentei user-ului
            cmdSelectNume = new OleDbCommand("SELECT Nume FROM DetaliiCont where DetaliiCont.idCont = @idCont", conn);
            cmdSelectNume.Parameters.AddWithValue("@idCont", this.cont);
            readerNume = cmdSelectNume.ExecuteReader();

            readerNume.Read();
            lblNume.Text = Convert.ToString(readerNume.GetValue(0));



            int i = 0;

            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Nr";
            dataGridView1.Columns[1].Name = "Tip Eveniment";
            dataGridView1.Columns[2].Name = "Locatie";
            dataGridView1.Columns[3].Name = "Data-Ora";
            dataGridView1.Columns[4].Name = "Perioada desfasurare";
            dataGridView1.Columns[5].Name = "Aprobare";
            dataGridView1.Columns[6].Name = "Id";
            dataGridView1.Columns[6].Visible = false;
            OleDbCommand cmdSelect, cmdSelect2;
            OleDbDataReader reader,reader2;

            cmdSelect = new OleDbCommand("Select idSolicitare, idCont,idLocatie,TipEveniment, BeneficiiLimuzina, BeneficiiMuzica,BeneficiiAranjamentFloral, BeneficiiDansatori,BeneficiiAranjamentBaloane, BeneficiiAnimatori, Specificatii, Data, PerioadaDesfasurare,Aprobare, idMeniu FROM SolicitariEvenimente", conn);
            cmdSelect.Parameters.AddWithValue("@idCont", this.cont);
            reader = cmdSelect.ExecuteReader();

            while (reader.Read())
            {
                i++;
                cmdSelect2 = new OleDbCommand("Select idLocatie, Denumire from Locatii where idLocatie=@idLoc", conn);
                cmdSelect2.Parameters.AddWithValue("@idLoc", reader.GetValue(2));
                reader2 = cmdSelect2.ExecuteReader();
                reader2.Read();

                string[] row1 = new string[] { i.ToString(), reader.GetValue(3).ToString(), reader2.GetValue(1).ToString(), reader.GetValue(11).ToString(), reader.GetValue(12).ToString(), reader.GetValue(13).ToString(), reader.GetValue(0).ToString() };
                dataGridView1.Rows.Add(row1);
            }
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.MultiSelect = false;
            Beneficii.Items.Clear();
           
                Beneficii.Visible = true;
                conn = conectare.ConectareBazDate();
                conn.Open();
                OleDbCommand cmdSelect, cmdSelect2;
                OleDbDataReader reader, reader2;

                cmdSelect = new OleDbCommand("Select idSolicitare, idCont,idLocatie,TipEveniment, BeneficiiLimuzina, BeneficiiMuzica,BeneficiiAranjamentFloral, BeneficiiDansatori,BeneficiiAranjamentBaloane, BeneficiiAnimatori, Specificatii, Data, PerioadaDesfasurare,Aprobare, idMeniu FROM SolicitariEvenimente ", conn);
                //cmdSelect.Parameters.AddWithValue("@idCont", this.cont);
                reader = cmdSelect.ExecuteReader();
                while (reader.Read())
                {
                try
                {
                    if (reader.GetValue(0).ToString() == dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString())
                    {
                        if (reader.GetValue(4).ToString().Length.ToString() != "0")
                        {
                            Beneficii.Items.Add("Transport: " + reader.GetValue(4).ToString());
                        }
                        if (reader.GetValue(5).ToString().Length.ToString() != "0")
                        {
                            Beneficii.Items.Add("Muzica: " + reader.GetValue(5).ToString());
                        }
                        if (reader.GetValue(6).ToString().Length.ToString() != "0")
                        {
                            Beneficii.Items.Add("Aranjament Floral: " + reader.GetValue(6).ToString());
                        }
                        if (reader.GetValue(7).ToString().Length.ToString() != "0")
                        {
                            Beneficii.Items.Add("Dansatori: " + reader.GetValue(7).ToString());
                        }
                        if (reader.GetValue(8).ToString().Length.ToString() != "0")
                        {
                            Beneficii.Items.Add("Baloane: " + reader.GetValue(8).ToString());
                        }
                        if (reader.GetValue(9).ToString().Length.ToString() != "0")
                        {
                            Beneficii.Items.Add("Animatori: " + reader.GetValue(9).ToString());
                        }
                        if (reader.GetValue(14).ToString().Length.ToString() != "0")
                        {

                            cmdSelect2 = new OleDbCommand("Select idMeniu, NumeMeniu from Meniu where Meniu.idMeniu=@Meniu", conn);
                            cmdSelect2.Parameters.AddWithValue("@Meniu", reader.GetValue(14));
                            reader2 = cmdSelect2.ExecuteReader();
                            reader2.Read();
                            Beneficii.Items.Add("Animatori: " + reader2.GetValue(1).ToString());
                        }
                    }
                }
                catch
                {

                }
                    
                }

            
            conn.Close();
        }

        private void btnAprobare_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();

            

            cmd.Connection = conn;
            cmd.CommandText = " UPDATE  SolicitariEvenimente SET Aprobare = 'Aprobat' where idSolicitare =@Solicitare";
            cmd.Parameters.AddWithValue("@Soliocitare", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString());

            cmd.ExecuteNonQuery();
            conn.Close();
            this.Hide();
            var vizualizareCont = new MeniuResponsabilEvenimente(cont);
            vizualizareCont.ShowDialog();
            this.Close();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();

            
            cmd.Connection = conn;
            cmd.CommandText = " UPDATE SolicitariEvenimente SET Aprobare = 'Anulat' where idSolicitare =@Solicitare";
            cmd.Parameters.AddWithValue("@Soliocitare", dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString());

            cmd.ExecuteNonQuery();

            conn.Close();

            this.Hide();
            var vizualizareCont = new MeniuResponsabilEvenimente(cont);
            vizualizareCont.ShowDialog();
            this.Close();

        }
    }
}

