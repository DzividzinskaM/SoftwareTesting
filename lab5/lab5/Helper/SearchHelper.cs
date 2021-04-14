using lab5.Steps;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab5.Helper
{
    public class SearchHelper
    {
        private GetSearchMoviesSteps steps = new GetSearchMoviesSteps();

        public void SearchMoviesWithSuccesfullResult(string query, int page)
        {
            steps.GivenExecuteOperation(Config.GetSearchMovieUrl());
            steps.GivenExecuteOperationForQueryAndPages(query, page);
            steps.ThenCheckStatusCodeOk();
            steps.ThenCheckThatResultIsAtLeastOne();

        }
    }
}
