using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3_IM
{
    class Program
    {
        static void Main(string[] args)
        {
            TestRunner();
        }
        public static void TestRunner()
        {
            //TestLogin.TestSuccessfulLogin();
            //TestLogin.TestUnsuccessfulLogin();
            //TestUserDetails.TestCorrectUserDetails();
            //TestUserDetails.TestIncorrectUserDetails();
            //TestUserDetails.TestCorrectUserIncorrectPass();
            //TestUserDetails.TestIncorrectUserCorrectPass();
            TestLoginAndUserDetails.TestFullLoginCorrect();
            TestLoginAndUserDetails.TestFullLoginIncorrect();
        }
}
    }
