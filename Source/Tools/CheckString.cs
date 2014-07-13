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
            String pattern = @"^[a-zA-Z0-9_ \-\@\#\$\%\^\!\&\*\(\)]{6,24}$", 
                   pattern2 = @"(.)\1{3,}?";

            Regex regex = new Regex(pattern),
                  regex2 = new Regex(pattern2);

            if (!regex.IsMatch(Password) || Password.Contains(Username))
                valid = false;

            else if ((!Password2.Equals("") && !Password.Equals(Password2)))
                    valid = false;
            
            else if (regex2.IsMatch(Password) || regex2.IsMatch(Password2))
                valid = false;

            return valid;
        }

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

            return val;
        }
    }
}
