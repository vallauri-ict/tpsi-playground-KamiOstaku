using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Forza4_Console.Forza4;

namespace Forza4_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] Carlo;
            char giocatoreCorrente;
            int colums,rows;
            bool vittoria,campopieno;

            do
            {
                vittoria = false;
                campopieno = false;
                Carlo = new char[6, 7];
                giocatoreCorrente = 'X';
                inizializzacampo(Carlo);
                stampamatrice(Carlo);
                //Inizio partita
                do
                {
                    do
                    {

                        Console.Write("Giocatore " + giocatoreCorrente + ", " +"scegli colonna (0-6) > ");

                    } while (!int.TryParse(Console.ReadLine(), out colums) || colums < 0 || colums > 6);

                    if (Carlo[0,colums] == '-')
                    {
                        rows = posizionaGettone(Carlo, giocatoreCorrente, colums);
                        stampamatrice(Carlo);
                        vittoria = WinCheck(Carlo, rows, colums, giocatoreCorrente);
                        campopieno = campoPieno(Carlo);
                        giocatoreCorrente = giocatoreCorrente == 'X' ? 'O' : 'X';
                    }
                    else
                    {
                        Console.WriteLine("Colonna piena. Riprova.");
                    }
                } while (!vittoria);
                
                if(vittoria)
                {
                    Console.WriteLine($"Ha vinto il giocatore con il carattere: {giocatoreCorrente}");
                }

                Console.ReadKey();
            } while (true);
        }

        private static bool campoPieno(char[,] carlo)
        {
            int j = 0;
            while(j < carlo.GetLength(1) && carlo[0,j] == '-')
            {
                j++;
            }
        }
    }
}
