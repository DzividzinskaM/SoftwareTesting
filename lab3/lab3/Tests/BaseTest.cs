using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace lab3.Tests
{
    class BaseTest : BaseObject
    {
        //public IWebDriver driver;

        private string baseUrl = "https://www.zara.com/ua/";

        [OneTimeSetUp]
        public void beforeClass()
        {
            Driver = new ChromeDriver("D:/Fork/qa-course/lab3/resources/chromedriver.exe");

            /*var options = new ChromeOptions();
            options.BinaryLocation = "C:/jenkins";
            Driver = new ChromeDriver(options);*/


            /*C:\jenkins*/

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
