using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_TAC_TOE_GAME
{
    public class GameRules
    {

        //Checking the win.
        public bool CheckWin(char[,] board, char Mark)
        {
            for(int i=0;i<3;i++)
            {
                    if (board[0,i]==Mark && board[1,i]==Mark && board[2,i]==Mark)
                    {
                        return true;
                    }
                    else if (board[i, 0] == Mark && board[i, 1] == Mark && board[i, 2] == Mark)
                    {
                        return true;
                    }
                    else if (board[0, 0] == Mark && board[1, 1] == Mark && board[2,2]==Mark || board[0, 2] == Mark && board[1, 1] == Mark && board[2, 0] == Mark)
                    {
                        return true;
                    }
                }
            return false;
        }
    }
}
