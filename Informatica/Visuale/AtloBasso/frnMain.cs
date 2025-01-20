using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtloBasso
{
    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        int secretNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            secretNumber = rnd.Next(0,21);
        }

        private void checkNumber_Click(object sender, EventArgs e)
        {
            int number;
            if(int.TryParse(insertNumber.Text, out number) && number > 0 && number <= 20)
            {
                if(number == secretNumber)
                {
                    showResult.Text = "You guessed it!!";
                    showResult.ForeColor = Color.Green;
                    checkNumber.Enabled = false;
                }
                else if(number > secretNumber)
                {
                    showResult .Text= "The secret number is lower";
                    showResult.ForeColor = Color.Red;
                }
                else
                {
                    showResult.Text = "The secret number is higer";
                    showResult.ForeColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Error 001: Insert a Valid number");
            }

            insertNumber.Text = "";
            insertNumber.Focus();
        }
    }
}
