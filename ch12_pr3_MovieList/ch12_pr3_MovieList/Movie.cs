using System;
using System.Collections.Generic;
using System.Text;

namespace ch12_pr3_MovieList
{
    class Movie
    {
        public String title { get; set; }
        public String category { get; set; }

        public Movie()
        {

        }

        public Movie(string title, string category)
        {
            this.title = title;
            this.category = category;
        }
    }
}
