using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_TAC_TOE_GAME
{
    public class Board
    {
        public char[,] board=new char[3,3];


        //Initializing the board with "_" Mark.
        public Board()
        {
            for(int i=0;i<3;i++)
            {
                for(int j = 0; j < 3;j++)
                {
                    board[i,j] = '_';
                }
            }
        }

        //Placing the mark at particular row and column.
        public bool PlaceMark(int row , int col ,char Mark)
        {
           if(row>=0 && row<3 && col>=0 && col<3 && board[row, col] == '_')
            {
                board[row, col] = Mark;
                return true;
            }
            return false;
        }

        //Checking if board is full 
        public bool IsFull()
        {
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    if (board[i,j]=='_')
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        //Printing the board.
        public void PrintBoard()
        {
            for(int i=0;i<3;i++)
            {
                Console.Write("[ ");
                for (int j=0;j<3;j++)
                {
                    Console.Write(board[i, j]+" ");
                }
                Console.Write(" ]\n");
            }
            Console.WriteLine();
        }
    }
}
