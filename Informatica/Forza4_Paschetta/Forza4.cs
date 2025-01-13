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
        public static int posizionaGettone(char[,] carlo, char giocatoreCorrente, int colums)
        {
            int i = carlo.GetLength(1) - 1;

            while (carlo[i, colums] == '-')//Ho gia verificato che il gettone poss essere piazzato
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
            int cnt;

            while(i<carlo.GetLength(0))





        }
    }
}
