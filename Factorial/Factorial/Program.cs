// See https://aka.ms/new-console-template for more information
using System;

namespace Factorial
{
    class Class2
    {
        public static void Main(String[] args)
        {
            string input;

            Console.WriteLine("Enter a number (or 'q' to quit):");
            input = Console.ReadLine();

            while (input != "q")
            {
                int fact = 1;   // Reset factorial each time

                int num = int.Parse(input);

                for (int i = 1; i <= num; i++)
                {
                    fact = fact * i;
                }

                Console.WriteLine(fact);

                Console.WriteLine("Enter a number (or 'q' to quit):");
                input = Console.ReadLine();   // Update input inside loop
            }

            Console.WriteLine("Program exited.");
        }
    }
}