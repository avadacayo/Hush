using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Hush.Tools
{
    class CheckString
    {
        //Password2 optional
        public Boolean ValidPasswordCheck(String Username, String Password, String Password2 = "")
        {
            Boolean valid = true;
            String pattern = @"^[a-zA-Z0-9_\-\@\#\$\%\^\!\&\*\(\)]{6,24}$";
            Regex regex = new Regex(pattern);
            if (!regex.IsMatch(Password) || Password.Contains(Username))
                valid = false;

            if (!Password2.Equals(""))
            {
                if (!regex.IsMatch(Password) || Password.Contains(Username) && Password.Equals(Password2))
                    valid = false;
            }

            //MessageBox.Show(valid.ToString());
            return valid;
        }

        //TODO: move this somewhere
        public Int32 PasswordStrength(String Password)
        {
            Int32 val = 0;
            Regex regex = new Regex("[A-Z]");

            if (regex.IsMatch(Password))
            {
                val++;
            }

            regex = new Regex("[0-9]");
            if (regex.IsMatch(Password))
            {
                val++;
            }

            regex = new Regex("[^A-Za-z0-9]");
            if (regex.IsMatch(Password))
            {
                val++;
            }

            if (Password.Length > 6)
            {
                val++;
            }

            regex = new Regex(@"(.)\1");
            if (regex.IsMatch(Password))
            {
                val--;
            }

            return val;
        }
    }
}
