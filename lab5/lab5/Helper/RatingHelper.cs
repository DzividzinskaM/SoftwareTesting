using lab5.Steps;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab5.Helper
{
    public class RatingHelper
    {
        private RateMovieSteps steps = new RateMovieSteps();

        public void PostRatingSuccess(int movieId, double rate)
        {
            steps.GivenExecuteOperationPost(Config.RateMovie());
            steps.GivenExecuteOperationWithParams(rate, movieId);
            steps.ThenCheckThatStatusCodeCreated();
            steps.ThenCheckStatusCodeIsEqual1();
        }

        public void PostRatingFaileWithIncorrectData(int movieId, double rate)
        {
            steps.GivenExecuteOperationPost(Config.RateMovie());
            steps.GivenExecuteOperationWithParams(rate, movieId);
            steps.ThenCheckThatStatusCodeBadRequest();
        }

        public void DeleteRatingSuccess(int movieId)
        {
            steps.GivenExecuteOperationDelete(Config.RateMovie());
            steps.GivenExecuteOperationWithParams(movieId);
            steps.ThenCheckThatStatusCodeOK();
            steps.ThenCheckStatusCodeIsEqual13();

        }
    }
}
