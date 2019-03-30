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
    public partial class Conectare : Form
    {
        Validare validare = new Validare();
        ConectareBD conectare = new ConectareBD();
        OleDbConnection conn;
        public object idCont;
        public Conectare()
        {

            InitializeComponent();

        }

        public void btnConectare_Click(object sender, EventArgs e)
        {

            conectare.ConectareBazDate();
            conn = conectare.ConectareBazDate();

            OleDbCommand cmdSelect, cmdSelect2;

            OleDbDataReader reader, reader2;
            conn.Open();
            // verificarea existentei user-ului
            cmdSelect = new OleDbCommand("SELECT User, Parola, Rol FROM Conturi where Conturi.User = @User AND Conturi.Parola = @Parola", conn);
            cmdSelect.Parameters.AddWithValue("@User", this.txtUser.Text);
            cmdSelect.Parameters.AddWithValue("@Parola", this.txtParola.Text);
            reader = cmdSelect.ExecuteReader();
            
            if(reader.HasRows)
            {
                reader.Read();
                cmdSelect2 = new OleDbCommand("SELECT idCont FROM Conturi where Conturi.User = @User", conn);
                cmdSelect2.Parameters.AddWithValue("@User", this.txtUser.Text);
                reader2 = cmdSelect2.ExecuteReader();

                reader2.Read();
                idCont = reader2.GetValue(0);

                if (reader.GetValue(2).ToString() == "Client")
                {
                    this.Hide();
                    var meniu = new MeniuClient(idCont);
                    meniu.ShowDialog();
                    this.Close();
                }
                else
                {
                    if (reader.GetValue(2).ToString() == "Administrator")
                    {
                        this.Hide();
                        var meniu = new MeniuAdministrator(idCont);
                        meniu.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        if (reader.GetValue(2).ToString() == "Personal Hotel")
                        {
                            this.Hide();
                            var meniu = new MeniuPersonalHotelPrincipal(idCont);
                            meniu.ShowDialog();
                            this.Close();

                        }
                        else
                        {
                            if (reader.GetValue(2).ToString() == "Personal Restaurant")
                            {
                                this.Hide();
                                var meniu = new MeniuPersonalRestaurant(idCont);
                                meniu.ShowDialog();
                                this.Close();
                            }


                            else
                            {
                                if (reader.GetValue(2).ToString() == "ResponsabilEvenimente")
                                {
                                    this.Hide();
                                    var meniu = new MeniuResponsabilEvenimente(idCont);
                                    meniu.ShowDialog();
                                    this.Close();
                                }
                            }
                                
                        }

                    }
                }
                
            }
            else
            {
                MessageBox.Show("User-ul sau parola au fost introduse gresit!");
                conn.Close();
            }



        }

        public void btnInapoi_Click(object sender, EventArgs e)
        {
            
              this.Hide();
              var Start = new Start();
              Start.ShowDialog();
              this.Close();

        }
    }
}
