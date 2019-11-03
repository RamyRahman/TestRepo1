using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviesBackEnd.Models;

namespace MoviesBackEnd.Main
{
    public static class Mapper
    {
        public static List<Item> MapMovies(List<Movie> movies)
        {
            var mappedMovies = new List<Item>();

            foreach (var movie in movies)
            {
                var item = new Item();
                item.Id = movie.Id;
                item.OriginalLanguage = movie.Original_Language;
                item.Popularity = movie.Popularity;
                item.VoteCount = movie.Vote_Count;
                item.PosterPath = movie.Poster_Path;
                item.VoteAverage = movie.Vote_Average;
                item.Overview = movie.Overview;
                item.GenreIds = movie.Genre_Ids;


                item.Title = movie.Title;
                item.Date = movie.Release_Date;
                item.Type = 1;

                mappedMovies.Add(item);
            }
            return mappedMovies;
        }


        public static List<Item> MapTvShows(List<TvShow> movies)
        {
            var mappedMovies = new List<Item>();

            foreach (var movie in movies)
            {
                var item = new Item();
                item.Id = movie.Id;
                item.OriginalLanguage = movie.Original_Language;
                item.Popularity = movie.Popularity;
                item.VoteCount = movie.Vote_Count;
                item.PosterPath = movie.Poster_Path;
                item.VoteAverage = movie.Vote_Average;
                item.Overview = movie.Overview;
                item.GenreIds = movie.Genre_Ids;


                item.Title = movie.Original_Name;
                item.Date = movie.First_Air_Date;
                item.Type = 2;

                mappedMovies.Add(item);
            }
            return mappedMovies;
        }

    }
}
