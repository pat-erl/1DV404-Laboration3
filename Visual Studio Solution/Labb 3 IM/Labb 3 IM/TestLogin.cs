using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3_IM
{
    class TestLogin
    {
        // TESTSVIT 1

        // ENHETSTEST 1 - Testar metoder i klassen Login.

        // Testfall 1 - Testar metoden SuccessfulLogin.
        public static void TestSuccessfulLogin()
        {
            //Testfixtur är klassen Login
            Boolean login = Login.SuccessfulLogin(); 

            if (login == true)
            {
                Console.WriteLine("Testet lyckades");
            }
            else
            {
                Console.WriteLine("Testet misslyckades");
            }
        }

        // Testfall 2 - Testar metoden UnsuccessfulLogin.
        public static void TestUnsuccessfulLogin()
        {
            //Testfixtur är klassen Login 
            Boolean login = Login.UnsuccessfulLogin();

            if (login == false)
            {
                Console.WriteLine("Testet lyckades");
            }
            else
            {
                Console.WriteLine("Testet misslyckades");
            }
        }
    }
}
