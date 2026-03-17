
namespace PrimeChecker
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number == 1)
            {
                Console.WriteLine("The Number {0} is neither Prime nor  a Composite.", number);
                return;
            }

            bool isPrime = true;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                Console.WriteLine("The number {0} is Prime", number);
            else
                Console.WriteLine("The number {0} is Not a Prime", number);
        }
    }
}