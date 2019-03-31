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
    public partial class MeniuPersonalRestaurant_AdaugaPreparat : Form
    {
        ConectareBD conectare = new ConectareBD();
        OleDbConnection conn;
        object ContPersonal;

        public MeniuPersonalRestaurant_AdaugaPreparat(object contId)
        {
            InitializeComponent();
            ContPersonal = contId;
        }

        private void MeniuPersonalRestaurant_AdaugaPreparat_Load(object sender, EventArgs e)
        {
            conectare.ConectareBazDate();
            conn = conectare.ConectareBazDate();

        }

        private void lbl_Preparate_Click(object sender, EventArgs e)
        {

        }
        private void btn_salveaza_Click_1(object sender, EventArgs e)
        {
            {
                String numePreparat = txtNume.Text;
                String pret = txtPret.Text;
                String ingrediente = txtIngrediente.Text;
                String tip = txtTipPreparat.Text;

                lblErrorNume.Text = "";
                lblErrorPret.Text = "";




                if (numePreparat == "" || pret == "" || ingrediente == "" || tip == "")
                {
                    lblErrorNume.Text = "Toate campurile sunt obligatorii!";
                }

                else
                {

                    // TO TO: Inregistrarea noului utilizator
                    OleDbCommand cmdSelect, cmdInsert, cmdInsertDetalii;


                    string insert, insertDetalii;
                    OleDbDataReader reader;

                    insert = "INSERT INTO Preparate([NumePreparat],[Ingrediente],[TipPreparat],[Pret]) VALUES ('" + txtNume.Text + "','" + txtIngrediente.Text + "', '" + txtTipPreparat.Text + "', '" + txtPret.Text + "')";

                    cmdInsert = new OleDbCommand(insert, conn);

                    OleDbDataAdapter adapter = new OleDbDataAdapter();

                    try
                    {
                        // inserarea in meniu
                        conn.Open();
                        adapter.InsertCommand = new OleDbCommand(insert, conn);
                        adapter.InsertCommand.ExecuteNonQuery();
                        cmdInsert.Dispose();

                        MessageBox.Show("Preparatul a fost adaugat!");
                        conn.Close();

                        //deschidere meniu

                        this.Hide();
                        var meniu = new MeniuPersonalRestaurant_Preparate(ContPersonal);
                        meniu.ShowDialog();
                        this.Close();

                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }

        private void btn_Inapoi_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var meniu = new MeniuPersonalRestaurant_Preparate(ContPersonal);
            meniu.ShowDialog();
            this.Close();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblPret_Click(object sender, EventArgs e)
        {

        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPret_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblErrorUser_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorParola_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorNume_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorPret_Click(object sender, EventArgs e)
        {

        }

        private void lblErrorName_Click(object sender, EventArgs e)
        {

        }

        private void txtIngrediente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTipPrep0arat_TextChanged(object sender, EventArgs e)
        {

        }


    }
}

