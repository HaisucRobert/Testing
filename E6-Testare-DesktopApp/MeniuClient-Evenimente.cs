using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Globalization;

namespace E6_Testare_DesktopApp
{
    public partial class MeniuClient_Evenimente : Form
    {
        ConectareBD conectare = new ConectareBD();
        OleDbConnection conn;
        object ContClient;
        public MeniuClient_Evenimente(object idCont)
        {
            InitializeComponent();
            ContClient = idCont;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Solicita.Visible = false;
            lblPret.Visible = false;
            txtPret.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.treeView1.Visible = true;
        }

        private void MeniuClient_Evenimente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testareBDDataSet.Meniu' table. You can move, or remove it, as needed.
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            conectare.ConectareBazDate();
            conn = conectare.ConectareBazDate();
            int i = 0;

            OleDbCommand cmdSelect, cmdselect2;

            OleDbDataReader reader, reader2;
            conn.Open();
            // verificarea existentei user-ului
            cmdselect2 = new OleDbCommand("SELECT Meniu.idMeniu, Meniu.NumeMeniu, Meniu.Pret FROM Meniu", conn);
            reader2 = cmdselect2.ExecuteReader();

            while (reader2.Read())
            {

                cboMeniu.Items.Add(reader2.GetValue(1).ToString());
                this.treeView1.Nodes.Add("'" + reader2.GetValue(1).ToString() + "' - '" + reader2.GetValue(2).ToString() + "' lei");
                i++;

                cmdSelect = new OleDbCommand(" SELECT MeniuPreparat.idMeniu, MeniuPreparat.idPreparat, Preparate.idPreparat, Preparate.NumePreparat from MeniuPreparat INNER JOIN Preparate on MeniuPreparat.idPreparat = Preparate.idPreparat where MeniuPreparat.idMeniu = @idMeniu", conn);
                cmdSelect.Parameters.AddWithValue("@idMeniu", reader2.GetValue(0));
                reader = cmdSelect.ExecuteReader();

                while (reader.Read())
                {
                    treeView1.Nodes[i - 1].Nodes.Add("'" + reader.GetValue(3).ToString() + "'");
                }
            }
            OleDbDataReader readerLocatii;
            cmdSelect = new OleDbCommand("Select idLocatie, Denumire, Capacitate from Locatii", conn);
            readerLocatii = cmdSelect.ExecuteReader();

            while (readerLocatii.Read())
            {

                cboLocatii.Items.Add(readerLocatii.GetValue(1));
            }
            conn.Close();



        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Solicita_Click(object sender, EventArgs e)
        {
            conectare.ConectareBazDate();
            conn = conectare.ConectareBazDate();
            int i = 0;
            Boolean disponibil = true;

            OleDbCommand cmdSelect, cmdselect2;

            OleDbDataReader reader, reader2;
            conn.Open();


                            string select1, select2;
                            OleDbDataReader readerselectLocatie, readerselectMeniu;
                            OleDbCommand cmdLocatie, cmdMeniu;


                            select1 = "SELECT idMeniu FROM Meniu where Meniu.NumeMeniu = '" + cboMeniu.Text + "'";
                            select2 = "Select idLocatie from Locatii where Locatii.Denumire = '" + cboLocatii.Text + "'";
                            cmdLocatie = new OleDbCommand(select2, conn);
                            cmdMeniu = new OleDbCommand(select1, conn);
                            readerselectLocatie = cmdLocatie.ExecuteReader();
                            readerselectMeniu = cmdMeniu.ExecuteReader();

                            readerselectLocatie.Read();
                            readerselectMeniu.Read();
                            string insert;
                            insert = "INSERT INTO SolicitariEvenimente([idCont],[TipEveniment],[idLocatie], [BeneficiiLimuzina], [BeneficiiMuzica], [BeneficiiAranjamentFloral], [BeneficiiDansatori],[BeneficiiAnimatori],[BeneficiiAranjamentBaloane],[Data],[PerioadaDesfasurare],[idMeniu],[Aprobare]) VALUES('" + ContClient + "','" + cboTip.Text + "','" + readerselectLocatie.GetValue(0) + "' ,'" + cboTransport.Text + "','" + cboMuzica.Text + "','" + cboFlori.Text + "','" + cboDansatori.Text + "','" + cboAnimatori.Text + "','" + cboBaloane.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + textBox1.Text + "','" + readerselectMeniu.GetValue(0) + "','in asteptare')";

                            OleDbCommand cmdInsert;
                
                            OleDbDataAdapter adapter = new OleDbDataAdapter();

                            cmdInsert = new OleDbCommand(insert, conn);

            try
            {
                // inserarea in conturi

                adapter.InsertCommand = new OleDbCommand(insert, conn);
                adapter.InsertCommand.ExecuteNonQuery();
                cmdInsert.Dispose();
                

            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);

                    }
                            


