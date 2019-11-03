using MoviesBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesBackEnd.Interfaces
{
    public interface IHttpService
    {
         Task<MoviesDbQueryResult<T>> Get<T>(string url);

        Task<T> GetItem<T>(string url);

    }
}
