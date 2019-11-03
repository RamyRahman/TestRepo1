using MoviesBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesBackEnd.Interfaces
{
    public interface IMoviesService
    {
        Task<List<Item>> GetTopRatedMovies(int take);

        Task<List<Item>> GetTopRatedTvShows(int take);

        Task<Dictionary<string, object>> GetMovieById(int id);

        Task<Dictionary<string, object>> GetTvShowById(int id);

    }
}
