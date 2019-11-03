using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoviesBackEnd.Interfaces;
using MoviesBackEnd.Models;

namespace MoviesBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        private IMoviesService _moviesService;

        public MoviesController(IMoviesService _moviesService)
        {
            this._moviesService = _moviesService;
        }

        [Route("GetTopRatedMovies")]
        [HttpGet]
        public async Task<ItemsResponse> GetMovies(int page)
        {
            return await _moviesService.GetTopRatedMovies(page);
        }

        [Route("GetTopRatedTvShows")]
        [HttpGet]
        public async Task<ItemsResponse> GetTvShows(int page)
        {
            return await _moviesService.GetTopRatedTvShows(page);
        }

    }
}
