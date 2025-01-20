namespace AtloBasso
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.insertNumber = new System.Windows.Forms.TextBox();
            this.checkNumber = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.showResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(46, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIOCO ALTO E BASSO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inserisci numero:";
            // 
            // insertNumber
            // 
            this.insertNumber.Location = new System.Drawing.Point(184, 98);
            this.insertNumber.Name = "insertNumber";
            this.insertNumber.Size = new System.Drawing.Size(155, 28);
            this.insertNumber.TabIndex = 2;
            // 
            // checkNumber
            // 
            this.checkNumber.Location = new System.Drawing.Point(345, 103);
            this.checkNumber.Name = "checkNumber";
            this.checkNumber.Size = new System.Drawing.Size(75, 23);
            this.checkNumber.TabIndex = 3;
            this.checkNumber.Text = "verifica";
            this.checkNumber.UseVisualStyleBackColor = true;
            this.checkNumber.Click += new System.EventHandler(this.checkNumber_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Risultato:";
            // 
            // showResult
            // 
            this.showResult.AutoSize = true;
            this.showResult.Location = new System.Drawing.Point(180, 199);
            this.showResult.Name = "showResult";
            this.showResult.Size = new System.Drawing.Size(0, 20);
            this.showResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 663);
            this.Controls.Add(this.showResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkNumber);
            this.Controls.Add(this.insertNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("KacstOffice", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox insertNumber;
        private System.Windows.Forms.Button checkNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label showResult;
    }
}

