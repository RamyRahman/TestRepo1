using MoviesBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesBackEnd.Interfaces
{
    public interface IMoviesService
    {
        Task<ItemsResponse> GetTopRatedMovies(int page);

        Task<ItemsResponse> GetTopRatedTvShows(int page);

    }
}
