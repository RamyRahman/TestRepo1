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
        public async Task<List<Item>> GetMovies(int take)
        {
            return await _moviesService.GetTopRatedMovies(take);
        }

        [Route("GetTopRatedTvShows")]
        [HttpGet]
        public async Task<List<Item>> GetTvShows(int take)
        {
            return await _moviesService.GetTopRatedTvShows(take);
        }

        [Route("GetMovieById")]
        [HttpGet]
        public async Task<Dictionary<string, object>> GetMovieById(int id)
        {
            return await _moviesService.GetMovieById(id);
        }

        [Route("GetTvShowById")]
        [HttpGet]
        public async Task<Dictionary<string, object>> GetTvShowById(int id)
        {
            return await _moviesService.GetTvShowById(id);
        }

        [Route("GetSortedMoviesByCategory")]
        [HttpGet]
        public async Task<List<Item>> GetSortedMoviesByCategory(int categoryId, int take)
        {
            return await _moviesService.GetSortedMoviesByCategory(categoryId,take);
        }

        [Route("GetSortedTvShowsByCategory")]
        [HttpGet]
        public async Task<List<Item>> GetSortedTvShowsByCategory(int categoryId, int take)
        {
            return await _moviesService.GetSortedTvShowsByCategory(categoryId, take);
        }

        [Route("GetTvShowsCategories")]
        [HttpGet]
        public async Task<Dictionary<string, object>> GetTvShowsCategories()
        {
            return await _moviesService.GetTvShowsCategories();
        }

        [Route("GetMoviesCategories")]
        [HttpGet]
        public async Task<Dictionary<string, object>> GetMoviesCategories()
        {
            return await _moviesService.GetMoviesCategories();
        }

        [Route("GetMoviesByCategory")]
        [HttpGet]
        public async Task<MoviesDbPagingQueryResult> GetMoviesByCategory(int categoryId, int page)
        {
            return await _moviesService.GetMoviesByCategory(categoryId, page);
        }

        [Route("GetTvShowsByCategory")]
        [HttpGet]
        public async Task<MoviesDbPagingQueryResult> GetTvShowsByCategory(int categoryId, int page)
        {
            return await _moviesService.GetTvShowsByCategory(categoryId, page);
        }

    }
}
