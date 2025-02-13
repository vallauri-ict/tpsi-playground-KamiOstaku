namespace forza_
{
    partial class Alone
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameBoard = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.endGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // gameBoard
            // 
            this.gameBoard.BackgroundColor = System.Drawing.Color.White;
            this.gameBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameBoard.Location = new System.Drawing.Point(405, 152);
            this.gameBoard.Margin = new System.Windows.Forms.Padding(4);
            this.gameBoard.Name = "gameBoard";
            this.gameBoard.RowHeadersWidth = 51;
            this.gameBoard.Size = new System.Drawing.Size(418, 234);
            this.gameBoard.TabIndex = 0;
            this.gameBoard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gameBoard_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(457, 390);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tocca al giocatore rosso";
            // 
            // endGame
            // 
            this.endGame.BackColor = System.Drawing.Color.RosyBrown;
            this.endGame.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endGame.ForeColor = System.Drawing.SystemColors.InfoText;
            this.endGame.Location = new System.Drawing.Point(86, 235);
            this.endGame.Margin = new System.Windows.Forms.Padding(4);
            this.endGame.Name = "endGame";
            this.endGame.Size = new System.Drawing.Size(187, 92);
            this.endGame.TabIndex = 2;
            this.endGame.Text = "Termina partita";
            this.endGame.UseVisualStyleBackColor = false;
            this.endGame.Click += new System.EventHandler(this.endGame_Click);
            // 
            // Alone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(890, 554);
            this.Controls.Add(this.endGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameBoard);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Alone";
            this.Text = "Alone";
            this.Load += new System.EventHandler(this.Alone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gameBoard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button endGame;
    }
}