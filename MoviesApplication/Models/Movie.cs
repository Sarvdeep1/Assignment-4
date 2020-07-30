using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApplication.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string MovieName { get; set; }
        public string MovieType { get; set; }
        public string MovieLength { get; set; }
    }
}
