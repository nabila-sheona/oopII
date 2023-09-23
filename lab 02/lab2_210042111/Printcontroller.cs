using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab2_210042111
{
    public class Printcontroller
    {
         string content;
        
        public void Printdoc(Iprinter printer, string content, string type, bool iscolor, bool isduplex)
        {
           

            string color = iscolor ? "Yes" : "No";
            string page = isduplex ? "Yes" : "No";
            Console.WriteLine($"Printig {color} {page} page {type} paper");
            if (iscolor)
            {
                if (printer is Icolorprint colorPrinter)
                {
                    colorPrinter.Printcolor(content);
                }
                else
                {
                    Console.WriteLine("Error: The selected printer does not support color printing.");
                }
            }
            else
            {
                printer.Print(content);
            }

            Console.WriteLine("Print completed.");
        }

    }
}


