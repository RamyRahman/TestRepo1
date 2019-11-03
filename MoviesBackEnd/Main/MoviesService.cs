using MoviesBackEnd.Interfaces;
using MoviesBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MoviesBackEnd.Main
{
    public class MoviesService : IMoviesService
    {
        private IHttpService _httpService;
        public MoviesService(IHttpService _httpService)
        {
            this._httpService = _httpService;
        }

        public async Task<List<Item>> GetTopRatedMovies()
        {
            var url = GlobalVariables.Url + "/movie/top_rated?api_key=" +
                GlobalVariables.API_KEY + "&language=" + GlobalVariables.Language; 

            var queryResult = await this._httpService.Get<Movie>(url);
            if (queryResult != null)
            {
                var originalListOfMovies= queryResult.Results.Take(6).ToList();
                var listOfMovies = Mapper.MapMovies(originalListOfMovies);
                return listOfMovies;
            }
            else
            {
                return new List<Item>(); //empty object
            }

        }

        public async Task<List<Item>> GetTopRatedTvShows()
        {
            var url = GlobalVariables.Url + "/tv/top_rated?api_key=" +
               GlobalVariables.API_KEY + "&language=" + GlobalVariables.Language ;

            var queryResult = await this._httpService.Get<TvShow>(url);
            if (queryResult != null)
            {
                var originalListOfTvShows= queryResult.Results.Take(6).ToList();
                var listOfTvShows = Mapper.MapTvShows(originalListOfTvShows);
                return listOfTvShows;
            }
            else
            {
                return new List<Item>(); //empty object
            }
        }

    }
}
