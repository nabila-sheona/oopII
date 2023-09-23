using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_210042111_lsp
{
    public abstract class Account
    {
        public string Name { get; set; }    

        public string Signature { get; set; }

        public int Acc_no { get; set; }

        public double balance { get; set; }

        public double interest;

        public virtual double Withdraw(double amount)
        {


            return balance;
        }

        public virtual void Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("invalid amount");
            }

            balance = balance+ amount;
        }

        public virtual double GetBalance()
        {
            return balance;
        }


        public virtual double calculateinterest(double balance)
        {
           
            return interest;
        }




    }
}
