using lab5.Models;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using TechTalk.SpecFlow;

namespace lab5.Steps
{

    public class GetSearchMoviesSteps : BaseSteps
    {
        public IRestResponse response = new RestResponse<List<Movie>>();
        public SearchResult<Movie> searchResult;
        
        public void GivenExecuteOperation(string url)
        {
            request = new RestRequest(url, Method.GET);
        }

        public void GivenExecuteOperationForQueryAndPages(string query, int page)
        {
            request.AddUrlSegment("query", query);
            request.AddUrlSegment("page", page.ToString());

            response = client.Execute<SearchResult<Movie>>(request);
            searchResult = client.Execute<SearchResult<Movie>>(request).Data;            
        }

        public void ThenCheckStatusCodeOk()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK), "status is incorrect");
        }

        public void ThenCheckStatusCodeUnauthorised()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Unauthorized), "status is incorrect");
        }

        public void ThenCheckStatusCodeBadRequest()
        {
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.BadRequest), "status is incorrect");
        }

        public void ThenCheckThatResultIsAtLeastOne()
        {
            Assert.That(searchResult.total_results, Is.AtLeast(1), "search list is empty");
        }
    }
}
