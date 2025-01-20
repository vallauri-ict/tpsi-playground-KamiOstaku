using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllo_Sotto_Diagonale_Principale
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[,] matrix = new int[5,5];

            //Matrix filling

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(0, 10);
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //DS research
            int dsVerify = matrix.GetLength(1) - 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    if (dsVerify == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        dsVerify--;
                    }
                    if(i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    if(i == matrix.GetLength(0)/2 && j == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
