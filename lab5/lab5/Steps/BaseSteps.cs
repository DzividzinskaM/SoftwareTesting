using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab5.Steps
{
    public class BaseSteps
    {
        public RestClient client = new RestClient("https://api.themoviedb.org/3/");
        public RestRequest request = new RestRequest();
    }

}
