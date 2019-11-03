using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesBackEnd.Models
{
    public class Show
    {
        public double Popularity { get; set; }
        public int Vote_Count { get; set; }
        public string Poster_Path { get; set; }
        public int Id { get; set; }
        public string Original_Language { get; set; }
        public string Overview { get; set; }
        public string Backdrop_Path { get; set; }
        public Double Vote_Average { get; set; }
        public List<int> Genre_Ids { get; set; }

    }
}
