using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_B_alter
{
    public class releasetime
    {
       private Icalculation bill;
        public double calculate(Movie movie)
        {
            double baseprice = 5.0;
            
            if (movie.genre == genre.horror)
            {
                bill = new horror();

            }
            else if (movie.genre == genre.romance)
            {
                bill = new romance();
            }
            else if (movie.genre == genre.thriller)
            {
                if (DateTime.Now.Year - movie.release.Year > 5)
                {
                    bill = new oldmovies();
                }
                else{
                    bill = new thriller();
                }
            }
            
            return bill.calcbill(baseprice);
        }
    }
}