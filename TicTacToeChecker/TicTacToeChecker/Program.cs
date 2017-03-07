using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates a 3x3 multidimensional array representing a Tic-Tac-Toe game, change this to check different games
            String[,] ticTacToe = new String[3, 3] { { "O", "X", "X" }, { "X", "O", "O" }, { "O", "O", "X" } };

            //prints the game to the console
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", ticTacToe[i, j]);
                }
                Console.Write("\n");
            }

            bool win = false;

            //checks rows for a win
            for (int i = 0; i < 3; i++)
            {
                if (ticTacToe[i, 0] == ticTacToe[i, 1] && ticTacToe[i, 0] == ticTacToe[i, 2])
                {
                    win = true;
                }
            }

            //checks columns for a win
            for (int j = 0; j < 3; j++)
            {
                if (ticTacToe[0, j] == ticTacToe[1, j] && ticTacToe[0, j] == ticTacToe[2, j])
                {
                    win = true;
                }
            }

            //checks diagonals for a win
            if (ticTacToe[0, 0] == ticTacToe[1, 1] && ticTacToe[0, 0] == ticTacToe[2, 2])
            {
                win = true;
            }
            else if (ticTacToe[0, 2] == ticTacToe[1, 1] && ticTacToe[0, 2] == ticTacToe[2, 0])
            {
                win = true;
            }

            //prints win or tie to the console
            if (win == true)
            {
                Console.WriteLine("TicTacToe!");
            }
            else
            {
                Console.WriteLine("Tie game.");
            }
        }
    }
}
