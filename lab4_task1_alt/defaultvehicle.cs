using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_task1_alt
{
    public class defaultvehicle: IFareCalc
    {
        public int calcfare(int distance, int time, int numberofpassengers)
        {
            if (distance < 10)
                return 300 / numberofpassengers;
            else
                return  distance * 30 / numberofpassengers;
       

        }
    }
}
