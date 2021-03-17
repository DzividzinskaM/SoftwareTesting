using lab3.TestHelpers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Tests
{
    [TestFixture]
    class SearchTests : BaseTest
    {
        private static SearchHelper searchHelper = new SearchHelper();
        [Test]
        public void ShowTips()
        {
            string searchRequest = "с";

            searchHelper.Search(searchRequest)
                .AssertTipsIsPresent();
        }

        [Test]
        public void SearchIsCorrect()
        {
            string searchRequest = "сумки";

            searchHelper.Search(searchRequest)
                .AssertProductListIsShown();
        }

        [Test]
        public void SearchIsNotSuccessfullTest()
        {
            string searchRequest = "аааа";

            searchHelper.Search(searchRequest)
                .AssertMeesage();
        }
    }
}
