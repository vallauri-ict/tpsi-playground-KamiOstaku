using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace GetioneTabella3B
{
    public partial class frmMain : Form
    {
        static Random rnd = new Random();
        public struct studente
        {
            public int matricola;
            public string cognome;
            public string nome;
            public string classe;
        }
        int ns; //numero studenti
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCaricaTabellaStudenti_Click(object sender, EventArgs e)
        {
            if (!(int.TryParse(Interaction.InputBox("Inserisci il numero di studenti:"), out ns) && ns > 0))
                MessageBox.Show("Devi inserire un valore positivo");
            studente[] studenti = new studente[ns];
            settaDgv(dgvStudenti, ns, 4);
            int x=rnd.Next(1,1000);
            for (int i = 0; i < studenti.Length; i++)
            {
                studenti[i].matricola = x + rnd.Next(1, 10);
                studenti[i].cognome = Interaction.InputBox("Inserisci il cognome");
                studenti[i].nome = Interaction.InputBox("Inserisci il nome");
                studenti[i].classe = Interaction.InputBox("Inserisci la classe");
            }

          
        }

        private void settaDgv(DataGridView dgv, int r, int c)
        {
            dgv.RowCount = r;
            dgv.ColumnCount = c;
            dgv.ClearSelection();
            dgv.RowHeadersVisible=false;
            intestaTabella(dgvStudenti, c, "MATRICOLA,COGNOME,NOME,CLASSE");
            


        }

        private void intestaTabella(DataGridView dgv, int c, string msg)
        {
            string[] v=new string[c];
            v=msg.Split(',');
            for (int j = 0; j < c; j++)
                dgv.Columns[j].HeaderText = v[j];
        }
    }
}
