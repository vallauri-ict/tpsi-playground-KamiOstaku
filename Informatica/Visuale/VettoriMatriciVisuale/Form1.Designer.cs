namespace VettoriMatriciVisuale
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
            this.dgvA = new System.Windows.Forms.DataGridView();
            this.btnMaxVettore = new System.Windows.Forms.Button();
            this.btnCalcolaMediaVettore = new System.Windows.Forms.Button();
            this.btnCercaElementoVettore = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnSpeulare = new System.Windows.Forms.Button();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrimi3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSomma = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSomma = new System.Windows.Forms.DataGridView();
            this.dgv2Addendo = new System.Windows.Forms.DataGridView();
            this.dgv1Addendo = new System.Windows.Forms.DataGridView();
            this.dgvB = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvUnione = new System.Windows.Forms.DataGridView();
            this.btnUnione = new System.Windows.Forms.Button();
            this.dgvIntersezione = new System.Windows.Forms.DataGridView();
            this.btnIntersezione = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvC = new System.Windows.Forms.DataGridView();
            this.btnCaricaMatrice = new System.Windows.Forms.Button();
            this.btnTuttiUguali = new System.Windows.Forms.Button();
            this.btnColoraDP = new System.Windows.Forms.Button();
            this.btnSommaSottoDP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSomma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2Addendo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1Addendo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnione)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntersezione)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvA
            // 
            this.dgvA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvA.Location = new System.Drawing.Point(38, 39);
            this.dgvA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvA.Name = "dgvA";
            this.dgvA.Size = new System.Drawing.Size(426, 60);
            this.dgvA.TabIndex = 0;
            // 
            // btnMaxVettore
            // 
            this.btnMaxVettore.Location = new System.Drawing.Point(24, 239);
            this.btnMaxVettore.Name = "btnMaxVettore";
            this.btnMaxVettore.Size = new System.Drawing.Size(75, 53);
            this.btnMaxVettore.TabIndex = 1;
            this.btnMaxVettore.Text = "Cercare il MAX del vettore";
            this.btnMaxVettore.UseVisualStyleBackColor = true;
            this.btnMaxVettore.Click += new System.EventHandler(this.btnMaxVettore_Click);
            // 
            // btnCalcolaMediaVettore
            // 
            this.btnCalcolaMediaVettore.Location = new System.Drawing.Point(105, 239);
            this.btnCalcolaMediaVettore.Name = "btnCalcolaMediaVettore";
            this.btnCalcolaMediaVettore.Size = new System.Drawing.Size(75, 53);
            this.btnCalcolaMediaVettore.TabIndex = 2;
            this.btnCalcolaMediaVettore.Text = "Calcolare la MEDIA vettore";
            this.btnCalcolaMediaVettore.UseVisualStyleBackColor = true;
            this.btnCalcolaMediaVettore.Click += new System.EventHandler(this.btnCalcolaMediaVettore_Click);
            // 
            // btnCercaElementoVettore
            // 
            this.btnCercaElementoVettore.Location = new System.Drawing.Point(58, 16);
            this.btnCercaElementoVettore.Name = "btnCercaElementoVettore";
            this.btnCercaElementoVettore.Size = new System.Drawing.Size(75, 53);
            this.btnCercaElementoVettore.TabIndex = 4;
            this.btnCercaElementoVettore.Text = "Cercare elemento vettore";
            this.btnCercaElementoVettore.UseVisualStyleBackColor = true;
            this.btnCercaElementoVettore.Click += new System.EventHandler(this.btnCercaElementoVettore_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.btnCercaElementoVettore);
            this.groupBox1.Location = new System.Drawing.Point(186, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 75);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(6, 16);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(34, 20);
            this.txtNumero.TabIndex = 0;
            // 
            // btnSpeulare
            // 
            this.btnSpeulare.Location = new System.Drawing.Point(342, 239);
            this.btnSpeulare.Name = "btnSpeulare";
            this.btnSpeulare.Size = new System.Drawing.Size(89, 53);
            this.btnSpeulare.TabIndex = 6;
            this.btnSpeulare.Text = "Verificare se vettore SPECULARE";
            this.btnSpeulare.UseVisualStyleBackColor = true;
            this.btnSpeulare.Click += new System.EventHandler(this.btnSpeulare_Click);
            // 
            // dgv3
            // 
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Location = new System.Drawing.Point(86, 19);
            this.dgv3.Name = "dgv3";
            this.dgv3.Size = new System.Drawing.Size(81, 34);
            this.dgv3.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrimi3);
            this.groupBox2.Controls.Add(this.dgv3);
            this.groupBox2.Location = new System.Drawing.Point(451, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 97);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MASSIMI";
            // 
            // btnPrimi3
            // 
            this.btnPrimi3.Location = new System.Drawing.Point(6, 19);
            this.btnPrimi3.Name = "btnPrimi3";
            this.btnPrimi3.Size = new System.Drawing.Size(75, 63);
            this.btnPrimi3.TabIndex = 8;
            this.btnPrimi3.Text = "Cerca 3 MASSIMI vettore";
            this.btnPrimi3.UseVisualStyleBackColor = true;
            this.btnPrimi3.Click += new System.EventHandler(this.btnPrimi3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSomma);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dgvSomma);
            this.groupBox3.Controls.Add(this.dgv2Addendo);
            this.groupBox3.Controls.Add(this.dgv1Addendo);
            this.groupBox3.Location = new System.Drawing.Point(494, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 192);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SOMMA VETTORI";
            // 
            // btnSomma
            // 
            this.btnSomma.Location = new System.Drawing.Point(127, 111);
            this.btnSomma.Name = "btnSomma";
            this.btnSomma.Size = new System.Drawing.Size(75, 63);
            this.btnSomma.TabIndex = 14;
            this.btnSomma.Text = "SOMMA Vettori";
            this.btnSomma.UseVisualStyleBackColor = true;
            this.btnSomma.Click += new System.EventHandler(this.btnSomma_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "-----------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "+";
            // 
            // dgvSomma
            // 
            this.dgvSomma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSomma.Location = new System.Drawing.Point(16, 136);
            this.dgvSomma.Name = "dgvSomma";
            this.dgvSomma.Size = new System.Drawing.Size(96, 34);
            this.dgvSomma.TabIndex = 10;
            // 
            // dgv2Addendo
            // 
            this.dgv2Addendo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2Addendo.Location = new System.Drawing.Point(31, 77);
            this.dgv2Addendo.Name = "dgv2Addendo";
            this.dgv2Addendo.Size = new System.Drawing.Size(81, 34);
            this.dgv2Addendo.TabIndex = 9;
            // 
            // dgv1Addendo
            // 
            this.dgv1Addendo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1Addendo.Location = new System.Drawing.Point(31, 26);
            this.dgv1Addendo.Name = "dgv1Addendo";
            this.dgv1Addendo.Size = new System.Drawing.Size(81, 34);
            this.dgv1Addendo.TabIndex = 8;
            // 
            // dgvB
            // 
            this.dgvB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvB.Location = new System.Drawing.Point(38, 116);
            this.dgvB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvB.Name = "dgvB";
            this.dgvB.Size = new System.Drawing.Size(426, 60);
            this.dgvB.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvUnione);
            this.groupBox4.Controls.Add(this.btnUnione);
            this.groupBox4.Controls.Add(this.dgvIntersezione);
            this.groupBox4.Controls.Add(this.btnIntersezione);
            this.groupBox4.Location = new System.Drawing.Point(664, 239);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(337, 142);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Insiemistica";
            // 
            // dgvUnione
            // 
            this.dgvUnione.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnione.Location = new System.Drawing.Point(90, 75);
            this.dgvUnione.Name = "dgvUnione";
            this.dgvUnione.Size = new System.Drawing.Size(222, 53);
            this.dgvUnione.TabIndex = 18;
            // 
            // btnUnione
            // 
            this.btnUnione.Location = new System.Drawing.Point(7, 75);
            this.btnUnione.Name = "btnUnione";
            this.btnUnione.Size = new System.Drawing.Size(69, 53);
            this.btnUnione.TabIndex = 17;
            this.btnUnione.Text = "Unione";
            this.btnUnione.UseVisualStyleBackColor = true;
            this.btnUnione.Click += new System.EventHandler(this.btnUnione_Click);
            // 
            // dgvIntersezione
            // 
            this.dgvIntersezione.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntersezione.Location = new System.Drawing.Point(90, 16);
            this.dgvIntersezione.Name = "dgvIntersezione";
            this.dgvIntersezione.Size = new System.Drawing.Size(222, 53);
            this.dgvIntersezione.TabIndex = 16;
            // 
            // btnIntersezione
            // 
            this.btnIntersezione.Location = new System.Drawing.Point(7, 16);
            this.btnIntersezione.Name = "btnIntersezione";
            this.btnIntersezione.Size = new System.Drawing.Size(69, 53);
            this.btnIntersezione.TabIndex = 15;
            this.btnIntersezione.Text = "Interseca";
            this.btnIntersezione.UseVisualStyleBackColor = true;
            this.btnIntersezione.Click += new System.EventHandler(this.btnIntersezione_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(751, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "C";
            // 
            // dgvC
            // 
            this.dgvC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvC.Location = new System.Drawing.Point(773, 49);
            this.dgvC.Name = "dgvC";
            this.dgvC.Size = new System.Drawing.Size(240, 150);
            this.dgvC.TabIndex = 15;
            // 
            // btnCaricaMatrice
            // 
            this.btnCaricaMatrice.Location = new System.Drawing.Point(773, 207);
            this.btnCaricaMatrice.Name = "btnCaricaMatrice";
            this.btnCaricaMatrice.Size = new System.Drawing.Size(240, 23);
            this.btnCaricaMatrice.TabIndex = 16;
            this.btnCaricaMatrice.Text = "Carica Matrice";
            this.btnCaricaMatrice.UseVisualStyleBackColor = true;
            this.btnCaricaMatrice.Click += new System.EventHandler(this.btnCaricaMatrice_Click);
            // 
            // btnTuttiUguali
            // 
            this.btnTuttiUguali.Location = new System.Drawing.Point(1063, 49);
            this.btnTuttiUguali.Name = "btnTuttiUguali";
            this.btnTuttiUguali.Size = new System.Drawing.Size(75, 63);
            this.btnTuttiUguali.TabIndex = 17;
            this.btnTuttiUguali.Text = "Tutti uguali";
            this.btnTuttiUguali.UseVisualStyleBackColor = true;
            this.btnTuttiUguali.Click += new System.EventHandler(this.btnTuttiUguali_Click);
            // 
            // btnColoraDP
            // 
            this.btnColoraDP.Location = new System.Drawing.Point(1063, 187);
            this.btnColoraDP.Name = "btnColoraDP";
            this.btnColoraDP.Size = new System.Drawing.Size(75, 63);
            this.btnColoraDP.TabIndex = 18;
            this.btnColoraDP.Text = "Colora DP";
            this.btnColoraDP.UseVisualStyleBackColor = true;
            this.btnColoraDP.Click += new System.EventHandler(this.btnColoraDP_Click);
            // 
            // btnSommaSottoDP
            // 
            this.btnSommaSottoDP.Location = new System.Drawing.Point(1063, 118);
            this.btnSommaSottoDP.Name = "btnSommaSottoDP";
            this.btnSommaSottoDP.Size = new System.Drawing.Size(75, 63);
            this.btnSommaSottoDP.TabIndex = 19;
            this.btnSommaSottoDP.Text = "Somma Sotto DP";
            this.btnSommaSottoDP.UseVisualStyleBackColor = true;
            this.btnSommaSottoDP.Click += new System.EventHandler(this.btnSommaSottoDP_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 467);
            this.Controls.Add(this.btnSommaSottoDP);
            this.Controls.Add(this.btnColoraDP);
            this.Controls.Add(this.btnTuttiUguali);
            this.Controls.Add(this.btnCaricaMatrice);
            this.Controls.Add(this.dgvC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgvB);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSpeulare);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalcolaMediaVettore);
            this.Controls.Add(this.btnMaxVettore);
            this.Controls.Add(this.dgvA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.Text = "Vettori e Matrici in Visuale";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSomma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2Addendo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1Addendo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnione)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntersezione)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvA;
        private System.Windows.Forms.Button btnMaxVettore;
        private System.Windows.Forms.Button btnCalcolaMediaVettore;
        private System.Windows.Forms.Button btnCercaElementoVettore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnSpeulare;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrimi3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSomma;
        private System.Windows.Forms.DataGridView dgv2Addendo;
        private System.Windows.Forms.DataGridView dgv1Addendo;
        private System.Windows.Forms.Button btnSomma;
        private System.Windows.Forms.DataGridView dgvB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvIntersezione;
        private System.Windows.Forms.Button btnIntersezione;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvUnione;
        private System.Windows.Forms.Button btnUnione;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvC;
        private System.Windows.Forms.Button btnCaricaMatrice;
        private System.Windows.Forms.Button btnTuttiUguali;
        private System.Windows.Forms.Button btnColoraDP;
        private System.Windows.Forms.Button btnSommaSottoDP;
    }
}

