using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileaTestolina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileSelection_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();

            fdlg.Title = "Seleziona un file di testo";
            fdlg.Filter = ".txt , .csv (*.txt,*.csv)|*.txt;*.csv";
            
            if(fdlg.ShowDialog() == DialogResult.OK)
            {
                filePath.Text = fdlg.FileName;

                stampaFile(filePath.Text,rtxtFile);
            }
        }

        private void stampaFile(string nf, RichTextBox rTxt)
        {
            rTxt.Text = "";
            StreamReader sr = new StreamReader(nf);

            string linea;

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine();
                rTxt.Text += $"{linea}\n";
            }

            sr.Close();
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            numeraRighe(filePath.Text);
            
        }

        private void numeraRighe(string nf)
        {
            string nome = RicavaNome(nf);
            StreamReader sr = new StreamReader(nf);

            StreamWriter sw = new StreamWriter($"{nome}_temp.txt");

            string linea;
            int cont = 1;

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine();
                sw.Write($"{cont}) {linea}\n");
                cont++;
            }

            sr.Close();
            sw.Close();
            stampaFile("temp.txt", rtxtNRighe);   
        }

        private string RicavaNome(string nf)
        {
            string[] v = nf.Split('\\');
            v = v[v.Length - 1].Split('.');

            return v[0];
        }

        private void btnVocali_Click(object sender, EventArgs e)
        {
            contaVocali(filePath.Text);
        }

        private void contaVocali(string nf)
        {
            int nTrovate = 0;
            char[] aux = new char[] {'a','e','i','o','u'};

            string nome = RicavaNome(nf);
            StreamReader sr = new StreamReader(nf);

            StreamWriter sw = new StreamWriter($"{nome}_vocali.txt");

            string linea;

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine().ToLower();

                foreach (char c in linea)
                {
                    if(aux.Contains(c))
                    {
                        nTrovate++;
                    }
                }
            }

            sr.Close();
            sw.Close();
            stampaFile("temp.txt", rtxtNRighe);

            MessageBox.Show($"Ci sono {nTrovate} vocali");
        }
    }
}