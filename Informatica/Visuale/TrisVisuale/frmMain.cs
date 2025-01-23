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
            button1.Text = gameTurn;
            gameTurn = (gameTurn == "X") ? "O" : "X";
            button1.Enabled = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = gameTurn;
            gameTurn = (gameTurn == "X") ? "O" : "X";
            button2.Enabled = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = gameTurn;
            gameTurn = (gameTurn == "X") ? "O" : "X";
            button3.Enabled = false;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = gameTurn;
            gameTurn = (gameTurn == "X") ? "O" : "X";
            button4.Enabled = false;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = gameTurn;
            gameTurn = (gameTurn == "X") ? "O" : "X";
            button5.Enabled = false;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = gameTurn;
            gameTurn = (gameTurn == "X") ? "O" : "X";
            button6.Enabled = false;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = gameTurn;
            gameTurn = (gameTurn == "X") ? "O" : "X";
            button7.Enabled = false;
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = gameTurn;
            gameTurn = (gameTurn == "X") ? "O" : "X";
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = gameTurn;
            gameTurn = (gameTurn == "X") ? "O" : "X";
            button9.Enabled = false;
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
