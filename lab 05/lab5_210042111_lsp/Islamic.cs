using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_210042111_lsp
{
    public class Islamic: Account
    {

        public Islamic(int acc_no, double balance, string name, string signature)
        {

            this.Acc_no = acc_no;
            this.balance = balance;
            this.Name = name;
            this.Signature = signature;



        }


        public override double Withdraw(double amount)
        {

            if (amount < 0)
            {
                throw new ArgumentException("invalid amount");
            }


            else if (amount > 10000)
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
            if (balance < 200)
            {
                throw new ArgumentException("insufficient amount");
            }
            else
            {
                return balance;

            }
        }



        public override double calculateinterest(double balance)
        {
            throw new ArgumentException("islamic account do not have interest");
        }

    }
}
