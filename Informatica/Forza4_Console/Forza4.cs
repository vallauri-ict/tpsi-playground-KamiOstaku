using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forza4_Console
{
    internal class Forza4
    {
        public static void inizializzacampo(char[,] carlo)
        {
            for (int i = 0; i < carlo.GetLength(0); i++)
            {
                for (int j = 0; j < carlo.GetLength(1); j++)
                {
                    carlo[i, j] = '-';
                }
            }
        }

        public static void stampamatrice(char[,] carlo)
        {
            Console.Clear();

            for (int i = 0; i < carlo.GetLength(0); i++)
            {
                for (int j = 0; j < carlo.GetLength(1); j++)
                {
                    Console.Write($"{carlo[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
