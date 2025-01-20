using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forza4
{
    internal class Forza4
    {
        internal static void FillBoard(char[,] board)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    board[i, j] = '.';
                }
            }
        }

        internal static void DisplayBoard(char[,] board)
        {
            Console.Clear();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (board[i, j] == 'X')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (board[i, j] == 'O')
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
            Console.WriteLine("0 1 2 3 4 5 6");
        }


        internal static int GetValidColumn(char[,] board)
        {
            int column;
            while (true)
            {
                Console.Write("Scegli una colonna (0-6): ");
                if (int.TryParse(Console.ReadLine(), out column) && column >= 0 && column < 7)
                    return column;
                Console.WriteLine("Input non valido, scegli un numero tra 0 e 6.");
                Console.ReadKey();
                Console.Clear();
                DisplayBoard(board);
            }
        }

        internal static bool PlacePiece(char player, int column, char[,] board)
        {
            for (int i = 5; i >= 0; i--)
            {
                if (board[i, column] == '.')
                {
                    board[i, column] = player;
                    return true;
                }
            }
            return false;
        }

        internal static bool CheckWinner(char player, char[,] board)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (board[i, j] == player && board[i, j + 1] == player &&
                        board[i, j + 2] == player && board[i, j + 3] == player)
                        return true;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (board[i, j] == player && board[i + 1, j] == player &&
                        board[i + 2, j] == player && board[i + 3, j] == player)
                        return true;
                }
            }

            for (int i = 3; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (board[i, j] == player && board[i - 1, j + 1] == player &&
                        board[i - 2, j + 2] == player && board[i - 3, j + 3] == player)
                        return true;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (board[i, j] == player && board[i + 1, j + 1] == player &&
                        board[i + 2, j + 2] == player && board[i + 3, j + 3] == player)
                        return true;
                }
            }

            return false;
        }

        internal static bool IsBoardFull(char[,] board)
        {
            for (int j = 0; j < 7; j++)
            {
                if (board[0, j] == '.')
                    return false;
            }
            return true;
        }
    }
}