                  // inserarea in conturi
                        
                        adapter.InsertCommand = new OleDbCommand(insert, conn);
                        adapter.InsertCommand.ExecuteNonQuery();
                        cmdInsert.Dispose();
            OleDbDataReader readerE;

                        // inserarea in detaliicont
            OleDbCommand cmdSelect2 = new OleDbCommand("SELECT idSolicitare FROM SolicitariEvenimente where SolicitariEvenimente.idCont = @Cont AND SolicitariEvenimente.idLocatie=@Locatie AND SolicitariEvenimente.Data=@Data", conn);
                        cmdSelect2.Parameters.AddWithValue("@Cont", this.ContClient);
                        cmdSelect2.Parameters.AddWithValue("@Locatie", readerselectLocatie.GetValue(0));
                        cmdSelect2.Parameters.AddWithValue("@Data", dateTimePicker1.Value.ToShortDateString());
                        readerE = cmdSelect2.ExecuteReader();

                        readerE.Read();
                        OleDbDataAdapter adapter2 = new OleDbDataAdapter();
                        String insertDetalii = "INSERT INTO Evenimente([idSolicitare],[Pret]) VALUES ('" + readerE.GetValue(0) + "','" + txtPret.Text + "')";
                        OleDbCommand cmdInsertDetalii = new OleDbCommand(insertDetalii, conn);
                        adapter2.InsertCommand = new OleDbCommand(insertDetalii, conn);
                        adapter2.InsertCommand.ExecuteNonQuery();
                        cmdInsertDetalii.Dispose();
                        MessageBox.Show("Solicitarea dumneavoastra a fost inregistrata");
                        conn.Close();
                        
          
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MeniuClient = new MeniuClient(ContClient);
            MeniuClient.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double pret = 0, pretsala=0 ;
            
            conectare.ConectareBazDate();
            conn = conectare.ConectareBazDate();
            int i = 0;
            Boolean disponibil = true;

            OleDbCommand cmdSelect, cmdselect2;

            OleDbDataReader reader, reader2;
            conn.Open();

