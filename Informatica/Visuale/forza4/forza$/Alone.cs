using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forza_
{
    public partial class Alone : Form
    {
        int y = 0;
        char[,] m = new char[6, 7];
        bool gameMod;
        char turno = 'X';
        bool check = false;
        bool check2 = false;

        public Random rnd = new Random();
        public Alone(bool tipo)
        {
            InitializeComponent();
            gameMod = tipo;
        }

        private void posizionaPezzo(int y)
        {
            int i = 0;
            while(i<5 && m[i,y] == '\0')
            {
                if(m[i, y] != 'X' && m[i, y] != 'O')
                {
                    i++;
                }
                else
                {
                    i--;
                    break;
                }
            }
            if (i < 6 && i>=-1)
            {
                m[i, y] = turno;
                gameBoard.Rows[i].Cells[y].Value = turno;
                if (turno == 'X')
                {
                    gameBoard.Rows[i].Cells[y].Style.ForeColor = Color.Red;
                    turno = 'O';
                    check2 = true;
                    MessageBox.Show(gameBoard.Rows[i].Cells[y].Value.ToString());
                }
                else
                {
                    gameBoard.Rows[i].Cells[y].Style.ForeColor = Color.Green;
                    turno = 'X';
                }
                check = false;
            }
            else
            {
                check = true;
                if(gameMod)
                {
                    MessageBox.Show("Input non valido, non è stata contata la mossa");
                    check2 = false;
                }
            }
        }

        private bool winCondition()
        {
            MessageBox.Show("In implementazione");

            return false;
        }

        private void CreaGridView()
        {
            gameBoard.RowCount = 6;
            gameBoard.ColumnCount = 7;
            gameBoard.ColumnHeadersVisible = false;
            gameBoard.RowHeadersVisible = false;
            gameBoard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gameBoard.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void endGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hai deciso di fermare il gioco. Verrai riportato al menu principale");
            Hide();
            Form frmMain = new frmMain();
            frmMain.Show();
        }

        private void Alone_Load(object sender, EventArgs e)
        {
            CreaGridView();  
        }

        private void MossaPlayer(object sender, DataGridViewCellEventArgs e)
        {
            if(gameMod)
            {
                posizionaPezzo(e.ColumnIndex);

                if(check2)
                {
                    do
                    {
                        posizionaPezzo(rnd.Next(0, 7));
                    } while (check);
                    check = false;
                }
            }
            else
            {
                posizionaPezzo(e.ColumnIndex);
            }

            winCondition();
            check2 = false;
        }

        private void Attesa()
        {

        }
    }
}
