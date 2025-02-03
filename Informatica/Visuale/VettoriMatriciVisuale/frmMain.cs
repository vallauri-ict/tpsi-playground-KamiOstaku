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
        int[] a; 
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
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
    }
}
