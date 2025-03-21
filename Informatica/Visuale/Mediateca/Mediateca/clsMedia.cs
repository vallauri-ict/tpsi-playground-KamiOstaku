using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediateca
{
    internal class clsMedia
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

        public static media[] medias = new media[50];

        public static string[] datiMedia = new string[]
        {
            "m1,La Volpe, Pasolini, Libro, Narrativa,false",
            "m2,La Farfalla, Manzoni, Libro, Saggio,false",
            "m3,La Balena, Manzoni, DVD, Avventura,false",
            "m4,Il Lupo, Verga, DVD, Avventura,false",
            "m5,La Gallina, Dante, Libro, Narrativa,false",
            "m6,Il Gallo, Pasolini, CD, Gioco,false",
            "m7,La Faina, Dante, CD, Gioco,false",
        };

        public static int nMedia;

        internal static void caricaMedia(DataGridView dgv)
        {
            caricaTabellaMedia();
            visualizzaTabellaMedia(dgv);
        }

        private static void visualizzaTabellaMedia(DataGridView dgv)
        {
            settaDgv(dgv, "CODICE,TITOLO,AUTORE,TIPO,GENERE,PRESTITO");
            caricaDati(dgv);
        }

        private static void caricaDati(DataGridView dgv)
        {
            for (int i = 0; i < nMedia; i++)
            {
                //Se Si vuole avere la riga vuota alla fine rimuovere la if
                //In caso di cambiamento della struct si ricordi di aumentare anche nMedia altrimenti non verrà modificata la dgv

                if (i < nMedia-1)
                {
                    dgv.Rows.Add();
                }
                
                dgv.Rows[i].Cells[0].Value = medias[i].codMedia.ToString();
                dgv.Rows[i].Cells[1].Value = medias[i].titolo.ToString();
                dgv.Rows[i].Cells[2].Value = medias[i].autore.ToString();
                dgv.Rows[i].Cells[3].Value = medias[i].tipo.ToString();
                dgv.Rows[i].Cells[4].Value = medias[i].genere.ToString();
                dgv.Rows[i].Cells[5].Value = medias[i].isInPrestito.ToString();
            }
        }

        private static void settaDgv(DataGridView dgv, string intestazione)
        {
            dgv.ColumnCount = 6;
            dgv.RowHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            string[] dati = intestazione.Split(',');

            for (int i = 0; i < dati.Length; i++)
            {
                dgv.Columns[i].HeaderText = dati[i];
            }
        }

        private static void caricaTabellaMedia()
        {
            string[] aux;

            for (int i = 0; i < datiMedia.Length; i++)
            {
                aux = datiMedia[i].Split(',');

                medias[i].codMedia = aux[0];
                medias[i].titolo = aux[1];
                medias[i].autore = aux[2];
                medias[i].tipo = aux[3];
                medias[i].genere = aux[4];
                medias[i].isInPrestito = bool.Parse(aux[5]);
            }
            nMedia = datiMedia.Length;
        }
    }
}
