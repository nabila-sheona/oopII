using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deligation1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Passenger
    { private int id;
        private string name;

 public Passenger(int id, string name)
        {
             this.id = id;
             this.name = name;
             }

 public int getId()
        {
             return id;
            }

 public string getName()
        {
             return name;
            }
 }
}
