using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_210042111
{
    public class Epson: Iprinter, IDuplexPrinter
    {

        public void Print(string content)
        {
            Console.WriteLine("Epson Printer: Printing in black and white");
            Console.WriteLine(content);
        }

        public void PrintDuplex(string content)
        {
            Console.WriteLine("Epson Printer: Printing in black and white (duplex mode)");
            Console.WriteLine(content);
        }
    }
}
