using System;using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many bottles of oop?\n");
            int number;
            string n;

            n=Console.ReadLine();
            number = Convert.ToInt32(n);

            int total = number;
            if (number > 1)
            {
                Console.WriteLine("\n" + number + " bottles of oop\n");
            }
            else
            {
                Console.WriteLine(number + " bottle of oop");
            }

            while (number > -1)
            {
                string state = "bottle";
                int p = number - 1;
                if (number >= 3)
                {
                    Console.WriteLine("\n" + number + " " + state + "s " + " of milk on the wall, " + number + " " + state + "s of milk.\n" + "Take one down and pass it around, " + p + " bottles of milk on the wall.\n");
                }

                else if (number == 2)
                {
                    Console.WriteLine("\n" + number + " " + state + "s " + " of milk on the wall, " + number + " " + state + "s of milk.\n" + "Take one down and pass it around, " + p + " bottle of milk on the wall.\n");
                }

                else if (number == 1)
                {
                    Console.WriteLine("\n" + number + " " + state + "s " + " of milk on the wall, " + number + " " + state + "s of milk.\n" + "Take it down and pass it around, no more bottles of milk on the wall.\n");


                }

                else
                {
                    if (number == 0)
                        Console.WriteLine("No more bottles of milk on the wall, no more bottles of milk." + "\n" + "Go to the store and buy some more, " + total + " bottles of milk on the wall.");
                }


                number--;

              
                
            }
            Console.ReadKey();
        }
    }
}
