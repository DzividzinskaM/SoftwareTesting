using lab5.Helper;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    public class SearchTests
    {
        SearchHelper helper = new SearchHelper();

        [Test]

        public void SearchMovies()
        {
            string query = "Sherlock Holmes";
            int page = 1;

            helper.SearchMoviesWithSuccesfullResult(query, page);
        }
    }
}
