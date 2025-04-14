using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediateca
{
    public struct socio
    {
        public string codSocio;
        public string cognome;
        public string nome;
        public string email;
        public string telefono;
    }
    

    internal class clsSoci
    {
        public static socio[] soci = new socio[50];
        public static string[] datiSoci = new string[]
        {
            "s1,Rossi,Mario,mario@rossi.it,3246785431",
            "s2,Brambilla,Lorenzo,lorenzo@brambilla.it,3298765430",
            "s3,Bianchi,Roberta,roberta@bianchi.it,3476722198",
            "s4,Ferrero,Luigi,luigi@ferrero.it,3337651239",
            "s5,Montessori,Maria,maria@montessori.it,3270985632",
            "s6,Abate,Anna,anna@abate.it,3984560021",
            "s7,Pautasso,Giuseppe,giuseppe@pautasso.it,3126754492"
        };
        public static int nSoci;

        internal static void caricaSoci(DataGridView dgv)
        {
            caricaTabellaSoci();
            visualizzaTabellaSoci(dgv);
        }

        private static void visualizzaTabellaSoci(DataGridView dgv)
        {
            frmMain.settaDgv(dgv,"CODICE,COGNOME,NOME,EMAIL,TELEFONO");
            caricaDati(dgv);
        }

        private static void caricaDati(DataGridView dgv)
        {
            dgv.Rows.Clear();
            for (int i = 0; i < nSoci; i++)
            {
                dgv.Rows.Add(); 
                dgv.Rows[i].Cells[0].Value = soci[i].codSocio;
                dgv.Rows[i].Cells[1].Value = soci[i].cognome;
                dgv.Rows[i].Cells[2].Value = soci[i].nome;
                dgv.Rows[i].Cells[3].Value = soci[i].email;
                dgv.Rows[i].Cells[4].Value = soci[i].telefono;
            }
            //togliere riga vuota
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

        internal static void inserisciSocio(string cognome, string nome, string email, string telefono, DataGridView dgv)
        {
            string lastCode = soci[nSoci - 1].codSocio.Remove(0, 1);
            int newCode = Convert.ToInt32(lastCode) + 1;
            socio s = new socio();
            s.codSocio = "s"+newCode.ToString();
            s.cognome = cognome;
            s.nome = nome;
            s.email = email;
            s.telefono = telefono;
            soci[nSoci]=s;
            nSoci++;
            visualizzaTabellaSoci(dgv);

        }

        internal static void cancellaSocio(int indice, DataGridView dgv)
        {
            //uso una tabella locale in cui copio tutti i dati
            //dei soci tranne quello da cancellare
            socio[] newSoci= new socio[50];
            int j = 0;
            for (int i = 0; i < indice; i++)
                newSoci[j++] = soci[i];
            for (int i = indice+1;i<nSoci;i++)
                newSoci[j++]= soci[i];
            soci = newSoci;
            nSoci--;
            visualizzaTabellaSoci(dgv);
        }

        internal static void modificaSocio(string cognome,
            string nome,
            string email, 
            string telefono, 
            int indice, 
            DataGridView dgv)
        {
            soci[indice].cognome = cognome;
            soci[indice].nome = nome;
            soci[indice].email = email;
            soci[indice].telefono = telefono;
            visualizzaTabellaSoci(dgv);
        }
    }
}
