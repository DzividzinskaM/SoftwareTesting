using System;
using System.Collections.Generic;
using System.Text;

namespace lab5
{
    public static class Config
    {
        //private string apiKey = "923b6bad1181866112a736086aec0711";

        public static string GetSearchMovieUrl()
        {
            return @"search/movie?api_key=923b6bad1181866112a736086aec0711&language=en-US&page={page}&include_adult=false&query={query}";
        }

        public static string RateMovie()
        {
            return @"movie/{movie_id}/rating?api_key=923b6bad1181866112a736086aec0711&guest_session_id=fef3645b5f4d42ddd926ce3cd5fc2a99";
        }

        
    }
}
