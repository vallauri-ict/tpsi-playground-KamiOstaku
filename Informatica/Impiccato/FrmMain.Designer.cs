namespace Impiccato
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.choiceSecretWord = new System.Windows.Forms.Button();
            this.insertSecretChoice = new System.Windows.Forms.TextBox();
            this.Game = new System.Windows.Forms.GroupBox();
            this.displayWord = new System.Windows.Forms.Label();
            this.submitGuess = new System.Windows.Forms.Button();
            this.guess = new System.Windows.Forms.TextBox();
            this.pictures = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.Game.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictures)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.choiceSecretWord);
            this.groupBox1.Controls.Add(this.insertSecretChoice);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserisci Parola Segreta";
            // 
            // choiceSecretWord
            // 
            this.choiceSecretWord.BackColor = System.Drawing.Color.Aquamarine;
            this.choiceSecretWord.Location = new System.Drawing.Point(160, 22);
            this.choiceSecretWord.Name = "choiceSecretWord";
            this.choiceSecretWord.Size = new System.Drawing.Size(88, 22);
            this.choiceSecretWord.TabIndex = 2;
            this.choiceSecretWord.Text = "gioca";
            this.choiceSecretWord.UseVisualStyleBackColor = false;
            this.choiceSecretWord.Click += new System.EventHandler(this.choiceSecretWord_Click);
            // 
            // insertSecretChoice
            // 
            this.insertSecretChoice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.insertSecretChoice.Location = new System.Drawing.Point(6, 22);
            this.insertSecretChoice.Name = "insertSecretChoice";
            this.insertSecretChoice.Size = new System.Drawing.Size(136, 20);
            this.insertSecretChoice.TabIndex = 1;
            this.insertSecretChoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Game
            // 
            this.Game.Controls.Add(this.displayWord);
            this.Game.Controls.Add(this.submitGuess);
            this.Game.Controls.Add(this.guess);
            this.Game.Location = new System.Drawing.Point(18, 137);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(242, 120);
            this.Game.TabIndex = 1;
            this.Game.TabStop = false;
            this.Game.Text = "Game";
            this.Game.Visible = false;
            // 
            // displayWord
            // 
            this.displayWord.AutoSize = true;
            this.displayWord.Location = new System.Drawing.Point(6, 59);
            this.displayWord.Name = "displayWord";
            this.displayWord.Size = new System.Drawing.Size(35, 13);
            this.displayWord.TabIndex = 2;
            this.displayWord.Text = "label1";
            // 
            // submitGuess
            // 
            this.submitGuess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.submitGuess.Location = new System.Drawing.Point(109, 19);
            this.submitGuess.Name = "submitGuess";
            this.submitGuess.Size = new System.Drawing.Size(120, 20);
            this.submitGuess.TabIndex = 1;
            this.submitGuess.Text = "tenta";
            this.submitGuess.UseVisualStyleBackColor = false;
            this.submitGuess.Click += new System.EventHandler(this.submitGuess_Click);
            // 
            // guess
            // 
            this.guess.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.guess.Location = new System.Drawing.Point(6, 19);
            this.guess.MaxLength = 1;
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(91, 20);
            this.guess.TabIndex = 0;
            this.guess.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictures
            // 
            this.pictures.Location = new System.Drawing.Point(370, 34);
            this.pictures.Name = "pictures";
            this.pictures.Size = new System.Drawing.Size(348, 365);
            this.pictures.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictures.TabIndex = 2;
            this.pictures.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictures);
            this.Controls.Add(this.Game);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "IMPICCATO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Game.ResumeLayout(false);
            this.Game.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button choiceSecretWord;
        private System.Windows.Forms.TextBox insertSecretChoice;
        private System.Windows.Forms.GroupBox Game;
        private System.Windows.Forms.Label displayWord;
        private System.Windows.Forms.Button submitGuess;
        private System.Windows.Forms.TextBox guess;
        private System.Windows.Forms.PictureBox pictures;
    }
}

