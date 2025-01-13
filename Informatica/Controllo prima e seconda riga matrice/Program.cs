using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllo_prima_e_seconda_riga_matrice
{
    internal class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            int[,] m = new int[5, 10];

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if(i == 0 || i == m.GetLength(0) - 1)
                    {
                        m[i, j] = 1;
                    }
                    else
                    {
                        m[i, j] = 0;
                    }
                }
            }

            bool One = false;
            int x = 0;

            while (!One && x < m.GetLength(0) - 1)
            {
                if (x == 0 || x == m.GetLength(0) - 1)
                {
                    for (int i = 0; i < m.GetLength(1); i++)
                    {
                        if (m[x,i] != 1)
                        {
                            One = true;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < m.GetLength(1); i++)
                    {
                        if (m[x, i] == 1)
                        {
                            One = true;
                        }
                    }
                }

                x++;
            }

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j]);
                }
                Console.WriteLine();
            }

            if(One)
            {
                Console.WriteLine("Non uguali");
            }
            else
            {
                Console.WriteLine("Uguali");
            }

            Console.ReadKey();
        }
    }
}
