using System;
using System.Collections.Generic;
namespace EmployeePolymorphism
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            int count = ReadId("Enter number of employees:");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("------------------Choose Employee Type------------------");
                Console.WriteLine("1. Manager");
                Console.WriteLine("2. Developer");
                Console.WriteLine("3. Tester");

                int choice = ReadId("Enter choice:");

                int id = ReadId("Enter Id:");
                string name = ReadName("Enter Name:");
                double salary = ReadSalary("Enter Basic Salary:");

                switch (choice)
                {
                    case 1:
                        employees.Add(new Manager(id, name, salary));
                        break;
                    case 2:
                        employees.Add(new Developer(id, name, salary));
                        break;
                    case 3:
                        employees.Add(new Tester(id, name, salary));
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        i--;
                        break;
                }
            }

            Console.WriteLine("\nEmployee Details:\n");

            foreach (Employee emp in employees)
            {
                emp.Display();

                double monthly = emp.CalculateSalary();
                double annual = monthly * 12;

                Console.WriteLine("Monthly Salary: " + monthly);
                Console.WriteLine("Annual CTC: " + annual);
                Console.WriteLine("------------------------");
            }
        }

        //Validation the Id input.
        public static int ReadId(string message)
        {
            int value;
            Console.WriteLine(message);

            while (!int.TryParse(Console.ReadLine(), out value) || value <= 0)
            {
                Console.WriteLine("Invalid input. Enter positive number:");
            }

            return value;
        }


        //Validating the Salary input.
        public static double ReadSalary(string message)
        {
            double value;
            Console.WriteLine(message);

            while (!double.TryParse(Console.ReadLine(), out value) || value <= 0)
            {
                Console.WriteLine("Invalid salary. Enter positive amount:");
            }

            return value;
        }


        //Validating the Name input.

        public static string ReadName(string message)
        {
            string input;
            Console.WriteLine(message);

            while (string.IsNullOrWhiteSpace(input = Console.ReadLine()))
            {
                Console.WriteLine("Name cannot be empty:");
            }

            return input;
        }
    }
}