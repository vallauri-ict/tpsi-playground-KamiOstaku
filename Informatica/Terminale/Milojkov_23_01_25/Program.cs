using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Barbero_23_01_25
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //dichiarazione matrice
            int r, c; //r: numero righe - c: numero colonne
           do
                Console.Write("Inserisci il numero di righe: ");
            while (!int.TryParse(Console.ReadLine(), out r) || r <= 0);
            do
                Console.Write("Inserisci il numero di colonne: ");
            while (!int.TryParse(Console.ReadLine(), out c) || c <= 0);
            //dichiarazione matrice
            int[,] a = new int[r, c];
            caricaMatrice(a);
            stampaMatrice(a, "MATRICE A");

            Console.WriteLine();
            es1(a);
            Console.ReadKey();

            Console.WriteLine("\n\nEsercizio 2:\n");
            if(r == c)
            {
                //La funzione es due restituisce un bool e quindi usata per dare l'output corretto
                if (es2(a))
                {
                    Console.WriteLine("La matrice è dominante");
                }
                else
                {
                    Console.WriteLine("La matrice non è dominante");
                }
            }    
            else
            {
                Console.WriteLine("Il secondo esercizio richiede una matrice quadrata e ne hai inserita una rettangolare");
            }  
            
            Console.ReadKey();
        }

        private static void caricaMatrice(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++)
                    m[i, j] = rnd.Next(1,10);
        }
        private static void stampaMatrice(int[,] m, string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.ResetColor();
            for (int i = 0; i < m.GetLength(0); i++) 
            {
                for (int j = 0; j < m.GetLength(1); j++) 
                    Console.Write(m[i, j].ToString().PadRight(4));
                Console.WriteLine();
            }
        }
        private static void es1(int[,] a)
        {
            //COPIARE GLI ELEMENTI DISPARI DI UNA MATRICE IN UNA 
            //SECONDA MATRICE SENZA LASCIARE BUCHI, SE NON IN FONDO.
            //STAMPARE LA NUOVA MATRICE
            //ES. CON MATRICE A(3 X 4):
            //4, 5, 2, 7
            //1, 9, 2, 8
            //5, 7, 4, 4
            //SI OTTIENE MATRICE B(3 X 4):
            //5, 7, 1, 9
            //5, 7, 0, 0
            //0, 0, 0, 0

            
            //Dichiaro ed inizializzo le variabili c,r ad intero per tenere le misure della matrice, dichiaro la matrice B che viene inizializzata a 0 di base
            int c = a.GetLength(1), r = a.GetLength(0);
            int[,] matrixB = new int[r, c];

            //Dichiaro ed inizializzo a 0 x e y per gestire l'indice della seconda matrices
            int x =0, y=0;

            //Ciclo con i for perché va passato ogni elemento della matrice A
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    //Controllo se il numero è dispari, in caso lo aggiungo alla matrice B, mi sposto nella cella a destra della matrice B e controllo di non sforare i limiti della matrice
                    if (a[i, j] % 2 != 0)
                    {
                        matrixB[x, y] = a[i, j];
                        y++;
                        if (y == c)
                        {
                            x++;
                            y = 0;
                        }
                    }
                }
                
            }
            stampaMatrice(matrixB,"Stampa delle celle della matrice B");

        }
        private static bool es2(int[,] a)
        {
            //VERIFICARE SE UNA MATRICE QUADRATA E' DIAGONALMENTE
            //DOMINANTE, CIOE' SE LA SOMMA DEI SUOI VALORI SU 
            //CIASCUNA RIGA, ESCLUSO L'ELEMENTO SULLA DP, E' 
            //MINORE DELL'ELEMENTO CORRISPONDENTE SULLA DP
            //ES. CON MATRICE A(4 X 4):
            //5, 1, 2, 1
            //1, 9, 2, 1
            //1, 1, 4, 1
            //3, 1, 2, 8
            //SI OTTIENE MATRICE DIAGONALMENTE DOMINANTE
            //ES. CON MATRICE A(4 X 4):
            //5, 1, 2, 1
            //1, 9, 7, 7
            //1, 1, 4, 1
            //3, 1, 2, 8
            //SI OTTIENE MATRICE NON DIAGONALMENTE DOMINANTE



            //Dichiaro ed inizializzo le variabili c,r ad intero per tenere le misure della matrice, dichiaro ed inizializzo a true la variabile booleana chiamata dominante partendo dal
            //presupposto che è dominante e cercando di provare il contrario nei cicli, dichiaro il contatore del while inizializzandolo a 0 e somma senza inizializzarla poiché viene fatto nel while
            int c = a.GetLength(1), r = a.GetLength(0);
            bool dominante = true;
            int i = 0, somma;

            //Inizio il while con condizioni di uscita di domindante != da true oppure se l'indice supera i range della matrice
            while(dominante && i < r)
            {
                //Inizializzo la variabile somma in modo da non avere nessun risultato precedente
                somma = 0;
                for (int j = 0; j < c; j++)
                {
                    //Controllo di non sommare l'elemento sulla DP
                    if(i!=j)
                    {
                        somma += a[i, j];
                    }
                }
                
                //Controllo se la somma è maggiore della cella sulla DP e in caso cambio il valore della bool per uscire
                if(somma > a[i,i])
                {
                    dominante = false;
                }

                //Incremento il contatore nel while per evitare un loop infinito
                i++;
            }
            
            //Restituisco la variabile booleana nel main per gestire la stampa
            return dominante;     
        }
    }
}
