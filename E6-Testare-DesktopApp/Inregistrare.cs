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
using System.Data.SqlClient;

namespace E6_Testare_DesktopApp
{
    public partial class Inregistrare : Form
    {
        Validare validare = new Validare();
        ConectareBD conectare = new ConectareBD();
        OleDbConnection conn;
        public object idCont;



        public Inregistrare()
        {
            InitializeComponent();
        }

        public void btnInregistrare_Click(object sender, EventArgs e)
        {

            conectare.ConectareBazDate();
            conn = conectare.ConectareBazDate();
            conn.Open();


            Boolean valid = true;
            lblDimensiune.ForeColor = System.Drawing.Color.Black;
            lblLiteraMare.ForeColor = System.Drawing.Color.Black;
            lblLiteraMica.ForeColor = System.Drawing.Color.Black;
            lblCifra.ForeColor = System.Drawing.Color.Black;
            LblCaracter.ForeColor = System.Drawing.Color.Black;
            lblNull.Text = "";
            lblTelErr.Text = "";
            lblUserErr.Text = "";

            String user = txtUser.Text;
            String parola = txtParola.Text;
            String Email = txtEmail.Text;
            String Telefon = TxtTelefon.Text;
            String Nume = txtNume.Text;
            string Prenume = txtPrenume.Text;




            if (validare.ValidareTelefon(TxtTelefon.Text, out string ErrorMessage) == false)
            {
                lblTelErr.Text = ErrorMessage.ToString();
                valid = false;
            }

            if (validare.ValidareParola(txtParola.Text, out string ErrorMessagePass) == false)
            {

                if (ErrorMessagePass.ToString() == "0")
                {
                    lblNull.Text = "Trebuie sa introduci o parola";
                }
                else
                {
                    // label-urile se coloreaza in rosu in functie de validarile nerespectate
                    for (int i = 0; i <= ErrorMessagePass.ToString().Length - 1; i++)
                    {
                        if (ErrorMessagePass.Substring(i, 1) == "1")
                        {
                            lblDimensiune.ForeColor = System.Drawing.Color.Red;
                        }
                        if (ErrorMessagePass.Substring(i, 1) == "2")
                        {
                            lblLiteraMare.ForeColor = System.Drawing.Color.Red;
                        }
                        if (ErrorMessagePass.Substring(i, 1) == "3")
                        {
                            lblLiteraMica.ForeColor = System.Drawing.Color.Red;
                        }
                        if (ErrorMessagePass.Substring(i, 1) == "4")
                        {
                            lblCifra.ForeColor = System.Drawing.Color.Red;
                        }
                        if (ErrorMessagePass.Substring(i, 1) == "5")
                        {
                            LblCaracter.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                }

                valid = false;
            }

            if (validare.ValidareUser(txtUser.Text, out string ErrorMessageUser) == false)
            {
                lblUserErr.Text = ErrorMessageUser.ToString();
                valid = false;
            }

            if (valid == true)
            {
                // TO DO: Inregistrarea noului utilizator
                OleDbCommand cmdSelect, cmdInsert, cmdInsertDetalii;


                string insert, insertDetalii;
                OleDbDataReader reader;
                    insert = "INSERT INTO Conturi([User],[Parola],[Rol]) VALUES ('" + txtUser.Text + "','" + txtParola.Text + "','Client')";

                    cmdInsert = new OleDbCommand(insert, conn);

                    OleDbDataAdapter adapter = new OleDbDataAdapter();

                    try
                    {
                    // inserarea in conturi
                        
                        adapter.InsertCommand = new OleDbCommand(insert, conn);
                        adapter.InsertCommand.ExecuteNonQuery();
                        cmdInsert.Dispose();

                        // inserarea in detaliicont
                        cmdSelect = new OleDbCommand("SELECT idCont FROM Conturi where Conturi.User = @User", conn);
                        cmdSelect.Parameters.AddWithValue("@User", this.txtUser.Text);
                        reader = cmdSelect.ExecuteReader();

                        reader.Read();
                        idCont = reader.GetValue(0);
                        insertDetalii = "INSERT INTO DetaliiCont([Nume],[Prenume],[Telefon],[Email],[idCont]) VALUES ('" + txtNume.Text + "','" + txtPrenume.Text + "','" + TxtTelefon.Text + "','" + txtEmail.Text + "', '" + idCont + "')";
                        cmdInsertDetalii = new OleDbCommand(insertDetalii, conn);
                        adapter.InsertCommand = new OleDbCommand(insertDetalii, conn);
                        adapter.InsertCommand.ExecuteNonQuery();
                        cmdInsertDetalii.Dispose();
                        MessageBox.Show("Utilizatorul a fost adaugat!");
                        conn.Close();

                        //deschidere meniu

                        this.Hide();
                        var meniu = new MeniuClient(idCont);
                        meniu.ShowDialog();
                        this.Close();
                        
                    }

                    catch (OleDbException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        

     

        public void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            var start = new Start();
            start.ShowDialog();
            this.Close();
        }

        public void Inregistrare_Load(object sender, EventArgs e)
        {
            conn = conectare.ConectareBazDate();
        }
    }
}
