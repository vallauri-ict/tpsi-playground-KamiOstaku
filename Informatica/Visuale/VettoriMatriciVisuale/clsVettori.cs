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

        internal static void caricaVettore(int[] v)
        {
            for (int i = 0; i < v.Length; i++) 
                v[i]=rnd.Next(1,10);
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
