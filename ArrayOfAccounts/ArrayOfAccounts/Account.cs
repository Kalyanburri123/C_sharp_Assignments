using System;

namespace ArrayOfAccounts
{
    class Account
    {
        private string accountNumber;
        private string name;
        private double balance;
        private string accountType;

        public string AccountNumber { get { return accountNumber; } }
        public string Name { get { return name; } set { name = value; } }
        public double Balance { get { return balance; } }
        public string AccountType { get { return accountType; } set { accountType = value; } }

        public Account(string name, double balance, string accountType, string accNo)
        {
            this.name = name;
            this.balance = balance;
            this.accountType = accountType;
            this.accountNumber = accNo;
        }

        //To deposit into the account
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("Amount Deposited Successfully");
        }

        //To withdraw from the account.
        public void Withdraw(double amount)
        {
            if (balance - amount >= 500)
            {
                balance -= amount;
                Console.WriteLine("Withdrawal Successful");
            }
            else
            {
                Console.WriteLine("Minimum balance of 500 must be maintained!");
            }
        }

        public void Display()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine("Account Type: " + accountType);
        }
    }
}