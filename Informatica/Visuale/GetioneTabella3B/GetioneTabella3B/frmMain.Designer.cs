namespace GetioneTabella3B
{
    partial class frmMain
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
            this.btnCaricaTabellaStudenti = new System.Windows.Forms.Button();
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCaricaTabellaStudenti
            // 
            this.btnCaricaTabellaStudenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaricaTabellaStudenti.Location = new System.Drawing.Point(12, 12);
            this.btnCaricaTabellaStudenti.Name = "btnCaricaTabellaStudenti";
            this.btnCaricaTabellaStudenti.Size = new System.Drawing.Size(163, 23);
            this.btnCaricaTabellaStudenti.TabIndex = 0;
            this.btnCaricaTabellaStudenti.Text = "CARICA STUDENTI";
            this.btnCaricaTabellaStudenti.UseVisualStyleBackColor = true;
            this.btnCaricaTabellaStudenti.Click += new System.EventHandler(this.btnCaricaTabellaStudenti_Click);
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Location = new System.Drawing.Point(12, 56);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.Size = new System.Drawing.Size(240, 150);
            this.dgvStudenti.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.btnCaricaTabellaStudenti);
            this.Name = "frmMain";
            this.Text = "Gestione Tabella";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCaricaTabellaStudenti;
        private System.Windows.Forms.DataGridView dgvStudenti;
    }
}

