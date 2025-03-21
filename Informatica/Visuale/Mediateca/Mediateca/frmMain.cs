using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediateca
{
    public partial class frmMain : Form
    {
        public bool InputCheck = false;

        public frmMain()
        {
            InitializeComponent();
            clsSoci.caricaSoci(dgvSoci);
            clsMedia.caricaMedia(dgvMedia);
            clsOperazioni.caricaOperazioni(dgvOperazioni);
        }

        private void btnAddSocio_Click(object sender, EventArgs e)
        {

            if(InputCheck == false)
            {
                clsSoci.AddSocio(dgvSoci, InputCognomeSocio.Text, InputNomeSocio.Text, InputEmailSocio.Text, InputTelefonoSocio.Text);
            }
            
        }

        private void controllaInput(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue < 65 || e.KeyValue > 90) && e.KeyValue != 8)
            {
                e.SuppressKeyPress = true;
            }

        }
    }
}
