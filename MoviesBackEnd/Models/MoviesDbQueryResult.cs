using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesBackEnd.Models
{
    public class MoviesDbQueryResult<T>
    {
        public int Page { get; set; }
        public int  Total_Results { get; set; }
        public int Total_Pages { get; set; }
        public List<T> Results { get; set; }
        
    }
}
