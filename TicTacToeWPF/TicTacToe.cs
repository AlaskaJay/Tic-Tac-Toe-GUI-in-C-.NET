using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeWPF
{
    class TicTacToe
    {
        private char DEFAULT = '*';
        private char X = 'X';
        private char O = 'O';

        private char[,] board;
        private bool win;
        private int turn;

        public TicTacToe()
        {
            board = new char[3,3];
            for(int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = DEFAULT;
                }
            }
            win = false;
            turn = 0;
        }

        public String getSpace(int x, int y)
        {
            if (win)
            {
                if (turn % 2 == 0)
                    return "O wins!";
                return "X wins!";
            }
            if (board[x, y] == DEFAULT)
                return x + ", " + y;
            return "" + board[x, y];
        }

        public void takeTurn(int x, int y)
        {
            if (!over())
            {
                if (turn % 2 == 0)
                    takeTurn(x, y, X);
                else
                    takeTurn(x, y, O);

                checkWin();
            }
            else
                reset();

        }

        public void takeTurn(int x, int y, char player)
        {
            if(board[x, y] == DEFAULT)
            {
                board[x, y] = player;
                turn++;
            }
            
            
        }

        private bool over()
        {
            return win || turn >= 9;
        }

        private void reset()
        {
            board = new char[3, 3];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = DEFAULT;
                }
            }
            win = false;
            turn = 0;
        }

        private void checkWin()
        {
            if (board[1, 1] != DEFAULT)
            {
                if (board[0, 0] == board[1, 1] && board[2, 2] == board[1, 1])
                    win = true;
                if (board[2, 0] == board[1, 1] && board[0, 2] == board[1, 1])
                    win = true;
                if (board[1, 0] == board[1, 1] && board[1, 2] == board[1, 1])
                    win = true;
                if (board[0, 1] == board[1, 1] && board[2, 1] == board[1, 1])
                    win = true;
            }
            if (board[0, 0] != DEFAULT)
            {
                if (board[0, 0] == board[0, 1] && board[0, 0] == board[0, 2])
                    win = true;
                if (board[0, 0] == board[1, 0] && board[0, 0] == board[2, 0])
                    win = true;
            }
            if (board[2, 2] != DEFAULT)
            {
                if (board[2, 2] == board[2, 1] && board[2, 2] == board[2, 0])
                    win = true;
                if (board[2, 2] == board[1, 2] && board[2, 2] == board[0, 2])
                    win = true;
            }
        }
    }  
}
