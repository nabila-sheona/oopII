using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_B_210042111
{
   
    public class Movie
    {
       
        public DateTime releasedate { get; set; }
        public string Title;
        public Genre Genre { get; set; }
        public int Duration { get; set; }

        public Movie(string title, Genre genre, int duration, DateTime releasedate)
        {
            this.Title = title;
            this.Genre = genre;
            this.Duration = duration;
            this.releasedate = releasedate;

        }


    }
}
