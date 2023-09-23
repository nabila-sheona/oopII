using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_210042111
{
    internal class Samsung : Iprinter, Icolorprint, IDuplexPrinter
    {

        public void Print(string content)
        {
            Console.WriteLine("samsung Printer: Printing in black and white");
            Console.WriteLine(content);
        }

        public void Printcolor(string content)
        {
            Console.WriteLine("samsung Printer: Printing in color");
            Console.WriteLine(content);
        }
        public void PrintDuplex(string content)
        {
            Console.WriteLine("samsung Printer: Printing in colorful (duplex mode)");
            Console.WriteLine(content);
        }
    }
}
