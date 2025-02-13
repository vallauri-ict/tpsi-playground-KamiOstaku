using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic; //NotaBene

namespace VettoriMatriciVisuale
{
    public partial class frmMain : Form
    {
<<<<<<< HEAD
        public Random rnd = new Random();

        int[] a;
        int[,] m;
=======
        int[] a;
        int[] b;
        int[,] m;
        int[] addendo1;
        int[] addendo2;
        int[] somma;
>>>>>>> 728bc410fe387cd554330aa0bd1e7dbd5e4ba955
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            m = new int[5, 5];
            dataGridView2.RowCount = 5;
            dataGridView2.ColumnCount = 5;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.ColumnHeadersVisible = false;
            dataGridView2.AutoResizeColumns();
            dataGridView2.AutoResizeRows();

            int n = Convert.ToInt32(Interaction.InputBox("Inserisci la lunghezza del vettore"));
            settaDGV(dgvA, n);
            settaDGV(dgvMax, 3);
=======
            
            int n = Convert.ToInt32(Interaction.InputBox("Inserisci la lunghezza del vettore A"));
            settaDGV(dgvA, 1, n);
>>>>>>> 728bc410fe387cd554330aa0bd1e7dbd5e4ba955
            a = new int[n];
            clsVettori.caricaVettore(a, 1, 50);
            clsVettori.visualizzaVettore(a, dgvA);
            settaDGV(dgv3, 1, 3);
            settaDGV(dgv1Addendo, 1, 3);
            addendo1 = new int[3];
            clsVettori.caricaVettore(addendo1, 1, 9);
            clsVettori.visualizzaVettore(addendo1, dgv1Addendo);
            settaDGV(dgv2Addendo, 1, 3);
            addendo2 = new int[3];
            clsVettori.caricaVettore(addendo2,1,9);
            clsVettori.visualizzaVettore(addendo2, dgv2Addendo);
            settaDGV(dgvSomma, 1, 4);
            somma = new int[3];
            clsVettori.caricaVettore(somma, 0, 0);
            clsVettori.visualizzaVettore(somma, dgvSomma);

        }

        private void settaDGV(DataGridView dgv, int r, int c)
        {
            //vettore riga
            dgv.RowCount = r;
            dgv.ColumnCount = c;
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            dgv.AutoResizeColumns();
            dgv.AutoResizeRows();
            RandomLoadMatrix(m);
        }

        private void btnMaxVettore_Click(object sender, EventArgs e)
        {
            clsVettori.cercaMaxVettore(a);
        }

        private void btnCalcolaMediaVettore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La media del vettore è "
                + clsVettori.calcolaMediaVettore(a).ToString("F2"));
        }

        private void btnCercaElementoVettore_Click(object sender, EventArgs e)
        {
            int x=Convert.ToInt32(txtNumero.Text);

            clsVettori.cercaElementoVettore(a ,x);
            txtNumero.Text = null;
        }

        private void btnSpeulare_Click(object sender, EventArgs e)
        {
            clsVettori.verificaVettoreSpeculare(a);
        }

        private void btnPrimi3_Click(object sender, EventArgs e)
        {
            clsVettori.cercaPrimi3(a, dgv3);
        }

        private void btnSomma_Click(object sender, EventArgs e)
        {
            clsVettori.sommaVettori(addendo1, addendo2, dgvSomma);
        }

        private void btnIntersezione_Click(object sender, EventArgs e)
        {
            int m= Convert.ToInt32(Interaction.InputBox("Inserisci la lunghezza del vettore B"));
            settaDGV(dgvB, 1, m);
            b = new int[m];
            settaDGV(dgvIntersezione,1, m);
            clsVettori.caricaVettore(b , 1, 50);
            clsVettori.visualizzaVettore(b, dgvB);
            clsVettori.intersezione(a, b, dgvIntersezione);

        }

        private void btnUnione_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(Interaction.InputBox("Inserisci la lunghezza del vettore B"));
            settaDGV(dgvB, 1, m);
            b = new int[m];
            settaDGV(dgvUnione, 1, m + a.Length);
            clsVettori.caricaVettore(b, 1, 50);
            clsVettori.visualizzaVettore(b, dgvB);
            clsVettori.Unione(a, b, dgvUnione);
        }

        private void btnCaricaMatrice_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(Interaction.InputBox("Inserisci il numero di righe della matrice C"));
            int c = Convert.ToInt32(Interaction.InputBox("Inserisci il numero di colonne della matrice C"));
            m = new int[r, c];
            settaDGV(dgvC, r, c);
            clsMatrici.CaricaMatrice(m, 1, 10);
            clsMatrici.visualizzaMatrice(m,dgvC);
        }

        private void btnTuttiUguali_Click(object sender, EventArgs e)
        {
            //verificare se elementi tutti uguali
        }

        private void btnSommaSottoDP_Click(object sender, EventArgs e)
        {
            //somma elementi sotto DP matrice quadrata
        }

        private void btnColoraDP_Click(object sender, EventArgs e)
        {
            //in matrice quadrata
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SommaSottoDP(m);
            DispalayMatrix(m);
        }

        private void DispalayMatrix(int[,] m)
        {
            for(int i = 0;i< m.GetLength(0);i++)
            {
                for (int j = 0;j< m.GetLength(1);j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = m[i,j];
                }
            }
        }

        private void RandomLoadMatrix(int[,] m)
        {
            for(int i = 0;i< m.GetLength(0);i++)
            {
                for (int j = 0;j< m.GetLength(1);j++)
                {
                    m[i, j] = rnd.Next(0, 7);
                }
            }
        }

        private void SommaSottoDP(int[,] m)
        {
            int j = 0;
            int sum = 0;
            for(int i = 1;i< m.GetLength(0);i++)
            {
                sum+= m[i,j];
                dataGridView2.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                j++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int ii = 0; ii < m.GetLength(1); ii++)
                {
                    if (i % 2 == 0)
                    {
                        dataGridView2.Rows[i].Cells[ii].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        dataGridView2.Rows[i].Cells[ii].Style.ForeColor = Color.Red;
                    }

                    if (m[i,ii] == 6)
                    {
                        dataGridView2.Rows[i].Cells[ii].Style.ForeColor = Color.Green;
                    }
                }
            }
            DispalayMatrix(m);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(int i = 0;i< m.GetLength(0);i++)
            {
                for(int j = i+1; j<m.GetLength(1);j++)
                {
                    if (i % 2 == 0)
                    dataGridView2.Rows[i].Cells[j].Style.BackColor = Color.Blue;
                    else
                    dataGridView2.Rows[i].Cells[j].Style.BackColor = Color.Red;
                }
            }
            DispalayMatrix(m);
        }
    }
}
