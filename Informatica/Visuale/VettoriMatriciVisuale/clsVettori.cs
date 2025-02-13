using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VettoriMatriciVisuale
{
    internal class clsVettori
    {
        static Random rnd=new Random();

        internal static double calcolaMediaVettore(int[] v)
        {
            double somma = 0;
            for (int i = 0; i < v.Length; i++)
                somma += v[i];
            return somma/v.Length;
        }

        internal static void caricaVettore(int[] v, int min, int max)
        {
            for (int i = 0; i < v.Length; i++) 
                v[i]=rnd.Next(min,max+1);
        }

        internal static void cercaElementoVettore(int[] v, int x)
        {
            int i = 0;
            while (v[i]!=x && i!=v.Length-1)
                i++;
            if (v[i] == x)
                MessageBox.Show("Ho trovato l'elemento");
            else
                MessageBox.Show("Elemento non trovato");
        }

        internal static void cercaMaxVettore(int[] v)
        {
            int max = int.MinValue;
            for (int i = 0; i < v.Length; i++)
                if (v[i] > max)
                    max = v[i];
            MessageBox.Show("Il max del vettore è: " + max.ToString());
        }

        internal static void cercaPrimi3(int[] v, DataGridView dgv)
        {
            int p=0,s=0,t=0;

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i]>p)
                {
                    t = s;
                    s = p;
                    p = v[i];
                }
                else
                {
                    if (v[i]>s)
                    {
                        t = s;
                        s = v[i];
                    }
                    else
                    {
                        if (v[i]>t)
                            t= v[i];
                    }
                }
            }
            dgv.Rows[0].Cells[0].Value = p;
            dgv.Rows[0].Cells[1].Value = s;
            dgv.Rows[0].Cells[2].Value = t;
        }

        internal static void intersezione(int[] a, int[] b, DataGridView dgvIntersezione)
        {
            int j;
            int k = 0; //indice datagridview
            for (int i = 0;i < a.Length; i++)
            {
                j = 0;
                while (b[j] != a[i] && j != b.Length - 1)
                    j++;
                if (b[j] == a[i])
                {
                    dgvIntersezione.Rows[0].Cells[k].Value = a[i].ToString();
                    k++;
                }
                    
            }
        }

        internal static void sommaVettori(int[] a, int[] b, DataGridView dgv)
        {
            int riporto = 0;
            int somma;
            for (int i = a.Length - 1; i >= 0; i--)
            {
                somma = a[i] + b[i] + riporto;
                if(somma > 9)
                {
                    riporto = 1;
                    dgv.Rows[0].Cells[i+1].Value = (somma - 10).ToString();
                }
                else
                {
                    riporto = 0;
                    dgv.Rows[0].Cells[i+1].Value = somma.ToString();
                }
            }
            dgv.Rows[0].Cells[0].Value = riporto.ToString();


        }

        internal static void Unione(int[] a, int[] b, DataGridView dgv)
        {
            int i;
            for (i = 0; i < a.Length; i++)
                dgv.Rows[0].Cells[i].Value = a[i].ToString();
            int pos = i;
            
            for (int j = 0; j < b.Length; j++)
            {
                i = 0;
                while (b[j] != a[i] && i != a.Length - 1)
                    i++;
                if (b[j] != a[i])
                    dgv.Rows[0].Cells[pos++].Value = b[j].ToString();
            }
            dgv.AutoResizeColumns();
        }

        internal static void verificaVettoreSpeculare(int[] v)
        {
            int i = 0;
            int j=v.Length-1;

            while (v[i] == v[j] && i!=v.Length/2)
            {
                i++;
                j--;
            }
            if (v[i] == v[j])
                MessageBox.Show("Vettore speculare");
            else
                MessageBox.Show("Vettore NON speculare");
        }

        internal static void visualizzaVettore(int[] v, DataGridView dgv)
        {
            for(int j = 0;j < v.Length;j++)
                dgv.Rows[0].Cells[j].Value = v[j].ToString();
            dgv.AutoResizeColumns();
            dgv.AutoResizeRows();
        }
    }
}
