using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestioneMatrice3B
{
    internal class clsMatrice
    {
        public static void caricaMatrice(int[,] m)
        {
            Random rnd = new Random();
            //i indice RIGHE, j indice COLONNE

            for (int i = 0; i < m.GetLength(0); i++) //ottengo numero righe
                for (int j = 0; j < m.GetLength(1); j++) //ottengo numero colonne
                    m[i, j] = rnd.Next(1, 100);
        }
        public static void stampaMatrice(int[,] m, string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.ResetColor();
            for (int i = 0; i < m.GetLength(0); i++) //ottengo numero righe
            {
                for (int j = 0; j < m.GetLength(1); j++) //ottengo numero colonne
                    Console.Write(m[i, j].ToString().PadRight(3));
                Console.WriteLine();
            }
        }

        internal static double mediaMatrice(int[,] m)
        {
            double somma = 0;
            for (int i = 0; i < m.GetLength(0); i++) //scorro le righe
                for (int j = 0; j < m.GetLength(1); j++) //per ogni riga, scorro le colonne
                    somma += m[i, j];
            Console.WriteLine(somma.ToString());
            return somma / (m.GetLength(0) * m.GetLength(1));
        }
    }
}
