using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_B_alter
{
    public class oldmovies: Icalculation
    {
        public double calcbill(double price)
        {
            return price * .65;
        }
    }
}
