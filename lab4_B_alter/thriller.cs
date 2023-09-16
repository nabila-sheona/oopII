using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_B_alter
{
    public class thriller : Movie, Icalculation
    {
        double price = 5.0;
        public double calcbill()
        {
            if (DateTime.Now.Year - release.Year > 5)
            {
                return price * .65;
            }
            else
            {
                return price * .85;
            }
            
        }

        public thriller(string title, genre genre, DateTime release, int duration)
        {

            this.title = title;
            this.genre = genre;
            this.release = release;
            this.duration = duration;



        }


    }
}
