using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace NuoviComponenti
{
    public partial class Form1 : Form
    {
        List<string> cities = new List<string>() 
        {
            "BRA",
            "ALBA",
            "MONFORTE",
            "DOGLIANI",
            "ALTRO"
        };
        public Form1()
        {
            InitializeComponent();

            ToolTip tp = new ToolTip();

            tp.ReshowDelay = 100;
            tp.SetToolTip(btnInserisci, "Clicca qui per salvare i dati");

            for(int i = (97 - 32); i < (97 - 27); i++) 
            {
                sectSelector.Items.Add((char)i);
            }

            cmbComune.DataSource = cities;
        }

        private void btnInserisci_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.ShowDialog();
            WebBrowser wb = new WebBrowser();
            dgv.Hide();
                
            wb.Location = new System.Drawing.Point(0, 300);
            wb.Navigate(dlg.FileName);
            this.Controls.Add(wb);   
        }

        private void btnColore_Click(object sender, System.EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnColore.BackColor = colorDialog.Color;
                txtColor.Text = (colorDialog.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
            }    
        }

        private void btnFont_Click(object sender, System.EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                btnFont.Font = fontDialog.Font;
                txtFont.Font = fontDialog.Font;
            }
        }

        private void btnFolder_Click(object sender, System.EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = dialog.SelectedPath;
            }
        }

        private void btnFile_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Bocciato";
            dialog.Multiselect = false;
            dialog.Filter = "Text Dialog (*.txt) | *.txt | Images (*.jpg) | *.jpg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = dialog.FileName;
            }
        }
    }
}
