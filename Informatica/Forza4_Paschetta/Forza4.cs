using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public static int posizionaGettone(char[,] carlo, char giocatoreCorrente, int colums)
        {
            int i = carlo.GetLength(0) - 1;

            while (carlo[i, colums] != '-')//Ho gia verificato che il gettone poss essere piazzato
            {
                i--;
            }
            carlo[i, colums] = giocatoreCorrente;
            return i;
        }

        public static void stampamatrice(char[,] campo)
        {
            Console.Clear();

            // Stampo la parte superiore del bordo 
            Console.WriteLine("  -".PadRight(29, '-'));

            for (int i = 0; i < campo.GetLength(0); i++)
            {
                Console.Write(" | ");
                for (int j = 0; j < campo.GetLength(1); j++)
                {
                    Console.Write(campo[i, j] + " | ");
                }
                Console.WriteLine();
                Console.WriteLine("  -".PadRight(29, '-')); // linea separazione tra righe
            }
        }

        public static bool WinCheck(char[,] carlo, int rows, int colums, char giocatoreCorrente)
        {
            bool vittoria = false;
            int cnt = 0,i = rows,j=colums;

            while(rows<carlo.GetLength(0) && carlo[rows,colums] == giocatoreCorrente)
            {
                cnt++;
                rows++;
            }

            if (cnt >= 4)
            {
                vittoria = true;
            }
            else
            {
                rows = i - 1;
                colums = j - 1;

                while (colums < carlo.GetLength(1) && carlo[rows, colums] == giocatoreCorrente)
                {
                    cnt++;
                    colums++;
                }
                rows = i - 1;
                colums = j - 1;
                while (colums >= 0 && carlo[i, j] == giocatoreCorrente)
                {
                    cnt++;
                    colums--;
                }

                if (cnt >= 4)
                {
                    vittoria = true;
                }
                else
                {
                    cnt = 0;
                    rows = i - 1;
                    colums = j - 1;

                    while (colums < carlo.GetLength(1) && rows < carlo.GetLength(0) && giocatoreCorrente == carlo[rows, colums])
                    {
                        rows++;
                        colums++;
                        cnt++;
                    }
                    colums = j - 1;
                    rows = i - 1;
                    while (j >= 0 && i >= 0)
                    {
                        i--;
                        j--;
                        cnt++;
                    }
                }
                if (cnt >= 4)
                {
                    vittoria = true;
                }
                else
                {
                    cnt = 0;
                    rows = i - 1;
                    colums = j - 1;

                    while (rows < carlo.GetLength(0) && colums >= 0 && giocatoreCorrente == carlo[rows, colums])
                    {
                        rows++;
                        colums--;
                        cnt++;
                    }
                    colums = j - 1;
                    rows = i - 1;
                    while (j < carlo.GetLength(1) && i >= 0 && carlo[rows, colums] == giocatoreCorrente)
                    {
                        rows--;
                        colums++;
                        cnt++;
                    }

                    if (cnt >= 4)
                    {
                        vittoria = true;
                    }
                }
            }

            return vittoria;





        }
    }
}
