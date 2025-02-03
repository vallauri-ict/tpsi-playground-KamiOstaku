namespace RegistroElettronico
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.MediaColonna = new System.Windows.Forms.Button();
            this.selector = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(33, 12);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1108, 426);
            this.grid.TabIndex = 1;
            // 
            // MediaColonna
            // 
            this.MediaColonna.Location = new System.Drawing.Point(1202, 48);
            this.MediaColonna.Name = "MediaColonna";
            this.MediaColonna.Size = new System.Drawing.Size(109, 37);
            this.MediaColonna.TabIndex = 2;
            this.MediaColonna.Text = "Media Colonna";
            this.MediaColonna.UseVisualStyleBackColor = true;
            this.MediaColonna.Click += new System.EventHandler(this.MediaColonna_Click);
            // 
            // selector
            // 
            this.selector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selector.FormattingEnabled = true;
            this.selector.Items.AddRange(new object[] {
            "Matematica",
            "Italiano",
            "Storia",
            "Inglese",
            "Sistemi e Reti",
            "Telecomunicazioni",
            "Informatica",
            "TPSI"});
            this.selector.Location = new System.Drawing.Point(1205, 17);
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(105, 21);
            this.selector.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 450);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.MediaColonna);
            this.Controls.Add(this.grid);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button MediaColonna;
        private System.Windows.Forms.ComboBox selector;
    }
}

