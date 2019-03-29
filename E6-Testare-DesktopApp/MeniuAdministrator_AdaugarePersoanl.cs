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
    public partial class MeniuAdministrator_AdaugarePersoanl : Form
    {
        ConectareBD conectare = new ConectareBD();

        FolderBrowserDialog fbd = new FolderBrowserDialog();
        OleDbConnection conn;
        private object contAdministrator;
        object cont;
        Validare validare = new Validare();


        public object idCont;

        public MeniuAdministrator_AdaugarePersoanl(object idCont)
        {
            InitializeComponent();

            contAdministrator = idCont;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Start = new MeniuAdministrator(contAdministrator);
            Start.ShowDialog();
            this.Close();
        }

        private void MeniuAdministrator_AdaugarePersoanl_Load(object sender, EventArgs e)
        {
            cboFunctie.SelectedIndex = 0;
            conn = conectare.ConectareBazDate();
            dataGridView1.Hide();
            btnStergerePersonal.Hide();
        }



        private void cboFunctie_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cboFunctie.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Boolean valid = true;
            lblDimensiune.ForeColor = System.Drawing.Color.Black;
            lblLiteraMare.ForeColor = System.Drawing.Color.Black;
            lblLiteraMica.ForeColor = System.Drawing.Color.Black;
            lblCifra.ForeColor = System.Drawing.Color.Black;
            LblCaracter.ForeColor = System.Drawing.Color.Black;

            lblErrorNume.Text = "";
            lblErrorParola.Text = "";
            lblErrorUser.Text = "";

            String user = txtUser.Text;
            String parola = txtParola.Text;
            String Email = txtEmail.Text;
            String Telefon = TxtTelefon.Text;
            String Nume = txtNume.Text;
            String Prenume = txtPrenume.Text;
            String Adresa = txtAdresa.Text;
            String Functia = cboFunctie.Text;

            if (validare.ValidareNume(txtNume.Text, out string ErrorMessage) == false)
            {
                lblErrorNume.Text = ErrorMessage.ToString();
                valid = false;
            }

            if (validare.ValidareParola(txtParola.Text, out string ErrorMessagePass) == false)
            {

                if (ErrorMessagePass.ToString() == "0")
                {
                    lblErrorParola.Text = "Trebuie sa introduci o parola";
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

                lblErrorUser.Text = ErrorMessageUser.ToString();
                valid = false;
            }


            if (valid == true)
            {

                // TO TO: Inregistrarea noului utilizator
                OleDbCommand cmdSelect, cmdInsert, cmdInsertDetalii;


                string insert, insertDetalii;
                OleDbDataReader reader;
                insert = "INSERT INTO Conturi([User],[Parola],[Rol]) VALUES ('" + txtUser.Text + "','" + txtParola.Text + "','" + cboFunctie.Text + "')";

                cmdInsert = new OleDbCommand(insert, conn);

                OleDbDataAdapter adapter = new OleDbDataAdapter();

                try
                {
                    // inserarea in conturi
                    conn.Open();
                    adapter.InsertCommand = new OleDbCommand(insert, conn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    cmdInsert.Dispose();

                    // inserarea in detaliicont
                    cmdSelect = new OleDbCommand("SELECT idCont FROM Conturi where Conturi.User = @User", conn);
                    cmdSelect.Parameters.AddWithValue("@User", this.txtUser.Text);
                    reader = cmdSelect.ExecuteReader();

                    reader.Read();
                    idCont = reader.GetValue(0);
                    insertDetalii = "INSERT INTO DetaliiCont([Nume],[Prenume],[Telefon],[Email],[Adresa],[Functia],[idCont]) VALUES ('" + txtNume.Text + "','" + txtPrenume.Text + "','" + TxtTelefon.Text + "','" + txtEmail.Text + "', '" + txtAdresa.Text + "','" + cboFunctie.Text + "','" + idCont + "')";
                    cmdInsertDetalii = new OleDbCommand(insertDetalii, conn);
                    adapter.InsertCommand = new OleDbCommand(insertDetalii, conn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    cmdInsertDetalii.Dispose();
                    MessageBox.Show("Utilizatorul a fost adaugat!");
                    conn.Close();

                    //deschidere meniu

                    this.Hide();
                    var meniu = new MeniuAdministrator(idCont);
                    meniu.ShowDialog();
                    this.Close();

                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnAfisare_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Show();
            btnStergerePersonal.Show();


            conectare.ConectareBazDate();
            conn = conectare.ConectareBazDate();
            conn.Open();

            var q = "SELECT DetaliiCont.[idDC], DetaliiCont.[Nume], DetaliiCont.[Prenume], DetaliiCont.[Telefon], DetaliiCont.[Email], DetaliiCont.[Adresa], DetaliiCont.[Functia], DetaliiCont.[idCont] FROM DetaliiCont ";
            var cmd = new OleDbCommand(q, conn);
            var da = new OleDbDataAdapter(q, conn);
            OleDbDataReader reader;
            reader = cmd.ExecuteReader();

            var ds = new DataSet();
            da.Fill(ds, "Detalii cont");
            dataGridView1.DataMember = "Detalii cont";
            dataGridView1.DataSource = ds;
            conn.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var Start = new MeniuAdministrator(contAdministrator);
            Start.ShowDialog();
            this.Close();
        }

        private void btnStergerePersonal_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmdSelect;
            OleDbDataReader reader;
            // cmdSelect = new OleDbCommand("SELECT idDC FROM DetaliiCont where DetaliiCont.User = @User", conn);
            // cmdSelect.Parameters.AddWithValue("@User", this.txtUser.Text);
            //reader = cmdSelect.ExecuteReader();
            //  reader.Read();
            // idCont = reader.GetValue(0);

            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }

            try
            {
                OleDbCommand cmd = new OleDbCommand("Delete from DetaliiCont where Cstr(idDC)='" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", conn);
                cmd.ExecuteNonQuery();

               OleDbCommand cmd2 = new OleDbCommand("Delete from Conturi where Cstr(idCont)='" + dataGridView1.CurrentRow.Cells[7].Value + "'", conn);
                cmd2.ExecuteNonQuery();
                conn.Close();
            }

            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            MeniuAdministrator_AdaugarePersoanl form = new MeniuAdministrator_AdaugarePersoanl(contAdministrator);
            form.Refresh();
            
        }
    }
}

