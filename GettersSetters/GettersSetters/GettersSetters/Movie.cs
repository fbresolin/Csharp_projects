using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersSetters
{
    internal class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie(string atitle, string adirector, string arating)
        {
            title = atitle;
            director = adirector;
            Rating = arating;
        }

        public string Rating
        {
            get { return rating; }
            set { 
                if (value == "PG" || value == "G" || value == "PG-13" || value == "R")
                { 
                    rating = value; 
                } 
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
