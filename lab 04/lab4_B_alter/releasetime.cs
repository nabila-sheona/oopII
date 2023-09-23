using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_B_alter
{
    public class releasetime
    {
       
        public Icalculation bill=null;
        private genre genre;
   
        public releasetime(string title, genre genre, DateTime release, int duration)
        {
           this.genre=genre;

            if (genre == genre.horror)
            {
                bill = new horror(title, genre, release, duration);

            }
            else if (genre == genre.romance)
            {
                bill = new romance(title, genre, release, duration);
            }
            else if (genre == genre.thriller)
            {
                bill = new thriller(title, genre, release, duration);
            }
          
       
        }
    }
    public class service
    {
       
        public Icalculation m { get; set; }
        public double price = 5.0;
        public double calcbill()
        {
            return m.calcbill();


        }
        public service(Icalculation m)
        {
            this.m = m;
        }


    }

}