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



        public async Task<List<Item>> GetTopRatedMovies(int take)
        {
            var url = GlobalVariables.Url + "/movie/top_rated?api_key=" +
                GlobalVariables.API_KEY + "&language=" + GlobalVariables.Language;

            var queryResult = await this._httpService.Get<Movie>(url);
            if (queryResult != null)
            {
                var originalListOfMovies = queryResult.Results.Take(take).ToList();
                var listOfMovies = Mapper.MapMovies(originalListOfMovies);
                return listOfMovies;
            }
            else
            {
                return new List<Item>(); //empty object
            }

        }

        public async Task<List<Item>> GetTopRatedTvShows(int take)
        {
            var url = GlobalVariables.Url + "/tv/top_rated?api_key=" +
               GlobalVariables.API_KEY + "&language=" + GlobalVariables.Language;

            var queryResult = await this._httpService.Get<TvShow>(url);
            if (queryResult != null)
            {
                var originalListOfTvShows = queryResult.Results.Take(take).ToList();
                var listOfTvShows = Mapper.MapTvShows(originalListOfTvShows);
                return listOfTvShows;
            }
            else
            {
                return new List<Item>(); //empty object
            }
        }

        public async Task<Dictionary<string, object>> GetTvShowById(int id)
        {
            var url = GlobalVariables.Url + "/tv/" + id + "?api_key=" +
                          GlobalVariables.API_KEY + "&language=" + GlobalVariables.Language;
            var tvShow = await this._httpService.GetItem<Dictionary<string, object>>(url);

            return tvShow;
        }

        public async Task<Dictionary<string, object>> GetMovieById(int id)
        {
            var url = GlobalVariables.Url + "/movie/" + id + "?api_key=" +
                          GlobalVariables.API_KEY + "&language=" + GlobalVariables.Language;
            var movie = await this._httpService.GetItem<Dictionary<string, object>>(url);

            return movie;
        }

        public async Task<List<Item>> GetSortedMoviesByCategory(int categoryId, int take)
        {
            var url = GlobalVariables.Url + "/discover/tv?api_key=" +
               GlobalVariables.API_KEY + "&language=" + GlobalVariables.Language
               + "&sort_by=vote_average.desc&with_genres=" + categoryId;

            var queryResult = await this._httpService.Get<Movie>(url);
            if (queryResult != null)
            {
                var originalListOfMovies = queryResult.Results.Take(take).ToList();
                var listOfMovies = Mapper.MapMovies(originalListOfMovies);
                return listOfMovies;
            }
            else
            {
                return new List<Item>(); //empty object
            }
        }

        public async Task<List<Item>> GetSortedTvShowsByCategory(int categoryId, int take)
        {
            var url = GlobalVariables.Url + "/discover/movie?api_key=" +
               GlobalVariables.API_KEY + "&language=" + GlobalVariables.Language
               + "&sort_by=vote_average.desc&with_genres=" + categoryId;

            var queryResult = await this._httpService.Get<TvShow>(url);
            if (queryResult != null)
            {
                var originalListOfTvShows = queryResult.Results.Take(take).ToList();
                var listOfTvShows = Mapper.MapTvShows(originalListOfTvShows);
                return listOfTvShows;
            }
            else
            {
                return new List<Item>(); //empty object
            }
        }

        public async Task<Dictionary<string, object>> GetTvShowsCategories()
        {

            var url = GlobalVariables.Url + "/genre/tv/list?api_key=" +
                        GlobalVariables.API_KEY + "&language=" + GlobalVariables.Language;
            var tvShowsCategories = await this._httpService.GetItem<Dictionary<string, object>>(url);

            return tvShowsCategories;
        }

        public async Task<Dictionary<string, object>> GetMoviesCategories()
        {

            var url = GlobalVariables.Url + "/genre/movie/list?api_key=" +
                        GlobalVariables.API_KEY + "&language=" + GlobalVariables.Language;
            var movieCategories = await this._httpService.GetItem<Dictionary<string, object>>(url);

            return movieCategories;
        }

        public async Task<MoviesDbPagingQueryResult> GetMoviesByCategory(int categoryId, int page)
        {
            var url = GlobalVariables.Url + "/discover/movie?api_key=" +
              GlobalVariables.API_KEY + "&language=" + GlobalVariables.Language
              + "&page=" + page + "&with_genres=" + categoryId;

            var queryResult = await this._httpService.Get<Movie>(url);
            if (queryResult != null)
            {
                var items = new MoviesDbPagingQueryResult();
                items.Total_Pages = queryResult.Total_Pages;
                items.Total_Results = queryResult.Total_Results;
                items.Page = queryResult.Page;
                items.Results = new List<Item>();

                items.Results = Mapper.MapMovies(queryResult.Results);
                return items;
                //var originalListOfTvShows = queryResult.Results.Take(take).ToList();
                //var listOfTvShows = Mapper.MapTvShows(originalListOfTvShows);
                //return listOfTvShows;
            }
            else
            {
                return new MoviesDbPagingQueryResult(); //empty object
            }
        }

        public async Task<MoviesDbPagingQueryResult> GetTvShowsByCategory(int categoryId, int page)
        {
            var url = GlobalVariables.Url + "/discover/movie?api_key=" +
              GlobalVariables.API_KEY + "&language=" + GlobalVariables.Language
              + "&page=" + page + "&with_genres=" + categoryId;

            var queryResult = await this._httpService.Get<TvShow>(url);
            if (queryResult != null)
            {
                var items = new MoviesDbPagingQueryResult();
                items.Total_Pages = queryResult.Total_Pages;
                items.Total_Results = queryResult.Total_Results;
                items.Page = queryResult.Page;
                items.Results = new List<Item>();

                items.Results = Mapper.MapTvShows(queryResult.Results);
                return items;
                //var originalListOfTvShows = queryResult.Results.Take(take).ToList();
                //var listOfTvShows = Mapper.MapTvShows(originalListOfTvShows);
                //return listOfTvShows;
            }
            else
            {
                return new MoviesDbPagingQueryResult(); //empty object
            }
        }
        
    }
}
