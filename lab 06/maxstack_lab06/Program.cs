using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxstack_lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxStack Stack = new MaxStack();

            Stack.push(21);
            Stack.push(33);
            Stack.push(2);
            Stack.push(1);
            int xs = Stack.Max();
            Console.WriteLine(xs);

            Stack.pop();
            int x=Stack.Max();
            Console.WriteLine(x);
            Stack.push(3);
            
            Console.ReadKey();
        }
    }
}
