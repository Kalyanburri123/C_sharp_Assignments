using System;
namespace Movie_Project;
class Program
{
    static void Main()
    {
        MovieStore store = new MovieStore();
        Console.WriteLine("Welcome to movie store developed by {Kalyan}:");
        while (true)
        {
            Console.WriteLine("\n1. Add\n2. Display\n3. Find\n4. Remove\n5. Clear\n6. Exit");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input");
                continue;
            }

            switch (choice)
            {
                case 1: store.AddMovie(); break;
                case 2: store.DisplayAll(); break;
                case 3: store.FindById(); break;
                case 4: store.RemoveById(); break;
                case 5: store.ClearAll(); break;
                case 6: return;
                default: Console.WriteLine("Invalid choice"); break;
            }
        }
    }
}