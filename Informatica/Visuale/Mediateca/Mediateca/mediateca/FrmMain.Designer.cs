namespace mediateca
{
    partial class FrmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPageMedia = new System.Windows.Forms.TabControl();
            this.tabPageSoci = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvSoci = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPageMedia.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoci)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPageMedia
            // 
            this.tabPageMedia.Controls.Add(this.tabPageSoci);
            this.tabPageMedia.Controls.Add(this.tabPage2);
            this.tabPageMedia.Controls.Add(this.tabPage3);
            this.tabPageMedia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageMedia.Location = new System.Drawing.Point(0, 0);
            this.tabPageMedia.Name = "tabPageMedia";
            this.tabPageMedia.SelectedIndex = 0;
            this.tabPageMedia.Size = new System.Drawing.Size(800, 450);
            this.tabPageMedia.TabIndex = 0;
            // 
            // tabPageSoci
            // 
            this.tabPageSoci.Location = new System.Drawing.Point(4, 22);
            this.tabPageSoci.Name = "tabPageSoci";
            this.tabPageSoci.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSoci.Size = new System.Drawing.Size(792, 424);
            this.tabPageSoci.TabIndex = 0;
            this.tabPageSoci.Text = "SOCI";
            this.tabPageSoci.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvSoci);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MEDIA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvSoci
            // 
            this.dgvSoci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoci.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvSoci.Location = new System.Drawing.Point(3, 3);
            this.dgvSoci.Name = "dgvSoci";
            this.dgvSoci.Size = new System.Drawing.Size(606, 418);
            this.dgvSoci.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "OPERAZIONI";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabPageMedia);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabPageMedia.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPageMedia;
        private System.Windows.Forms.TabPage tabPageSoci;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvSoci;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

