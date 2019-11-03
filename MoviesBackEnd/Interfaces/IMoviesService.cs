using MoviesBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesBackEnd.Interfaces
{
    public interface IMoviesService
    {
        Task<List<Item>> GetTopRatedMovies();

        Task<List<Item>> GetTopRatedTvShows();

    }
}
