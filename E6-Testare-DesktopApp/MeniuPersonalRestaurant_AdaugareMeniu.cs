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
    public partial class MeniuPersonalRestaurant_AdaugareMeniu : Form
    {

        ConectareBD conectare = new ConectareBD();
        OleDbConnection conn;
        object ContPersonal;

        public MeniuPersonalRestaurant_AdaugareMeniu(object idCont)
        {
            InitializeComponent();
            ContPersonal = idCont;

        }

        private void MeniuPersonalRestaurant_AdaugareMeniu_Load(object sender, EventArgs e)
        {
            conn = conectare.ConectareBazDate();
            conn.Open();

            OleDbCommand cmdSelect;

            OleDbDataReader reader;

            cmdSelect = new OleDbCommand("SELECT * from Preparate", conn);
            reader = cmdSelect.ExecuteReader();


            while (reader.Read())
            {

                chLB_preparate.Items.Add(reader[1].ToString());

            }
            conn.Close();
        }

        private void btn_Inapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Meniu = new MeniuPersonalRestaurant_Meniuri(ContPersonal);
            Meniu.ShowDialog();
            this.Close();
        }
   


        private void btn_salveaza_Click_1(object sender, EventArgs e)
        {
            String numeMeniu = txtNume.Text;
            String pret = txtPret.Text;

            lblErrorNume.Text = "";
            lblErrorPret.Text = "";



            if (numeMeniu == "")
            {
                lblErrorNume.Text = "Denumirea meniului este obligatorie!";
            }
            else if (pret == "")
            {
                lblErrorNume.Text = "Pretul meniului este obligatorie!";
            }
            else
            {

                // TO TO: Inregistrarea noului utilizator
                OleDbCommand cmdSelect, cmdInsert, cmdInsertDetalii;


                string insert, insertDetalii;
                OleDbDataReader reader;

                insert = "INSERT INTO Meniu([NumeMeniu],[Pret]) VALUES ('" + txtNume.Text + "','" + txtPret.Text + "')";

                cmdInsert = new OleDbCommand(insert, conn);

                OleDbDataAdapter adapter = new OleDbDataAdapter();

                try
                {
                    // inserarea in meniu
                    conn.Open();
                    adapter.InsertCommand = new OleDbCommand(insert, conn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    cmdInsert.Dispose();

                    // inserarea in meniuPreparat
                    cmdSelect = new OleDbCommand("SELECT idMeniu FROM Meniu where Meniu.idMeniu = @Meniu", conn);
                    cmdSelect.Parameters.AddWithValue("@Meniu", this.txtNume.Text);
                    reader = cmdSelect.ExecuteReader();

                    reader.Read();

                    /*
                     var contMeniu = reader.GetValue(0);

                    int numar = chLB_preparate.CheckedItems.Count;
                    for(int i =0; i<=numar; i++)
                      {
                        insertDetalii = "INSERT INTO MeniuPreparate([idMeniu],[idPreparat]) VALUES ('" + contMeniu + "' , '" + chLB_preparate.CheckedItems[i] + "')";
                        cmdInsertDetalii = new OleDbCommand(insertDetalii, conn);
                        adapter.InsertCommand = new OleDbCommand(insertDetalii, conn);
                        adapter.InsertCommand.ExecuteNonQuery();
                        cmdInsertDetalii.Dispose();
                    }
                  */

                    MessageBox.Show("Meniul a fost adaugat!");
                    conn.Close();

                    //deschidere meniu

                    this.Hide();
                    var meniu = new MeniuPersonalRestaurant_Meniuri(ContPersonal);
                    meniu.ShowDialog();
                    this.Close();

                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    
    }
}
