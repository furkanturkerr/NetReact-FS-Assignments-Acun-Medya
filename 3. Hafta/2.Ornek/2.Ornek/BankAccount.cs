using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Ornek
{
    class BankAccount
    {
        public string AccountHolder { get; set; }
        public double Balance { get; set; }

        public BankAccount(string accountholder, double balance)
        {
            AccountHolder = accountholder;
            Balance = balance;
        }

        public virtual double CalculateInterest()
        {
            return 0;
        }
    }
}


