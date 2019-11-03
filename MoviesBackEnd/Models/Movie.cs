using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesBackEnd.Models
{
    
    public class Movie :Show
    {
        

        public bool Video { get; set; }
        public bool Adult { get; set; }
        public string Original_Title { get; set; }
        public string Title { get; set; }
        public string Release_Date { get; set; }


    }
}
