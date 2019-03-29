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
    public partial class MeniuClient_Restaurant_Meniu : Form
    {
        object ContClient;
        ConectareBD conectare = new ConectareBD();
        OleDbConnection conn;
        public MeniuClient_Restaurant_Meniu(object idCont)
        {
            InitializeComponent();
            ContClient = idCont;
        }

        private void MeniuClient_Restaurant_Meniu_Load(object sender, EventArgs e)
        {
            conn = conectare.ConectareBazDate();
            conn.Open();

            int i = 0;
            int j = 0;
            OleDbCommand cmdSelect, cmdselect2, cmdSelect3;

            OleDbDataReader reader, reader2, reader3;

            cmdselect2 = new OleDbCommand("SELECT Distinct TipPreparat from Preparate", conn);
            reader2 = cmdselect2.ExecuteReader();

            while (reader2.Read())
            {

               
                this.treeView1.Nodes.Add("'" + reader2.GetValue(0).ToString());
                i++;

                cmdSelect = new OleDbCommand(" SELECT idPreparat,TipPreparat, NumePreparat, Pret FROM Preparate where Preparate.TipPreparat =@Preparat", conn);
                cmdSelect.Parameters.AddWithValue("@Preparat", reader2.GetValue(0));
                reader = cmdSelect.ExecuteReader();
                j = 0;
                while (reader.Read())
                {
                    j++;
                    treeView1.Nodes[i - 1].Nodes.Add("'" + reader.GetValue(2).ToString() + "' - '"+ reader.GetValue(3).ToString()+"' lei");
                    treeView1.Nodes[i - 1].NodeFont = new Font("Monotype Corsiva", 16);
                    treeView1.Nodes[i - 1].Nodes[j - 1].NodeFont = new Font("Monotype Corsiva", 14);
/*
                    cmdSelect3 = new OleDbCommand("SELECT  Ingrediente from Preparate where Preparate.idPreparat =@Preparat", conn);
                    cmdSelect3.Parameters.AddWithValue("@Preparat", reader.GetValue(0));
                    reader3 = cmdSelect3.ExecuteReader();
                    while (reader3.Read())
                    {
                        treeView1.Nodes[i - 1].Nodes[0].Nodes.Add("Ingrediente:" + reader3.GetValue(0));
                       

                    }
                    */

                }
            }

        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MeniuClient = new MeniuClient_Restaurant(ContClient);
            MeniuClient.ShowDialog();
            this.Close();
        }
    }
}
