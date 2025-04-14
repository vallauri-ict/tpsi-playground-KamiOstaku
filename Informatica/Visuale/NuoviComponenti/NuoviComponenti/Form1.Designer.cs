namespace NuoviComponenti
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
            this.txtCogn = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.brtPicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbComune = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.clsSelector = new System.Windows.Forms.NumericUpDown();
            this.sectSelector = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chkAM = new System.Windows.Forms.CheckBox();
            this.chkB = new System.Windows.Forms.CheckBox();
            this.chkA = new System.Windows.Forms.CheckBox();
            this.chkA2 = new System.Windows.Forms.CheckBox();
            this.chkA1 = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.chkList = new System.Windows.Forms.CheckedListBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.DIALOG = new System.Windows.Forms.GroupBox();
            this.btnColore = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.txtFont = new System.Windows.Forms.TextBox();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsSelector)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.DIALOG.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCogn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COGNOME";
            // 
            // txtCogn
            // 
            this.txtCogn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCogn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCogn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCogn.Location = new System.Drawing.Point(6, 21);
            this.txtCogn.Name = "txtCogn";
            this.txtCogn.Size = new System.Drawing.Size(267, 34);
            this.txtCogn.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Location = new System.Drawing.Point(297, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 65);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NOME";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNome.Location = new System.Drawing.Point(6, 21);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(267, 34);
            this.txtNome.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdFemale);
            this.groupBox3.Controls.Add(this.rdMale);
            this.groupBox3.Location = new System.Drawing.Point(582, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(119, 65);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GENERE";
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(68, 32);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(36, 20);
            this.rdFemale.TabIndex = 5;
            this.rdFemale.Text = "F";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Checked = true;
            this.rdMale.Location = new System.Drawing.Point(23, 32);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(39, 20);
            this.rdMale.TabIndex = 4;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "M";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // brtPicker
            // 
            this.brtPicker.Location = new System.Drawing.Point(6, 21);
            this.brtPicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.brtPicker.MinDate = new System.DateTime(1899, 1, 1, 0, 0, 0, 0);
            this.brtPicker.Name = "brtPicker";
            this.brtPicker.Size = new System.Drawing.Size(267, 22);
            this.brtPicker.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.brtPicker);
            this.groupBox4.Location = new System.Drawing.Point(12, 83);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(279, 54);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DATA DI NASCITA";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbComune);
            this.groupBox5.Location = new System.Drawing.Point(297, 83);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(279, 65);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "COMUNE";
            // 
            // cmbComune
            // 
            this.cmbComune.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbComune.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComune.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComune.FormattingEnabled = true;
            this.cmbComune.Location = new System.Drawing.Point(6, 21);
            this.cmbComune.Name = "cmbComune";
            this.cmbComune.Size = new System.Drawing.Size(267, 37);
            this.cmbComune.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.clsSelector);
            this.groupBox6.Controls.Add(this.sectSelector);
            this.groupBox6.Location = new System.Drawing.Point(582, 83);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(119, 65);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "CLASSE";
            // 
            // clsSelector
            // 
            this.clsSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clsSelector.Location = new System.Drawing.Point(7, 22);
            this.clsSelector.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.clsSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clsSelector.Name = "clsSelector";
            this.clsSelector.Size = new System.Drawing.Size(55, 34);
            this.clsSelector.TabIndex = 1;
            this.clsSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clsSelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sectSelector
            // 
            this.sectSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sectSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectSelector.FormattingEnabled = true;
            this.sectSelector.Location = new System.Drawing.Point(68, 21);
            this.sectSelector.Name = "sectSelector";
            this.sectSelector.Size = new System.Drawing.Size(45, 37);
            this.sectSelector.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chkAM);
            this.groupBox7.Controls.Add(this.chkB);
            this.groupBox7.Controls.Add(this.chkA);
            this.groupBox7.Controls.Add(this.chkA2);
            this.groupBox7.Controls.Add(this.chkA1);
            this.groupBox7.Location = new System.Drawing.Point(12, 143);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(279, 80);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "PATENTE";
            // 
            // chkAM
            // 
            this.chkAM.AutoSize = true;
            this.chkAM.Location = new System.Drawing.Point(224, 21);
            this.chkAM.Name = "chkAM";
            this.chkAM.Size = new System.Drawing.Size(49, 20);
            this.chkAM.TabIndex = 7;
            this.chkAM.Text = "AM";
            this.chkAM.UseVisualStyleBackColor = true;
            // 
            // chkB
            // 
            this.chkB.AutoSize = true;
            this.chkB.Location = new System.Drawing.Point(121, 47);
            this.chkB.Name = "chkB";
            this.chkB.Size = new System.Drawing.Size(38, 20);
            this.chkB.TabIndex = 7;
            this.chkB.Text = "B";
            this.chkB.UseVisualStyleBackColor = true;
            // 
            // chkA
            // 
            this.chkA.AutoSize = true;
            this.chkA.Location = new System.Drawing.Point(121, 21);
            this.chkA.Name = "chkA";
            this.chkA.Size = new System.Drawing.Size(38, 20);
            this.chkA.TabIndex = 7;
            this.chkA.Text = "A";
            this.chkA.UseVisualStyleBackColor = true;
            // 
            // chkA2
            // 
            this.chkA2.AutoSize = true;
            this.chkA2.Location = new System.Drawing.Point(6, 47);
            this.chkA2.Name = "chkA2";
            this.chkA2.Size = new System.Drawing.Size(45, 20);
            this.chkA2.TabIndex = 1;
            this.chkA2.Text = "A2";
            this.chkA2.UseVisualStyleBackColor = true;
            // 
            // chkA1
            // 
            this.chkA1.AutoSize = true;
            this.chkA1.Location = new System.Drawing.Point(6, 21);
            this.chkA1.Name = "chkA1";
            this.chkA1.Size = new System.Drawing.Size(45, 20);
            this.chkA1.TabIndex = 0;
            this.chkA1.Text = "A1";
            this.chkA1.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.chkList);
            this.groupBox8.Location = new System.Drawing.Point(297, 154);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(279, 123);
            this.groupBox8.TabIndex = 2;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "HOBBY";
            // 
            // chkList
            // 
            this.chkList.CheckOnClick = true;
            this.chkList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkList.FormattingEnabled = true;
            this.chkList.Items.AddRange(new object[] {
            "Programmazione",
            "Giardinaggio",
            "Cucina",
            "Modellismo",
            "Disegno",
            "Musica"});
            this.chkList.Location = new System.Drawing.Point(6, 21);
            this.chkList.Name = "chkList";
            this.chkList.Size = new System.Drawing.Size(267, 79);
            this.chkList.TabIndex = 0;
            // 
            // btnInserisci
            // 
            this.btnInserisci.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInserisci.Location = new System.Drawing.Point(582, 161);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(119, 62);
            this.btnInserisci.TabIndex = 7;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 283);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(917, 275);
            this.dgv.TabIndex = 8;
            // 
            // DIALOG
            // 
            this.DIALOG.Controls.Add(this.txtFile);
            this.DIALOG.Controls.Add(this.txtFolder);
            this.DIALOG.Controls.Add(this.txtFont);
            this.DIALOG.Controls.Add(this.btnFile);
            this.DIALOG.Controls.Add(this.btnFolder);
            this.DIALOG.Controls.Add(this.btnFont);
            this.DIALOG.Controls.Add(this.txtColor);
            this.DIALOG.Controls.Add(this.btnColore);
            this.DIALOG.Location = new System.Drawing.Point(726, 12);
            this.DIALOG.Name = "DIALOG";
            this.DIALOG.Size = new System.Drawing.Size(469, 490);
            this.DIALOG.TabIndex = 9;
            this.DIALOG.TabStop = false;
            this.DIALOG.Text = "DIALOG";
            // 
            // btnColore
            // 
            this.btnColore.Location = new System.Drawing.Point(25, 25);
            this.btnColore.Name = "btnColore";
            this.btnColore.Size = new System.Drawing.Size(147, 67);
            this.btnColore.TabIndex = 0;
            this.btnColore.Text = "Colore";
            this.btnColore.UseVisualStyleBackColor = true;
            this.btnColore.Click += new System.EventHandler(this.btnColore_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(187, 47);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(254, 22);
            this.txtColor.TabIndex = 1;
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(25, 98);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(147, 67);
            this.btnFont.TabIndex = 2;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(25, 171);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(147, 67);
            this.btnFolder.TabIndex = 3;
            this.btnFolder.Text = "Folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(25, 244);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(147, 67);
            this.btnFile.TabIndex = 4;
            this.btnFile.Text = "File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // txtFont
            // 
            this.txtFont.Location = new System.Drawing.Point(187, 120);
            this.txtFont.Name = "txtFont";
            this.txtFont.ReadOnly = true;
            this.txtFont.Size = new System.Drawing.Size(254, 22);
            this.txtFont.TabIndex = 5;
            this.txtFont.Text = "Esempio Font";
            this.txtFont.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(187, 193);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.Size = new System.Drawing.Size(254, 22);
            this.txtFolder.TabIndex = 6;
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(187, 266);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(254, 22);
            this.txtFile.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 592);
            this.Controls.Add(this.DIALOG);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Componenti Aggiuntivi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clsSelector)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.DIALOG.ResumeLayout(false);
            this.DIALOG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCogn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.DateTimePicker brtPicker;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbComune;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown clsSelector;
        private System.Windows.Forms.ComboBox sectSelector;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox chkAM;
        private System.Windows.Forms.CheckBox chkB;
        private System.Windows.Forms.CheckBox chkA;
        private System.Windows.Forms.CheckBox chkA2;
        private System.Windows.Forms.CheckBox chkA1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckedListBox chkList;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox DIALOG;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Button btnColore;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.TextBox txtFont;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnFont;
    }
}

