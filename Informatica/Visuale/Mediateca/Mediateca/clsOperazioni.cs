using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediateca
{
    public struct operazione
    {
        public string codOperazione;
        public string codMedia; //chiave esterna
        public string codSocio; //chiave esterna
        public string dataPrestito;
        public string dataRestituzione;
    }

    internal class clsOperazioni
    {
        public static operazione[] operazioni = new operazione[50];
        public static string[] datiOperazioni = new string[]
        {
            "o1,m3,s2,07/10/2025,10/10/2025",
            "o2,m7,s6,08/10/2025,10/10/2025",
            "o3,m2,s1,10/10/2025,11/10/2025",
            "o4,m1,s7,10/10/2025,11/10/2025",
            "o5,m5,s3,10/10/2025,11/10/2025",
            "o6,m4,s5,10/10/2025,13/10/2025",
            "o7,m6,s4,11/10/2025,13/10/2025",
        };
        public static int nOperazioni;

        internal static void caricaOperazioni(DataGridView dgv)
        {
            caricaTabellaOperazioni();
            visualizzaTabellaOperazioni(dgv);
        }

        private static void visualizzaTabellaOperazioni(DataGridView dgv)
        {
            frmMain.settaDgv(dgv, "CODICE OPERAZIONE,CODICE MEDIA,CODICE SOCIO," +
                "DATA PRESTITO,DATA RESTITUZIONE");
            caricaDati(dgv);
        }

        private static void caricaDati(DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < nOperazioni; i++)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = operazioni[i].codOperazione;
                dgv.Rows[i].Cells[1].Value = operazioni[i].codMedia;
                dgv.Rows[i].Cells[2].Value = operazioni[i].codSocio;
                dgv.Rows[i].Cells[3].Value = operazioni[i].dataPrestito;
                dgv.Rows[i].Cells[4].Value = operazioni[i].dataRestituzione;
            }
            //togliere riga vuota
        }

        private static void caricaTabellaOperazioni()
        {
            for (int i = 0; i < datiOperazioni.Length; i++)
            {
                string[] dati = datiOperazioni[i].Split(',');
                operazioni[i].codOperazione = dati[0];
                operazioni[i].codMedia = dati[1];
                operazioni[i].codSocio = dati[2];
                operazioni[i].dataPrestito = dati[3];
                operazioni[i].dataRestituzione = dati[4];
            }
            nOperazioni = datiOperazioni.Length;
        }

        internal static void popolaCmbMedia(ComboBox cmb, media[] medias, int n)
        {
            cmb.DisplayMember = "Text";
            cmb.ValueMember = "Value";
            List<object> items = new List<object>();
            for (int i = 0; i < n; i++)
            {
                //seleziono solo i libri che non sono ancora in prestito
                if (!medias[i].isInPrestito)
                {
                    items.Add(new
                    {
                        Text = medias[i].titolo,
                        Value = medias[i].codMedia
                    });
                }
            }
            cmb.DataSource = items;
        }

        internal static void popolaCmbSocio(ComboBox cmb, socio[] soci, int nSoci)
        {
            cmb.DisplayMember = "Text";
            cmb.ValueMember = "Value";
            List<object> items = new List<object>();
            for (int i = 0; i < nSoci; i++)
            {
                 items.Add(new
                 {
                        Text = soci[i].cognome + " " + soci[i].nome,
                        Value = soci[i].codSocio
                 });
            }
            cmb.DataSource = items;
        }

        internal static void inserisciPrestito(string codSocio, string codMedia, DataGridView dgvMedia, DataGridView dgvOperazioni)
        {
            string lastCode = operazioni[nOperazioni - 1].codOperazione.Remove(0, 1);
            int newCode = Convert.ToInt32(lastCode) + 1;
            operazione o = new operazione();

            o.codOperazione = $"o{newCode}";
            o.codMedia = codMedia;
            o.codSocio = codSocio;
            o.dataPrestito = DateTime.Now.ToString("dd/MM/yyyy");
            o.dataRestituzione = "";
            operazioni[nOperazioni] = o;
            nOperazioni++;

            visualizzaTabellaOperazioni(dgvOperazioni);
            clsMedia.assegnaPrestito(codMedia,dgvMedia);
        }

        internal static void cancellaPrestito(int indice,DataGridView dgv)
        {
            if (clsMedia.medias[indice].isInPrestito == true)
            {
                operazioni[indice].dataRestituzione = DateTime.Now.ToString("dd/MM/yyyy");
                clsMedia.medias[indice].isInPrestito = false;
                visualizzaTabellaOperazioni(dgv);
            }
            else
            {
                MessageBox.Show("Media già restituito","ATTENZIONE",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
