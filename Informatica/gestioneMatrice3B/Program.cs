using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestioneMatrice3B
{
    internal class Program
    {  
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //array bidimensionali --> MATRICI
            int r, c;
            do
                Console.Write("Inserisci il numero di righe: ");

            while (!int.TryParse(Console.ReadLine(), out r) || r<0);
            do
                Console.Write("Inserisci il numero di colonne: ");

            while (!int.TryParse(Console.ReadLine(), out c) || c < 0);
            int[,] a = new int[r, r]; //righe==colonne --> matrice QUADRATA
            int[,] b= new int[r, c]; //righe!=colonne --> matrice RETTANGOLARE
            caricaMatrice(a);
            stampaMatrice(a, "Matrice A quadrata");
            caricaMatrice(b);
            stampaMatrice(b, "Matrice B rettangolare");
            //Console.WriteLine("La media degli elementi della matrice A è: " +
            //    mediaMatrice(a).ToString("F2"));
            //Console.ReadKey();
            //Console.WriteLine("La media degli elementi della matrice B è: " +
            //    mediaMatrice(b).ToString("F2"));
            //Console.ReadKey();
            //if (mediaMatrice(a) == mediaMatrice(b))
            //    Console.WriteLine("MEDIE ==");
            //else
            //    Console.WriteLine("MEDIE !=");
            //Console.ReadKey();
            //Console.WriteLine("L'elemento massimo della matrice è: " +
            //   maxMatrice(b).ToString());
            //Console.ReadKey();
            //Console.WriteLine("La somma della diagonale principale è: " +
            //   sommaDP(a).ToString());
            //Console.ReadKey();
            //Console.WriteLine("La somma della diagonale secondaria è: " +
            //   sommaDS(a).ToString());
            //Console.ReadKey();
            //Console.WriteLine("La somma della cornice esterna è: " +
            //   sommaCornice(a).ToString());
            //Console.WriteLine("La somma della riga i-esima è: " +
            //   sommaRigaI(b).ToString());
            //Console.ReadKey();
            //Console.WriteLine("La somma della colonna j-esima è: " +
            //   sommaColonnaJ(b).ToString());
            //Console.ReadKey();
            //Console.WriteLine("Il valore compare: " +
            //   contaX(b).ToString());
            //Console.ReadKey();
            //if (sommaRigaI(a) == sommaColonnaJ(a))
            //    Console.WriteLine("SOMME ==");
            //else
            //    Console.WriteLine("SOMME !=");
            //caricaMatriceSequenza(a);
            //stampaMatrice(a, "Matrice con valori in sequenza");
            //caricaMatriceSequenzaContraria(a);
            //stampaMatrice(a, "Matrice con valori in sequenza contraria");
            //caricaCorniceSequenza(a);
            //stampaMatrice(a, "Matrice con cornice in sequenza");
            //matriceTuttiElementiUguali(b);
            //matriceNulla(a);
            //matriceUnitaria(a);
            //matriceConCroce(a);
            //matriceConPrimaUltimaRigaDi1(b);
            //sommaElementiSopraDP(a);
            //Console.ReadKey();
            //sommaElementiSottoDP(a);
            //Console.ReadKey();
            //ricercaXTriangoloSopraDP(a);
            //Console.ReadKey();
            //ricercaXTriangoloSottoDP(a);
            //Console.ReadKey();
            //tuttiUgualiSottoDP(a);
            //Console.ReadKey();
            //sommaElementiSottoDS(a);
            //Console.ReadKey();
            //verificareSeSottoDSsolo0(a);
            //Console.ReadKey();
            //sommaElementiSopraDS(a);
            //Console.ReadKey();
            //verificareSeSopraDSsolo0(a);
            //Console.ReadKey();
            //verificareSeSopraDpsolo0(a);
            //Console.ReadKey();
            //int[,] d = { {1, 2, 3 },{4, 5, 6 },{7, 8, 9 } };
            //stampaMatrice(d, "Matrice con sequenza");
            //verificareSeSottoDPOrdinati(d);
            //Console.ReadKey();
            //int[,] e = { { 5, 7, 12 }, {7, 2, 8 }, { 12, 8,3} };
            //matriceSimmetrica(e);
            //stampaMatrice(e, "Matrice simmetrica");
            //matriceTrasposta(b);
            //Console.ReadKey();
            ricercaSottoMatrice(a);
            Console.ReadKey();
        }

        private static void ricercaSottoMatrice(int[,] a)
        {
            //contare quante volte si trova la sotto matrice b nella
            //matrice quadrata a
            int r = a.GetLength(0);
            int[,] b = { {0, 0},{0, 0} }; //sotto matrice da cercare
            int[,] m = new int[r + 2, r + 2]; //matrice con bordi
            caricaMatriceAppoggio(m, a);
            stampaMatrice(b, "Sotto matrice da cercare");
            int cont = 0;
            for (int i = 1; i < r-2; i++)
            {
                for (int j = 1; i <= r - 2; i++)
                {
                    if (m[i, j] == b[0, 0] && m[i, j+1] == b[0, 1]
                        && m[i + 1, j] == b[1, 0] && m[i + 1, j + 1] == b[1, 1])
                        cont++;
                }
            }

            Console.WriteLine("La sottomatrice compare " + cont.ToString() +
                " volte");
        }

        private static void caricaMatriceAppoggio(int[,] m, int[,] a)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(0); j++)
                {
                    if (i == 0 || i == m.GetLength(0) - 1
                        || j == 0 || j == m.GetLength(0) - 1) //sono sul bordo
                        m[i, j] = -1;
                    else
                        m[i, j] = a[i-1, j-1];
                }
            }
            stampaMatrice(m, "Matrice di appoggio con bordi");
        }

        private static void matriceTrasposta(int[,] a)
        {
            int r = a.GetLength(0);
            int c = a.GetLength(1);
            int[,] b = new int[c, r]; //matrice trasposta
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    b[j, i] = a[i, j];
            stampaMatrice(b, "Matrice trasposta");
        }

        private static void matriceSimmetrica(int[,] m)
        {
            int i = 1, j = 0;
            bool esci = false;
            int r = m.GetLength(0);

            while (!esci && i <= r - 1)
            {
                if (m[i, j] != m[j, i])
                    esci = true;
                else
                {
                    if (j == i - 1)
                    {
                        i++;
                        j = 0;
                    }
                    else
                        j++;
                }
            }
            if (esci)
                Console.WriteLine("Matrce NON simmetrica");
            else
                Console.WriteLine("Matrice simmetrica");
        }

        private static void verificareSeSottoDPOrdinati(int[,] m)
        {
            int i = 1, j = 0;
            bool esci = false;
            int r = m.GetLength(0);
            int prec = m[1, 0];

            while (!esci && i <= r - 1)
            {
                if (m[i, j]< prec)
                    esci = true;
                else
                {
                    prec = m[i, j];
                    if (j == i-1)
                    {
                        i++;
                        j = 0;
                    }
                    else
                        j++;
                }
            }
            if (esci)
                Console.WriteLine("Non ordinati sotto DP");
            else
                Console.WriteLine("Tutti ordinati sotto DP");
        }

        private static void verificareSeSopraDpsolo0(int[,] m)
        {
            int i = 0, j = 1;
            bool esci = false;
            int r = m.GetLength(0);

            while (!esci && i<=r-2)
            {
                if (m[i, j] != 0)
                    esci = true;
                else
                {
                    if (j == r - 1)
                    {
                        i++;
                        j = i + 1;
                    }
                    else
                        j++;
                }
            }
            if (esci)
                Console.WriteLine("Non tutti 0");
            else
                Console.WriteLine("Tutti 0");
        }

        private static void verificareSeSopraDSsolo0(int[,] m)
        {
            //verificare se nel triangolo sopra la DS 
            //ci sono solo 0
            bool esci = false;
            int r = m.GetLength(0);
            int i = 0;
            int j = 0;

            while (!esci && i <= r - 2)
            {
                if (m[i, j] != 0)
                    esci = true;
                else
                {
                    if (j == r - 2 - i)
                    {
                        i++;
                        j = 0;
                    }
                    else
                        j++;
                }
            }
            if (esci)
                Console.WriteLine("Valori sopra la DS diversi da 0");
            else
                Console.WriteLine("Valori sopra la DS == a 0");
        }

        private static void sommaElementiSopraDS(int[,] m)
        {
            int somma = 0;
            int r = m.GetLength(0);

            for (int i = 0; i <= r - 2; i++)
                for (int j = 0; j <= r - 2 - i; j++)
                    somma += m[i, j];
            Console.WriteLine("La somma degli elementi " +
                "sopra la DS è: " + somma.ToString());
        }

        private static void verificareSeSottoDSsolo0(int[,] m)
        {
            //verificare se nel triangolo sotto la DS 
            //ci sono solo 0
            bool esci = false;
            int r = m.GetLength(0);
            int i = 1;
            int j = r-i;
            
            while (!esci && i <= r - 1)
            {
                if (m[i, j] != 0)
                    esci = true;
                else
                {
                    if (j == r - 1)
                    {
                        i++;
                        j = r-i;
                    }
                    else
                        j++;
                }
            }
            if (esci)
                Console.WriteLine("Valori sotto la DS diversi da 0");
            else
                Console.WriteLine("Valori sotto la DS == a 0");
        }

        private static void sommaElementiSottoDS(int[,] m)
        {
            int somma = 0;
            int r = m.GetLength(0);

            for (int i = 1; i <= r - 1; i++)
                for (int j = r - i; j <= r - 1; j++)
                    somma += m[i, j];
            Console.WriteLine("La somma degli elelemti " +
                "sotto la DS è: " + somma.ToString());
        }

        private static void tuttiUgualiSottoDP(int[,] m)
        {
            //solo sul triangolo inferiore rispetto alla DP
            //di una matrice quadrata
            bool esci = false;
            int i = 1;
            int j = 0;
            int r = m.GetLength(0);
            int x = m[i, j];
            while (!esci && i<=r-1)
            {
                if (m[i, j] != x)
                    esci = true;
                else
                {
                    if (j == i - 1)
                    {
                        i++;
                        j = 0;
                    }
                    else
                        j++;
                }
            }
            if (esci)
                Console.WriteLine("Valori diversi sotto la DP");
            else
                Console.WriteLine("Valori uguali sotto la DP");
        }

        private static void ricercaXTriangoloSottoDP(int[,] m)
        {
            int i = 1;
            int j = 0;
            bool esci = false;
            int r = m.GetLength(0);

            Console.Write("Inserisci x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            while (!esci && i <= r - 1)
            {
                if (m[i, j] == x)
                    esci = true;
                else
                {
                    if (j == i - 1)
                    {
                        i++;
                        j = 0;
                    }
                    else
                        j++;
                }
            }
            if (esci)
                Console.WriteLine("Trovato pos: " + i.ToString() +
                    " - " + j.ToString());
            else
                Console.WriteLine("Non trovato");
        }

        private static void ricercaXTriangoloSopraDP(int[,] m)
        {
            int i = 0;
            int j = 1;
            bool esci = false;
            int r = m.GetLength(0);

            Console.Write("Inserisci x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            while (!esci && i<=r-2)
            {
                if (m[i, j] == x)
                    esci = true;
                else
                {
                    if (j == r - 1)
                    {
                        i++;
                        j = i + 1;
                    }
                    else
                        j++;
                }
            }
            if (esci)
                Console.WriteLine("Trovato pos: "+i.ToString()+
                    " - "+j.ToString());
            else
                Console.WriteLine("Non trovato");
        }

        private static void sommaElementiSottoDP(int[,] m)
        {
            //solo su matrice quadrata e mi sposto 
            //solo sul triangolo sotto la DP
            int somma = 0;
            int r = m.GetLength(0);

            for (int i = 1; i <= r - 1; i++)
                for (int j = 0; j <= i - 1; j++)
                    somma += m[i, j];
            Console.WriteLine("La somma dei valori sotto DP è: "
                + somma.ToString());
        }

        private static void sommaElementiSopraDP(int[,] m)
        {
            //solo su matrice quadrata e mi sposto 
            //solo sul triangolo sopra la DP
            int somma = 0;
            int r = m.GetLength(0);

            for (int i = 0; i <= r - 2; i++)
                for (int j = i + 1; j <= r - 1; j++)
                    somma += m[i, j];
            Console.WriteLine("La somma dei valori sopra DP è: "
                + somma.ToString());
        }

        private static void matriceConPrimaUltimaRigaDi1(int[,] m)
        {
            bool esci = false;
            int i = 0, j = 0;
            int r = m.GetLength(0);
            int c = m.GetLength(1);

            while (!esci && i <= r - 1)
            {
                if (i == 0 || i == r - 1)
                {
                    if (m[i, j] == 1)
                        proseguiVisitaMatrice(c, ref i, ref j);
                    else
                        esci = true;
                }
                else
                {
                    if (m[i, j] == 0)
                        proseguiVisitaMatrice(c, ref i, ref j);
                    else
                        esci = true;
                }
            }
            if (esci)
                Console.WriteLine("Matrice con prima e ultima riga != 1");
            else
                Console.WriteLine("Matrice con prima e ultima riga di 1");
        }

        private static void matriceConCroce(int[,] m)
        {
            //solo su matrice quadrata con r>=5
            bool esci = false;
            int i = 0, j = 0;
            int r = m.GetLength(0);

            while (!esci && i <= r - 1)
            {
                if (i==r/2 || j==r/2) //sono sulla croce
                {
                    if (m[i, j] == 1)
                        proseguiVisitaMatrice(r, ref i, ref j);
                    else
                        esci = true;
                }
                else //non sono sulla croce
                {
                    if (m[i, j] == 0)
                        proseguiVisitaMatrice(r, ref i, ref j);
                    else
                        esci = true;
                }
            }
            if (esci)
                Console.WriteLine("Matrice SENZA croce");
            else
                Console.WriteLine("Matrice CON croce");
        }

        private static void matriceUnitaria(int[,] m)
        {
            //solo su matrice quadrata
            bool esci = false;
            int i = 0, j = 0;
            int r = m.GetLength(0);

            while (!esci && i <= r - 1)
            {
                if (i == j) //sono sulla DP
                {
                    if (m[i, j] == 1)
                        proseguiVisitaMatrice(r, ref i, ref j);
                    else
                        esci = true;
                }
                else //non sono sulla DP
                {
                    if (m[i, j] == 0)
                        proseguiVisitaMatrice(r, ref i, ref j);
                    else
                        esci = true;
                }
            }
            if (esci)
                Console.WriteLine("Matrice NON unitaria");
            else
                Console.WriteLine("Matrice unitaria");
        }

        private static void proseguiVisitaMatrice(int r, ref int i, ref int j)
        {
            if (j == r - 1)
            {
                i++;
                j = 0;
            }
            else
                j++;
        }
        private static void matriceNulla(int[,] m)
        {
            //lavoro su matrice quadrata
            bool esci = false;
            int i = 0, j = 0;
            int r = m.GetLength(0);

            while (!esci && i <= r - 1)
            {
                if (m[i, j] == 0)
                    proseguiVisitaMatrice(r, ref i, ref j);
                else
                    esci = true;
            }
            if (esci)
                Console.WriteLine("Matrice NON nulla");
            else
                Console.WriteLine("Matrice nulla");
        }

        private static void matriceTuttiElementiUguali(int[,] m)
        {
            bool esci = false;
            int x = m[0, 0];
            int i = 0, j = 1;
            int r = m.GetLength(0);
            int c = m.GetLength(1);

            while (!esci && i<=r-1)
            {
                if (m[i, j] == x)
                    proseguiVisitaMatrice(c, ref i, ref j);
                else
                    esci = true;
            }
            if (esci)
                Console.WriteLine("Matrice con elementi diversi");
            else
                Console.WriteLine("Matrice con elementi uguali");
        }

        private static void caricaCorniceSequenza(int[,] m)
        {
            int x = 1;
            int i, j;
            int r = m.GetLength(0);
            int c = m.GetLength(1);
            for (j = 0; j < c; j++)
                m[0, j] = x++;
            for (i = 1; i < r - 1; i++)
                m[i, c - 1] = x++;
            for (j = c - 1; j >= 0; j--)
                m[r - 1, j] = x++;
            for (i = r - 2; i >= 1; i--)
                m[i, 0] = x++;
        }

        private static void caricaMatriceSequenzaContraria(int[,] m)
        {
            int cont = m.Length;
            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++)
                    m[i, j] = cont--;
        }

        private static void caricaMatriceSequenza(int[,] m)
        {
            int cont = 1;
            for (int i = 0; i < m.GetLength(0); i++) 
                for (int j = 0; j < m.GetLength(1); j++) 
                    m[i, j] = cont++;
        }

        private static void caricaMatrice(int[,] m)
        {
            Random rnd = new Random();
            //i indice RIGHE, j indice COLONNE

            for (int i = 0; i < m.GetLength(0); i++) //ottengo numero righe
                for (int j = 0; j < m.GetLength(1); j++) //ottengo numero colonne
                    m[i, j] = rnd.Next(0, 2);
        }
        private static void stampaMatrice(int[,] m, string msg)
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

        private static double mediaMatrice(int[,] m)
        {
            double somma = 0;
            for (int i = 0; i < m.GetLength(0); i++) //scorro le righe
                for (int j = 0; j < m.GetLength(1); j++) //per ogni riga, scorro le colonne
                    somma += m[i, j];
            return somma / (m.GetLength(0) * m.GetLength(1));
        }
        private static int contaX(int[,] m)
        {
            int cont = 0;
            Console.Write("Inserisci x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++)
                    if (m[i, j] == x)
                        cont++;
            return cont;
        }

        private static int sommaColonnaJ(int[,] m)
        {
            int somma = 0;
            Console.Write("Inserisci il numero di colonna: ");
            int j = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < m.GetLength(0); i++)
                somma += m[i, j];
            return somma;
        }

        private static int sommaRigaI(int[,] m)
        {
            int somma = 0;
            Console.Write("Inserisci il numero di riga: ");
            int i = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < m.GetLength(1); j++)
                somma += m[i, j];
            return somma;
        }

        private static int sommaCornice(int[,] m)
        {
            int somma = 0;
            //sommo la 1^ e ultima riga
            for (int j = 0; j < m.GetLength(1); j++)
            {
                somma += m[0, j];
                somma += m[m.GetLength(0) - 1, j];
            }
            //sommo la 1^ e ultima colonna
            for (int i = 1; i < m.GetLength(0) - 1; i++)
            {
                somma += m[i, 0];
                somma += m[i, m.GetLength(1) - 1];
            }
            return somma;
        }

        private static int sommaDS(int[,] m)
        {
            //la matrice è quadrata
            int somma = 0;
            int j = m.GetLength(0) - 1;
            for (int i = 0; i < m.GetLength(0); i++)
                somma += m[i, j--];
            return somma;
        }

        private static int sommaDP(int[,] m)
        {
            //la matrice è quadrata
            int somma = 0;

            for (int i = 0; i < m.GetLength(0); i++)
                somma += m[i, i];
            return somma;
        }

        private static int maxMatrice(int[,] m)
        {
            int massimo = int.MinValue;
            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++)
                    if (m[i, j] > massimo)
                        massimo = m[i, j];
            return massimo;
        }

        

        

        
    }
}
