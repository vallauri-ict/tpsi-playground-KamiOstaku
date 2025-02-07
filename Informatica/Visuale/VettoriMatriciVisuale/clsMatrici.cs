using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VettoriMatriciVisuale
{
    internal class clsMatrici
    {
        static Random rnd= new Random();
        internal static void CaricaMatrice(int[,] m, int min, int max)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                    m[i,j]=rnd.Next(min, max +1);
            }
        }

        internal static void visualizzaMatrice(int[,] m, DataGridView dgv)
        {
            for (int i = 0; i < m.GetLength(0); i++)
                for (int j = 0; j < m.GetLength(1); j++)
                    dgv.Rows[i].Cells[j].Value= m[i,j].ToString();
            dgv.AutoResizeColumns();
            dgv.AutoResizeRows();
        }
    }
}
