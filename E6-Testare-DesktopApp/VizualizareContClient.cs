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
    public partial class VizualizareContClient : Form
    {
        bool ok = false;
        ConectareBD conectare = new ConectareBD();
        object ContClient;
        OleDbConnection conn;
        Validare validare = new Validare();
        public VizualizareContClient(object idCont)
        {
            InitializeComponent();
            ContClient = idCont;
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MeniuClient = new MeniuClient(ContClient);
            MeniuClient.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            if(ok == true)
            {
                btnModifica.Text = "Modifica";
                ok = false;
            }
            else
            {

                btnModifica.Text = "Anuleaza";
                txtEmail.Enabled = true;
                TxtTelefon.Enabled = true;
                txtNume.Enabled = true;
                txtPrenume.Enabled = true;
                txtParola.Enabled = true;
                txtUser.Enabled = true;
                
                ok = true;

            }
            btnSalveaza.Visible = ok;
            */
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            /*
            string update, update2, select;
            OleDbCommand cmdUpdate, cmdSelect;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbDataReader reader;
           
            
            conn.Open();
            select = "SELECT Conturi.idCont, Conturi.User, Conturi.Parola,DetaliiCont.idCont, DetaliiCont.Nume, DetaliiCont.Prenume, DetaliiCont.Telefon, DetaliiCont.Email FROM Conturi INNER JOIN  DetaliiCont ON Conturi.idCont = DetaliiCont.idCont WHERE Conturi.IdCont = @idClient";
            

            cmdSelect = new OleDbCommand(select, conn);
            cmdSelect.Parameters.AddWithValue("@idClient", this.ContClient);

            reader = cmdSelect.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();

                if (txtUser.Text == reader.GetValue(1) && txtParola.Text == reader.GetValue(2) && txtNume.Text == reader.GetValue(4) && txtPrenume.Text == reader.GetValue(5) && TxtTelefon.Text == reader.GetValue(6) && txtEmail.Text == reader.GetValue(7) )
                {
                    btnSalveaza.Visible = false;
                    ok = false;
                    btnModifica.Text = "Modifica";
                   

                    
                }


                else
                {
                    if (validare.ValidareParola(txtParola.Text, out string Eroare) == false || validare.ValidareTelefon(TxtTelefon.Text, out string Eroare2) == false )
                    {
                        MessageBox.Show("Datele introduse nu sunt corecte");
                        

                        btnSalveaza.Visible = false;
                        ok = false;
                        btnModifica.Text = "Modifica";
                        reader.Read();

                       // txtNume.Text = Convert.ToString(reader.GetValue(5));
                       // txtPrenume.Text = Convert.ToString(reader.GetValue(6));
                       /// txtEmail.Text = Convert.ToString(reader.GetValue(8));
                       // TxtTelefon.Text = Convert.ToString(reader.GetValue(7));

                       // txtUser.Text = Convert.ToString(reader.GetValue(1));
                       // txtParola.Text = Convert.ToString(reader.GetValue(2));
                    }
                    else
                    {//|| (txtUser.Text != reader.GetValue(1) && validare.ValidareUser(txtUser.Text, out string Eroare3) == false)

                        update = "UPDATE DetaliiCont SET DetaliiCont.Nume = '" + txtNume.Text.ToString() + "',  DetaliiCont.Prenume = '" + txtPrenume.Text.ToString() + "', DetaliiCont.Email = '" + txtEmail.Text.ToString() + "', DetaliiCont.Telefon = '" + TxtTelefon.Text.ToString() + "' where DetaliiCont.idCont = '" + ContClient + "'";
                        update2 = " UPDATE Conturi SET Conturi.User = '" + txtUser.Text.ToString() + "', Conturi.Parola = '" + txtParola.Text.ToString() + "' where Conturi.idCont = '" + ContClient + "'";

                        cmdUpdate = new OleDbCommand(update, conn);
                        adapter.UpdateCommand = new OleDbCommand(update, conn);
                        adapter.UpdateCommand.ExecuteNonQuery();
                        cmdUpdate.Dispose();

                        cmdUpdate = new OleDbCommand(update2, conn);
                        adapter.UpdateCommand = new OleDbCommand(update2, conn);
                        adapter.UpdateCommand.ExecuteNonQuery();
                        cmdUpdate.Dispose();

                        MessageBox.Show("Datele au fost modificate!");

                    }
                }
            }
            conn.Close();
            txtNume.Enabled = false;
            txtParola.Enabled = false;
            txtPrenume.Enabled = false;
            txtUser.Enabled = false;
            TxtTelefon.Enabled = false;
            txtEmail.Enabled = false;
            */

        }

        private void VizualizareContClient_Load(object sender, EventArgs e)
        {
            conn = conectare.ConectareBazDate();

            OleDbCommand cmdSelect, cmdSelect2;

            OleDbDataReader reader;
            conn.Open();
            // verificarea existentei user-ului
            cmdSelect = new OleDbCommand("SELECT Nume, Prenume, Email, Telefon FROM DetaliiCont where DetaliiCont.idCont = @idCont", conn);
            cmdSelect2 = new OleDbCommand("SELECT User, Parola  FROM Conturi where Conturi.idCont = @idCont", conn);

            cmdSelect.Parameters.AddWithValue("@idCont", this.ContClient);
            cmdSelect2.Parameters.AddWithValue("@idCont", this.ContClient);

            reader = cmdSelect.ExecuteReader();

            reader.Read();
            txtNume.Text = Convert.ToString(reader.GetValue(0));
            txtPrenume.Text = Convert.ToString(reader.GetValue(1));
            txtEmail.Text = Convert.ToString(reader.GetValue(2));
            TxtTelefon.Text = Convert.ToString(reader.GetValue(3));

            reader = cmdSelect2.ExecuteReader();

            reader.Read();
            txtUser.Text =Convert.ToString( reader.GetValue(0));
            txtParola.Text = Convert.ToString(reader.GetValue(1));
            conn.Close();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MeniuClient = new MeniuClient_Istoric(ContClient);
            MeniuClient.ShowDialog();
            this.Close();
        }
    }
}
