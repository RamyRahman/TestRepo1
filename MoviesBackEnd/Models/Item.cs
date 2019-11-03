using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesBackEnd.Models
{
    public class Item
    {
        public double Popularity { get; set; }
        public int VoteCount { get; set; }
        public string PosterPath { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string OriginalLanguage { get; set; }
        public double VoteAverage { get; set; }
        public string Overview { get; set; }
        public string Date { get; set; }
        public int Type { get; set; }
        public List<int> GenreIds { get; set; }


    }
}
