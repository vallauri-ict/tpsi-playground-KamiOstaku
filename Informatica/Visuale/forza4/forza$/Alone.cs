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
        int[,] m = new int[7, 6];
        bool gameMod;
        public Random rnd = new Random();
        public Alone(bool tipo)
        {
            InitializeComponent();
            gameMod = tipo;
        }

        private void posizionaPezzo(char turn)
        {
            int i = 0;
            while(i<7 && m[i,y] == 0)
            {
                i++;
            }
            if (i < 7)
            {
                m[i, y] = turn;
                gameBoard.Rows[i].Cells[y].Value = turn;
                if (turn == 'X')
                {
                    gameBoard.Rows[i].Cells[y].Style.ForeColor = Color.Red;
                    turn = 'O';
                }
                else
                {
                    gameBoard.Rows[i].Cells[y].Style.ForeColor = Color.Yellow;
                    turn = 'X';
                }
            }
            else
            {
                MessageBox.Show("Input non valido, non è stata contata la mossa");
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

        private void gameBoard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            y = e.RowIndex;
        }

        private void Alone_Load(object sender, EventArgs e)
        {
            CreaGridView();
            if (gameMod)
            {
            }

        }
    }
}
