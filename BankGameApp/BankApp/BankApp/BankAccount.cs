
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace BankApp

{
    class BankAccount
    {
        string AccountHolder;
        double Balance;
        public BankAccount(string AccountHolder, double Balance)
        {
            this.AccountHolder = AccountHolder;
            this.Balance = Balance;
        }
        public void Withdraw(double Amount)
        {
            if (Amount > Balance)
            {
                Console.WriteLine("Insufficient Balance.");
            }
            Balance = Balance - Amount;
        }

        public void Deposit(double Amount)
        {
            Balance = Balance + Amount;
        }

        public double GetBalance()
        {
            return Balance;
        }
    }
}