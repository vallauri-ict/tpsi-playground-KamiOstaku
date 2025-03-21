using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mediateca.clsMedia;
using System.Windows.Forms;

namespace Mediateca
{
    internal class clsOperazioni
    {
        public struct operazione
        {
            public string codOperazione;
            public string codMedia;
            public string codSocio;
            public DateTime dataPrelievo;
            public DateTime dataRestituzione;
        }

        public static operazione[] operazioni = new operazione[50];
        public static string[] datiOperazioni = new string[]
        {
            "o1,m3,s2,20220415,20220510",
            "o2,m7,s6,20220412,2022051",
            "o3,m2,s1,20220411,20220509",
            "o4,m1,s7,20220415,20220511",
            "o5,m5,s3,20220414,20220512",
            "o6,m4,s5,20220412,20220512",
            "o7,m6,s4,20220413,20220509",
        };

        public static int nOperazioni;

        internal static void caricaOperazioni(DataGridView dgv)
        {
            caricaTabellaOperazioni();
            visualizzaTabellaOperazioni(dgv);
        }

        private static void visualizzaTabellaOperazioni(DataGridView dgv)
        {
            settaDgv(dgv, "codOperazione,codMedia,codSocio,dataPrelievo,dataRestituzione");
            caricaDati(dgv);
        }

        private static void caricaDati(DataGridView dgv)
        {
            for (int i = 0; i < nOperazioni; i++)
            {
                //Se Si vuole avere la riga vuota alla fine rimuovere la if
                //In caso di cambiamento della struct si ricordi di aumentare anche nMedia altrimenti non verrà modificata la dgv

                if (i < nOperazioni - 1)
                {
                    dgv.Rows.Add();
                }

                //Notare che nelle parentesi di ToString si mette: "dd/MM/yyyy" per dire al programma che vuoi che ti vengano restituita solo e soltanto
                //la data senza orario

                dgv.Rows[i].Cells[0].Value = operazioni[i].codOperazione.ToString();
                dgv.Rows[i].Cells[1].Value = operazioni[i].codMedia.ToString();
                dgv.Rows[i].Cells[2].Value = operazioni[i].codSocio.ToString();
                dgv.Rows[i].Cells[3].Value = operazioni[i].dataPrelievo.ToString("dd/MM/yyyy");
                dgv.Rows[i].Cells[4].Value = operazioni[i].dataRestituzione.ToString("dd/MM/yyyy");
            }
        }

        private static void settaDgv(DataGridView dgv, string intestazione)
        {
            dgv.ColumnCount = 5;
            dgv.RowHeadersVisible = false;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            string[] dati = intestazione.Split(',');

            for (int i = 0; i < dati.Length; i++)
            {
                dgv.Columns[i].HeaderText = dati[i];
            }
        }

        private static void caricaTabellaOperazioni()
        {
            /*  Si usa substring perché credo sia l'unico metodo per separare la data visto che ha un numero fisso di numeri
             *  Si consideri anche che la substring viene convertita ad int poiché new DataTime() richiede Parametri Attuali di tipo Int
             */

            /*    -- NOTA BENE --
             *    
             *    Considera che substring ha come parametri Indice di inizio e lunghezza
             *    nell'ultimo caso non è necessaria la lunghezza perché se non indicata procede fino alla fine
             */

            //I campi della struct accettano il tipo DateTime visto che sono di quel tipo anche essi

            string[] aux;
            DateTime auxTime;

            for (int i = 0; i < datiOperazioni.Length; i++)
            {
                aux = datiOperazioni[i].Split(',');
                auxTime = new DateTime(int.Parse(aux[3].Substring(0, 4)), int.Parse(aux[3].Substring(4, 2)), int.Parse(aux[3].Substring(6)));


                operazioni[i].codOperazione = aux[0];
                operazioni[i].codMedia = aux[1];
                operazioni[i].codSocio = aux[2];
                operazioni[i].dataPrelievo = auxTime;

                auxTime = new DateTime(int.Parse(aux[4].Substring(0, 4)), int.Parse(aux[4].Substring(4, 2)), int.Parse(aux[4].Substring(6)));

                operazioni[i].dataRestituzione = auxTime;
            }
            nOperazioni = datiOperazioni.Length;
        }
    }
}



