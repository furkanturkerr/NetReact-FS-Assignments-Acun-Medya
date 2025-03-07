using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2.Ornek
{
    class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountholder, double balance) : base(accountholder, balance)
        {
        }

        public override double CalculateInterest()
        {
            return Balance * 0.05;
        }

        public void savingsinfo()
        {
            Console.WriteLine($"Hesabın Sahibi: {AccountHolder}, Bakiye: {Balance}, Faiz: {CalculateInterest()}");
        }
    }
}
