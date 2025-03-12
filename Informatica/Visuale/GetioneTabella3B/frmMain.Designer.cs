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
            this.btnOrdinaStudentiCognomeNome = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRicercaBinariaMatricola = new System.Windows.Forms.Button();
            this.btnCercaClassePiùStudenti = new System.Windows.Forms.Button();
            this.btnContaStudentiClasse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbMaterieDinamica = new System.Windows.Forms.ComboBox();
            this.cmbMaterieStatica = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMediaValutazioniMateria = new System.Windows.Forms.Button();
            this.btnCalcolaMediaValutazioniMateria = new System.Windows.Forms.Button();
            this.dgvValutazioni = new System.Windows.Forms.DataGridView();
            this.btnCaricaValutazioni = new System.Windows.Forms.Button();
            this.btn5Query = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn1QueryComuni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValutazioni)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCaricaTabellaStudenti
            // 
            this.btnCaricaTabellaStudenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaricaTabellaStudenti.Location = new System.Drawing.Point(16, 15);
            this.btnCaricaTabellaStudenti.Margin = new System.Windows.Forms.Padding(4);
            this.btnCaricaTabellaStudenti.Name = "btnCaricaTabellaStudenti";
            this.btnCaricaTabellaStudenti.Size = new System.Drawing.Size(217, 28);
            this.btnCaricaTabellaStudenti.TabIndex = 0;
            this.btnCaricaTabellaStudenti.Text = "CARICA STUDENTI";
            this.btnCaricaTabellaStudenti.UseVisualStyleBackColor = true;
            this.btnCaricaTabellaStudenti.Click += new System.EventHandler(this.btnCaricaTabellaStudenti_Click);
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStudenti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Location = new System.Drawing.Point(16, 58);
            this.dgvStudenti.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.RowHeadersWidth = 51;
            this.dgvStudenti.Size = new System.Drawing.Size(489, 185);
            this.dgvStudenti.TabIndex = 1;
            // 
            // btnOrdinaStudentiCognomeNome
            // 
            this.btnOrdinaStudentiCognomeNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdinaStudentiCognomeNome.Location = new System.Drawing.Point(23, 23);
            this.btnOrdinaStudentiCognomeNome.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrdinaStudentiCognomeNome.Name = "btnOrdinaStudentiCognomeNome";
            this.btnOrdinaStudentiCognomeNome.Size = new System.Drawing.Size(217, 52);
            this.btnOrdinaStudentiCognomeNome.TabIndex = 2;
            this.btnOrdinaStudentiCognomeNome.Text = "ORDINA STUDENTI NOMINATIVO";
            this.btnOrdinaStudentiCognomeNome.UseVisualStyleBackColor = true;
            this.btnOrdinaStudentiCognomeNome.Click += new System.EventHandler(this.btnOrdinaStudentiCognomeNome_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRicercaBinariaMatricola);
            this.groupBox1.Controls.Add(this.btnCercaClassePiùStudenti);
            this.groupBox1.Controls.Add(this.btnContaStudentiClasse);
            this.groupBox1.Controls.Add(this.btnOrdinaStudentiCognomeNome);
            this.groupBox1.Location = new System.Drawing.Point(547, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 256);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query";
            // 
            // btnRicercaBinariaMatricola
            // 
            this.btnRicercaBinariaMatricola.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRicercaBinariaMatricola.Location = new System.Drawing.Point(23, 197);
            this.btnRicercaBinariaMatricola.Margin = new System.Windows.Forms.Padding(4);
            this.btnRicercaBinariaMatricola.Name = "btnRicercaBinariaMatricola";
            this.btnRicercaBinariaMatricola.Size = new System.Drawing.Size(217, 52);
            this.btnRicercaBinariaMatricola.TabIndex = 5;
            this.btnRicercaBinariaMatricola.Text = "RICERCA BINARIA MATRICOLA";
            this.btnRicercaBinariaMatricola.UseVisualStyleBackColor = true;
            this.btnRicercaBinariaMatricola.Click += new System.EventHandler(this.btnRicercaBinariaMatricola_Click);
            // 
            // btnCercaClassePiùStudenti
            // 
            this.btnCercaClassePiùStudenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCercaClassePiùStudenti.Location = new System.Drawing.Point(23, 142);
            this.btnCercaClassePiùStudenti.Margin = new System.Windows.Forms.Padding(4);
            this.btnCercaClassePiùStudenti.Name = "btnCercaClassePiùStudenti";
            this.btnCercaClassePiùStudenti.Size = new System.Drawing.Size(217, 52);
            this.btnCercaClassePiùStudenti.TabIndex = 4;
            this.btnCercaClassePiùStudenti.Text = "CERCA CLASSE CON + STUDENTI";
            this.btnCercaClassePiùStudenti.UseVisualStyleBackColor = true;
            this.btnCercaClassePiùStudenti.Click += new System.EventHandler(this.btnCercaClassePiùStudenti_Click);
            // 
            // btnContaStudentiClasse
            // 
            this.btnContaStudentiClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContaStudentiClasse.Location = new System.Drawing.Point(23, 82);
            this.btnContaStudentiClasse.Margin = new System.Windows.Forms.Padding(4);
            this.btnContaStudentiClasse.Name = "btnContaStudentiClasse";
            this.btnContaStudentiClasse.Size = new System.Drawing.Size(217, 52);
            this.btnContaStudentiClasse.TabIndex = 3;
            this.btnContaStudentiClasse.Text = "CONTA STUDENTI CLASSE";
            this.btnContaStudentiClasse.UseVisualStyleBackColor = true;
            this.btnContaStudentiClasse.Click += new System.EventHandler(this.btnContaStudentiClasse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn5Query);
            this.groupBox2.Controls.Add(this.cmbMaterieDinamica);
            this.groupBox2.Controls.Add(this.cmbMaterieStatica);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnMediaValutazioniMateria);
            this.groupBox2.Controls.Add(this.btnCalcolaMediaValutazioniMateria);
            this.groupBox2.Location = new System.Drawing.Point(547, 289);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(385, 327);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Query";
            // 
            // cmbMaterieDinamica
            // 
            this.cmbMaterieDinamica.FormattingEnabled = true;
            this.cmbMaterieDinamica.Location = new System.Drawing.Point(8, 82);
            this.cmbMaterieDinamica.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMaterieDinamica.Name = "cmbMaterieDinamica";
            this.cmbMaterieDinamica.Size = new System.Drawing.Size(143, 24);
            this.cmbMaterieDinamica.TabIndex = 7;
            // 
            // cmbMaterieStatica
            // 
            this.cmbMaterieStatica.FormattingEnabled = true;
            this.cmbMaterieStatica.Items.AddRange(new object[] {
            "ITA",
            "STO",
            "INF",
            "ING"});
            this.cmbMaterieStatica.Location = new System.Drawing.Point(8, 23);
            this.cmbMaterieStatica.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMaterieStatica.Name = "cmbMaterieStatica";
            this.cmbMaterieStatica.Size = new System.Drawing.Size(143, 24);
            this.cmbMaterieStatica.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(160, 197);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "RICERCA BINARIA MATRICOLA";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(160, 142);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(217, 52);
            this.button2.TabIndex = 4;
            this.button2.Text = "CERCA CLASSE CON + STUDENTI";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnMediaValutazioniMateria
            // 
            this.btnMediaValutazioniMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMediaValutazioniMateria.Location = new System.Drawing.Point(160, 82);
            this.btnMediaValutazioniMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnMediaValutazioniMateria.Name = "btnMediaValutazioniMateria";
            this.btnMediaValutazioniMateria.Size = new System.Drawing.Size(217, 52);
            this.btnMediaValutazioniMateria.TabIndex = 3;
            this.btnMediaValutazioniMateria.Text = "CALCOLA MEDIA VALUTAZIONI MATERIA";
            this.btnMediaValutazioniMateria.UseVisualStyleBackColor = true;
            this.btnMediaValutazioniMateria.Click += new System.EventHandler(this.btnMediaValutazioniMateria_Click);
            // 
            // btnCalcolaMediaValutazioniMateria
            // 
            this.btnCalcolaMediaValutazioniMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcolaMediaValutazioniMateria.Location = new System.Drawing.Point(160, 23);
            this.btnCalcolaMediaValutazioniMateria.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcolaMediaValutazioniMateria.Name = "btnCalcolaMediaValutazioniMateria";
            this.btnCalcolaMediaValutazioniMateria.Size = new System.Drawing.Size(217, 52);
            this.btnCalcolaMediaValutazioniMateria.TabIndex = 2;
            this.btnCalcolaMediaValutazioniMateria.Text = "CALCOLA MEDIA VALUTAZIONI MATERIA";
            this.btnCalcolaMediaValutazioniMateria.UseVisualStyleBackColor = true;
            this.btnCalcolaMediaValutazioniMateria.Click += new System.EventHandler(this.btnCalcolaMediaValutazioniMateria_Click);
            // 
            // dgvValutazioni
            // 
            this.dgvValutazioni.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvValutazioni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvValutazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValutazioni.Location = new System.Drawing.Point(16, 327);
            this.dgvValutazioni.Margin = new System.Windows.Forms.Padding(4);
            this.dgvValutazioni.Name = "dgvValutazioni";
            this.dgvValutazioni.RowHeadersWidth = 51;
            this.dgvValutazioni.Size = new System.Drawing.Size(362, 185);
            this.dgvValutazioni.TabIndex = 5;
            // 
            // btnCaricaValutazioni
            // 
            this.btnCaricaValutazioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaricaValutazioni.Location = new System.Drawing.Point(16, 291);
            this.btnCaricaValutazioni.Margin = new System.Windows.Forms.Padding(4);
            this.btnCaricaValutazioni.Name = "btnCaricaValutazioni";
            this.btnCaricaValutazioni.Size = new System.Drawing.Size(217, 28);
            this.btnCaricaValutazioni.TabIndex = 4;
            this.btnCaricaValutazioni.Text = "CARICA VALUTAZIONI";
            this.btnCaricaValutazioni.UseVisualStyleBackColor = true;
            this.btnCaricaValutazioni.Click += new System.EventHandler(this.btnCaricaValutazioni_Click);
            // 
            // btn5Query
            // 
            this.btn5Query.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5Query.Location = new System.Drawing.Point(160, 257);
            this.btn5Query.Margin = new System.Windows.Forms.Padding(4);
            this.btn5Query.Name = "btn5Query";
            this.btn5Query.Size = new System.Drawing.Size(217, 52);
            this.btn5Query.TabIndex = 7;
            this.btn5Query.Text = "CERCA MATERIA CON + VOTI";
            this.btn5Query.UseVisualStyleBackColor = true;
            this.btn5Query.Click += new System.EventHandler(this.btn5Query_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.btn1QueryComuni);
            this.groupBox3.Location = new System.Drawing.Point(969, 291);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(385, 327);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "QueryComuni";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(160, 257);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 52);
            this.button3.TabIndex = 7;
            this.button3.Text = "CERCA MATERIA CON + VOTI";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 82);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ITA",
            "STO",
            "INF",
            "ING"});
            this.comboBox2.Location = new System.Drawing.Point(8, 23);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(143, 24);
            this.comboBox2.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(160, 197);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(217, 52);
            this.button4.TabIndex = 5;
            this.button4.Text = "RICERCA BINARIA MATRICOLA";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(160, 142);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(217, 52);
            this.button5.TabIndex = 4;
            this.button5.Text = "CERCA CLASSE CON + STUDENTI";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(160, 82);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(217, 52);
            this.button6.TabIndex = 3;
            this.button6.Text = "CALCOLA MEDIA VALUTAZIONI MATERIA";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btn1QueryComuni
            // 
            this.btn1QueryComuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1QueryComuni.Location = new System.Drawing.Point(160, 23);
            this.btn1QueryComuni.Margin = new System.Windows.Forms.Padding(4);
            this.btn1QueryComuni.Name = "btn1QueryComuni";
            this.btn1QueryComuni.Size = new System.Drawing.Size(217, 52);
            this.btn1QueryComuni.TabIndex = 2;
            this.btn1QueryComuni.Text = "CALCOLA MEDIA STUDENTI";
            this.btn1QueryComuni.UseVisualStyleBackColor = true;
            this.btn1QueryComuni.Click += new System.EventHandler(this.btn1QueryComuni_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1667, 724);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvValutazioni);
            this.Controls.Add(this.btnCaricaValutazioni);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvStudenti);
            this.Controls.Add(this.btnCaricaTabellaStudenti);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Gestione Tabella";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvValutazioni)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCaricaTabellaStudenti;
        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.Button btnOrdinaStudentiCognomeNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnContaStudentiClasse;
        private System.Windows.Forms.Button btnCercaClassePiùStudenti;
        private System.Windows.Forms.Button btnRicercaBinariaMatricola;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMediaValutazioniMateria;
        private System.Windows.Forms.Button btnCalcolaMediaValutazioniMateria;
        private System.Windows.Forms.DataGridView dgvValutazioni;
        private System.Windows.Forms.Button btnCaricaValutazioni;
        private System.Windows.Forms.ComboBox cmbMaterieStatica;
        private System.Windows.Forms.ComboBox cmbMaterieDinamica;
        private System.Windows.Forms.Button btn5Query;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn1QueryComuni;
    }
}