            if (textBox1.Text == "")
            {
                MessageBox.Show("Introduceti durata evenimentului");
            }
            else
            {
                if (cboLocatii.Text == "")
                {
                    MessageBox.Show("Introduceti locatia evenimentului");
                }
                else
                {
                    if (cboTip.Text == "")
                    {
                        MessageBox.Show("Introduceti tipul evenimentului");
                    }
                    else
                    {
                        if(textBox2.Text=="")
                        {
                            MessageBox.Show("Introduceti numarul de persoane");
                        }
                    
                    else
                    {
                        // verificarea existentei user-ului
                        cmdSelect = new OleDbCommand("SELECT SolicitariEvenimente.idLocatie, SolicitariEvenimente.Data, SolicitariEvenimente.PerioadaDesfasurare, Locatii.idLocatie, Locatii.Denumire FROM SolicitariEvenimente INNER JOIN Locatii on SolicitariEvenimente.idLocatie=Locatii.idLocatie WHERE Locatii.Denumire = '" + cboLocatii.Text.ToString() + "'", conn);
                        reader = cmdSelect.ExecuteReader();



                        while (reader.Read())
                        {
                            if (dateTimePicker1.Value >= Convert.ToDateTime(reader.GetValue(1)) && dateTimePicker1.Value <= Convert.ToDateTime(reader.GetValue(1)).AddHours(Convert.ToDouble(reader.GetValue(2))))
                            {
                                MessageBox.Show("Locatia aleasa nu este disponibila pentru data selectata");
                                disponibil = false;
                            }
                        }
                            if (disponibil == true)
                            {

                                Solicita.Visible = true;
                                lblPret.Visible = true;
                                txtPret.Visible = true;

                                if (cboLocatii.Text == "Sala de conferinte")
                                {
                                    pretsala = 100;
                                }

                                if (cboLocatii.Text == "Sala de evenimente mica")
                                {
                                    pretsala = 150;
                                }

                                if (cboLocatii.Text == "Sala de evenimente mare")
                                {
                                    pretsala = 300;
                                }

                                if (cboLocatii.Text == "Terasa")
                                {
                                    pretsala = 120;
                                }

                                pret = pret + pretsala * Convert.ToInt32(textBox1.Text);

                                if (cboFlori.Text != "")
                                {
                                    pret = pret + 200;

                                }
                                if (cboAnimatori.Text != "")
                                {
                                    pret = pret + 500;
                                }
                                if (cboBaloane.Text != "")
                                {
                                    pret = pret + 100;
                                }
                                if (cboDansatori.Text != "")
                                {
                                    pret = pret + 400;
                                }
                                if (cboMuzica.Text != "")
                                {
                                    pret = pret + 300;
                                }

                                if (cboMeniu.Text != "")
                                {
                                    OleDbCommand select1;
                                    OleDbDataReader readerMeniu;

                                    select1 = new OleDbCommand("SELECT idMeniu, NumeMeniu, Pret FROM Meniu where Meniu.NumeMeniu = '" + cboMeniu.Text + "'", conn);
                                    readerMeniu = select1.ExecuteReader();
                                    readerMeniu.Read();

                                    pret = pret + Convert.ToDouble(textBox2.Text) * Convert.ToDouble(readerMeniu.GetValue(2));

                                }
                            }

                        }
                    }
                }
            }
            txtPret.Text = Convert.ToString(pret);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Solicita.Visible = false;
            lblPret.Visible = false;
            txtPret.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Solicita.Visible = false;
            lblPret.Visible = false;
            txtPret.Visible = false;
        }

        private void cboTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            Solicita.Visible = false;
            lblPret.Visible = false;
            txtPret.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Solicita.Visible = false;
            lblPret.Visible = false;
            txtPret.Visible = false;
        }

        private void cboDansatori_SelectedIndexChanged(object sender, EventArgs e)
        {
            Solicita.Visible = false;
            lblPret.Visible = false;
            txtPret.Visible = false;
        }

        private void cboFlori_SelectedIndexChanged(object sender, EventArgs e)
        {
            Solicita.Visible = false;
            lblPret.Visible = false;
            txtPret.Visible = false;
        }

        private void cboBaloane_SelectedIndexChanged(object sender, EventArgs e)
        {
            Solicita.Visible = false;
            lblPret.Visible = false;
            txtPret.Visible = false;
        }

        private void cboTransport_SelectedIndexChanged(object sender, EventArgs e)
        {
            Solicita.Visible = false;
            lblPret.Visible = false;
            txtPret.Visible = false;
        }

        private void cboMuzica_SelectedIndexChanged(object sender, EventArgs e)
        {
            Solicita.Visible = false;
            lblPret.Visible = false;
            txtPret.Visible = false;
        }

        private void cboMeniu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Solicita.Visible = false;
            lblPret.Visible = false;
            txtPret.Visible = false;
        }

        private void cboLocatii_SelectedIndexChanged(object sender, EventArgs e)
        {
            Solicita.Visible = false;
            lblPret.Visible = false;
            txtPret.Visible = false;
        }
    }
}
    

