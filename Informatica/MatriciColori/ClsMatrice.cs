using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriciColori
{
    internal class ClsMatrice
    {
        static Random rnd = new Random(); 
        internal static void caricaMatrice(int[,] m, int min, int max)
        {
            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++)
                    m[i, j] = rnd.Next(min, max+1);
        }
        internal static void stampaMatrice(int[,] m, string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(msg);
            Console.ResetColor(); 
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                    Console.Write(m[i, j].ToString().PadRight(3));
                Console.WriteLine();
            }
        }
        internal static void inputDimensioniMatriceRettangolare(ref int r, ref int c)
        {
            do
            {
                Console.Write("Inserisci numero righe > "); 
            } while (!int.TryParse(Console.ReadLine(), out r) || (r <= 0));

            do
            {
                Console.Write("Inserisci numero colonne > ");
            } while (!int.TryParse(Console.ReadLine(), out c) || (c <= 0));
        }

        internal static int inputDimensioniMatriceQuadrata()
        {
            int r;
            do
            {
                Console.Write("Inserisci numero righe|colonne > ");
            } while (!int.TryParse(Console.ReadLine(), out r) || (r <= 0));
            return r; 
        }

        internal static void stampaDPColorata(int[,] m, string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(msg);
            Console.ResetColor();
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if(i == j)
                        Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(m[i, j].ToString().PadRight(3));
                    Console.ResetColor(); 
                }
                Console.WriteLine();
            }
        }

        internal static void stampaDSColorata(int[,] m, string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(msg);
            Console.ResetColor();
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (i+j == m.GetLength(0)-1)
                        Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(m[i, j].ToString().PadRight(3));
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }

        internal static void stampaCorniceColorata(int[,] m, string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(msg);
            Console.ResetColor();

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (i == 0 || i == m.GetLength(0)-1 
                            || j == 0 || j == m.GetLength(1)-1)
                        Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(m[i, j].ToString().PadRight(3));
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }

        internal static void stampaMatriceArlecchino(int[,] m, string msg)
        {
            ConsoleColor[] vColori = 
            { 
                ConsoleColor.Red, ConsoleColor.Magenta, ConsoleColor.Yellow,
                ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Gray,
                ConsoleColor.Cyan 
            };

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(msg);
            Console.ResetColor();

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.ForegroundColor = vColori[rnd.Next(0, vColori.Length)];
                    Console.Write(m[i, j].ToString().PadRight(3));
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        internal static void stampaMatriceRigheAlternate(int[,] m, string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(msg);
            Console.ResetColor();

            for (int i = 0; i < m.GetLength(0); i++)
            {
                if (i % 2 == 0)
                    Console.ForegroundColor = ConsoleColor.Green; 
                else
                    Console.ForegroundColor = ConsoleColor.Yellow;
                for (int j = 0; j < m.GetLength(1); j++)
                    Console.Write(m[i, j].ToString().PadRight(3));
                Console.WriteLine();
            }
            Console.ResetColor(); 
        }

        internal static void stampaSopraDS(int[,] m, string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(msg);
            Console.ResetColor();

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (i >= 0 && i <= m.GetLength(0) - 2 && j >= 0 && j <= m.GetLength(0) - 2 - i)
                        Console.ForegroundColor = ConsoleColor.Green;
                    else
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(m[i, j].ToString().PadRight(3));
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        internal static void stampaMatriceColonneAlternate(int[,] m, string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(msg);
            Console.ResetColor();

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (j % 2 == 0)
                        Console.ForegroundColor = ConsoleColor.Green;
                    else
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(m[i, j].ToString().PadRight(3));
                }
                Console.WriteLine();

            }
            Console.ResetColor();
        }

        internal static void stampaScacchiera(int[,] m, string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(msg);
            Console.ResetColor();

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if ((i+j) % 2 == 0)
                        Console.ForegroundColor = ConsoleColor.Green;
                    else
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(m[i, j].ToString().PadRight(3));
                }
                Console.WriteLine();

            }
            Console.ResetColor();
        }

        internal static void stampaSottoDP(int[,] m, string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(msg);
            Console.ResetColor();

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (i > j)
                        Console.ForegroundColor = ConsoleColor.Green;
                    else
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(m[i, j].ToString().PadRight(3));
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }

        internal static void stampaSottoDS(int[,] m, string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(msg);
            Console.ResetColor();

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (i>=1 && i<=m.GetLength(0)-1 && j>=m.GetLength(0)-i && j<=m.GetLength(0)-1)
                        Console.ForegroundColor = ConsoleColor.Green;
                    else
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(m[i, j].ToString().PadRight(3));
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
}
