using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_B_210042111
{
    public class Movierentalservice
    {
        public double calculate(Movie movie)
        {
            double baseprice = 5.0;
            if (movie.Genre == Genre.Horror)
            {
                return baseprice * .8;
            }
            else if (movie.Genre == Genre.Romantic)
            {
                return baseprice * .7;
            }
            else if (movie.Genre == Genre.Thriller)
            {
                return baseprice * .85;
            }
            else if (DateTime.Now.Year - movie.releasedate.Year > 5) { }
            {
                return baseprice * .65;
            }

        }


    }
}
