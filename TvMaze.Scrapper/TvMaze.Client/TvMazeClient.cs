using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TvMaze.Client.Contracts;
using TvMaze.Client.Contracts.Models;

namespace TvMaze.Client
{
    public class TvMazeClient : ITvMazeClient
    {
        private readonly string getUrl = "http://api.tvmaze.com/shows?embed=cast";
        private HttpClient client = new HttpClient();
        public async Task<IEnumerable<TvMazeShow>> GetAll()
        {
            HttpResponseMessage response = await client.GetAsync(getUrl);
            if (!response.IsSuccessStatusCode) return null;

            var source = await response.Content.ReadAsStringAsync();
            var res = JsonConvert.DeserializeObject<IEnumerable<TvMazeShow>>(source);
            return res;
        }
    }
}