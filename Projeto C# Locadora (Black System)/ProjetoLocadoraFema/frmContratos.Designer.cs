namespace ProjetoLocadoraFema
{
    partial class frmContratos
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
            this.cBContratos = new System.Windows.Forms.ComboBox();
            this.dtGrvContratos = new System.Windows.Forms.DataGridView();
            this.txtPesquisarContratos = new System.Windows.Forms.TextBox();
            this.btnProcurarContratos = new System.Windows.Forms.Button();
            this.txtIDFilmesContrato = new System.Windows.Forms.TextBox();
            this.txtNomeFilmeContratos = new System.Windows.Forms.TextBox();
            this.txtValorFilmeContratos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDClienteContratos = new System.Windows.Forms.TextBox();
            this.txtNomeClientesContratos = new System.Windows.Forms.TextBox();
            this.txtCPFClientesContratos = new System.Windows.Forms.TextBox();
            this.btnLimparContratos = new System.Windows.Forms.Button();
            this.btnConfirmarContrato = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cBPrazoContrato = new System.Windows.Forms.ComboBox();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.rBNome = new System.Windows.Forms.RadioButton();
            this.btnVoltarContratos = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDCompraContratos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrvContratos)).BeginInit();
            this.SuspendLayout();
            // 
            // cBContratos
            // 
            this.cBContratos.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.cBContratos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBContratos.FormattingEnabled = true;
            this.cBContratos.Items.AddRange(new object[] {
            "--Opção--",
            "Filmes",
            "Clientes",
            "Alugados"});
            this.cBContratos.Location = new System.Drawing.Point(12, 260);
            this.cBContratos.Name = "cBContratos";
            this.cBContratos.Size = new System.Drawing.Size(72, 21);
            this.cBContratos.TabIndex = 0;
            this.cBContratos.Tag = "";
            this.cBContratos.SelectedIndexChanged += new System.EventHandler(this.cBContratos_SelectedIndexChanged);
            // 
            // dtGrvContratos
            // 
            this.dtGrvContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrvContratos.Location = new System.Drawing.Point(12, 286);
            this.dtGrvContratos.Name = "dtGrvContratos";
            this.dtGrvContratos.Size = new System.Drawing.Size(702, 138);
            this.dtGrvContratos.TabIndex = 1;
            this.dtGrvContratos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrvContratos_CellContentClick);
            this.dtGrvContratos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtGrvContratos_CellMouseDoubleClick);
            // 
            // txtPesquisarContratos
            // 
            this.txtPesquisarContratos.Location = new System.Drawing.Point(90, 260);
            this.txtPesquisarContratos.Multiline = true;
            this.txtPesquisarContratos.Name = "txtPesquisarContratos";
            this.txtPesquisarContratos.Size = new System.Drawing.Size(414, 21);
            this.txtPesquisarContratos.TabIndex = 2;
            this.txtPesquisarContratos.TextChanged += new System.EventHandler(this.txtPesquisarContratos_TextChanged);
            // 
            // btnProcurarContratos
            // 
            this.btnProcurarContratos.Location = new System.Drawing.Point(510, 259);
            this.btnProcurarContratos.Name = "btnProcurarContratos";
            this.btnProcurarContratos.Size = new System.Drawing.Size(75, 21);
            this.btnProcurarContratos.TabIndex = 3;
            this.btnProcurarContratos.Text = "Procurar";
            this.btnProcurarContratos.UseVisualStyleBackColor = true;
            this.btnProcurarContratos.Click += new System.EventHandler(this.btnProcurarContratos_Click);
            // 
            // txtIDFilmesContrato
            // 
            this.txtIDFilmesContrato.Location = new System.Drawing.Point(134, 60);
            this.txtIDFilmesContrato.Name = "txtIDFilmesContrato";
            this.txtIDFilmesContrato.Size = new System.Drawing.Size(80, 20);
            this.txtIDFilmesContrato.TabIndex = 4;
            // 
            // txtNomeFilmeContratos
            // 
            this.txtNomeFilmeContratos.Location = new System.Drawing.Point(134, 104);
            this.txtNomeFilmeContratos.Name = "txtNomeFilmeContratos";
            this.txtNomeFilmeContratos.Size = new System.Drawing.Size(172, 20);
            this.txtNomeFilmeContratos.TabIndex = 5;
            // 
            // txtValorFilmeContratos
            // 
            this.txtValorFilmeContratos.Location = new System.Drawing.Point(134, 144);
            this.txtValorFilmeContratos.Name = "txtValorFilmeContratos";
            this.txtValorFilmeContratos.Size = new System.Drawing.Size(80, 20);
            this.txtValorFilmeContratos.TabIndex = 6;
            this.txtValorFilmeContratos.TextChanged += new System.EventHandler(this.txtValorFilmeContratos_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID Filme:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome Filme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "R$:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(319, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(319, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nome Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(319, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "CPF:";
            // 
            // txtIDClienteContratos
            // 
            this.txtIDClienteContratos.Location = new System.Drawing.Point(434, 61);
            this.txtIDClienteContratos.Name = "txtIDClienteContratos";
            this.txtIDClienteContratos.Size = new System.Drawing.Size(91, 20);
            this.txtIDClienteContratos.TabIndex = 13;
            // 
            // txtNomeClientesContratos
            // 
            this.txtNomeClientesContratos.Location = new System.Drawing.Point(434, 101);
            this.txtNomeClientesContratos.Name = "txtNomeClientesContratos";
            this.txtNomeClientesContratos.Size = new System.Drawing.Size(172, 20);
            this.txtNomeClientesContratos.TabIndex = 14;
            this.txtNomeClientesContratos.TextChanged += new System.EventHandler(this.txtNomeClientesContratos_TextChanged);
            // 
            // txtCPFClientesContratos
            // 
            this.txtCPFClientesContratos.Location = new System.Drawing.Point(434, 140);
            this.txtCPFClientesContratos.Name = "txtCPFClientesContratos";
            this.txtCPFClientesContratos.Size = new System.Drawing.Size(145, 20);
            this.txtCPFClientesContratos.TabIndex = 15;
            // 
            // btnLimparContratos
            // 
            this.btnLimparContratos.Location = new System.Drawing.Point(558, 179);
            this.btnLimparContratos.Name = "btnLimparContratos";
            this.btnLimparContratos.Size = new System.Drawing.Size(75, 23);
            this.btnLimparContratos.TabIndex = 16;
            this.btnLimparContratos.Text = "Limpar";
            this.btnLimparContratos.UseVisualStyleBackColor = true;
            this.btnLimparContratos.Click += new System.EventHandler(this.btnLimparContratos_Click);
            // 
            // btnConfirmarContrato
            // 
            this.btnConfirmarContrato.Location = new System.Drawing.Point(639, 179);
            this.btnConfirmarContrato.Name = "btnConfirmarContrato";
            this.btnConfirmarContrato.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmarContrato.TabIndex = 17;
            this.btnConfirmarContrato.Text = "Confirmar";
            this.btnConfirmarContrato.UseVisualStyleBackColor = true;
            this.btnConfirmarContrato.Click += new System.EventHandler(this.btnConfirmarContrato_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Prazo em Dias:";
            // 
            // cBPrazoContrato
            // 
            this.cBPrazoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBPrazoContrato.FormattingEnabled = true;
            this.cBPrazoContrato.Items.AddRange(new object[] {
            "1",
            "3",
            "7",
            "14"});
            this.cBPrazoContrato.Location = new System.Drawing.Point(134, 179);
            this.cBPrazoContrato.Name = "cBPrazoContrato";
            this.cBPrazoContrato.Size = new System.Drawing.Size(69, 21);
            this.cBPrazoContrato.TabIndex = 19;
            this.cBPrazoContrato.SelectedIndexChanged += new System.EventHandler(this.cBPrazoContrato_SelectedIndexChanged);
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.BackColor = System.Drawing.Color.Transparent;
            this.rbID.Checked = true;
            this.rbID.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.rbID.ForeColor = System.Drawing.Color.White;
            this.rbID.Location = new System.Drawing.Point(591, 255);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(44, 26);
            this.rbID.TabIndex = 20;
            this.rbID.TabStop = true;
            this.rbID.Text = "ID";
            this.rbID.UseVisualStyleBackColor = false;
            // 
            // rBNome
            // 
            this.rBNome.AutoSize = true;
            this.rBNome.BackColor = System.Drawing.Color.Transparent;
            this.rBNome.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.rBNome.ForeColor = System.Drawing.Color.White;
            this.rBNome.Location = new System.Drawing.Point(646, 255);
            this.rBNome.Name = "rBNome";
            this.rBNome.Size = new System.Drawing.Size(68, 26);
            this.rBNome.TabIndex = 21;
            this.rBNome.Text = "Nome";
            this.rBNome.UseVisualStyleBackColor = false;
            // 
            // btnVoltarContratos
            // 
            this.btnVoltarContratos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltarContratos.Image = global::ProjetoLocadoraFema.Properties.Resources.seta;
            this.btnVoltarContratos.Location = new System.Drawing.Point(12, 12);
            this.btnVoltarContratos.Name = "btnVoltarContratos";
            this.btnVoltarContratos.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarContratos.TabIndex = 22;
            this.btnVoltarContratos.UseVisualStyleBackColor = true;
            this.btnVoltarContratos.Click += new System.EventHandler(this.btnVoltarContratos_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(319, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 22);
            this.label8.TabIndex = 23;
            this.label8.Text = "ID Compra:";
            // 
            // txtIDCompraContratos
            // 
            this.txtIDCompraContratos.Location = new System.Drawing.Point(434, 179);
            this.txtIDCompraContratos.Name = "txtIDCompraContratos";
            this.txtIDCompraContratos.Size = new System.Drawing.Size(91, 20);
            this.txtIDCompraContratos.TabIndex = 24;
            this.txtIDCompraContratos.TextChanged += new System.EventHandler(this.txtIDCompraContratos_TextChanged);
            // 
            // frmContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoLocadoraFema.Properties.Resources.fundoblack;
            this.ClientSize = new System.Drawing.Size(726, 444);
            this.ControlBox = false;
            this.Controls.Add(this.txtIDCompraContratos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnVoltarContratos);
            this.Controls.Add(this.rBNome);
            this.Controls.Add(this.rbID);
            this.Controls.Add(this.cBPrazoContrato);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnConfirmarContrato);
            this.Controls.Add(this.btnLimparContratos);
            this.Controls.Add(this.txtCPFClientesContratos);
            this.Controls.Add(this.txtNomeClientesContratos);
            this.Controls.Add(this.txtIDClienteContratos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorFilmeContratos);
            this.Controls.Add(this.txtNomeFilmeContratos);
            this.Controls.Add(this.txtIDFilmesContrato);
            this.Controls.Add(this.btnProcurarContratos);
            this.Controls.Add(this.txtPesquisarContratos);
            this.Controls.Add(this.dtGrvContratos);
            this.Controls.Add(this.cBContratos);
            this.Name = "frmContratos";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.frmContratos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrvContratos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGrvContratos;
        private System.Windows.Forms.TextBox txtPesquisarContratos;
        private System.Windows.Forms.Button btnProcurarContratos;
        private System.Windows.Forms.TextBox txtIDFilmesContrato;
        private System.Windows.Forms.TextBox txtNomeFilmeContratos;
        private System.Windows.Forms.TextBox txtValorFilmeContratos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDClienteContratos;
        private System.Windows.Forms.TextBox txtNomeClientesContratos;
        private System.Windows.Forms.TextBox txtCPFClientesContratos;
        private System.Windows.Forms.Button btnLimparContratos;
        private System.Windows.Forms.Button btnConfirmarContrato;
        public System.Windows.Forms.ComboBox cBContratos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBPrazoContrato;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.RadioButton rBNome;
        private System.Windows.Forms.Button btnVoltarContratos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIDCompraContratos;
    }
}