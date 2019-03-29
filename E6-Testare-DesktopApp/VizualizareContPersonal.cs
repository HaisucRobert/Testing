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
    public partial class VizualizareContPersonal : Form
    {
        ConectareBD conectare = new ConectareBD();
        OleDbConnection conn;
        object Cont;
        public VizualizareContPersonal(object idCont)
        {
            InitializeComponent();
            Cont = idCont;

        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            conectare.ConectareBazDate();
            conn = conectare.ConectareBazDate();

            OleDbCommand cmdSelect;

            OleDbDataReader reader;
            conn.Open();

            cmdSelect = new OleDbCommand("SELECT Rol FROM Conturi where Conturi.idCont = @idCont", conn);
            cmdSelect.Parameters.AddWithValue("@idCont", Cont);
            reader = cmdSelect.ExecuteReader();

            reader.Read();



            if (reader.GetValue(0).ToString() == "Administrator")
            {
                this.Hide();
                var meniu = new MeniuAdministrator(Cont);
                meniu.ShowDialog();
                this.Close();
            }
            else
            {
                if (reader.GetValue(0).ToString() == "Personal Hotel")
                {
                    this.Hide();
                    var meniu = new MeniuPersonalHotel(Cont);
                    meniu.ShowDialog();
                    this.Close();

                }
                else
                {
                    if (reader.GetValue(0).ToString() == "Personal Restaurant")
                    {
                        this.Hide();
                        var meniu = new MeniuPersonalRestaurant(Cont);
                        meniu.ShowDialog();
                        this.Close();
                    }


                    else
                    {
                        if (reader.GetValue(0).ToString() == "ResponsabilEvenimente")
                        {
                            this.Hide();
                            var meniu = new MeniuResponsabilEvenimente(Cont);
                            meniu.ShowDialog();
                            this.Close();
                        }
                    }

                }
            }
        }

            

        private void VizualizareContPersonal_Load(object sender, EventArgs e)
        {
            conn = conectare.ConectareBazDate();

            OleDbCommand cmdSelect, cmdSelect2;

            OleDbDataReader reader;
            conn.Open();
            // verificarea existentei user-ului
            cmdSelect = new OleDbCommand("SELECT Nume, Prenume, Email, Telefon, Functia, Adresa FROM DetaliiCont where DetaliiCont.idCont = @idCont", conn);
            cmdSelect2 = new OleDbCommand("SELECT User, Parola  FROM Conturi where Conturi.idCont = @idCont", conn);

            cmdSelect.Parameters.AddWithValue("@idCont", this.Cont);
            cmdSelect2.Parameters.AddWithValue("@idCont", this.Cont);

            reader = cmdSelect.ExecuteReader();

            reader.Read();
            txtNume.Text = Convert.ToString(reader.GetValue(0));
            txtPrenume.Text = Convert.ToString(reader.GetValue(1));
            txtEmail.Text = Convert.ToString(reader.GetValue(2));
            TxtTelefon.Text = Convert.ToString(reader.GetValue(3));
            txtFunctia.Text = Convert.ToString(reader.GetValue(4));
            txtAdresa.Text = Convert.ToString(reader.GetValue(5));

            reader = cmdSelect2.ExecuteReader();

            reader.Read();
            txtUser.Text = Convert.ToString(reader.GetValue(0));
            txtParola.Text = Convert.ToString(reader.GetValue(1));
            conn.Close();
        }
    }
}
