using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace E6_Testare_DesktopApp
{
    class Validare
    {
        public bool ValidareParola(string password, out string ErrorMessage)
        {
            var input = password;
            ErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                ErrorMessage = "0";
                return false;
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input) || !hasUpperChar.IsMatch(input) || !hasMiniMaxChars.IsMatch(input) || !hasNumber.IsMatch(input) || !hasSymbols.IsMatch(input))
            {
                if (!hasLowerChar.IsMatch(input))
                {
                    ErrorMessage = ErrorMessage + "3";

                }
                if (!hasUpperChar.IsMatch(input))
                {
                    ErrorMessage = ErrorMessage + "2";

                }
                if (!hasMiniMaxChars.IsMatch(input))
                {
                    ErrorMessage = ErrorMessage + "1";

                }
                if (!hasNumber.IsMatch(input))
                {
                    ErrorMessage = ErrorMessage + "4";

                }

                if (!hasSymbols.IsMatch(input))
                {
                    ErrorMessage = ErrorMessage + "5";

                }
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidareTelefon(string telefon, out string ErrorMessage)
        {
            var input = telefon;
            ErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                ErrorMessage = "Trebuie sa adaugi un numar de telefon";
                return false;
            }


            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (hasLowerChar.IsMatch(input) || hasUpperChar.IsMatch(input) || hasSymbols.IsMatch(input))
            {
                ErrorMessage = "Numarul de telefon este invalid";
                return false;
            }

            else
            {
                return true;
            }
        }

        public bool ValidareNume(string nume, out string ErrorMessage)
        {
            var input = nume;
            ErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                ErrorMessage = "Trebuie sa adaugi un nume";
                return false;
            }



            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (hasSymbols.IsMatch(input))
            {
                ErrorMessage = "Numele este invalid";
                return false;
            }

            else
            {
                return true;
            }
        }



        public bool ValidareUser(string user, out string ErrorMessage)
        {
            //TO DO: Verficarea existaentei aceluiasi user in momentul inregistrarii
            var input = user;
            ErrorMessage = string.Empty;
            OleDbCommand cmdSelect;
            OleDbDataReader reader;
            ConectareBD conectare = new ConectareBD();
            OleDbConnection conn = conectare.ConectareBazDate();

            if (string.IsNullOrWhiteSpace(input))
            {
                ErrorMessage = "Trebuie sa adaugi un nume de utilizator";
                return false;
            }
            else
            {
                conn.Open();
                cmdSelect = new OleDbCommand("SELECT User, Parola FROM Conturi where Conturi.User = '" + user + "'", conn);

                reader = cmdSelect.ExecuteReader();

                if (reader.HasRows)
                {

                    ErrorMessage = "User-ul este deja folosit";
                    return false;

                }
            }

            return true;
        }


    }
}
