using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_TAC_TOE_GAME
{
    public class TicTacToeFacade
    {
        private Board _board;
        private GameRules _rules;
        private char _currentPlayer;
        private bool _isGameOver;
        public TicTacToeFacade()
        {
            _board = new Board();
            _rules = new GameRules();
            _currentPlayer = 'X';
            _isGameOver = false;
        }
        public void PlayTurn(int row, int col)
        {
            if (_isGameOver)
            {
                Console.WriteLine("The game is over! Please play again if you like.");
                return; 
            }

            bool moveSuccessful = _board.PlaceMark(row, col, _currentPlayer);

            if (moveSuccessful)
            {
                Console.WriteLine($"\nPlayer {_currentPlayer} played at [{row}, {col}]");
                _board.PrintBoard();
                if (_rules.CheckWin(_board.board, _currentPlayer))
                {
                    Console.WriteLine($"*** Player {_currentPlayer} WINS! ***");
                    _isGameOver = true;
                }
                else if (_board.IsFull())
                {
                    Console.WriteLine("*** It's a DRAW! ***");
                    _isGameOver = true;
                }
                else
                {
                    if (_currentPlayer == 'X')
                    {
                        _currentPlayer = 'O'; 
                    }
                    else
                    {
                        _currentPlayer = 'X'; 
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid move! That spot is already taken. Try a different spot.");
            }
        }
        public void ResetGame()
        {
            _board = new Board();
            _currentPlayer = 'X';
            _isGameOver = false;
        }
        public bool IsGameOver()
        {
            return _isGameOver;
        }
    }
}
