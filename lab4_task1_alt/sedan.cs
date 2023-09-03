using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_task1_alt
{
    public class sedan: IFareCalc
    {
        public int calcfare(int distance, int time, int numberofpassengers)
        {
            return (50 + distance * 30 + time * 2) / numberofpassengers;
        }

    
    }
}

