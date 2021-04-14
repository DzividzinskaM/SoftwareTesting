using lab5.Models;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace lab5.Steps
{
    public class RateMovieSteps : BaseSteps
    {
        public IRestResponse response = new RestResponse<Response>();
        public Response responseData;

        public void GivenExecuteOperationPost(string url)
        {
            request = new RestRequest(url, Method.POST);
        }

        public void GivenExecuteOperationDelete(string url)
        {
            request = new RestRequest(url, Method.DELETE);
        }

        public void GivenExecuteOperationWithParams(double rate, int movieId)
        {
            request.AddUrlSegment("movie_id", movieId);
            request.AddJsonBody(new Rating { value = rate});

            response = client.Execute<Response>(request);
            responseData = client.Execute<Response>(request).Data;
        }

        public void GivenExecuteOperationWithParams(int movieId)
        {
            request.AddUrlSegment("movie_id", movieId);

            response = client.Execute<Response>(request);
            responseData = client.Execute<Response>(request).Data;
        }

        public void ThenCheckThatStatusCodeCreated()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created), "status is incorrect");
        }

        public void ThenCheckThatStatusCodeOK()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK), "status is incorrect");
        }

        public void ThenCheckThatStatusCodeUnautorised()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Unauthorized), "status is incorrect");
        }

        public void ThenCheckThatStatusCodeNotFound()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.NotFound), "status is incorrect");
        }

        public void ThenCheckThatStatusCodeBadRequest()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.BadRequest), "status is incorrect");
        }

        public void ThenCheckStatusCodeIsEqual1()
        {
            Assert.That(responseData.status_code, Is.EqualTo(1));
        }

        public void ThenCheckStatusCodeIsEqual13()
        {
            Assert.That(responseData.status_code, Is.EqualTo(13));
        }

    }
}
