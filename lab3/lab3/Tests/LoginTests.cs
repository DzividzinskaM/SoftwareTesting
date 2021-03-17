using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Tests
{
    [TestFixture]
    class LoginTests : BaseTest
    {
        private static LoginHelper loginHelper = new LoginHelper();

        [Test]
        public static void CorrectLogin()
        {
            string email = "dzmarianadz@gmail.com";
            string password = "QA_lab3_test";

            string expectedUserName = "Mariana";

            loginHelper
                .Login(email, password)
                .AssertUserName(expectedUserName);
        }


        [Test]
        public static void InCorrectLogin()
        {
            string email = "dzmarianadz@gmail.com";
            string password = "12345678";

            //string expectedUserName = "Mariana";

            loginHelper
                .Login(email, password)
                .AssertIncorrectData();
        }
    }
}
