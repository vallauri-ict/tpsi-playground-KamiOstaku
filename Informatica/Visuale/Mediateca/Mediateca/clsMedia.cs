using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Mediateca
{
    public struct media
    {
        public string codMedia;
        public string titolo;
        public string autore;
        public string tipo;
        public string genere;
        public bool isInPrestito;
    }
    internal class clsMedia
    {
        public static media[] medias = new media[50];
        public static string[] datiMedia = new string[]
        {
            "m1,La Volpe,Pasolini,Libro,Narrativa,false",
            "m2,La Farfalla,Manzoni,Libro,Saggio,false",
            "m3,La Balena,Manzoni,DVD,Avventura,false",
            "m4,Il Lupo,Verga,DVD,Avventura,false",
            "m5,La Gallina,Dante,Libro,Narrativa,false",
            "m6,Il Gallo,Pasolini,CD,Gioco,false",
            "m7,La Faina,Dante,CD,Gioco,false",
        };

        public static int nMedia;


        internal static void caricaMedia(DataGridView dgv)
        {
            caricaTabellaMedia();
            visualizzaTabellaMedia(dgv);
        }

        private static void visualizzaTabellaMedia(DataGridView dgv)
        {
            frmMain.settaDgv(dgv, "CODICE,TITOLO,AUTORE,TIPO,GENERE,InPRESTITO");
            caricaDati(dgv);
        }

        private static void caricaDati(DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < nMedia; i++)
            {
                dgv.Rows.Add(); 
                dgv.Rows[i].Cells[0].Value = medias[i].codMedia;
                dgv.Rows[i].Cells[1].Value = medias[i].titolo;
                dgv.Rows[i].Cells[2].Value = medias[i].autore;
                dgv.Rows[i].Cells[3].Value = medias[i].tipo;
                dgv.Rows[i].Cells[4].Value = medias[i].genere;
                dgv.Rows[i].Cells[5].Value = medias[i].isInPrestito;
            }
            //togliere riga vuota
        }


        private static void caricaTabellaMedia()
        {
            for (int i = 0; i < datiMedia.Length; i++)
            {
                string[] dati = datiMedia[i].Split(',');
                medias[i].codMedia = dati[0];
                medias[i].titolo = dati[1];
                medias[i].autore = dati[2];
                medias[i].tipo = dati[3];
                medias[i].genere = dati[4];
                medias[i].isInPrestito = Convert.ToBoolean(dati[5]);
            }
            nMedia = datiMedia.Length;
        }

        internal static void ordinaMediaTipo()
        {
            //ordinamento per selezione
            int posmin;
            int n = nMedia;

            for (int i = 0; i <= n - 2; i++)
            {
                posmin = i;
                for (int j = i + 1; j <= n - 1; j++)
                {
                   
                    if (medias[posmin].tipo.CompareTo(medias[j].tipo) > 0)
                        posmin = j;
                }
                if (i != posmin)
                    scambioRecord(ref medias[i], ref medias[posmin]);
            }
        }
        private static void scambioRecord(ref media media1, ref media media2)
        {
            media aus;

            aus = media1;
            media1 = media2;
            media2 = aus;
        }

        internal static void ordinaMediaGenere()
        {
            //ordinamento per selezione
            int posmin;
            int n = nMedia;

            for (int i = 0; i <= n - 2; i++)
            {
                posmin = i;
                for (int j = i + 1; j <= n - 1; j++)
                {

                    if (medias[posmin].genere.CompareTo(medias[j].genere) > 0)
                        posmin = j;
                }
                if (i != posmin)
                    scambioRecord(ref medias[i], ref medias[posmin]);
            }
        }

        internal static void inserisciMedia(string titolo, string autore, string tipo, string genere, DataGridView dgv)
        {
            string lastCode = medias[nMedia - 1].codMedia.Remove(0, 1);
            int newCode = Convert.ToInt32(lastCode) + 1;
            media m = new media();
            m.codMedia = "m" + newCode.ToString();
            m.titolo = titolo;
            m.autore = autore;
            m.tipo = tipo;
            m.genere = genere;
            medias[nMedia] = m;
            nMedia++;
            visualizzaTabellaMedia(dgv);
        }

        internal static void cancellaMedia(int indice, DataGridView dgv)
        {
            //uso una tabella locale in cui copio tutti i dati
            //dei media tranne quello da cancellare
            media[] newMedias = new media[50];
            int j = 0;
            for (int i = 0; i < indice; i++)
                newMedias[j++] = medias[i];
            for (int i = indice + 1; i < nMedia; i++)
                newMedias[j++] = medias[i];
            medias = newMedias;
            nMedia--;
            visualizzaTabellaMedia(dgv);
        }

        internal static void modificaMedia(string titolo, string autore, string tipo, string genere, int indice, DataGridView dgv)
        {
            medias[indice].titolo = titolo;
            medias[indice].autore = autore;
            medias[indice].tipo = tipo;
            medias[indice].genere = genere;
            visualizzaTabellaMedia(dgv);
        }

        internal static void assegnaPrestito(string codMedia, DataGridView dgv)
        {
            int i = 0;

            while (medias[i].codMedia != codMedia)
            {
                i++;
            }
            medias[i].isInPrestito = true;
            visualizzaTabellaMedia(dgv);
        }
    }
}
