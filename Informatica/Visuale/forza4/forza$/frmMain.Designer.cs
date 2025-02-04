namespace forza_
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
            this.buttonCpuChoice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPlayerChoice = new System.Windows.Forms.Button();
            this.rules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCpuChoice
            // 
            this.buttonCpuChoice.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonCpuChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCpuChoice.Location = new System.Drawing.Point(73, 206);
            this.buttonCpuChoice.Name = "buttonCpuChoice";
            this.buttonCpuChoice.Size = new System.Drawing.Size(187, 104);
            this.buttonCpuChoice.TabIndex = 0;
            this.buttonCpuChoice.Text = "Gioca contro la CPU";
            this.buttonCpuChoice.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightYellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "BENVENUTO NEL GIOCO DI FORZA 4";
            // 
            // buttonPlayerChoice
            // 
            this.buttonPlayerChoice.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonPlayerChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayerChoice.Location = new System.Drawing.Point(543, 206);
            this.buttonPlayerChoice.Name = "buttonPlayerChoice";
            this.buttonPlayerChoice.Size = new System.Drawing.Size(187, 104);
            this.buttonPlayerChoice.TabIndex = 2;
            this.buttonPlayerChoice.Text = "Gioca contro un altro giocatore!";
            this.buttonPlayerChoice.UseVisualStyleBackColor = false;
            // 
            // rules
            // 
            this.rules.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rules.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rules.Location = new System.Drawing.Point(308, 206);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(187, 104);
            this.rules.TabIndex = 3;
            this.rules.Text = "Regole";
            this.rules.UseVisualStyleBackColor = false;
            this.rules.Click += new System.EventHandler(this.rules_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rules);
            this.Controls.Add(this.buttonPlayerChoice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCpuChoice);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCpuChoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPlayerChoice;
        private System.Windows.Forms.Button rules;
    }
}

