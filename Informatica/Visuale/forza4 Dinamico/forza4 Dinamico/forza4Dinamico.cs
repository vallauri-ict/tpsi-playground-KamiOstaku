using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forza4_Dinamico
{
    public partial class forza4Dinamico : Form
    {
        const int R = 6, C = 7;
        char[,] gameBoard;
        char giocatore;

        public forza4Dinamico()
        {
            InitializeComponent();
        }

        private void forza4Dinamico_Load(object sender, EventArgs e)
        {
            disegnaCampo();
            abilitaGioco(false);
        }

        private void abilitaGioco(bool flag)
        {
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                if(btn.Name == "btnGioca")
                {
                    btn.Enabled = !flag;
                }
                else
                {
                    btn.Enabled = flag;
                }
                
            }
        }

        private void disegnaCampo()
        {
            Button btn;
            Label lbl;
            int PosX, PosY = 60;

            lbl = new Label();
            lbl.Name = $"labelTitolo";
            lbl.Text = $"Premi gioca per giocare";
            lbl.Font = new Font(lbl.Font.FontFamily, 16);
            lbl.ForeColor = Color.Red;
            lbl.AutoSize = true;
            lbl.Location = new Point(10, 10);

            this.Controls.Add(lbl);

            for (int i = 0; i < R; i++)
            {
                PosX = 23;
                for (int j = 0; j < C; j++)
                {
                    lbl = new Label();

                    lbl.Name = $"gameBoard_{i}_{j}";
                    lbl.Text = $"--";
                    lbl.Size = new Size(50, 50);
                    lbl.Location = new Point(PosX,PosY);

                    this.Controls.Add(lbl);

                    PosX += 50;
                }
                PosY += 50;
            }

            PosX = 10;

            for (int i = 0; i < C; i++)
            {
                btn = new Button();

                btn.Name = $"bntC_{i}";
                btn.Text = $"**";
                btn.Size = new Size(50, 50);
                btn.Location = new Point(PosX, PosY);
                btn.Click += new EventHandler(btnColonna_Click);

                this.Controls.Add(btn);

                PosX += 50;
            }

            btn = new Button();
            btn.Name = $"btnGioca";
            btn.Text = $"Gioca";
            btn.Size = new Size(350, 50);
            btn.Location = new Point(10, PosY+50);
            btn.Click += new EventHandler(btnGioca_Click);
            this.Controls.Add(btn);

            lbl = new Label();
            lbl.Name = $"turno";
            lbl.Text = $"Tocca al giocatore: ";
            lbl.Font = new Font(lbl.Font.FontFamily, 16);
            lbl.ForeColor = Color.Green;
            lbl.AutoSize = true;
            lbl.Location = new Point(10, PosY+100);
            this.Controls.Add(lbl);
        }

        private void btnColonna_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int posJ = Convert.ToInt32(btn.Name.Substring(5));
            int posI;
            posI = posizionaGettone(posJ);

            Label lbl = (Label)this.Controls[$"gameBoard_{posI}_{posJ}"];
            lbl.Text = giocatore.ToString();

            if(giocatore == 'X')
            {
                lbl.ForeColor = Color.Red;
            }
            else
            {
                lbl.ForeColor = Color.Yellow;
            }
            
            if(posI == 0)
            {
                btn.Enabled = false;
            }

            lbl = (Label)this.Controls["turno"];
            lbl.Text = $"Tocca al giocatore: {giocatore.ToString()}";

            bool winCheck = controllaVittoria(gameBoard,R,C,giocatore);

            if (winCheck)
            {
                MessageBox.Show($"Ha vinto il giocatore con le {giocatore}");
            }
            else if (controllaPatta())
            {
                MessageBox.Show($"Avete pattato");
            }
            else
            {
                giocatore = giocatore == 'X' ? 'O' : 'X';
            }
        }

        private bool controllaPatta()
        {
            int i = 0; 
            while (gameBoard[0,i] != '\0')
            {
                i++;
            }

            return i < C ? false : true;
        }

        public static bool controllaVittoria(char[,] carlo, int rows, int colums, char giocatoreCorrente)
        {
            bool vittoria = false;
            int cnt = 0, i = rows, j = colums;

            while (rows < carlo.GetLength(0) && carlo[rows, colums] == giocatoreCorrente)
            {
                cnt++;
                rows++;
            }

            if (cnt >= 4)
            {
                vittoria = true;
            }
            else
            {
                rows = i - 1;
                colums = j - 1;

                while (colums < carlo.GetLength(1) && carlo[rows, colums] == giocatoreCorrente)
                {
                    cnt++;
                    colums++;
                }
                rows = i - 1;
                colums = j - 1;
                while (colums >= 0 && carlo[i, j] == giocatoreCorrente)
                {
                    cnt++;
                    colums--;
                }

                if (cnt >= 4)
                {
                    vittoria = true;
                }
                else
                {
                    cnt = 0;
                    rows = i - 1;
                    colums = j - 1;

                    while (colums < carlo.GetLength(1) && rows < carlo.GetLength(0) && giocatoreCorrente == carlo[rows, colums])
                    {
                        rows++;
                        colums++;
                        cnt++;
                    }
                    colums = j - 1;
                    rows = i - 1;
                    while (j >= 0 && i >= 0)
                    {
                        i--;
                        j--;
                        cnt++;
                    }
                }
                if (cnt >= 4)
                {
                    vittoria = true;
                }
                else
                {
                    cnt = 0;
                    rows = i - 1;
                    colums = j - 1;

                    while (rows < carlo.GetLength(0) && colums >= 0 && giocatoreCorrente == carlo[rows, colums])
                    {
                        rows++;
                        colums--;
                        cnt++;
                    }
                    colums = j - 1;
                    rows = i - 1;
                    while (j < carlo.GetLength(1) && i >= 0 && carlo[rows, colums] == giocatoreCorrente)
                    {
                        rows--;
                        colums++;
                        cnt++;
                    }

                    if (cnt >= 4)
                    {
                        vittoria = true;
                    }
                }
            }
            return vittoria;
        }

        private int posizionaGettone(int posJ)
        {
            int i = R-1;
            while(gameBoard[i,posJ] != '\0')
            {
                i--;
            }
            gameBoard[i, posJ] = giocatore;
            return i;
        }

        private void btnGioca_Click(object sender, EventArgs e)
        {
            abilitaGioco(true);
            giocatore = 'X';
            gameBoard = new char[R,C];

            Label lbl;
            lbl = (Label)this.Controls["turno"];
            lbl.Text = $"Tocca al giocatore: {giocatore.ToString()}";
        }
    }
}
