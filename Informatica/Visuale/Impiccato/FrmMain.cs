using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impiccato
{
    public partial class FrmMain : Form
    {
        string secretWord;
        string insertGuess;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void choiceSecretWord_Click(object sender, EventArgs e)
        {
            
            if (insertSecretChoice.Text.Length > 0) 
            {
                secretWord = insertSecretChoice.Text;
                Game.Visible = true;
                groupBox1.Visible = false;
                pictures.Image = Image.FromFile("C:\\Users\\n.milojkov.3572\\Desktop\\tpsi-playground-KamiOstaku\\Informatica\\Impiccato\\bin\\Debug\\Img\\vuoto.png");

                displayWord.Text = "";
                for (int i = 0; i < secretWord.Length;i++)
                {
                    displayWord.Text += "*";
                }
            }
            else
            {
                MessageBox.Show("Insert at least a character");
            }
                
            
        }

        private void submitGuess_Click(object sender, EventArgs e)
        {
            CheckGuess();  
        }

        private void CheckGuess()
        {
            insertGuess = guess.Text;
            if(!string.IsNullOrEmpty(insertGuess) && char.IsLetter(Convert.ToChar(insertGuess)))
            {
                if (!changeOutput(insertGuess))
                {
                    if(secretWord == displayWord.Text)
                    {
                        MessageBox.Show("Congratulations, you won!");
                    }    
                }
            }
            else
            {
                MessageBox.Show("Insert a valid character");
            }
        }

        private bool changeOutput(string insertGuess)
        {
            bool found = false;
            int pos = -1;

            do
            {
                pos = secretWord.IndexOf(insertGuess, pos + 1);

                if(pos != -1)
                {
                    found = true;
                    displayWord.Text = changeDisplayWord(insertGuess, pos);
                }    

            } while (pos != -1);

            return found;
        }

        private string changeDisplayWord(string insertGuess, int pos)
        {
            string aux = "";

            for (int i = 0; i < secretWord.Length; i++)
            {
                if (i == pos)
                {
                    aux += insertGuess;
                }
                else if (displayWord.Text[i] != ' ')
                {
                    aux += displayWord.Text[i];
                }
            }

            return aux;
        }
    }
}
