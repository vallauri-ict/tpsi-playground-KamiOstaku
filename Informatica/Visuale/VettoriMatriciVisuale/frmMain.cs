using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic; //NotaBene

namespace VettoriMatriciVisuale
{
    public partial class frmMain : Form
    {
        public Random rnd = new Random();

        int[] a;
        int[,] m;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
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
            a = new int[n];
            clsVettori.caricaVettore(a);
            clsVettori.visualizzaVettore(a, dgvA);

        }

        private void settaDGV(DataGridView dgv, int n)
        {
            //vettore riga
            dgv.RowCount = 1;
            dgv.ColumnCount = n;
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

        private void findMax_Click(object sender, EventArgs e)
        {
            int first = 0, second = 0, third = 0;
            for(int i = 0; i< a.Length; i++) 
            { 
                if(first < a[i])
                {
                    third = second;
                    second = first;
                    first = a[i];
                }
                else if(second < a[i]) 
                {
                    third = second;
                    second = a[i];
                }
                else if(third < a[i])
                {
                    third = a[i];
                }
            }

            dgvMax.Rows[0].Cells[0].Value = first.ToString();
            dgvMax.Rows[0].Cells[1].Value = second.ToString();
            dgvMax.Rows[0].Cells[2].Value = third.ToString();
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
