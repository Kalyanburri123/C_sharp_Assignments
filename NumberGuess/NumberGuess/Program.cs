namespace NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            Random random = new Random();
            Console.WriteLine("Welocme to Number Guessing game,Let's test your IQ");
            while (playAgain)
            {
                int targetNumber = random.Next(1, 101);
                int attempts = 0;
                int guessedNumber = 0;
                while (guessedNumber != targetNumber)
                {
                    Console.WriteLine("Enter your Guess");
                    string input = Console.ReadLine();
                    if(!int.TryParse(input, out guessedNumber))
                    { 
                        Console.WriteLine("Invalid input,Please Enter a number");
                        continue;
                    }
                    attempts++;

                    if (guessedNumber < targetNumber)
                    {
                        Console.WriteLine("Sorry, Too Low!");
                    }
                    else if (guessedNumber > targetNumber)
                    {
                        Console.WriteLine("Sorry, Too High!");
                    }
                    else
                    {
                        Console.WriteLine($"Correct! You guessed in {attempts} tries.");
                    }
                }
                Console.Write("Do you want to play again? (yes/no): ");
                string choice = Console.ReadLine().ToLower();

                if (choice != "yes")
                {
                    playAgain = false;
                }

                Console.WriteLine();
            }
            Console.WriteLine("Thanks for playing!");
        }
    }
}