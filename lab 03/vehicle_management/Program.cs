using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("task starting");

            vehicle car = new drivable();
            car.fuel = "Petrol";
            car.isdrivable = true;

            vehicle bicycle = new ridable();
            bicycle.fuel = "Nothing";
            bicycle.isdrivable = false;

            testvehicles(car);
            testvehicles(bicycle);
            Console.ReadKey();
        }

        public static void testvehicles(vehicle Vehicle) { 
        
                Console.WriteLine($"Vehicle with {Vehicle.fuel} as fuel");
                Vehicle.start();
                Vehicle.stop();

            if (Vehicle is Idrivable driveable)
            {
                driveable.accelerate();
            }
            Console.WriteLine("task done");
            }

        
    }
}
