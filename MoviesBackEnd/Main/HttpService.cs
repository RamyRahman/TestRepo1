using MoviesBackEnd.Interfaces;
using MoviesBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MoviesBackEnd.Main
{
    public class HttpService : IHttpService
    {

        public async Task<MoviesDbQueryResult<T>> Get<T>(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                var httpRequest = new HttpRequestMessage(HttpMethod.Get, url);
                HttpResponseMessage response = await client.SendAsync(httpRequest);
                if (response.IsSuccessStatusCode)
                {
                    var moviesAsString = await response.Content.ReadAsStringAsync();
                    var result = Newtonsoft.Json.JsonConvert.DeserializeObject<MoviesDbQueryResult<T>>(moviesAsString);
                    return result;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
