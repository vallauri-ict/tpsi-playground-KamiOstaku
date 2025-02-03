using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroElettronico
{
    public partial class frmMain : Form
    {
        static Random rnd = new Random();
        public frmMain()
        {
            InitializeComponent();
        }

        string[] cognomi = { "Barberis", "Bedreag", "Cambieri", "Cane", "Casalis", "Cebotari", "Dellaferrera", "Ferrero", "Francavilla", "Gatto", "Genta", "Ingaramo", "Manunta", "Marciuc", "Milojkov", "Monte", "Oricco", "Ressia", "Revello", "Riso", "Roveta", "Salinitri", "Ufe" };
        string[] nomi = { "Lorenzo", "Cosmin Andrei", "Luca", "Mattia", "Cristopher", "Maxim", "Miriam", "Valentino", "Andrea", "Nicolò", "Stefano", "Gabriele", "Gabriele", "Robert Stefan", "Nikola", "Loris", "Giacomo", "Sofia", "Iacopo", "Carlo", "Riccardo", "Mattia", "Elio" };
        string[] materie = { "Matematica", "Italiano", "TPSI", "Storia", "Telecomunicazioni", "Sistemi e Reti", "Inglese", "Informatica" };
        int[,] voti;

        private void frmMain_Load(object sender, EventArgs e)
        {
            GridReset();
            GradesGenerator(voti);
            MediaCalculator(voti);
            ClassStatus(voti);
            DebtFix(voti);
        }

        private void DebtFix(int[,] voti)
        {
            int gradeChecker;
            int j;
            string aux;
            for (int i = 0; i < voti.GetLength(0); i++)
            {
                gradeChecker = 0;
                j = 0;
                aux = "";
                if(grid.Rows[i].Cells[voti.GetLength(1) + 1].Value == "Rimandato")
                {
                    while(gradeChecker != 4 && j < voti.GetLength(1))
                    {
                        if (voti[i, j] < 6)
                        {
                            gradeChecker++;
                            aux += materie[j] + " ";
                        }
                        j++;
                    }
                    grid.Rows[i].Cells[voti.GetLength(1) + 2].Value = aux;
                }
            }
        }

        private void ClassStatus(int[,] voti)
        {
            int grades;
            int j;
            for (int i = 0; i < voti.GetLength(0); i++)
            {
                grades = 0;
                j = 0;
                while(grades <= 3 && j < voti.GetLength(1))
                {
                    if (voti[i, j] < 6)
                    {
                        grades++;
                    }
                    j++;
                }
                if(grades > 3)
                {
                    grid.Rows[i].Cells[voti.GetLength(1)+1].Style.ForeColor = Color.Red;
                    grid.Rows[i].Cells[voti.GetLength(1) + 1].Value = "Bocciato";
                }
                else if(grades >= 1)
                {
                    grid.Rows[i].Cells[voti.GetLength(1) + 1].Style.ForeColor = Color.DarkKhaki;
                    grid.Rows[i].Cells[voti.GetLength(1) + 1].Value = "Rimandato";
                } 
                else
                {
                    grid.Rows[i].Cells[voti.GetLength(1) + 1].Style.ForeColor = Color.Green;
                    grid.Rows[i].Cells[voti.GetLength(1) + 1].Value = "Promosso";
                }
                
            }
        }

        private void MediaCalculator(int[,] voti)
        {
            float media;
            for (int i = 0; i < voti.GetLength(0); i++)
            {
                media = 0;
                for (int j = 0; j < voti.GetLength(1); j++)
                {
                    media += voti[i, j];
                }

                media = media / 8;
                grid.Rows[i].Cells[voti.GetLength(1)].Value = media.ToString("F2");

                if (media < 6)
                {
                    grid.Rows[i].Cells[voti.GetLength(1)].Style.ForeColor = Color.Red;
                }
                else if (media == 6)
                {
                    grid.Rows[i].Cells[voti.GetLength(1)].Style.ForeColor = Color.DarkKhaki;
                }
                else
                {
                    grid.Rows[i].Cells[voti.GetLength(1)].Style.ForeColor = Color.Green;
                }
            }
        }

        private void GradesGenerator(int[,] voti)
        {
            for (int i = 0; i < voti.GetLength(0); i++)
            {
                for (int j = 0; j < voti.GetLength(1); j++)
                {
                    voti[i, j] = rnd.Next(3, 11);
                    if (voti[i, j] < 6)
                    {
                        grid.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    }
                    else if (voti[i,j] == 6)
                    {
                        grid.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                    }
                    else
                    {
                        grid.Rows[i].Cells[j].Style.BackColor = Color.Green;
                    }
                    grid.Rows[i].Cells[j].Value = voti[i, j];
                }
            }
        }

        private void GridReset()
        {
            voti = new int[cognomi.Length, materie.Length];
            grid.RowCount = voti.GetLength(0);
            grid.ColumnCount = voti.GetLength(1)+3;
            grid.ReadOnly = true;
            int i;

            for (i = 0; i < materie.Length; i++)
            {
                grid.Columns[i].HeaderText = materie[i];
            }
            grid.Columns[i++].HeaderText = "MEDIA";
            grid.Columns[i++].HeaderText = "ESITO";
            grid.Columns[i].HeaderText = "RECUPERO";
            for (i = 0; i < cognomi.Length; i++)
            {
                grid.Rows[i].HeaderCell.Value = cognomi[i];
            }

            grid.ClearSelection();
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
        }

        private void MediaColonna_Click(object sender, EventArgs e)
        {
            int j = 0;
            float media = 0;

            while (selector.Text != materie[j])
            {
                j++;
            }

            for(int i = 0; i < voti.GetLength(0); i++)
            {
                media += voti[i,j];
            }

            MessageBox.Show($"La media della materia {materie[j]} è: {(media/cognomi.Length).ToString("F2")}");
        }
    }
}
