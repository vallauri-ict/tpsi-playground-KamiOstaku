using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mediateca.clsSoci;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Mediateca
{
    internal class clsSoci
    {
        public struct Socio
        {
            public string codSocio;
            public string cognome;
            public string nome;
            public string email;
            public string telefono;
        }
        public static Socio[] soci = new Socio[50];
        public static string[] datiSoci = new string[]
        {
            "s1,Rossi,Mario,mario @rossi.it,3246785431",
            "s2,Brambilla,Lorenzo,lorenzo @brambilla.it,3298765430",
            "s3,Bianchi,Roberta,roberta @bianchi.it,3476722198",
            "s4,Ferrero,Luigi,luigi @ferrero.it,3337651239",
            "s5,Montessori,Maria,maria @montessori.it,3270985632",
            "s6,Abate,Anna,anna @abate.it,3984560021",
            "s7,Pautasso,Giuseppe,giuseppe @pautasso.it,3126754492",
        };

        public static int nSoci;

        internal static void caricaSoci(DataGridView dgvSoci)
        {
            caricaTabellaSoci();
            visualizzaTabellaSoci(dgvSoci);
        }

        private static void visualizzaTabellaSoci(DataGridView dgvSoci)
        {
            setDgv(dgvSoci);
            caricaDati(dgvSoci);
        }

        private static void caricaDati(DataGridView dgvSoci)
        {
            dgvSoci.Rows.Clear();

            for (int i = 0; i < nSoci; i++) 
            {
                if (i < nSoci - 1)
                {
                    dgvSoci.Rows.Add();
                }

                dgvSoci.Rows[i].Cells[0].Value = soci[i].codSocio;
                dgvSoci.Rows[i].Cells[1].Value = soci[i].cognome;
                dgvSoci.Rows[i].Cells[2].Value = soci[i].nome;
                dgvSoci.Rows[i].Cells[3].Value = soci[i].email;
                dgvSoci.Rows[i].Cells[4].Value = soci[i].telefono;
            }
        }

        private static void setDgv(DataGridView dgvSoci)
        {
            dgvSoci.ColumnCount = 5;
            dgvSoci.RowHeadersVisible = false;
            dgvSoci.ScrollBars = ScrollBars.Vertical;

            dgvSoci.Columns[0].HeaderText = "Codice";
            dgvSoci.Columns[1].HeaderText = "Cognome";
            dgvSoci.Columns[2].HeaderText = "Nome";
            dgvSoci.Columns[3].HeaderText = "Email";
            dgvSoci.Columns[4].HeaderText = "Telefono";

            dgvSoci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private static void caricaTabellaSoci()
        {
            for (int i = 0; i < datiSoci.Length; i++)
            {
                string[] dati = datiSoci[i].Split(',');

                soci[i].codSocio = dati[0];
                soci[i].cognome = dati[1];
                soci[i].nome = dati[2];
                soci[i].email = dati[3];
                soci[i].telefono = dati[4];
            }
            nSoci = datiSoci.Length;
        }

        internal static void AddSocio(DataGridView dgvSoci, string text1, string text2, string text3, string text4)
        {   
            aggiornaStruct(text1,text2,text3,text4);
            
            aggiornaDgv(dgvSoci);
        }

        private static void aggiornaDgv(DataGridView dgvSoci)
        {
            dgvSoci.Rows.Add();

            int x = dgvSoci.Rows.Count - 1;

            dgvSoci.Rows[x].Cells[1].Value = soci[nSoci - 1].cognome;
            dgvSoci.Rows[x].Cells[2].Value = soci[nSoci - 1].nome;
            dgvSoci.Rows[x].Cells[3].Value = soci[nSoci - 1].email;
            dgvSoci.Rows[x].Cells[4].Value = soci[nSoci - 1].telefono;

        }

        private static void aggiornaStruct(string text1, string text2, string text3, string text4)
        {
            soci[nSoci].cognome = text1;
            soci[nSoci].nome = text2;
            soci[nSoci].email = text3;
            soci[nSoci].telefono = text4;
            nSoci++;
        }
    }

}

