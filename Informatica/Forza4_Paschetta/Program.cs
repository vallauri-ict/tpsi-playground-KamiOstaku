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
            bool vittoria;

            do
            {
                vittoria = false;
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
                        giocatoreCorrente = giocatoreCorrente == 'X' ? 'O' : 'X';

                        vittoria = WinCheck(Carlo, rows, colums, giocatoreCorrente);
                    }
                    else
                    {
                        Console.WriteLine("Colonna piena. Riprova.");
                    }
                } while (!vittoria);


            } while (true);
        }
    }
}
