using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3_IM
{
    // Denna klass representerar användarens inloggningsuppgifter.
    // Uppgifterna valideras och returnerar antingen rätt eller fel.
    public class UserDetails
    {
        public static bool UserDetail(string username, string password)
        {
            if (username == "username1")
            {
                return true;
            }
            else
            {
                return false;
            }

            if (password == "password1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
