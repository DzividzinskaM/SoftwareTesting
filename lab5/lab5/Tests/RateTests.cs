using lab5.Helper;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    public class RateTests
    {
        private RatingHelper helper = new RatingHelper();

        [Test]
        public void RateMovieSuccess()
        {
            int movieId = 10527;
            double value = 9;

            helper.PostRatingSuccess(movieId, value);
        }

        [Test]
        public void DeleteRateMovie()
        {
            int movieId = 10528;

            helper.DeleteRatingSuccess(movieId);
        }

        [Test]
        public void RateMovieWithIncorrect()
        {
            int movieId = 10528;
            double value = -2;
            helper.PostRatingFaileWithIncorrectData(movieId, value);
        }

    }
}
