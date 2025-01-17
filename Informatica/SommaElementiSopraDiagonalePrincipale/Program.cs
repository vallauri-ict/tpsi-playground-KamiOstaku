using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SommaElementiSopraDiagonalePrincipale
{
    internal class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {

            int[,] m = new int[5, 5];

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] += rnd.Next(0, 10);
                }
            }

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }

            int somma = 0;

            //for (int i = 0; i < m.GetLength(0)-1; i++)
            //{
            //    for (int j = i+1; j < m.GetLength(1); j++)
            //    {
            //        somma += m[i,j];
            //    }
            //}
            //Sopra somma elementi sopra dp


            //for (int i = 1; i < m.GetLength(0); i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        somma += m[i, j];
            //    }
            //}
            //Sopra elementi sotto dp

            int a = 0, b = 1;
            bool esci = false;
            int x = Convert.ToInt32(Console.ReadLine());

            while (!esci && a < m.GetLength(0))
            {
                if (m[a, b] == x)
                {
                    esci = true;
                }
                else if (b == m.GetLength(0) - 1)
                {
                    a++;
                    b = a + 1;
                }
                else
                {
                    b++;
                }
            }

            Console.WriteLine(a + "  " + b);
            Console.ReadKey();
        }
    }
}
