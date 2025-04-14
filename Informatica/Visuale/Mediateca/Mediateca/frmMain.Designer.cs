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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageSoci = new System.Windows.Forms.TabPage();
            this.groupBoxSoci = new System.Windows.Forms.GroupBox();
            this.btnAnnullaSocio = new System.Windows.Forms.Button();
            this.btnSalvaSocio = new System.Windows.Forms.Button();
            this.btnModificaSocio = new System.Windows.Forms.Button();
            this.btnCancellaSocio = new System.Windows.Forms.Button();
            this.btnInserisciSocio = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSoci = new System.Windows.Forms.DataGridView();
            this.tabPageMedia = new System.Windows.Forms.TabPage();
            this.groupBoxMedia = new System.Windows.Forms.GroupBox();
            this.cmbGenere = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnAnnullaMedia = new System.Windows.Forms.Button();
            this.btnSalvaMedia = new System.Windows.Forms.Button();
            this.btnModificaMedia = new System.Windows.Forms.Button();
            this.btnCancellaMedia = new System.Windows.Forms.Button();
            this.btnInserisciMedia = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTitolo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvMedia = new System.Windows.Forms.DataGridView();
            this.tabPageOperazioni = new System.Windows.Forms.TabPage();
            this.groupBoxOperazioni = new System.Windows.Forms.GroupBox();
            this.cmbMedia = new System.Windows.Forms.ComboBox();
            this.cmbSocio = new System.Windows.Forms.ComboBox();
            this.btnRestituzione = new System.Windows.Forms.Button();
            this.btnPrestito = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvOperazioni = new System.Windows.Forms.DataGridView();
            this.tabControlMain.SuspendLayout();
            this.tabPageSoci.SuspendLayout();
            this.groupBoxSoci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoci)).BeginInit();
            this.tabPageMedia.SuspendLayout();
            this.groupBoxMedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedia)).BeginInit();
            this.tabPageOperazioni.SuspendLayout();
            this.groupBoxOperazioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperazioni)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageSoci);
            this.tabControlMain.Controls.Add(this.tabPageMedia);
            this.tabControlMain.Controls.Add(this.tabPageOperazioni);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1097, 554);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPageSoci
            // 
            this.tabPageSoci.Controls.Add(this.groupBoxSoci);
            this.tabPageSoci.Controls.Add(this.dgvSoci);
            this.tabPageSoci.Location = new System.Drawing.Point(4, 25);
            this.tabPageSoci.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageSoci.Name = "tabPageSoci";
            this.tabPageSoci.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageSoci.Size = new System.Drawing.Size(1089, 525);
            this.tabPageSoci.TabIndex = 1;
            this.tabPageSoci.Text = "SOCI";
            this.tabPageSoci.UseVisualStyleBackColor = true;
            // 
            // groupBoxSoci
            // 
            this.groupBoxSoci.Controls.Add(this.btnAnnullaSocio);
            this.groupBoxSoci.Controls.Add(this.btnSalvaSocio);
            this.groupBoxSoci.Controls.Add(this.btnModificaSocio);
            this.groupBoxSoci.Controls.Add(this.btnCancellaSocio);
            this.groupBoxSoci.Controls.Add(this.btnInserisciSocio);
            this.groupBoxSoci.Controls.Add(this.txtTelefono);
            this.groupBoxSoci.Controls.Add(this.label4);
            this.groupBoxSoci.Controls.Add(this.txtEmail);
            this.groupBoxSoci.Controls.Add(this.label3);
            this.groupBoxSoci.Controls.Add(this.txtNome);
            this.groupBoxSoci.Controls.Add(this.label2);
            this.groupBoxSoci.Controls.Add(this.txtCognome);
            this.groupBoxSoci.Controls.Add(this.label1);
            this.groupBoxSoci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSoci.Location = new System.Drawing.Point(789, 4);
            this.groupBoxSoci.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSoci.Name = "groupBoxSoci";
            this.groupBoxSoci.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxSoci.Size = new System.Drawing.Size(287, 508);
            this.groupBoxSoci.TabIndex = 1;
            this.groupBoxSoci.TabStop = false;
            this.groupBoxSoci.Text = "Comandi e Query";
            // 
            // btnAnnullaSocio
            // 
            this.btnAnnullaSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnullaSocio.Location = new System.Drawing.Point(149, 318);
            this.btnAnnullaSocio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnnullaSocio.Name = "btnAnnullaSocio";
            this.btnAnnullaSocio.Size = new System.Drawing.Size(124, 38);
            this.btnAnnullaSocio.TabIndex = 12;
            this.btnAnnullaSocio.Text = "ANNULLA";
            this.btnAnnullaSocio.UseVisualStyleBackColor = true;
            this.btnAnnullaSocio.Click += new System.EventHandler(this.btnAnnullaSocio_Click);
            // 
            // btnSalvaSocio
            // 
            this.btnSalvaSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvaSocio.Location = new System.Drawing.Point(23, 318);
            this.btnSalvaSocio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvaSocio.Name = "btnSalvaSocio";
            this.btnSalvaSocio.Size = new System.Drawing.Size(119, 38);
            this.btnSalvaSocio.TabIndex = 11;
            this.btnSalvaSocio.Text = "SALVA";
            this.btnSalvaSocio.UseVisualStyleBackColor = true;
            this.btnSalvaSocio.Click += new System.EventHandler(this.btnSalvaSocio_Click);
            // 
            // btnModificaSocio
            // 
            this.btnModificaSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaSocio.Location = new System.Drawing.Point(23, 272);
            this.btnModificaSocio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificaSocio.Name = "btnModificaSocio";
            this.btnModificaSocio.Size = new System.Drawing.Size(251, 38);
            this.btnModificaSocio.TabIndex = 10;
            this.btnModificaSocio.Text = "MODIFICA SOCIO";
            this.btnModificaSocio.UseVisualStyleBackColor = true;
            this.btnModificaSocio.Click += new System.EventHandler(this.btnModificaSocio_Click);
            // 
            // btnCancellaSocio
            // 
            this.btnCancellaSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancellaSocio.Location = new System.Drawing.Point(23, 226);
            this.btnCancellaSocio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancellaSocio.Name = "btnCancellaSocio";
            this.btnCancellaSocio.Size = new System.Drawing.Size(251, 38);
            this.btnCancellaSocio.TabIndex = 9;
            this.btnCancellaSocio.Text = "CANCELLA SOCIO";
            this.btnCancellaSocio.UseVisualStyleBackColor = true;
            this.btnCancellaSocio.Click += new System.EventHandler(this.btnCancellaSocio_Click);
            // 
            // btnInserisciSocio
            // 
            this.btnInserisciSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserisciSocio.Location = new System.Drawing.Point(23, 181);
            this.btnInserisciSocio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInserisciSocio.Name = "btnInserisciSocio";
            this.btnInserisciSocio.Size = new System.Drawing.Size(251, 38);
            this.btnInserisciSocio.TabIndex = 8;
            this.btnInserisciSocio.Text = "INSERISCI SOCIO";
            this.btnInserisciSocio.UseVisualStyleBackColor = true;
            this.btnInserisciSocio.Click += new System.EventHandler(this.btnInserisciSocio_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(119, 142);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(153, 26);
            this.txtTelefono.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(119, 106);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(153, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "eMail";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(119, 70);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(153, 26);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(119, 34);
            this.txtCognome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(153, 26);
            this.txtCognome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cognome";
            // 
            // dgvSoci
            // 
            this.dgvSoci.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSoci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSoci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoci.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvSoci.Location = new System.Drawing.Point(4, 4);
            this.dgvSoci.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSoci.Name = "dgvSoci";
            this.dgvSoci.RowHeadersWidth = 51;
            this.dgvSoci.Size = new System.Drawing.Size(777, 517);
            this.dgvSoci.TabIndex = 0;
            // 
            // tabPageMedia
            // 
            this.tabPageMedia.Controls.Add(this.groupBoxMedia);
            this.tabPageMedia.Controls.Add(this.dgvMedia);
            this.tabPageMedia.Location = new System.Drawing.Point(4, 25);
            this.tabPageMedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageMedia.Name = "tabPageMedia";
            this.tabPageMedia.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageMedia.Size = new System.Drawing.Size(1089, 525);
            this.tabPageMedia.TabIndex = 0;
            this.tabPageMedia.Text = "MEDIA";
            this.tabPageMedia.UseVisualStyleBackColor = true;
            // 
            // groupBoxMedia
            // 
            this.groupBoxMedia.Controls.Add(this.cmbGenere);
            this.groupBoxMedia.Controls.Add(this.cmbTipo);
            this.groupBoxMedia.Controls.Add(this.btnAnnullaMedia);
            this.groupBoxMedia.Controls.Add(this.btnSalvaMedia);
            this.groupBoxMedia.Controls.Add(this.btnModificaMedia);
            this.groupBoxMedia.Controls.Add(this.btnCancellaMedia);
            this.groupBoxMedia.Controls.Add(this.btnInserisciMedia);
            this.groupBoxMedia.Controls.Add(this.label5);
            this.groupBoxMedia.Controls.Add(this.label6);
            this.groupBoxMedia.Controls.Add(this.txtAutore);
            this.groupBoxMedia.Controls.Add(this.label7);
            this.groupBoxMedia.Controls.Add(this.txtTitolo);
            this.groupBoxMedia.Controls.Add(this.label8);
            this.groupBoxMedia.Location = new System.Drawing.Point(793, 9);
            this.groupBoxMedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMedia.Name = "groupBoxMedia";
            this.groupBoxMedia.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMedia.Size = new System.Drawing.Size(283, 503);
            this.groupBoxMedia.TabIndex = 1;
            this.groupBoxMedia.TabStop = false;
            this.groupBoxMedia.Text = "Comandi e Query";
            // 
            // cmbGenere
            // 
            this.cmbGenere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenere.FormattingEnabled = true;
            this.cmbGenere.Location = new System.Drawing.Point(108, 135);
            this.cmbGenere.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbGenere.Name = "cmbGenere";
            this.cmbGenere.Size = new System.Drawing.Size(153, 24);
            this.cmbGenere.TabIndex = 27;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(108, 96);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(153, 24);
            this.cmbTipo.TabIndex = 26;
            // 
            // btnAnnullaMedia
            // 
            this.btnAnnullaMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnullaMedia.Location = new System.Drawing.Point(139, 305);
            this.btnAnnullaMedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnnullaMedia.Name = "btnAnnullaMedia";
            this.btnAnnullaMedia.Size = new System.Drawing.Size(124, 38);
            this.btnAnnullaMedia.TabIndex = 25;
            this.btnAnnullaMedia.Text = "ANNULLA";
            this.btnAnnullaMedia.UseVisualStyleBackColor = true;
            this.btnAnnullaMedia.Click += new System.EventHandler(this.btnAnnullaMedia_Click);
            // 
            // btnSalvaMedia
            // 
            this.btnSalvaMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvaMedia.Location = new System.Drawing.Point(12, 305);
            this.btnSalvaMedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvaMedia.Name = "btnSalvaMedia";
            this.btnSalvaMedia.Size = new System.Drawing.Size(119, 38);
            this.btnSalvaMedia.TabIndex = 24;
            this.btnSalvaMedia.Text = "SALVA";
            this.btnSalvaMedia.UseVisualStyleBackColor = true;
            this.btnSalvaMedia.Click += new System.EventHandler(this.btnSalvaMedia_Click);
            // 
            // btnModificaMedia
            // 
            this.btnModificaMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificaMedia.Location = new System.Drawing.Point(12, 260);
            this.btnModificaMedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModificaMedia.Name = "btnModificaMedia";
            this.btnModificaMedia.Size = new System.Drawing.Size(251, 38);
            this.btnModificaMedia.TabIndex = 23;
            this.btnModificaMedia.Text = "MODIFICA MEDIA";
            this.btnModificaMedia.UseVisualStyleBackColor = true;
            this.btnModificaMedia.Click += new System.EventHandler(this.btnModificaMedia_Click);
            // 
            // btnCancellaMedia
            // 
            this.btnCancellaMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancellaMedia.Location = new System.Drawing.Point(12, 214);
            this.btnCancellaMedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancellaMedia.Name = "btnCancellaMedia";
            this.btnCancellaMedia.Size = new System.Drawing.Size(251, 38);
            this.btnCancellaMedia.TabIndex = 22;
            this.btnCancellaMedia.Text = "CANCELLA MEDIA";
            this.btnCancellaMedia.UseVisualStyleBackColor = true;
            this.btnCancellaMedia.Click += new System.EventHandler(this.btnCancellaMedia_Click);
            // 
            // btnInserisciMedia
            // 
            this.btnInserisciMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserisciMedia.Location = new System.Drawing.Point(12, 169);
            this.btnInserisciMedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInserisciMedia.Name = "btnInserisciMedia";
            this.btnInserisciMedia.Size = new System.Drawing.Size(251, 38);
            this.btnInserisciMedia.TabIndex = 21;
            this.btnInserisciMedia.Text = "INSERISCI MEDIA";
            this.btnInserisciMedia.UseVisualStyleBackColor = true;
            this.btnInserisciMedia.Click += new System.EventHandler(this.btnInserisciMedia_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Genere";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Tipo";
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(108, 58);
            this.txtAutore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(153, 22);
            this.txtAutore.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Autore";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(108, 22);
            this.txtTitolo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(153, 22);
            this.txtTitolo.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Titolo";
            // 
            // dgvMedia
            // 
            this.dgvMedia.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMedia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedia.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvMedia.Location = new System.Drawing.Point(4, 4);
            this.dgvMedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMedia.Name = "dgvMedia";
            this.dgvMedia.RowHeadersWidth = 51;
            this.dgvMedia.Size = new System.Drawing.Size(780, 517);
            this.dgvMedia.TabIndex = 0;
            // 
            // tabPageOperazioni
            // 
            this.tabPageOperazioni.Controls.Add(this.groupBoxOperazioni);
            this.tabPageOperazioni.Controls.Add(this.dgvOperazioni);
            this.tabPageOperazioni.Location = new System.Drawing.Point(4, 25);
            this.tabPageOperazioni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageOperazioni.Name = "tabPageOperazioni";
            this.tabPageOperazioni.Size = new System.Drawing.Size(1089, 525);
            this.tabPageOperazioni.TabIndex = 2;
            this.tabPageOperazioni.Text = "OPERAZIONI";
            this.tabPageOperazioni.UseVisualStyleBackColor = true;
            // 
            // groupBoxOperazioni
            // 
            this.groupBoxOperazioni.Controls.Add(this.cmbMedia);
            this.groupBoxOperazioni.Controls.Add(this.cmbSocio);
            this.groupBoxOperazioni.Controls.Add(this.btnRestituzione);
            this.groupBoxOperazioni.Controls.Add(this.btnPrestito);
            this.groupBoxOperazioni.Controls.Add(this.label11);
            this.groupBoxOperazioni.Controls.Add(this.label12);
            this.groupBoxOperazioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOperazioni.Location = new System.Drawing.Point(785, 10);
            this.groupBoxOperazioni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxOperazioni.Name = "groupBoxOperazioni";
            this.groupBoxOperazioni.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxOperazioni.Size = new System.Drawing.Size(287, 508);
            this.groupBoxOperazioni.TabIndex = 2;
            this.groupBoxOperazioni.TabStop = false;
            this.groupBoxOperazioni.Text = "Comandi e Query";
            // 
            // cmbMedia
            // 
            this.cmbMedia.FormattingEnabled = true;
            this.cmbMedia.Location = new System.Drawing.Point(119, 70);
            this.cmbMedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMedia.Name = "cmbMedia";
            this.cmbMedia.Size = new System.Drawing.Size(153, 28);
            this.cmbMedia.TabIndex = 11;
            // 
            // cmbSocio
            // 
            this.cmbSocio.FormattingEnabled = true;
            this.cmbSocio.Location = new System.Drawing.Point(119, 34);
            this.cmbSocio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSocio.Name = "cmbSocio";
            this.cmbSocio.Size = new System.Drawing.Size(153, 28);
            this.cmbSocio.TabIndex = 10;
            // 
            // btnRestituzione
            // 
            this.btnRestituzione.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestituzione.Location = new System.Drawing.Point(23, 165);
            this.btnRestituzione.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRestituzione.Name = "btnRestituzione";
            this.btnRestituzione.Size = new System.Drawing.Size(251, 38);
            this.btnRestituzione.TabIndex = 9;
            this.btnRestituzione.Text = "RESTITUZIONE";
            this.btnRestituzione.UseVisualStyleBackColor = true;
            this.btnRestituzione.Click += new System.EventHandler(this.btnRestituzione_Click);
            // 
            // btnPrestito
            // 
            this.btnPrestito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestito.Location = new System.Drawing.Point(23, 119);
            this.btnPrestito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrestito.Name = "btnPrestito";
            this.btnPrestito.Size = new System.Drawing.Size(251, 38);
            this.btnPrestito.TabIndex = 8;
            this.btnPrestito.Text = "PRESTITO";
            this.btnPrestito.UseVisualStyleBackColor = true;
            this.btnPrestito.Click += new System.EventHandler(this.btnPrestito_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 74);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Media";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 34);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Socio";
            // 
            // dgvOperazioni
            // 
            this.dgvOperazioni.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvOperazioni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOperazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperazioni.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvOperazioni.Location = new System.Drawing.Point(0, 0);
            this.dgvOperazioni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvOperazioni.Name = "dgvOperazioni";
            this.dgvOperazioni.RowHeadersWidth = 51;
            this.dgvOperazioni.Size = new System.Drawing.Size(777, 525);
            this.dgvOperazioni.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 554);
            this.Controls.Add(this.tabControlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "MEDIATECA";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageSoci.ResumeLayout(false);
            this.groupBoxSoci.ResumeLayout(false);
            this.groupBoxSoci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoci)).EndInit();
            this.tabPageMedia.ResumeLayout(false);
            this.groupBoxMedia.ResumeLayout(false);
            this.groupBoxMedia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedia)).EndInit();
            this.tabPageOperazioni.ResumeLayout(false);
            this.groupBoxOperazioni.ResumeLayout(false);
            this.groupBoxOperazioni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperazioni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageSoci;
        private System.Windows.Forms.DataGridView dgvSoci;
        private System.Windows.Forms.TabPage tabPageMedia;
        private System.Windows.Forms.TabPage tabPageOperazioni;
        private System.Windows.Forms.GroupBox groupBoxSoci;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInserisciSocio;
        private System.Windows.Forms.Button btnCancellaSocio;
        private System.Windows.Forms.Button btnModificaSocio;
        private System.Windows.Forms.Button btnAnnullaSocio;
        private System.Windows.Forms.Button btnSalvaSocio;
        private System.Windows.Forms.DataGridView dgvMedia;
        private System.Windows.Forms.GroupBox groupBoxMedia;
        private System.Windows.Forms.Button btnAnnullaMedia;
        private System.Windows.Forms.Button btnSalvaMedia;
        private System.Windows.Forms.Button btnModificaMedia;
        private System.Windows.Forms.Button btnCancellaMedia;
        private System.Windows.Forms.Button btnInserisciMedia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTitolo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbGenere;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.GroupBox groupBoxOperazioni;
        private System.Windows.Forms.Button btnRestituzione;
        private System.Windows.Forms.Button btnPrestito;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvOperazioni;
        private System.Windows.Forms.ComboBox cmbMedia;
        private System.Windows.Forms.ComboBox cmbSocio;
    }
}

