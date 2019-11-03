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

        public async Task<ItemsResponse> GetTopRatedMovies(int page)
        {
            var url = GlobalVariables.Url + "/movie/top_rated?api_key=" +
                GlobalVariables.API_KEY + "&language=" + GlobalVariables.Language + "&page=" + page; 

            var queryResult = await this._httpService.Get<Movie>(url);
            if (queryResult != null)
            {
                ItemsResponse listOfMovies = Mapper.MapMovies(queryResult);
                return listOfMovies;
            }
            else
            {
                return new ItemsResponse(); //empty object
            }

        }

        public async Task<ItemsResponse> GetTopRatedTvShows(int page)
        {
            var url = GlobalVariables.Url + "/tv/top_rated?api_key=" +
               GlobalVariables.API_KEY + "&language=" + GlobalVariables.Language + "&page=" + page;

            var queryResult = await this._httpService.Get<TvShow>(url);
            if (queryResult != null)
            {
                ItemsResponse listOfMovies = Mapper.MapTvShows(queryResult);
                return listOfMovies;
            }
            else
            {
                return new ItemsResponse(); //empty object
            }
        }

    }
}
