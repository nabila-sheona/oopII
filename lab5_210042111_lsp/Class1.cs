using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_210042111_lsp
{
    public class Class1
    {
      
        public double receiveaccount(Account ac)
        {
            double balance = ac.GetBalance();
            return ac.calculateinterest(balance);



        }
    }
}
