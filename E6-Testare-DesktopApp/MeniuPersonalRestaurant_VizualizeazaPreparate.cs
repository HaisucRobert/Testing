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
    public partial class MeniuPersonalRestaurant_VizualizeazaPreparate : Form
    {
        object ContPersonal;
        ConectareBD conectare = new ConectareBD();
        OleDbConnection conn;
        public MeniuPersonalRestaurant_VizualizeazaPreparate()
        {
            InitializeComponent();
        }

        private void MeniuPersonalRestaurant_VizualizeazaPreparate_Load(object sender, EventArgs e)
        {
            conn = conectare.ConectareBazDate();
            conn.Open();

            int i = 0;
            int j = 0;
            OleDbCommand cmdSelect, cmdselect2;

            OleDbDataReader reader, reader2;

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



                }
            }
        }

        private void btnInapoi_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            var MeniuPersonal = new MeniuPersonalRestaurant_Preparate(ContPersonal);
            MeniuPersonal.ShowDialog();
            this.Close();
        }

    }
}
