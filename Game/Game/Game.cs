using System;

namespace PigDiceGame
{
    class Game
    {
        private int totalScore = 0;
        private int turn = 1;
        private Random rand = new Random();

        public void StartGame()
        {
            while (totalScore < 20)
            {
                Console.WriteLine($"\nTURN {turn}");
                PlayTurn();
                turn++;
            }

            Console.WriteLine($"\nYou finished in {turn - 1} turns!");
            Console.WriteLine("Game over!");
        }

        private void PlayTurn()
        {
            int turnScore = 0;
            bool turnOver = false;

            while (!turnOver)
            {
                char choice = GetUserChoice();

                if (choice == 'r')
                {
                    int die = rand.Next(1, 7);
                    Console.WriteLine("Die: " + die);

                    if (die == 1)
                    {
                        Console.WriteLine("Turn over. No score.");
                        turnScore = 0;
                        turnOver = true;
                    }
                    else
                    {
                        turnScore += die;
                    }
                }
                else if (choice == 'h')
                {
                    Console.WriteLine("Score for turn: " + turnScore);
                    totalScore += turnScore;
                    Console.WriteLine("Total score: " + totalScore);
                    turnOver = true;
                }
            }
        }

        private char GetUserChoice()
        {
            while (true)
            {
                Console.Write("Roll or hold? (r/h): ");
                string input = Console.ReadLine().ToLower();

                if (input == "r" || input == "h")
                {
                    return input[0];
                }
                else
                {
                    Console.WriteLine("Invalid input! Enter 'r' or 'h'");
                }
            }
        }
    }
}