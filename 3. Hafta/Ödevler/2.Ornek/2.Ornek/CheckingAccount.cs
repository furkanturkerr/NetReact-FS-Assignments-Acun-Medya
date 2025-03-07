using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Ornek
{
    class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountholder, double balance) : base(accountholder, balance)
        {
        }

        public override double CalculateInterest()
        {
            Console.WriteLine("Checking accounts do not earn interest.\" ");
            return 0;
        }

        public void checkinginfo()
        {
            Console.WriteLine($"Hesabın Sahibi: {AccountHolder}, Bakiye: {Balance}, Faiz: {CalculateInterest()}");
        }
    }
}
