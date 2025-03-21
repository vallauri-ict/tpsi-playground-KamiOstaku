namespace Mediateca
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
            this.tabPagine = new System.Windows.Forms.TabControl();
            this.Soci = new System.Windows.Forms.TabPage();
            this.dgvSoci = new System.Windows.Forms.DataGridView();
            this.Media = new System.Windows.Forms.TabPage();
            this.Operazioni = new System.Windows.Forms.TabPage();
            this.dgvMedia = new System.Windows.Forms.DataGridView();
            this.dgvOperazioni = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InputCognomeSocio = new System.Windows.Forms.TextBox();
            this.InputNomeSocio = new System.Windows.Forms.TextBox();
            this.InputEmailSocio = new System.Windows.Forms.TextBox();
            this.InputTelefonoSocio = new System.Windows.Forms.TextBox();
            this.btnAddSocio = new System.Windows.Forms.Button();
            this.tabPagine.SuspendLayout();
            this.Soci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoci)).BeginInit();
            this.Media.SuspendLayout();
            this.Operazioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperazioni)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPagine
            // 
            this.tabPagine.Controls.Add(this.Soci);
            this.tabPagine.Controls.Add(this.Media);
            this.tabPagine.Controls.Add(this.Operazioni);
            this.tabPagine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPagine.Location = new System.Drawing.Point(0, 0);
            this.tabPagine.Name = "tabPagine";
            this.tabPagine.SelectedIndex = 0;
            this.tabPagine.Size = new System.Drawing.Size(1079, 450);
            this.tabPagine.TabIndex = 0;
            // 
            // Soci
            // 
            this.Soci.Controls.Add(this.groupBox1);
            this.Soci.Controls.Add(this.dgvSoci);
            this.Soci.Location = new System.Drawing.Point(4, 25);
            this.Soci.Name = "Soci";
            this.Soci.Padding = new System.Windows.Forms.Padding(3);
            this.Soci.Size = new System.Drawing.Size(1071, 421);
            this.Soci.TabIndex = 1;
            this.Soci.Text = "Soci";
            this.Soci.UseVisualStyleBackColor = true;
            // 
            // dgvSoci
            // 
            this.dgvSoci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoci.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvSoci.Location = new System.Drawing.Point(3, 3);
            this.dgvSoci.Name = "dgvSoci";
            this.dgvSoci.RowHeadersWidth = 51;
            this.dgvSoci.RowTemplate.Height = 24;
            this.dgvSoci.Size = new System.Drawing.Size(651, 415);
            this.dgvSoci.TabIndex = 0;
            // 
            // Media
            // 
            this.Media.Controls.Add(this.dgvMedia);
            this.Media.Location = new System.Drawing.Point(4, 25);
            this.Media.Name = "Media";
            this.Media.Padding = new System.Windows.Forms.Padding(3);
            this.Media.Size = new System.Drawing.Size(1071, 421);
            this.Media.TabIndex = 0;
            this.Media.Text = "Media";
            this.Media.UseVisualStyleBackColor = true;
            // 
            // Operazioni
            // 
            this.Operazioni.Controls.Add(this.dgvOperazioni);
            this.Operazioni.Location = new System.Drawing.Point(4, 25);
            this.Operazioni.Name = "Operazioni";
            this.Operazioni.Size = new System.Drawing.Size(1071, 421);
            this.Operazioni.TabIndex = 2;
            this.Operazioni.Text = "Operazioni";
            this.Operazioni.UseVisualStyleBackColor = true;
            // 
            // dgvMedia
            // 
            this.dgvMedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedia.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvMedia.Location = new System.Drawing.Point(3, 3);
            this.dgvMedia.Name = "dgvMedia";
            this.dgvMedia.RowHeadersWidth = 51;
            this.dgvMedia.RowTemplate.Height = 24;
            this.dgvMedia.Size = new System.Drawing.Size(651, 415);
            this.dgvMedia.TabIndex = 1;
            // 
            // dgvOperazioni
            // 
            this.dgvOperazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperazioni.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvOperazioni.Location = new System.Drawing.Point(0, 0);
            this.dgvOperazioni.Name = "dgvOperazioni";
            this.dgvOperazioni.RowHeadersWidth = 51;
            this.dgvOperazioni.RowTemplate.Height = 24;
            this.dgvOperazioni.Size = new System.Drawing.Size(651, 421);
            this.dgvOperazioni.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddSocio);
            this.groupBox1.Controls.Add(this.InputTelefonoSocio);
            this.groupBox1.Controls.Add(this.InputEmailSocio);
            this.groupBox1.Controls.Add(this.InputNomeSocio);
            this.groupBox1.Controls.Add(this.InputCognomeSocio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(660, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 414);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inserisci Socio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "cognome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "telefono";
            // 
            // InputCognomeSocio
            // 
            this.InputCognomeSocio.Location = new System.Drawing.Point(118, 30);
            this.InputCognomeSocio.Name = "InputCognomeSocio";
            this.InputCognomeSocio.Size = new System.Drawing.Size(265, 22);
            this.InputCognomeSocio.TabIndex = 4;
            this.InputCognomeSocio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.controllaInput);
            // 
            // InputNomeSocio
            // 
            this.InputNomeSocio.Location = new System.Drawing.Point(118, 65);
            this.InputNomeSocio.Name = "InputNomeSocio";
            this.InputNomeSocio.Size = new System.Drawing.Size(265, 22);
            this.InputNomeSocio.TabIndex = 5;
            // 
            // InputEmailSocio
            // 
            this.InputEmailSocio.Location = new System.Drawing.Point(118, 101);
            this.InputEmailSocio.Name = "InputEmailSocio";
            this.InputEmailSocio.Size = new System.Drawing.Size(265, 22);
            this.InputEmailSocio.TabIndex = 6;
            // 
            // InputTelefonoSocio
            // 
            this.InputTelefonoSocio.Location = new System.Drawing.Point(118, 141);
            this.InputTelefonoSocio.Name = "InputTelefonoSocio";
            this.InputTelefonoSocio.Size = new System.Drawing.Size(265, 22);
            this.InputTelefonoSocio.TabIndex = 7;
            // 
            // btnAddSocio
            // 
            this.btnAddSocio.Location = new System.Drawing.Point(113, 195);
            this.btnAddSocio.Name = "btnAddSocio";
            this.btnAddSocio.Size = new System.Drawing.Size(149, 39);
            this.btnAddSocio.TabIndex = 8;
            this.btnAddSocio.Text = "Inserisci Socio";
            this.btnAddSocio.UseVisualStyleBackColor = true;
            this.btnAddSocio.Click += new System.EventHandler(this.btnAddSocio_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 450);
            this.Controls.Add(this.tabPagine);
            this.Name = "frmMain";
            this.Text = "MediaTeca";
            this.tabPagine.ResumeLayout(false);
            this.Soci.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoci)).EndInit();
            this.Media.ResumeLayout(false);
            this.Operazioni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperazioni)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPagine;
        private System.Windows.Forms.TabPage Media;
        private System.Windows.Forms.TabPage Soci;
        private System.Windows.Forms.DataGridView dgvSoci;
        private System.Windows.Forms.TabPage Operazioni;
        private System.Windows.Forms.DataGridView dgvMedia;
        private System.Windows.Forms.DataGridView dgvOperazioni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddSocio;
        private System.Windows.Forms.TextBox InputTelefonoSocio;
        private System.Windows.Forms.TextBox InputEmailSocio;
        private System.Windows.Forms.TextBox InputNomeSocio;
        private System.Windows.Forms.TextBox InputCognomeSocio;
    }
}

