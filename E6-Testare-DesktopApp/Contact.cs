using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E6_Testare_DesktopApp
{
    public partial class Contact : Form
    {
        object ContClient;
        public Contact(object idCont)
        {
            InitializeComponent();
            ContClient = idCont;
        }

        private void Contact_Load(object sender, EventArgs e)
        {
            ;
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MeniuClient = new MeniuClient(ContClient);
            MeniuClient.ShowDialog();
            this.Close();
        }
    }
}
