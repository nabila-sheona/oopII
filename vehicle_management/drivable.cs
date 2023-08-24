using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_management
{
    public enum fueltype
    {
        Petrol,
        Diesel,
        Gasoline

    }


    class drivable : vehicle, Idrivable
    {
       
        public void accelerate()
        {
            Console.WriteLine("accelerating...");

        }

    }
}

