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


        public static List<Item> MapTvShows(List<TvShow> tvShows)
        {
            var mappedMovies = new List<Item>();

            foreach (var show in tvShows)
            {
                var item = new Item();
                item.Id = show.Id;
                item.OriginalLanguage = show.Original_Language;
                item.Popularity = show.Popularity;
                item.VoteCount = show.Vote_Count;
                item.PosterPath = show.Poster_Path;
                item.VoteAverage = show.Vote_Average;
                item.Overview = show.Overview;
                item.GenreIds = show.Genre_Ids;


                item.Title = show.Original_Name;
                item.Date = show.First_Air_Date;
                item.Type = 2;

                mappedMovies.Add(item);
            }
            return mappedMovies;
        }

    }
}
