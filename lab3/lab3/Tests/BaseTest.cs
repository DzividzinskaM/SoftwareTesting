
using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace lab3.Tests
{
    class BaseTest : BaseObject
    {
        private string baseUrl = "https://www.zara.com/ua/";

        [OneTimeSetUp]
        public void beforeClass()
        {
            Driver = new FirefoxDriver();
        }

        [SetUp]
        public void beforeTest()
        {
            Driver.Navigate().GoToUrl(baseUrl);
        }

        [OneTimeTearDown]
        public void afterClass()
        {
            Driver.Close();
        }

    }
}
