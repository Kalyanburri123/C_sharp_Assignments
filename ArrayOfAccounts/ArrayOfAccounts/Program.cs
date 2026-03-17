using System;
using System.Security.Principal;

namespace ArrayOfAccounts
{
    class Program
    {
        static Account[] accounts;
        static int count = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of accounts:");
            int n = int.Parse(Console.ReadLine());

            accounts = new Account[n];

            while (true)
            {
                Console.WriteLine("\n1. Create Account");
                Console.WriteLine("2. View Balance");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Withdraw");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateAccount();
                        break;

                    case 2:
                        ViewBalance();
                        break;

                    case 3:
                        Deposit();
                        break;

                    case 4:
                        Withdraw();
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        // Create Account
        static void CreateAccount()
        {
            if (count == accounts.Length)
            {
                Console.WriteLine("Account limit reached!");
                return;
            }

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Initial Balance: ");
            double balance = double.Parse(Console.ReadLine());

            Console.Write("Enter Account Type (savings/current): ");
            string type = Console.ReadLine();

            string accNo = GenerateAccountNumber();

            accounts[count++] = new Account(name, balance, type, accNo);

            Console.WriteLine("Account Created Successfully!");
            Console.WriteLine("Account Number: " + accNo);
        }

        //Generate Unique Account Number
        static string GenerateAccountNumber()
        {
            Random rnd = new Random();
            string accNo;

            while (true)
            {
                accNo = "IDBI" + rnd.Next(100000000, 999999999);

                bool exists = false;

                for (int i = 0; i < count; i++)
                {
                    if (accounts[i].AccountNumber == accNo)
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                    return accNo;
            }
        }

        //Find Account
        static Account FindAccount(string accNo)
        {
            for (int i = 0; i < count; i++)
            {
                if (accounts[i].AccountNumber == accNo)
                    return accounts[i];
            }
            return null;
        }

        //View Balance
        static void ViewBalance()
        {
            Console.Write("Enter Account Number: ");
            string accNo = Console.ReadLine();

            Account acc = FindAccount(accNo);

            if (acc != null)
                Console.WriteLine("Balance: " + acc.Balance);
            else
                Console.WriteLine("Account not found");
        }

        //Deposit
        static void Deposit()
        {
            Console.Write("Enter Account Number: ");
            string accNo = Console.ReadLine();

            Account acc = FindAccount(accNo);

            if (acc != null)
            {
                Console.Write("Enter amount: ");
                double amt = double.Parse(Console.ReadLine());
                acc.Deposit(amt);
            }
            else
            {
                Console.WriteLine("Account not found");
            }
        }

        //Withdraw
        static void Withdraw()
        {
            Console.Write("Enter Account Number: ");
            string accNo = Console.ReadLine();

            Account acc = FindAccount(accNo);

            if (acc != null)
            {
                Console.Write("Enter amount: ");
                double amt = double.Parse(Console.ReadLine());
                acc.Withdraw(amt);
            }
            else
            {
                Console.WriteLine("Account not found");
            }
        }
    }
}