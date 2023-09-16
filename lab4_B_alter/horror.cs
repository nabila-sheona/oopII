using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_B_alter
{
    public class horror: Movie, Icalculation
    {
        double price = 5.0;
        public double calcbill()
        {
            return price * .8;
        }

           public horror(string title, genre genre, DateTime release, int duration)
        {

            this.title = title;
            this.genre = genre;
            this.release = release;
            this.duration = duration;



        }
    }
}
