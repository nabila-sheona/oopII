using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_management
{
     abstract class vehicle
    {
        public string fuel { get; set; }
        public bool isdrivable { get; set; }

      
        public virtual void start()
        {
            Console.WriteLine("vehicle starting...");

        }

        public virtual void stop() { 
            
            Console.WriteLine("vehicle stopping...");
        }


    }
}
