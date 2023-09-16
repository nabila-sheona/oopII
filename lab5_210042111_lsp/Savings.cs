using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_210042111_lsp
{
    public class Savings: Account
    {

        public Savings(int acc_no, double balance, string name, string signature)
            {

                this.Acc_no = acc_no;
                this.balance = balance;
                this.Name = name;
                this.Signature = signature;

            if (balance < 100)
            {
                throw new ArgumentException("insufficient amount");
            }

        }

        public override double Withdraw(double amount)
        {

            if (amount < 0)
            {
                throw new ArgumentException("invalid amount");
            }


            else if (amount > 15000)
            {
                throw new ArgumentException("amount exceeds the limit");

            }


            else
            {
                if (amount > balance)
                {
                    throw new ArgumentException("insufficient amount");
                }

                else
                {
                    balance = balance - amount;
                    Console.WriteLine(amount + " withdrawed");
                }

            }

            return balance;

        }

        public override double calculateinterest(double balance)
        {
            interest = balance * .1;
            Console.WriteLine(balance * .1);
            return interest;
        }
    }
}
