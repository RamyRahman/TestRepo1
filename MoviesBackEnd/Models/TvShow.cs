using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesBackEnd.Models
{
    public class TvShow : Show
    {
        

        public string Original_Name { get; set; }
        public string Name { get; set; }
        public List<string> Origin_Country { get; set; }
        public string First_Air_Date { get; set; }

    }
}
