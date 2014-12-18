using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3_IM
{
    class TestLoginAndUserDetails
    {
        
        public static void TestFullLoginCorrect()
        {
            string username = "username1";
            string password = "password1";
            Boolean userDetails = UserDetails.UserDetail(username, password);
            
            if(userDetails == true)
            {
                Boolean login = Login.SuccessfulLogin();

                if (login == true)
                {
                    Console.WriteLine("Inloggning lyckades");
                }
                else
                {
                    Console.WriteLine("Inloggning misslyckades");
                }
            }
            else
            {
                Boolean login = Login.UnsuccessfulLogin();

                if (login == false)
                {
                    Console.WriteLine("Inloggning misslyckades");
                }
                else
                {
                    Console.WriteLine("Inloggning lyckades");
                }
            }
        }
        public static void TestFullLoginIncorrect()
        {
            string username = "username2";
            string password = "password2";
            Boolean userDetails = UserDetails.UserDetail(username, password);

            if (userDetails == true)
            {
                Boolean login = Login.SuccessfulLogin();

                if (login == true)
                {
                    Console.WriteLine("Inloggning lyckades");
                }
                else
                {
                    Console.WriteLine("Inloggning misslyckades");
                }
            }
            else
            {
                Boolean login = Login.UnsuccessfulLogin();

                if (login == false)
                {
                    Console.WriteLine("Inloggning misslyckades");
                }
                else
                {
                    Console.WriteLine("Inloggning lyckades");
                }
            }
        }
    }
}
