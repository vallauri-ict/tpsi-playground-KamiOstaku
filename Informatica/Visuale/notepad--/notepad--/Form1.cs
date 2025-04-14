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

namespace notepad__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void apriFile(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Multiselect = false;
            ofd.Title = "SELEZIONA UN FILE";
            ofd.Filter = "INSERISCI UN FILE DI TESTO (*.txt) | *.txt";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                textArea.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void salvaConNome(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "SALVA IL FILE";
            sfd.Filter = "INSERISCI UN FILE DI TESTO (*.txt) | *.txt";
            sfd.CheckFileExists = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.Create(sfd.SelectedPath);
            }
        }
    }
}
