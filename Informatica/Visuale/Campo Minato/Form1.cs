using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campo_Minato
{
    public partial class Form1 : Form
    {
        protected Random rnd = new Random(); //The random is used to generate the random bomb positions
        Button btn; //Is used to make all the buttons
        int[,] gameMatrix; //Handles game logic
        int winCount = 0;
        int allCells = 0;

        public Form1()
        {
            //Initializes the components of the form and makes the window not resizable
            //It changes the form title and load position

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text = "Campo Minato";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Generates the game by first waiting a difficulty choice which is handled in the class DifficultyChoice
            generateGame(DifficultyChoice.selectChoice());
        }

        private void generateGame(int selectChoice)
        {
            //selects the difficulty based on the player choice and uses nButton to know how many buttons to make

            //The difference between those 3 gameModes are just the numbers of buttons, the number of bombs and the position of the window
            //The bomb number is calculated with this formula: 0,15625 * nButton^2

            int nButton;
            switch (selectChoice)
            {
                case 0:
                    nButton = 8;
                    modalitaFacile(nButton);
                    break;

                case 1:
                    nButton = 16;
                    modalitaMedia(nButton);
                    break;

                case 2:
                    nButton = 17;
                    modalitaDifficile(nButton);
                    break;
            }
        }

        private void generaMine(int max, int aX,int aY)
        {
            int nBombs = 0;
            int y, x;
            do
            {
                y = rnd.Next(0, gameMatrix.GetLength(0));
                x = rnd.Next(0, gameMatrix.GetLength(0));
                if (gameMatrix[x, y] != 1 && aY != y && aX != x)
                {
                    gameMatrix[x, y] = 1;
                    nBombs++;
                }
            } while (nBombs < max);
        }

        private void modalitaDifficile(int nButton)
        {
            this.Width = 965;
            this.Height = 1030;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(500, 000);

            for (int i = 1; i <= nButton; i++)
            {
                for (int j = 1; j <= nButton; j++)
                {
                    btn = new Button();

                    btn.Name = $"{i - 1}.{j - 1}";
                    btn.Location = new Point(50 * i, j * 50);
                    btn.Size = new Size(45, 45);
                    btn.Click += new EventHandler(controlloMina);

                    this.Controls.Add(btn);
                }
            }

            btn = new Button();

            btn.Name = "Reset";
            btn.Text = "Reset";
            btn.Location = new Point(this.Width / 2 - 59, this.Height - 110);
            btn.BackColor = Color.DarkBlue;
            btn.ForeColor = Color.White;
            btn.Size = new Size(100, 45);
            btn.Click += new EventHandler(resetClick);

            this.Controls.Add(btn);

            gameMatrix = new int[24, 24];

            //generaMine(90);

            //allCells = (gameMatrix.GetLength(0) * gameMatrix.GetLength(0)) - nBombs;
        }

        private void modalitaMedia(int nButton)
        {
            this.Width = 915;
            this.Height = 1000;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(500,000);

            for (int i = 1; i <= nButton; i++)
            {
                for (int j = 1; j <= nButton; j++)
                {
                    btn = new Button
                    {
                        Name = $"{i - 1}.{j - 1}",
                        Location = new Point(50 * i, j * 50),
                        Size = new Size(45, 45)
                    };
                    btn.Click += new EventHandler(controlloMina);

                    this.Controls.Add(btn);
                }
            }

            btn = new Button
            {
                Name = "Reset",
                Text = "Reset",
                Location = new Point(this.Width / 2 - 59, this.Height - 130),
                BackColor = Color.DarkBlue,
                ForeColor = Color.White,
                Size = new Size(100, 45)
            };
            btn.Click += new EventHandler(resetClick);

            this.Controls.Add(btn);

            gameMatrix = new int[16, 16];

            //generaMine(40);

            //allCells = (gameMatrix.GetLength(0) * gameMatrix.GetLength(0)) - nBombs;
        }

        private void modalitaFacile(int nButton)
        {
            this.Width = 515;
            this. Height = 600;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(600,200);

            for (int i = 1; i <= nButton; i++) 
            {
                for (int j = 1; j <= nButton; j++) 
                {
                    btn = new Button();

                    btn.Name = $"{i-1}.{j-1}";
                    btn.Location = new Point(50 * i, j * 50);
                    btn.Size = new Size(45,45);
                    btn.Click += new EventHandler(controlloMina);

                    this.Controls.Add(btn);
                }
            }

            btn = new Button
            {
                Name = "Reset",
                Text = "Reset",
                Location = new Point(this.Width / 2 - 59, this.Height - 130),
                BackColor = Color.DarkBlue,
                ForeColor = Color.White,
                Size = new Size(100, 45)
            };
            btn.Click += new EventHandler(resetClick);

            this.Controls.Add(btn);

            gameMatrix = new int[8,8];

            //generaMine(10);
        }

        private void resetClick(object sender, EventArgs e)
        {
            //Does the previous said thing in the class costructor and resets the game view

            this.Controls.Clear();
            this.InitializeComponent();
            this.Text = "Campo Minato";
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(635,375);
            generateGame(DifficultyChoice.selectChoice());
            winCount = 0;
        }

        private void controlloMina(object sender, EventArgs e)
        {
            //Checks if the pressed button contains a bomb

            btn = (Button)sender;

            //Takes the button position for use it on the gameMatrix
            string[] position;
            position = btn.Name.Split('.');

            int x = int.Parse(position[0]);
            int y = int.Parse(position[1]);

            if(gameMatrix[x, y] == 1 && winCount == 0 || winCount == 0)
            {
                int numeroMine = Convert.ToInt32(0.15625 * gameMatrix.GetLength(0)*gameMatrix.GetLength(1));
                generaMine(numeroMine,x,y);
                allCells = (gameMatrix.GetLength(0) * gameMatrix.GetLength(0)) - numeroMine;
            }

            if (gameMatrix[x,y] == 1)
            {
                //If the button is a bomb the game says you lose and resets
                MessageBox.Show("Hai preso una mina, hai perso");
                btn.Text = "BOOM";

                this.Controls.Clear();
                this.InitializeComponent();
                this.Text = "Campo Minato";
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(635, 375);
                generateGame(DifficultyChoice.selectChoice());
                winCount = 0;
            }
            else
            {
                //It counts the bomb around the pressed buttons
                btn.Text = checkAroundBombs(x, y).ToString();
                btn.Click -= controlloMina;
                winCount++;
            }

            if(winCount >= allCells)
            {
                MessageBox.Show("Hai vinto complimenti");

                this.Controls.Clear();
                this.InitializeComponent();
                this.Text = "Campo Minato";
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(635, 375);
                generateGame(DifficultyChoice.selectChoice());
                winCount = 0;
            }
        }

        private int checkAroundBombs(int y, int x)
        {
            int cont = 0;

            //iterates on the cells around by starting on the top left going to the bottom right
            //The if fixes the indexOutOfRange problems

            for (int i = y - 1; i < y + 2; i++)
            {
                if(i >= 0 && i < gameMatrix.GetLength(0))
                {
                    for (int j = x - 1; j < x+ 2; j++)
                    {
                        if (j >= 0 && j < gameMatrix.GetLength(0) && (i != y || j != x))
                        {
                            if (gameMatrix[i, j] == 1)
                            {
                                cont++;
                            }
                        }
                    }
                }
            }

            return cont;
        }
    }

    public class DifficultyChoice : Form
    {
        DifficultyChoice()
        {
            //Makes a form
            this.Width = 500;
            this.Width = 300;
        }

        public static int selectChoice()
        {
            DifficultyChoice prova = new DifficultyChoice();
            prova.StartPosition = FormStartPosition.CenterParent;

            string[] aux = { "Facile", "Medio", "Difficile" };

            int result = 0;

            prova.FormBorderStyle = FormBorderStyle.FixedDialog;
            prova.ControlBox = false;
            prova.Height = 110;
            prova.Text = "Scegli difficoltà";


            Label label = new Label
            {
                Text = "             Scegli la Difficoltà",
                Size = new Size(prova.Width, 25),
                ForeColor = Color.Blue
            };
            label.Font = new Font(label.Font.FontFamily, 13);
            prova.Controls.Add(label);

            for (int i = 0; i < 3; i++)
            {
                Button btn = new Button
                {
                    Name = $"bnt{i}",
                    Text = aux[i],
                    AutoSize = true
                };
                btn.Location = new Point((btn.Width + 5) * i + 25, 40);

                btn.Click += (sender, e) =>
                {
                    result = int.Parse(btn.Name.Substring(3, 1));
                    prova.DialogResult = DialogResult.OK;
                    prova.Close();
                };

                prova.Controls.Add(btn);
            }
            prova.ShowDialog();

            return result;
        }
    }
}