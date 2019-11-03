using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviesBackEnd.Models;

namespace MoviesBackEnd.Main
{
    public static class Mapper
    {
        public static ItemsResponse MapMovies(MoviesDbQueryResult<Movie> queryResult)
        {
            var response = new ItemsResponse();
            response.Page = queryResult.Page;
            response.Total_Pages= queryResult.Total_Pages;
            response.Total_Results= queryResult.Total_Results;
            response.Results = new List<Item>();

            foreach (var result in queryResult.Results)
            {
                var item = new Item();
                item.Id = result.Id;
                item.OriginalLanguage = result.Original_Language;
                item.Popularity = result.Popularity;
                item.VoteCount = result.Vote_Count;
                item.PosterPath = result.Poster_Path;
                item.VoteAverage = result.Vote_Average;
                item.Overview = result.Overview;
                item.GenreIds = result.Genre_Ids;


                item.Title = result.Title;
                item.Date = result.Release_Date;
                item.Type =1;

                response.Results.Add(item);
            }
            return response;
        }

        public static ItemsResponse MapTvShows(MoviesDbQueryResult<TvShow> queryResult)
        {
            var response = new ItemsResponse();
            response.Page = queryResult.Page;
            response.Total_Pages = queryResult.Total_Pages;
            response.Total_Results = queryResult.Total_Results;
            response.Results = new List<Item>();

            foreach (var result in queryResult.Results)
            {
                var item = new Item();
                item.Id = result.Id;
                item.OriginalLanguage = result.Original_Language;
                item.Popularity = result.Popularity;
                item.VoteCount = result.Vote_Count;
                item.PosterPath = result.Poster_Path;
                item.VoteAverage = result.Vote_Average;
                item.Overview = result.Overview;
                item.GenreIds = result.Genre_Ids;

                item.Title = result.Original_Name;
                item.Date = result.First_Air_Date;
                item.Type = 2;

                response.Results.Add(item);
            }
            return response;
        }

    }
}
