using System;
using TIC_TAC_TOE_GAME; 

class Program
{
    static void Main(string[] args)
    {
        TicTacToeFacade game = new TicTacToeFacade();
        Console.WriteLine("--- Welcome to Tic Tac Toe ---");

        bool keepPlayingApp = true; 


        //Asking to play again if won or lost.
        while (keepPlayingApp)
        {
            Console.WriteLine("To play, enter a row (0, 1, or 2) and a column (0, 1, or 2).");
            int row = 0;
            int col = 0;
            while (game.IsGameOver() == false)
            {
                Console.Write("\nEnter row: ");
                while (!int.TryParse(Console.ReadLine(), out row))
                {
                    Console.WriteLine("Enter number only");
                    Console.Write("Enter row: ");
                }

                Console.Write("Enter column: ");
                while (!int.TryParse(Console.ReadLine(), out col))
                {
                    Console.WriteLine("Enter number only");
                    Console.Write("Enter column: ");
                }

                game.PlayTurn(row, col);
            }

            Console.WriteLine("\nDo you want to play again? (Y/N)");

            string answer = Console.ReadLine().ToUpper();

            if (answer == "Y")
            {
                game.ResetGame();
            }
            else
            {
                keepPlayingApp = false; 
                Console.WriteLine("Thanks for playing!");
            }
        }
    }
}