using System;

namespace Serialization
{
    class Program
    {
        static void Main()
        {
            Account acc = SaveToFile.Load();

            if (acc == null)
            {
                Console.WriteLine("Enter Account Details:");

                acc = new Account();
                int accNo;
                Console.Write("Acc No: ");
                while (!int.TryParse(Console.ReadLine(), out accNo))
                {
                    Console.Write("Invalid input! Enter valid Account No: ");
                }
                acc.SetAccountNo(accNo);
                Console.Write("Name: ");
                acc.SetAccountHolderName(Console.ReadLine());
                Console.Write("Bank Name: ");
                acc.SetBankName(Console.ReadLine());
                double bal;
                Console.Write("Opening Balance: ");
                while (!double.TryParse(Console.ReadLine(), out bal) || bal < 500)
                {
                    Console.Write("Invalid! Minimum ₹500 required. Enter again: ");
                }
                acc.SetBalance(bal);

                SaveToFile.Save(acc);
                Console.WriteLine("Account created successfully");
            }
            else
            {
                Console.WriteLine("Welcome Back!");
            }

            while (true)
            {
                Console.WriteLine("\n1. Deposit\n2. Withdraw\n3. Display Balance\n4. Exit");
                Console.Write("Enter choice: ");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Write("Invalid choice! Enter again: ");
                }

                switch (choice)
                {
                    case 1:
                        double dep;
                        Console.Write("Enter amount: ");
                        while (!double.TryParse(Console.ReadLine(), out dep) || dep <= 0)
                        {
                            Console.Write("Invalid amount! Enter again: ");
                        }
                        acc.Deposit(dep);
                        break;

                    case 2:
                        double wd;
                        Console.Write("Enter amount: ");
                        while (!double.TryParse(Console.ReadLine(), out wd) || wd <= 0)
                        {
                            Console.Write("Invalid amount! Enter again: ");
                        }
                        acc.Withdraw(wd);
                        break;

                    case 3:
                        Console.WriteLine("Balance: " + acc.CheckBalance());
                        break;

                    case 4:
                        SaveToFile.Save(acc);
                        Console.WriteLine("Data saved. Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                // ✅ Save after every operation
                SaveToFile.Save(acc);
            }
        }
    }
}