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
    public partial class MeniuClient_Istoric : Form
    {
        ConectareBD conectare = new ConectareBD();

        OleDbConnection conn;
        object ContClient;
        public MeniuClient_Istoric(object idCont)
        {
            InitializeComponent();
            ContClient = idCont;
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Start = new VizualizareContClient(ContClient);
            Start.ShowDialog();
            this.Close();
        }

        private void MeniuClient_Istoric_Load(object sender, EventArgs e)
        {
           
        }

        private void cboTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = conectare.ConectareBazDate();
            conn.Open();
            OleDbCommand cmdSelect, cmdSelect2;
            OleDbDataReader reader, reader2;
            dataGridView1.Columns.Clear();
            int i = 0;
            Beneficii.Visible = false;

            if (cboTip.SelectedItem.ToString() == "Hotel")
            {
               
                dataGridView1.ColumnCount = 6;
                dataGridView1.Columns[0].Name = "Nr";
                dataGridView1.Columns[1].Name = "Nr Camera";
                dataGridView1.Columns[2].Name = "Check in";
                dataGridView1.Columns[3].Name = "CheckOut";
                dataGridView1.Columns[4].Name = "Specificatii";
                dataGridView1.Columns[5].Name = "Pret";
                cmdSelect = new OleDbCommand("Select idRezervareCamera, NrCamera,DataStart, DataStop, Specificatii,Pret, idCont FROM RezervariCamere where idCont=@idCont", conn);
                cmdSelect.Parameters.AddWithValue("@idCont", this.ContClient);
                reader = cmdSelect.ExecuteReader();

                while(reader.Read())
                {
                    i++;
                    string[] row1 = new string[] {i.ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString(), reader.GetValue(5).ToString() };
                    dataGridView1.Rows.Add(row1);
                }

            }
            else
            {
                if (cboTip.SelectedItem.ToString() == "Evenimente")
                {
                    dataGridView1.ColumnCount = 7;
                    dataGridView1.Columns[0].Name = "Nr";
                    dataGridView1.Columns[1].Name = "Tip Eveniment";
                    dataGridView1.Columns[2].Name = "Locatie";
                    dataGridView1.Columns[3].Name = "Data-Ora";
                    dataGridView1.Columns[4].Name = "Perioada desfasurare";
                    dataGridView1.Columns[5].Name = "Aprobare";
                    dataGridView1.Columns[6].Name = "Id";
                    dataGridView1.Columns[6].Visible = false;

                    cmdSelect = new OleDbCommand("Select idSolicitare, idCont,idLocatie,TipEveniment, BeneficiiLimuzina, BeneficiiMuzica,BeneficiiAranjamentFloral, BeneficiiDansatori,BeneficiiAranjamentBaloane, BeneficiiAnimatori, Specificatii, Data, PerioadaDesfasurare,Aprobare, idMeniu FROM SolicitariEvenimente where idCont=@idCont", conn);
                    cmdSelect.Parameters.AddWithValue("@idCont", this.ContClient);
                    reader = cmdSelect.ExecuteReader();

                    while (reader.Read())
                    {
                        i++;
                        cmdSelect2 = new OleDbCommand("Select idLocatie, Denumire from Locatii where idLocatie=@idLoc", conn);
                        cmdSelect2.Parameters.AddWithValue("@idLoc", reader.GetValue(2));
                        reader2 = cmdSelect2.ExecuteReader();
                        reader2.Read();

                        string[] row1 = new string[] { i.ToString() ,reader.GetValue(3).ToString(), reader2.GetValue(1).ToString(), reader.GetValue(11).ToString(), reader.GetValue(12).ToString(), reader.GetValue(13).ToString(), reader.GetValue(0).ToString() };
                        dataGridView1.Rows.Add(row1);
                    }

                }
                else
                {
                    if (cboTip.SelectedItem.ToString() == "Restaurant")
                    {
                        
                        dataGridView1.ColumnCount = 3;
                        dataGridView1.Columns[0].Name = "Nr";
                        dataGridView1.Columns[1].Name = "Data";
                        dataGridView1.Columns[2].Name = "Numar persoane";
                       
                        cmdSelect = new OleDbCommand("Select Data, NrPersoane, idCont from RezervariRestaurant where idCont=@idCont", conn);
                        cmdSelect.Parameters.AddWithValue("@idCont", this.ContClient);
                        reader = cmdSelect.ExecuteReader();

                        while (reader.Read())
                        {
                            i++;
                            string[] row1 = new string[] { i.ToString(), reader.GetValue(0).ToString(), reader.GetValue(1).ToString()};
                            dataGridView1.Rows.Add(row1);
                        }
                    }
                    }
            }
            conn.Close();
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.MultiSelect=false;
            Beneficii.Items.Clear();
            if(cboTip.Text =="Evenimente")
            {
                Beneficii.Visible = true;
                conn = conectare.ConectareBazDate();
                conn.Open();
                OleDbCommand cmdSelect, cmdSelect2;
                OleDbDataReader reader, reader2;

                cmdSelect = new OleDbCommand("Select idSolicitare, idCont,idLocatie,TipEveniment, BeneficiiLimuzina, BeneficiiMuzica,BeneficiiAranjamentFloral, BeneficiiDansatori,BeneficiiAranjamentBaloane, BeneficiiAnimatori, Specificatii, Data, PerioadaDesfasurare,Aprobare, idMeniu FROM SolicitariEvenimente where idCont=@idCont", conn);
                cmdSelect.Parameters.AddWithValue("@idCont", this.ContClient);
                reader = cmdSelect.ExecuteReader();
                while(reader.Read())
                {
                    if(reader.GetValue(0).ToString() == dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value.ToString())
                    {
                        if(reader.GetValue(4).ToString().Length.ToString() != "0")
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
                        if (reader.GetValue(14).ToString().Length.ToString()!="0")
                        {
                            
                            cmdSelect2 = new OleDbCommand("Select idMeniu, NumeMeniu from Meniu where Meniu.idMeniu=@Meniu", conn);
                            cmdSelect2.Parameters.AddWithValue("@Meniu", reader.GetValue(14));
                            reader2 = cmdSelect2.ExecuteReader();
                            reader2.Read();
                            Beneficii.Items.Add("Animatori: " + reader2.GetValue(1).ToString());
                        }
                    }
                }
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
