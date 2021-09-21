namespace ProjetoLocadoraFema
{
    partial class frmListarFilmes
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
            this.dtGrvListarFilmes = new System.Windows.Forms.DataGridView();
            this.txtProcurarFilmes = new System.Windows.Forms.TextBox();
            this.btnPesquistar = new System.Windows.Forms.Button();
            this.rBIDFilmes = new System.Windows.Forms.RadioButton();
            this.rbNomeFilmes = new System.Windows.Forms.RadioButton();
            this.btnEditarFilmes = new System.Windows.Forms.Button();
            this.btnRemoverFilmes = new System.Windows.Forms.Button();
            this.btnAtualizarFilmes = new System.Windows.Forms.Button();
            this.txtClassificacao = new System.Windows.Forms.TextBox();
            this.dTPFilmes = new System.Windows.Forms.DateTimePicker();
            this.nUPPreco = new System.Windows.Forms.NumericUpDown();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtNomeFilmes = new System.Windows.Forms.TextBox();
            this.txtProdutoraFilmes = new System.Windows.Forms.TextBox();
            this.txtIDFilmes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimparFilmes = new System.Windows.Forms.Button();
            this.btnInserirFilme = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.nUDQtd = new System.Windows.Forms.NumericUpDown();
            this.cbStatusFilmes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrvListarFilmes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDQtd)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGrvListarFilmes
            // 
            this.dtGrvListarFilmes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtGrvListarFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrvListarFilmes.Location = new System.Drawing.Point(12, 313);
            this.dtGrvListarFilmes.Name = "dtGrvListarFilmes";
            this.dtGrvListarFilmes.Size = new System.Drawing.Size(702, 106);
            this.dtGrvListarFilmes.TabIndex = 0;
            this.dtGrvListarFilmes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGrvListarFilmes_CellContentClick);
            this.dtGrvListarFilmes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtGrvListarFilmes_CellMouseClick);
            this.dtGrvListarFilmes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtGrvListarFilmes_CellMouseDoubleClick);
            // 
            // txtProcurarFilmes
            // 
            this.txtProcurarFilmes.Location = new System.Drawing.Point(127, 61);
            this.txtProcurarFilmes.Name = "txtProcurarFilmes";
            this.txtProcurarFilmes.Size = new System.Drawing.Size(520, 20);
            this.txtProcurarFilmes.TabIndex = 1;
            this.txtProcurarFilmes.TextChanged += new System.EventHandler(this.txtProcurarFilmes_TextChanged);
            // 
            // btnPesquistar
            // 
            this.btnPesquistar.Location = new System.Drawing.Point(653, 58);
            this.btnPesquistar.Name = "btnPesquistar";
            this.btnPesquistar.Size = new System.Drawing.Size(58, 23);
            this.btnPesquistar.TabIndex = 2;
            this.btnPesquistar.Text = "Pesquisar";
            this.btnPesquistar.UseVisualStyleBackColor = true;
            this.btnPesquistar.Click += new System.EventHandler(this.button1_Click);
            // 
            // rBIDFilmes
            // 
            this.rBIDFilmes.AutoSize = true;
            this.rBIDFilmes.BackColor = System.Drawing.Color.Transparent;
            this.rBIDFilmes.Checked = true;
            this.rBIDFilmes.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.rBIDFilmes.ForeColor = System.Drawing.Color.White;
            this.rBIDFilmes.Location = new System.Drawing.Point(11, 58);
            this.rBIDFilmes.Name = "rBIDFilmes";
            this.rBIDFilmes.Size = new System.Drawing.Size(44, 26);
            this.rBIDFilmes.TabIndex = 5;
            this.rBIDFilmes.TabStop = true;
            this.rBIDFilmes.Text = "ID";
            this.rBIDFilmes.UseVisualStyleBackColor = false;
            this.rBIDFilmes.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbNomeFilmes
            // 
            this.rbNomeFilmes.AutoSize = true;
            this.rbNomeFilmes.BackColor = System.Drawing.Color.Transparent;
            this.rbNomeFilmes.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.rbNomeFilmes.ForeColor = System.Drawing.Color.White;
            this.rbNomeFilmes.Location = new System.Drawing.Point(53, 58);
            this.rbNomeFilmes.Name = "rbNomeFilmes";
            this.rbNomeFilmes.Size = new System.Drawing.Size(68, 26);
            this.rbNomeFilmes.TabIndex = 6;
            this.rbNomeFilmes.Text = "Nome";
            this.rbNomeFilmes.UseVisualStyleBackColor = false;
            // 
            // btnEditarFilmes
            // 
            this.btnEditarFilmes.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnEditarFilmes.FlatAppearance.BorderSize = 23;
            this.btnEditarFilmes.Location = new System.Drawing.Point(626, 123);
            this.btnEditarFilmes.Name = "btnEditarFilmes";
            this.btnEditarFilmes.Size = new System.Drawing.Size(85, 23);
            this.btnEditarFilmes.TabIndex = 7;
            this.btnEditarFilmes.Text = "Editar";
            this.btnEditarFilmes.UseVisualStyleBackColor = true;
            this.btnEditarFilmes.Click += new System.EventHandler(this.btnEditarFilmes_Click);
            // 
            // btnRemoverFilmes
            // 
            this.btnRemoverFilmes.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnRemoverFilmes.FlatAppearance.BorderSize = 23;
            this.btnRemoverFilmes.Location = new System.Drawing.Point(626, 193);
            this.btnRemoverFilmes.Name = "btnRemoverFilmes";
            this.btnRemoverFilmes.Size = new System.Drawing.Size(85, 23);
            this.btnRemoverFilmes.TabIndex = 8;
            this.btnRemoverFilmes.Text = "Remover";
            this.btnRemoverFilmes.UseVisualStyleBackColor = true;
            this.btnRemoverFilmes.Click += new System.EventHandler(this.btnRemoverFilmes_Click);
            // 
            // btnAtualizarFilmes
            // 
            this.btnAtualizarFilmes.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnAtualizarFilmes.FlatAppearance.BorderSize = 23;
            this.btnAtualizarFilmes.Location = new System.Drawing.Point(12, 284);
            this.btnAtualizarFilmes.Name = "btnAtualizarFilmes";
            this.btnAtualizarFilmes.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizarFilmes.TabIndex = 9;
            this.btnAtualizarFilmes.Text = "Atualizar";
            this.btnAtualizarFilmes.UseVisualStyleBackColor = true;
            this.btnAtualizarFilmes.Click += new System.EventHandler(this.btnAtualizarFilmes_Click);
            // 
            // txtClassificacao
            // 
            this.txtClassificacao.Location = new System.Drawing.Point(468, 124);
            this.txtClassificacao.Name = "txtClassificacao";
            this.txtClassificacao.Size = new System.Drawing.Size(85, 20);
            this.txtClassificacao.TabIndex = 63;
            this.txtClassificacao.TextChanged += new System.EventHandler(this.txtClassificacao_TextChanged);
            // 
            // dTPFilmes
            // 
            this.dTPFilmes.CustomFormat = "";
            this.dTPFilmes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPFilmes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dTPFilmes.Location = new System.Drawing.Point(468, 156);
            this.dTPFilmes.Name = "dTPFilmes";
            this.dTPFilmes.Size = new System.Drawing.Size(85, 20);
            this.dTPFilmes.TabIndex = 62;
            this.dTPFilmes.Value = new System.DateTime(2020, 6, 1, 0, 0, 0, 0);
            this.dTPFilmes.ValueChanged += new System.EventHandler(this.dTPFilmes_ValueChanged);
            // 
            // nUPPreco
            // 
            this.nUPPreco.DecimalPlaces = 2;
            this.nUPPreco.Location = new System.Drawing.Point(468, 196);
            this.nUPPreco.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nUPPreco.Name = "nUPPreco";
            this.nUPPreco.Size = new System.Drawing.Size(85, 20);
            this.nUPPreco.TabIndex = 61;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(113, 230);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(130, 20);
            this.txtCategoria.TabIndex = 60;
            this.txtCategoria.TextChanged += new System.EventHandler(this.txtCategoria_TextChanged);
            // 
            // txtNomeFilmes
            // 
            this.txtNomeFilmes.Location = new System.Drawing.Point(113, 159);
            this.txtNomeFilmes.Name = "txtNomeFilmes";
            this.txtNomeFilmes.Size = new System.Drawing.Size(222, 20);
            this.txtNomeFilmes.TabIndex = 59;
            this.txtNomeFilmes.TextChanged += new System.EventHandler(this.txtNomeFilmes_TextChanged);
            // 
            // txtProdutoraFilmes
            // 
            this.txtProdutoraFilmes.Location = new System.Drawing.Point(113, 194);
            this.txtProdutoraFilmes.Name = "txtProdutoraFilmes";
            this.txtProdutoraFilmes.Size = new System.Drawing.Size(222, 20);
            this.txtProdutoraFilmes.TabIndex = 58;
            this.txtProdutoraFilmes.TextChanged += new System.EventHandler(this.txtProdutoraFilmes_TextChanged);
            // 
            // txtIDFilmes
            // 
            this.txtIDFilmes.Location = new System.Drawing.Point(113, 124);
            this.txtIDFilmes.Name = "txtIDFilmes";
            this.txtIDFilmes.Size = new System.Drawing.Size(130, 20);
            this.txtIDFilmes.TabIndex = 57;
            this.txtIDFilmes.TextChanged += new System.EventHandler(this.txtIDFilmes_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(366, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 22);
            this.label7.TabIndex = 56;
            this.label7.Text = "Preço:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(366, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 22);
            this.label6.TabIndex = 55;
            this.label6.Text = "Classificação:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 54;
            this.label5.Text = "Categoria:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(366, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 53;
            this.label4.Text = "Data:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 22);
            this.label3.TabIndex = 52;
            this.label3.Text = "Nome:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 51;
            this.label2.Text = "Produtora:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 22);
            this.label1.TabIndex = 50;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLimparFilmes
            // 
            this.btnLimparFilmes.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnLimparFilmes.FlatAppearance.BorderSize = 23;
            this.btnLimparFilmes.Location = new System.Drawing.Point(626, 157);
            this.btnLimparFilmes.Name = "btnLimparFilmes";
            this.btnLimparFilmes.Size = new System.Drawing.Size(85, 23);
            this.btnLimparFilmes.TabIndex = 64;
            this.btnLimparFilmes.Text = "Limpar";
            this.btnLimparFilmes.UseVisualStyleBackColor = true;
            this.btnLimparFilmes.Click += new System.EventHandler(this.btnLimparCampos_Click);
            // 
            // btnInserirFilme
            // 
            this.btnInserirFilme.Location = new System.Drawing.Point(626, 228);
            this.btnInserirFilme.Name = "btnInserirFilme";
            this.btnInserirFilme.Size = new System.Drawing.Size(85, 23);
            this.btnInserirFilme.TabIndex = 65;
            this.btnInserirFilme.Text = "Cadastrar";
            this.btnInserirFilme.UseVisualStyleBackColor = true;
            this.btnInserirFilme.Click += new System.EventHandler(this.btnInserirFilme_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::ProjetoLocadoraFema.Properties.Resources.seta;
            this.button1.Location = new System.Drawing.Point(11, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 30);
            this.button1.TabIndex = 66;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(368, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 22);
            this.label8.TabIndex = 67;
            this.label8.Text = "Quantidade:";
            // 
            // nUDQtd
            // 
            this.nUDQtd.Location = new System.Drawing.Point(468, 231);
            this.nUDQtd.Name = "nUDQtd";
            this.nUDQtd.Size = new System.Drawing.Size(40, 20);
            this.nUDQtd.TabIndex = 68;
            // 
            // cbStatusFilmes
            // 
            this.cbStatusFilmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatusFilmes.FormattingEnabled = true;
            this.cbStatusFilmes.Items.AddRange(new object[] {
            "--Opção--",
            "Disponiveis",
            "Alugados"});
            this.cbStatusFilmes.Location = new System.Drawing.Point(103, 284);
            this.cbStatusFilmes.Name = "cbStatusFilmes";
            this.cbStatusFilmes.Size = new System.Drawing.Size(78, 21);
            this.cbStatusFilmes.TabIndex = 69;
            this.cbStatusFilmes.SelectedIndexChanged += new System.EventHandler(this.cbStatusFilmes_SelectedIndexChanged);
            // 
            // frmListarFilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ProjetoLocadoraFema.Properties.Resources.fundoblack;
            this.ClientSize = new System.Drawing.Size(726, 443);
            this.Controls.Add(this.cbStatusFilmes);
            this.Controls.Add(this.nUDQtd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInserirFilme);
            this.Controls.Add(this.btnLimparFilmes);
            this.Controls.Add(this.txtClassificacao);
            this.Controls.Add(this.dTPFilmes);
            this.Controls.Add(this.nUPPreco);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtNomeFilmes);
            this.Controls.Add(this.txtProdutoraFilmes);
            this.Controls.Add(this.txtIDFilmes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtualizarFilmes);
            this.Controls.Add(this.btnRemoverFilmes);
            this.Controls.Add(this.btnEditarFilmes);
            this.Controls.Add(this.rbNomeFilmes);
            this.Controls.Add(this.rBIDFilmes);
            this.Controls.Add(this.btnPesquistar);
            this.Controls.Add(this.txtProcurarFilmes);
            this.Controls.Add(this.dtGrvListarFilmes);
            this.Name = "frmListarFilmes";
            this.Text = "Filmes";
            this.Load += new System.EventHandler(this.frmListarFilmes_Load);
            this.TextChanged += new System.EventHandler(this.txtClassificacao_TextChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrvListarFilmes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDQtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrvListarFilmes;
        private System.Windows.Forms.TextBox txtProcurarFilmes;
        private System.Windows.Forms.Button btnPesquistar;
        private System.Windows.Forms.RadioButton rBIDFilmes;
        private System.Windows.Forms.RadioButton rbNomeFilmes;
        private System.Windows.Forms.Button btnEditarFilmes;
        private System.Windows.Forms.Button btnRemoverFilmes;
        private System.Windows.Forms.Button btnAtualizarFilmes;
        private System.Windows.Forms.TextBox txtClassificacao;
        private System.Windows.Forms.DateTimePicker dTPFilmes;
        private System.Windows.Forms.NumericUpDown nUPPreco;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtNomeFilmes;
        private System.Windows.Forms.TextBox txtProdutoraFilmes;
        private System.Windows.Forms.TextBox txtIDFilmes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimparFilmes;
        private System.Windows.Forms.Button btnInserirFilme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nUDQtd;
        private System.Windows.Forms.ComboBox cbStatusFilmes;
    }
}