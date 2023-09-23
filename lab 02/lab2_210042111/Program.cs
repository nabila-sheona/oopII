using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_210042111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type;
            string p;
            Console.WriteLine("CHOOSE PAGE SIZE:\n A3 \n A4 \n Letterman\n");
            type = Console.ReadLine();
            Console.WriteLine("CHOOSE Printer\n");
            p = Console.ReadLine();
            Printcontroller controller = new Printcontroller();
            if (p == "espon")
            {
                Iprinter epson = new Epson();
                
                controller.Printdoc(epson, "this is epson", type, false, false);
                controller.Printdoc(epson, "this is epson", type, true, true);

                Console.WriteLine("PRINTING WITH Epson PRINTER");
            }
            else if (p == "cannon")
            {


                Iprinter cannon = new Cannon();

              
                controller.Printdoc(cannon, "this is cannon" , type, true, true);
                controller.Printdoc(cannon, "this is cannon" , type, true, true);
                Console.WriteLine("\nPRINTING WITH canon PRINTER");
            }

            else if (p == "samsung")
            {

                Iprinter samsung = new Samsung();
           
            controller.Printdoc(samsung, "this is samsung", type, true, true);
            controller.Printdoc(samsung, "this is samsung", type, true, true);
                Console.WriteLine("\nPRINTING WITH samsung PRINTER");
            }
        }
    }
}
