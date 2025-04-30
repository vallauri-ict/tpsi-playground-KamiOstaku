namespace FileaTestolina
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.filePath = new System.Windows.Forms.TextBox();
            this.fileSelection = new System.Windows.Forms.Button();
            this.rtxtFile = new System.Windows.Forms.RichTextBox();
            this.btnCont = new System.Windows.Forms.Button();
            this.rtxtNRighe = new System.Windows.Forms.RichTextBox();
            this.btnVocali = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVocali);
            this.groupBox1.Controls.Add(this.rtxtNRighe);
            this.groupBox1.Controls.Add(this.btnCont);
            this.groupBox1.Controls.Add(this.rtxtFile);
            this.groupBox1.Controls.Add(this.fileSelection);
            this.groupBox1.Controls.Add(this.filePath);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1014, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleziona File";
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(20, 30);
            this.filePath.Name = "filePath";
            this.filePath.ReadOnly = true;
            this.filePath.Size = new System.Drawing.Size(599, 22);
            this.filePath.TabIndex = 0;
            // 
            // fileSelection
            // 
            this.fileSelection.Location = new System.Drawing.Point(625, 21);
            this.fileSelection.Name = "fileSelection";
            this.fileSelection.Size = new System.Drawing.Size(142, 40);
            this.fileSelection.TabIndex = 1;
            this.fileSelection.Text = "Apri";
            this.fileSelection.UseVisualStyleBackColor = true;
            this.fileSelection.Click += new System.EventHandler(this.fileSelection_Click);
            // 
            // rtxtFile
            // 
            this.rtxtFile.Location = new System.Drawing.Point(20, 77);
            this.rtxtFile.Name = "rtxtFile";
            this.rtxtFile.Size = new System.Drawing.Size(369, 320);
            this.rtxtFile.TabIndex = 2;
            this.rtxtFile.Text = "";
            // 
            // btnCont
            // 
            this.btnCont.Location = new System.Drawing.Point(861, 21);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(153, 63);
            this.btnCont.TabIndex = 3;
            this.btnCont.Text = "Numera Righe";
            this.btnCont.UseVisualStyleBackColor = true;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click);
            // 
            // rtxtNRighe
            // 
            this.rtxtNRighe.Location = new System.Drawing.Point(645, 105);
            this.rtxtNRighe.Name = "rtxtNRighe";
            this.rtxtNRighe.Size = new System.Drawing.Size(369, 320);
            this.rtxtNRighe.TabIndex = 4;
            this.rtxtNRighe.Text = "";
            // 
            // btnVocali
            // 
            this.btnVocali.Location = new System.Drawing.Point(427, 138);
            this.btnVocali.Name = "btnVocali";
            this.btnVocali.Size = new System.Drawing.Size(116, 66);
            this.btnVocali.TabIndex = 5;
            this.btnVocali.Text = "Conta Vocali";
            this.btnVocali.UseVisualStyleBackColor = true;
            this.btnVocali.Click += new System.EventHandler(this.btnVocali_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button fileSelection;
        private System.Windows.Forms.TextBox filePath;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox rtxtFile;
        private System.Windows.Forms.RichTextBox rtxtNRighe;
        private System.Windows.Forms.Button btnCont;
        private System.Windows.Forms.Button btnVocali;
    }
}

