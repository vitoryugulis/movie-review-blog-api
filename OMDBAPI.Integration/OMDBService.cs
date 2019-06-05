using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OMDBAPI.Integration.Interfaces;
using OMDBAPI.Integration.Models;

namespace OMDBAPI.Integration
{
    public class OMDBService : IOMDBService
    {
        private readonly HttpClient client = new HttpClient();

        public async Task<JsonMovie> GetMovieByTitle(string movieTitle)
        {
            try
            {
                DotNetEnv.Env.Load("../.env", false);
                var omdbApi = DotNetEnv.Env.GetString("omdb_api");
                var omdbKey = DotNetEnv.Env.GetString("omdb_api_key");
                var response = await client.GetStringAsync($"{omdbApi}/?apikey={omdbKey}&t={movieTitle}");
                var jsonMovie = JsonConvert.DeserializeObject<JsonMovie>(response);
                return jsonMovie;
            }
            catch (System.Exception)
            {
                Console.WriteLine("Could not get OMDB movie");
                return null;
            }
        }
    }
}