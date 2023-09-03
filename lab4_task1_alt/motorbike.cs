using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_task1_alt
{
    public class motorbike: IFareCalc
    {

        public int calcfare(int distance, int time, int numberofpassengers)
        {
            return Math.Max(25, distance* 20) / numberofpassengers;
            
        }
    }
}
