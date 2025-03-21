namespace GestioneClientelaNegozio
{
    partial class ClientManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DisplayStruct = new DataGridView();
            SubmitClient = new Button();
            groupBox1 = new GroupBox();
            ListaProdotti = new ComboBox();
            InputQuantity = new TextBox();
            Quantita = new Label();
            label2 = new Label();
            label1 = new Label();
            InputName = new TextBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            matricolaAnnullamento = new TextBox();
            btnUndoRegistration = new Button();
            groupBox3 = new GroupBox();
            inputPrice = new TextBox();
            label3 = new Label();
            label6 = new Label();
            inputAddProduct = new TextBox();
            btnAddProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)DisplayStruct).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // DisplayStruct
            // 
            DisplayStruct.AllowUserToAddRows = false;
            DisplayStruct.AllowUserToDeleteRows = false;
            DisplayStruct.AllowUserToResizeColumns = false;
            DisplayStruct.AllowUserToResizeRows = false;
            DisplayStruct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            DisplayStruct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DisplayStruct.Location = new Point(815, 12);
            DisplayStruct.Name = "DisplayStruct";
            DisplayStruct.RowHeadersVisible = false;
            DisplayStruct.RowHeadersWidth = 51;
            DisplayStruct.Size = new Size(608, 550);
            DisplayStruct.TabIndex = 0;
            // 
            // SubmitClient
            // 
            SubmitClient.Location = new Point(78, 194);
            SubmitClient.Name = "SubmitClient";
            SubmitClient.Size = new Size(166, 54);
            SubmitClient.TabIndex = 1;
            SubmitClient.Text = "Registra";
            SubmitClient.UseVisualStyleBackColor = true;
            SubmitClient.Click += SubmitClient_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ListaProdotti);
            groupBox1.Controls.Add(InputQuantity);
            groupBox1.Controls.Add(Quantita);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(InputName);
            groupBox1.Controls.Add(SubmitClient);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 267);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Aggiungi Cliente";
            // 
            // ListaProdotti
            // 
            ListaProdotti.DropDownStyle = ComboBoxStyle.DropDownList;
            ListaProdotti.FormattingEnabled = true;
            ListaProdotti.Location = new Point(134, 96);
            ListaProdotti.Name = "ListaProdotti";
            ListaProdotti.Size = new Size(181, 28);
            ListaProdotti.TabIndex = 8;
            // 
            // InputQuantity
            // 
            InputQuantity.Location = new Point(134, 145);
            InputQuantity.Name = "InputQuantity";
            InputQuantity.Size = new Size(181, 27);
            InputQuantity.TabIndex = 7;
            InputQuantity.KeyDown += KeyNumberCheck;
            // 
            // Quantita
            // 
            Quantita.AutoSize = true;
            Quantita.Location = new Point(34, 148);
            Quantita.Name = "Quantita";
            Quantita.Size = new Size(66, 20);
            Quantita.TabIndex = 6;
            Quantita.Text = "Quantità";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 104);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 5;
            label2.Text = "Prodotto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 49);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "Nome";
            // 
            // InputName
            // 
            InputName.Location = new Point(134, 42);
            InputName.Name = "InputName";
            InputName.Size = new Size(181, 27);
            InputName.TabIndex = 2;
            InputName.KeyDown += Check_Key;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(matricolaAnnullamento);
            groupBox2.Controls.Add(btnUndoRegistration);
            groupBox2.Location = new Point(409, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(340, 267);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Annulla registrazione cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 104);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 4;
            label5.Text = "Order Code";
            // 
            // matricolaAnnullamento
            // 
            matricolaAnnullamento.Location = new Point(135, 101);
            matricolaAnnullamento.Name = "matricolaAnnullamento";
            matricolaAnnullamento.Size = new Size(181, 27);
            matricolaAnnullamento.TabIndex = 2;
            // 
            // btnUndoRegistration
            // 
            btnUndoRegistration.Location = new Point(80, 194);
            btnUndoRegistration.Name = "btnUndoRegistration";
            btnUndoRegistration.Size = new Size(166, 54);
            btnUndoRegistration.TabIndex = 1;
            btnUndoRegistration.Text = "Rimuovi";
            btnUndoRegistration.UseVisualStyleBackColor = true;
            btnUndoRegistration.Click += btnUndoRegistration_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(inputPrice);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(inputAddProduct);
            groupBox3.Controls.Add(btnAddProduct);
            groupBox3.Location = new Point(12, 295);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(340, 267);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Aggiungi Prodotto";
            // 
            // inputPrice
            // 
            inputPrice.Location = new Point(134, 106);
            inputPrice.Name = "inputPrice";
            inputPrice.Size = new Size(181, 27);
            inputPrice.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 113);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 6;
            label3.Text = "Prezzo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 49);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 4;
            label6.Text = "Nome";
            // 
            // inputAddProduct
            // 
            inputAddProduct.Location = new Point(134, 42);
            inputAddProduct.Name = "inputAddProduct";
            inputAddProduct.Size = new Size(181, 27);
            inputAddProduct.TabIndex = 2;
            inputAddProduct.KeyDown += Check_Key;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(78, 169);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(166, 54);
            btnAddProduct.TabIndex = 1;
            btnAddProduct.Text = "Aggiungi";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += button1_Click;
            // 
            // ClientManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1435, 573);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(DisplayStruct);
            Name = "ClientManagement";
            Text = "Gibbo&Bobbo Corporation";
            Load += ClientManagement_Load;
            ((System.ComponentModel.ISupportInitialize)DisplayStruct).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DisplayStruct;
        private Button SubmitClient;
        private GroupBox groupBox1;
        private TextBox InputQuantity;
        private Label Quantita;
        private Label label2;
        private Label label1;
        private TextBox InputName;
        private ComboBox ListaProdotti;
        private GroupBox groupBox2;
        private Label label5;
        private TextBox matricolaAnnullamento;
        private Button btnUndoRegistration;
        private GroupBox groupBox3;
        private TextBox inputPrice;
        private Label label3;
        private Label label6;
        private TextBox inputAddProduct;
        private Button btnAddProduct;
    }
}
