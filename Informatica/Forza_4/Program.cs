using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Forza4.Forza4;

namespace Forza4
{
    class ForzaGame
    {
        static char[,] board = new char[6, 7];
        static char player1 = 'X';
        static char player2 = 'O';

        static void Main(string[] args)
        {
            FillBoard(board);
            bool isGameOver = false;
            char currentPlayer = player1;

            while (!isGameOver)
            {
                DisplayBoard(board);
                Console.WriteLine($"Giocatore {(currentPlayer == player1 ? 1 : 2)} ({currentPlayer}), è il tuo turno.");

                int column = GetValidColumn(board);
                if (!PlacePiece(currentPlayer, column, board))
                {
                    Console.WriteLine("Colonna piena, riprova.");
                    continue;
                }

                if (CheckWinner(currentPlayer, board))
                {
                    DisplayBoard(board);
                    Console.WriteLine($"Il giocatore {(currentPlayer == player1 ? 1 : 2)} ({currentPlayer}) vince!");
                    isGameOver = true;
                }
                else if (IsBoardFull(board))
                {
                    DisplayBoard(board);
                    Console.WriteLine("Pareggio...");
                    isGameOver = true;
                }
                else
                {
                    currentPlayer = currentPlayer == player1 ? player2 : player1;
                }
            }
        }
    }
}