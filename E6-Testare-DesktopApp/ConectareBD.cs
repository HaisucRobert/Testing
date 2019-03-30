using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

using System.Windows.Forms;

namespace E6_Testare_DesktopApp
{
    class ConectareBD
    {
        private OleDbConnection conn;
        private OleDbCommand command;
        private OleDbDataReader reader;
        string ole = "";
        string connectionString = "";
        OleDbConnection conexiuneaMea;
        public OleDbConnection ConectareBazDate()
        {


            {
                //incerc o super conectare la baza de date
                //definesc un sir de conectare
                string sirDeConectare;
                sirDeConectare = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\TestareBD.accdb; Persist Security Info = False; ";
                //definesc o conexiune pe care o voi deschide ulterior
                
                conexiuneaMea = new OleDbConnection();
                conexiuneaMea.ConnectionString = sirDeConectare;
               
                return conexiuneaMea;
               // MessageBox.Show("M-am conectat si am o legatura stabila la BD");

            }
        }
      
        }
    }
