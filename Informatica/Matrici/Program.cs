using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrici
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[,] m = new int[4, 4];

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = rnd.Next(0, 1);
                }
            }

            //int aux = m.GetLength(0) - 1;
            //for (int i = 0; i < m.GetLength(0); i++)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    for (int j = 0; j < m.GetLength(1); j++)
            //    {
            //        if (j == aux)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Yellow;
            //            aux--;
            //        }
            //        Console.Write(m[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }


            int[,] b = { {0,0},
                         {0,0}
                        };
            int cont = 0;
            bool esci = true;
            for (int i = 0; i < m.GetLength(0)-1; i++)
            {
                for (int j = 0; j < m.GetLength(1)-1; j++)
                {
                    if (m[i, j] == b[0, 0] && m[i + 1, j] == b[1, 0] && m[i, j + 1] == b[0, 1] && m[i + 1, j + 1] == b[1,1])
                    {
                        cont++;
                    }
                }
            }

            Console.Write("\n\n" + cont);
            Console.ReadKey();
        }
    }
}
