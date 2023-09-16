using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_210042111_lsp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Savings(122345, 23000, "nabila", "nb");
            Account account2 = new Islamic(122345, 23000, "nabila", "nb");

            Class1 class1 = new Class1();

            class1.receiveaccount(account);

            try
            {
                class1.receiveaccount(account2);
            }
            catch (Exception  ex) {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            
            
            Console.ReadKey();

            
        }
    }
}
