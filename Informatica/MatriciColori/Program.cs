using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriciColori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string scelta;
            int r = 0, c = 0; // Salvo n righe e n colonne 
            int[,] m; // Dichiarazione matrice
            do
            {
                scelta = visualizzaMenu();
                Console.Clear(); 
                switch(scelta.ToLower())
                {
                    case "a":
                        ClsMatrice.inputDimensioniMatriceRettangolare(ref r, ref c);
                        m = new int[r, c]; 
                        ClsMatrice.caricaMatrice(m, 1, 99);
                        ClsMatrice.stampaMatrice(m, "Stampa matrice rettangolare");
                        break;
                    case "b": // Carica matrice quadrata e colora D.P.
                        r = ClsMatrice.inputDimensioniMatriceQuadrata();
                        m = new int[r, r];
                        ClsMatrice.caricaMatrice(m, 1, 99);
                        ClsMatrice.stampaDPColorata(m, "Stampa matrice quadrata D.P. colorata");
                        break;
                    case "c": // Carica matrice quadrata e colora D.S.
                        r = ClsMatrice.inputDimensioniMatriceQuadrata();
                        m = new int[r, r];
                        ClsMatrice.caricaMatrice(m, 1, 99);
                        ClsMatrice.stampaDSColorata(m, "Stampa matrice quadrata D.S. colorata");
                        break;
                    case "d": // Carica matrice rettangolare e colora cornice
                        ClsMatrice.inputDimensioniMatriceRettangolare(ref r, ref c);
                        m = new int[r, c];
                        ClsMatrice.caricaMatrice(m, 1, 99);
                        ClsMatrice.stampaCorniceColorata(m, "Stampa cornice colorata");
                        break;
                    case "e": // Carica matrice rettangolare e colore Arlecchino
                        ClsMatrice.inputDimensioniMatriceRettangolare(ref r, ref c);
                        m = new int[r, c];
                        ClsMatrice.caricaMatrice(m, 1, 99);
                        ClsMatrice.stampaMatriceArlecchino(m, "Stampa matrice Arlecchino");
                        break;
                    case "f": // Carica matrice rettangolare e colora righe alternate
                        ClsMatrice.inputDimensioniMatriceRettangolare(ref r, ref c);
                        m = new int[r, c];
                        ClsMatrice.caricaMatrice(m, 1, 99);
                        ClsMatrice.stampaMatriceRigheAlternate(m, "Stampa matrice righe alternate");
                        break;
                    case "g": // Carica matrice rettangolare e colora colonne alternate
                        ClsMatrice.inputDimensioniMatriceRettangolare(ref r, ref c);
                        m = new int[r, c];
                        ClsMatrice.caricaMatrice(m, 1, 99);
                        ClsMatrice.stampaMatriceColonneAlternate(m, "Stampa matrice colonne alternate");
                        break;
                    case "h": // Carica matrice quadrata e colora a scacchiera
                        r = ClsMatrice.inputDimensioniMatriceQuadrata();
                        m = new int[r, r];
                        ClsMatrice.caricaMatrice(m, 1, 99);
                        ClsMatrice.stampaScacchiera(m, "Stampa matrice quadrata e colora a scacchiera");
                        break;
                    case "k": // Carica matrice quadrata e colora sotto DP
                        r = ClsMatrice.inputDimensioniMatriceQuadrata();
                        m = new int[r, r];
                        ClsMatrice.caricaMatrice(m, 1, 99);
                        ClsMatrice.stampaSottoDP(m, "Stampa matrice quadrata e colora sotto DP");
                        break;
                    case "j": // Carica matrice quadrata e colora sotto DS
                        r = ClsMatrice.inputDimensioniMatriceQuadrata();
                        m = new int[r, r];
                        ClsMatrice.caricaMatrice(m, 1, 99);
                        ClsMatrice.stampaSottoDS(m, "Stampa matrice quadrata e colora sotto DS");
                        break;
                    case "l": // Carica matrice quadrata e colora sopra DS
                        r = ClsMatrice.inputDimensioniMatriceQuadrata();
                        m = new int[r, r];
                        ClsMatrice.caricaMatrice(m, 1, 99);
                        ClsMatrice.stampaSopraDS(m, "Stampa matrice quadrata e colora sopra DS");
                        break;
                    case "q":
                        Console.WriteLine("Programma terminato..."); 
                        break;
                    default:
                        Console.WriteLine("Opzione non disponibile");
                        break;
                }
                Console.ReadKey(); 
            } while (scelta.ToLower() != "q");

        }

        private static string visualizzaMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow; 
            Console.WriteLine("::: ESERCIZI MATRICI (COLORI) :::");
            Console.ResetColor(); 
            Console.WriteLine("a. Carica e stampa matrice (rxc)"); 
            Console.WriteLine("b. Carica matrice quadrata e colora D.P."); 
            Console.WriteLine("c. Carica matrice quadrata e colora D.S."); 
            Console.WriteLine("d. Carica matrice rettangolare e colora cornice"); 
            Console.WriteLine("e. Carica matrice rettangolare e colore Arlecchino"); 
            Console.WriteLine("f. Carica matrice rettangolare e colora righe alternate"); 
            Console.WriteLine("g. Carica matrice rettangolare e colora colonne alternate"); 
            Console.WriteLine("h. Carica matrice quadrata e colora a scacchiera");
            Console.WriteLine("k. Carica matrice quadrata e colora sotto la DP");
            Console.WriteLine("j. Carica matrice quadrata e colora sotto la DS");
            Console.WriteLine("l. Carica matrice quadrata e colora sopra la DS");
            Console.WriteLine("q. Esci");
            Console.Write("Scelta > ");
            return Console.ReadLine(); 
        }
    }
}
