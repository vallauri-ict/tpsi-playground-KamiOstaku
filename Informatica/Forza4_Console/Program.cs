using System;
using System.Collections.Generic;
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
            char[,] Carlo = new char[6, 7];
            char giocatorecorrente = 'X';

            do
            {
                Carlo = new char[6, 7];
                giocatorecorrente = 'X';
                inizializzacampo(Carlo);
                stampamatrice(Carlo);
                //Inizio partita
                do
                {

                } while (true);


            } while (true);
        }
    }
}
