using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace lab6_210042111
{
    public class FizzBuzz
    {
        public static string getFizzyBuzz(int n)
        {
            if(n%5==0 && n % 9 == 0)
            {

                return "LA LA LAND";
            }
            else if (n % 5 == 0)
            {

                return "LA LA";
            }

            else if (n % 9 == 0)
            {
                return "LAND";
            }
            else
            {
                return "NOT FOUND";
            }

        }
    }
}
