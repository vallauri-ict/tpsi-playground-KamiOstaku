using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[,] m = new int[,] { { 2, 7, 6 }, { 9, 5, 1 }, { 4, 3, 8 } };
            int target = 15;

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }

            bool no = false;
            controllo(ref no,m,target);

            if (!no)
            {
                Console.WriteLine("Non è magica");
            }
            else
            {
                Console.WriteLine("è magico");
            }

            Console.ReadKey();
        }

        private static void controllo(ref bool no, int[,] m, int t)
        {
            no = controlloOrrizontale(m,t);
            if(no)
            {
                no = controlloVerticale(m,t);
                if (!no)
                {
                    no = controlloObliqua(m,t);
                }
            }    
            
        }

        private static bool controlloObliqua(int[,] m, int t)
        {
            int somma = 0;
            int j = m.GetLength(0) - 1;
            bool fuori = false;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                somma += m[i, j--];
            }
            
            if(somma == t)
            {
                fuori = true;
            }

            for (int i = 0; i < m.GetLength(0); i++)
                somma += m[i, i];

            if (somma == t)
            {
                fuori = true;
            }

            return fuori;

        }

        private static bool controlloVerticale(int[,] m, int t)
        {
            int somma = 0, i = 0;
            bool fuori = false;

            while (fuori && i < m.GetLength(1)-1)
            {
                for (int j = 0; j < m.GetLength(0); j++)
                {
                    somma += m[j, i];
                }

                if (somma != t)
                {
                    fuori = true;
                }

                i++;
            }

            return fuori;
        }

        private static bool controlloOrrizontale(int[,] m, int t)
        {
            int somma = 0,i = 0;
            bool fuori = false;

            while(fuori && i < m.GetLength(0) - 1)
            {
                for (int j = 0; j < m.GetLength(0); j++)
                {
                    somma += m[i, j];
                }

                if(somma != t)
                {
                    fuori = true;
                }
                i++;
            }

            return fuori;
        }
    }
}
