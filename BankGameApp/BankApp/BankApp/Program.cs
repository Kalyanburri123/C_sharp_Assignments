

using System;
namespace BankApp

{
    class Program
    {
        public static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("Kalyan", 1000);
            BankAccount account2 = new BankAccount("Vikram", 2000);
            WinFunctionality(account1, account2);
        }

        public static void WinFunctionality(BankAccount account1, BankAccount account2)
        {
            int i = 1;
            while (i < 4)
            {
                Console.WriteLine("Round:" + i);
                Console.Write("Account 1 Withdraw or Deposit (w or d):");
                char choice = Char.ToLower(Console.ReadLine()[0]);
                if (choice == 'w')
                {
                    Console.Write("Enter the amount to withdraw:");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    account1.Withdraw(amount);
                }
                else
                {
                    Console.Write("Enter the amount to Deposit:");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    account1.Deposit(amount);
                }
                Console.Write("Account 2 Withdraw or Deposit (w or d):");
                choice = Char.ToLower(Console.ReadLine()[0]);
                if (choice == 'w')
                {
                    Console.Write("Enter the amount to withdraw:");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    account2.Withdraw(amount);
                }
                else
                {
                    Console.Write("Enter the amount to Deposit:");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    account2.Deposit(amount);
                }
                i++;
            }
            if (account1.GetBalance() > account2.GetBalance())
            {
                Console.WriteLine("Account 1 wins with balance: " + account1.GetBalance());
            }
            else if (account2.GetBalance() > account1.GetBalance())
            {
                Console.WriteLine("Account 2 wins with balance: " + account2.GetBalance());
            }
            else
            {
                Console.WriteLine("It's a tie with balance: " + account1.GetBalance());
            }
        }
    }
}


