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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMax = new System.Windows.Forms.DataGridView();
            this.findMax = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMax)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvA
            // 
            this.dgvA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvA.Location = new System.Drawing.Point(38, 39);
            this.dgvA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvA.Name = "dgvA";
            this.dgvA.RowHeadersWidth = 51;
            this.dgvA.Size = new System.Drawing.Size(426, 60);
            this.dgvA.TabIndex = 0;
            // 
            // btnMaxVettore
            // 
            this.btnMaxVettore.Location = new System.Drawing.Point(38, 134);
            this.btnMaxVettore.Name = "btnMaxVettore";
            this.btnMaxVettore.Size = new System.Drawing.Size(75, 53);
            this.btnMaxVettore.TabIndex = 1;
            this.btnMaxVettore.Text = "Cercare il MAX del vettore";
            this.btnMaxVettore.UseVisualStyleBackColor = true;
            this.btnMaxVettore.Click += new System.EventHandler(this.btnMaxVettore_Click);
            // 
            // btnCalcolaMediaVettore
            // 
            this.btnCalcolaMediaVettore.Location = new System.Drawing.Point(119, 134);
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
            this.groupBox1.Location = new System.Drawing.Point(200, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 75);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(6, 16);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(34, 23);
            this.txtNumero.TabIndex = 0;
            // 
            // btnSpeulare
            // 
            this.btnSpeulare.Location = new System.Drawing.Point(356, 134);
            this.btnSpeulare.Name = "btnSpeulare";
            this.btnSpeulare.Size = new System.Drawing.Size(89, 53);
            this.btnSpeulare.TabIndex = 6;
            this.btnSpeulare.Text = "Verificare se vettore SPECULARE";
            this.btnSpeulare.UseVisualStyleBackColor = true;
            this.btnSpeulare.Click += new System.EventHandler(this.btnSpeulare_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMax);
            this.groupBox2.Controls.Add(this.findMax);
            this.groupBox2.Location = new System.Drawing.Point(38, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 117);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MASSIMI";
            // 
            // dgvMax
            // 
            this.dgvMax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMax.Location = new System.Drawing.Point(7, 37);
            this.dgvMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvMax.Name = "dgvMax";
            this.dgvMax.RowHeadersWidth = 51;
            this.dgvMax.Size = new System.Drawing.Size(101, 60);
            this.dgvMax.TabIndex = 8;
            // 
            // findMax
            // 
            this.findMax.Location = new System.Drawing.Point(121, 37);
            this.findMax.Name = "findMax";
            this.findMax.Size = new System.Drawing.Size(75, 53);
            this.findMax.TabIndex = 4;
            this.findMax.Text = "Cerca Massimo";
            this.findMax.UseVisualStyleBackColor = true;
            this.findMax.Click += new System.EventHandler(this.findMax_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(282, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 117);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MASSIMI";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 37);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(101, 60);
            this.dataGridView1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cerca Massimo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(612, 39);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(426, 232);
            this.dataGridView2.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(578, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 53);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cerca Massimo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(659, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 53);
            this.button3.TabIndex = 11;
            this.button3.Text = "Cerca Massimo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 518);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
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
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMax)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvA;
        private System.Windows.Forms.Button btnMaxVettore;
        private System.Windows.Forms.Button btnCalcolaMediaVettore;
        private System.Windows.Forms.Button btnCercaElementoVettore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnSpeulare;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMax;
        private System.Windows.Forms.Button findMax;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

