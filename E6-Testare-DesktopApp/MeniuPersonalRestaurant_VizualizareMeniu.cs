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
    public partial class MeniuPersonalRestaurant_VizualizareMeniu : Form
    {
        object ContPersonal;
        ConectareBD conectare = new ConectareBD();
        OleDbConnection conn;

        public MeniuPersonalRestaurant_VizualizareMeniu(object idCont)
        {
            InitializeComponent();
            ContPersonal = idCont;
        }

        private void MeniuPersonalRestaurant_VizualizareMeniu_Load(object sender, EventArgs e)
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
                    treeView1.Nodes[i - 1].Nodes.Add("'" + reader.GetValue(2).ToString() + "' - '" + reader.GetValue(3).ToString() + "' lei");
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
            var MeniuPersonal = new MeniuPersonalRestaurant_Meniuri(ContPersonal);
            MeniuPersonal.ShowDialog();
            this.Close();
        }

    }
}
