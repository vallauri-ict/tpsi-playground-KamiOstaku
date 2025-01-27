using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrisVisuale
{
    public partial class frmMain : Form
    {
        string[,] tris = new string[3, 3];

        string gameTurn =  "X";
        public frmMain()
        {
            InitializeComponent();
        }

        private void submitMove_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            gameTurn = "X";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tris[0,0] = gameTurn;
            button1.Text = gameTurn;
            if (vittoria(tris, gameTurn) != " ")
            {
                MessageBox.Show("Ha vinto il giocatore con le: " + gameTurn, "TRIS");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            gameTurn = (gameTurn == "X") ? "O" : "X";
            button1.Enabled = false;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tris[0, 1] = gameTurn;
            button2.Text = gameTurn;
            if (vittoria(tris, gameTurn) != " ")
            {
                MessageBox.Show("Ha vinto il giocatore con le: " + gameTurn, "TRIS");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            gameTurn = (gameTurn == "X") ? "O" : "X";
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tris[0, 2] = gameTurn;
            button3.Text = gameTurn;
            if (vittoria(tris, gameTurn) != " ")
            {
                MessageBox.Show("Ha vinto il giocatore con le: " + gameTurn, "TRIS");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            gameTurn = (gameTurn == "X") ? "O" : "X";
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tris[1, 0] = gameTurn;
            button4.Text = gameTurn;
            if (vittoria(tris, gameTurn) != " ")
            {
                MessageBox.Show("Ha vinto il giocatore con le: " + gameTurn, "TRIS");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            gameTurn = (gameTurn == "X") ? "O" : "X";
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tris[1, 1] = gameTurn;
            button5.Text = gameTurn;
            if (vittoria(tris, gameTurn) != " ")
            {
                MessageBox.Show("Ha vinto il giocatore con le: " + gameTurn, "TRIS");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            gameTurn = (gameTurn == "X") ? "O" : "X";
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tris[1, 2] = gameTurn;
            button6.Text = gameTurn;
            if (vittoria(tris, gameTurn) != " ")
            {
                MessageBox.Show("Ha vinto il giocatore con le: " + gameTurn, "TRIS"); 
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            gameTurn = (gameTurn == "X") ? "O" : "X";
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tris[2, 0] = gameTurn;
            button7.Text = gameTurn;
            if (vittoria(tris, gameTurn) != " ")
            {
                MessageBox.Show("Ha vinto il giocatore con le: " + gameTurn, "TRIS");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            gameTurn = (gameTurn == "X") ? "O" : "X";
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tris[2, 1] = gameTurn;
            button8.Text = gameTurn;
            if (vittoria(tris, gameTurn) != " ")
            {
                MessageBox.Show("Ha vinto il giocatore con le: " + gameTurn, "TRIS");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            gameTurn = (gameTurn == "X") ? "O" : "X";
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tris[2, 2] = gameTurn;
            button9.Text = gameTurn;

            if(vittoria(tris, gameTurn) != " ")
            {
                MessageBox.Show("Ha vinto il giocatore con le: " + gameTurn, "TRIS");
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }

            gameTurn = (gameTurn == "X") ? "O" : "X";
            button9.Enabled = false;
        }

        private static string vittoria(string[,] t, string ch)
        {
            if ((t[0, 0] == ch && t[0, 1] == ch && t[0, 2] == ch) ||
                    (t[1, 0] == ch && t[1, 1] == ch && t[1, 2] == ch) ||
                    (t[2, 0] == ch && t[2, 1] == ch && t[2, 2] == ch) ||
                    (t[0, 0] == ch && t[1, 0] == ch && t[2, 0] == ch) ||
                    (t[0, 1] == ch && t[1, 1] == ch && t[2, 1] == ch) ||
                    (t[0, 2] == ch && t[1, 2] == ch && t[2, 2] == ch) ||
                    (t[0, 0] == ch && t[1, 1] == ch && t[2, 2] == ch) ||
                    (t[0, 2] == ch && t[1, 1] == ch && t[2, 0] == ch))
                return ch;
            else
                return " ";
        }
    }
}
