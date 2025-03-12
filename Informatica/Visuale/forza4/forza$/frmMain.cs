using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forza_
{
    public partial class frmMain : Form
    {
        private Form Alone;
        public bool tipoGioco;
        public frmMain()
        {
            InitializeComponent();
        }

        private void rules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Benvenuto nel regolamento di forza 4. Le regole sono le seguenti:\n\n\t• Impila i gettoni del tuo colore lasciandoli cadere dall'alto\t\t  con lo scopo di metterne 4 in riga,colonna oppure in linea \t\t  obliqua.\n\n\t• Per selezionare dove vuoi lasciare cadere il gettone seleziona \t  una cella qualsiasi della colonna nella quale posizionarlo");
        }

        private void buttonCpuChoice_Click(object sender, EventArgs e)
        {
            tipoGioco = true;
            Alone alone= new Alone(tipoGioco);
            this.Hide();
            alone.Show();
        }
    }
}
