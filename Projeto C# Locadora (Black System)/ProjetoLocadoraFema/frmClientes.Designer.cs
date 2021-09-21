namespace ProjetoLocadoraFema
{
    partial class frmClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtCPFCliente = new System.Windows.Forms.TextBox();
            this.txtEnderCliente = new System.Windows.Forms.TextBox();
            this.txtTelCliente = new System.Windows.Forms.TextBox();
            this.btnLimparClientes = new System.Windows.Forms.Button();
            this.btnEditarClientes = new System.Windows.Forms.Button();
            this.btnRemoverClientes = new System.Windows.Forms.Button();
            this.btnCadastrarClientes = new System.Windows.Forms.Button();
            this.btnAtualizarClientes = new System.Windows.Forms.Button();
            this.rBID = new System.Windows.Forms.RadioButton();
            this.rBNome = new System.Windows.Forms.RadioButton();
            this.txtProcurarClientes = new System.Windows.Forms.TextBox();
            this.btnProcurarCliente = new System.Windows.Forms.Button();
            this.dTGrvClientes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dTGrvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(329, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(329, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefone:";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(104, 122);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIDCliente.TabIndex = 5;
            this.txtIDCliente.TextChanged += new System.EventHandler(this.txtIDCliente_TextChanged);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(104, 168);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(195, 20);
            this.txtNomeCliente.TabIndex = 6;
            this.txtNomeCliente.TextChanged += new System.EventHandler(this.txtNomeCliente_TextChanged_1);
            // 
            // txtCPFCliente
            // 
            this.txtCPFCliente.Location = new System.Drawing.Point(406, 122);
            this.txtCPFCliente.Name = "txtCPFCliente";
            this.txtCPFCliente.Size = new System.Drawing.Size(158, 20);
            this.txtCPFCliente.TabIndex = 7;
            this.txtCPFCliente.TextChanged += new System.EventHandler(this.txtCPFCliente_TextChanged);
            // 
            // txtEnderCliente
            // 
            this.txtEnderCliente.Location = new System.Drawing.Point(104, 212);
            this.txtEnderCliente.Name = "txtEnderCliente";
            this.txtEnderCliente.Size = new System.Drawing.Size(195, 20);
            this.txtEnderCliente.TabIndex = 8;
            this.txtEnderCliente.TextChanged += new System.EventHandler(this.txtEnderCliente_TextChanged);
            // 
            // txtTelCliente
            // 
            this.txtTelCliente.Location = new System.Drawing.Point(406, 166);
            this.txtTelCliente.Name = "txtTelCliente";
            this.txtTelCliente.Size = new System.Drawing.Size(158, 20);
            this.txtTelCliente.TabIndex = 9;
            this.txtTelCliente.TextChanged += new System.EventHandler(this.txtTelCliente_TextChanged);
            // 
            // btnLimparClientes
            // 
            this.btnLimparClientes.Location = new System.Drawing.Point(594, 120);
            this.btnLimparClientes.Name = "btnLimparClientes";
            this.btnLimparClientes.Size = new System.Drawing.Size(75, 23);
            this.btnLimparClientes.TabIndex = 10;
            this.btnLimparClientes.Text = "Limpar";
            this.btnLimparClientes.UseVisualStyleBackColor = true;
            this.btnLimparClientes.Click += new System.EventHandler(this.btnLimparClientes_Click);
            // 
            // btnEditarClientes
            // 
            this.btnEditarClientes.Location = new System.Drawing.Point(594, 164);
            this.btnEditarClientes.Name = "btnEditarClientes";
            this.btnEditarClientes.Size = new System.Drawing.Size(75, 23);
            this.btnEditarClientes.TabIndex = 11;
            this.btnEditarClientes.Text = "Editar";
            this.btnEditarClientes.UseVisualStyleBackColor = true;
            this.btnEditarClientes.Click += new System.EventHandler(this.btnEditarClientes_Click);
            // 
            // btnRemoverClientes
            // 
            this.btnRemoverClientes.Location = new System.Drawing.Point(594, 208);
            this.btnRemoverClientes.Name = "btnRemoverClientes";
            this.btnRemoverClientes.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverClientes.TabIndex = 12;
            this.btnRemoverClientes.Text = "Remover";
            this.btnRemoverClientes.UseVisualStyleBackColor = true;
            this.btnRemoverClientes.Click += new System.EventHandler(this.btnRemoverClientes_Click);
            // 
            // btnCadastrarClientes
            // 
            this.btnCadastrarClientes.Location = new System.Drawing.Point(489, 208);
            this.btnCadastrarClientes.Name = "btnCadastrarClientes";
            this.btnCadastrarClientes.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarClientes.TabIndex = 13;
            this.btnCadastrarClientes.Text = "Cadastrar";
            this.btnCadastrarClientes.UseVisualStyleBackColor = true;
            this.btnCadastrarClientes.Click += new System.EventHandler(this.btnCadastrarClientes_Click);
            // 
            // btnAtualizarClientes
            // 
            this.btnAtualizarClientes.Location = new System.Drawing.Point(396, 208);
            this.btnAtualizarClientes.Name = "btnAtualizarClientes";
            this.btnAtualizarClientes.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizarClientes.TabIndex = 14;
            this.btnAtualizarClientes.Text = "Atualizar";
            this.btnAtualizarClientes.UseVisualStyleBackColor = true;
            this.btnAtualizarClientes.Click += new System.EventHandler(this.btnAtualizarClientes_Click);
            // 
            // rBID
            // 
            this.rBID.AutoSize = true;
            this.rBID.BackColor = System.Drawing.Color.Transparent;
            this.rBID.Checked = true;
            this.rBID.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.rBID.ForeColor = System.Drawing.Color.White;
            this.rBID.Location = new System.Drawing.Point(12, 52);
            this.rBID.Name = "rBID";
            this.rBID.Size = new System.Drawing.Size(44, 26);
            this.rBID.TabIndex = 17;
            this.rBID.TabStop = true;
            this.rBID.Text = "ID";
            this.rBID.UseVisualStyleBackColor = false;
            // 
            // rBNome
            // 
            this.rBNome.AutoSize = true;
            this.rBNome.BackColor = System.Drawing.Color.Transparent;
            this.rBNome.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.rBNome.ForeColor = System.Drawing.Color.White;
            this.rBNome.Location = new System.Drawing.Point(69, 52);
            this.rBNome.Name = "rBNome";
            this.rBNome.Size = new System.Drawing.Size(72, 26);
            this.rBNome.TabIndex = 18;
            this.rBNome.Text = "Nome:";
            this.rBNome.UseVisualStyleBackColor = false;
            // 
            // txtProcurarClientes
            // 
            this.txtProcurarClientes.Location = new System.Drawing.Point(148, 52);
            this.txtProcurarClientes.Name = "txtProcurarClientes";
            this.txtProcurarClientes.Size = new System.Drawing.Size(464, 20);
            this.txtProcurarClientes.TabIndex = 19;
            this.txtProcurarClientes.TextChanged += new System.EventHandler(this.txtProcurarClientes_TextChanged);
            // 
            // btnProcurarCliente
            // 
            this.btnProcurarCliente.Location = new System.Drawing.Point(618, 50);
            this.btnProcurarCliente.Name = "btnProcurarCliente";
            this.btnProcurarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnProcurarCliente.TabIndex = 20;
            this.btnProcurarCliente.Text = "Procurar";
            this.btnProcurarCliente.UseVisualStyleBackColor = true;
            this.btnProcurarCliente.Click += new System.EventHandler(this.btnProcurarCliente_Click);
            // 
            // dTGrvClientes
            // 
            this.dTGrvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dTGrvClientes.Location = new System.Drawing.Point(18, 253);
            this.dTGrvClientes.Name = "dTGrvClientes";
            this.dTGrvClientes.Size = new System.Drawing.Size(696, 166);
            this.dTGrvClientes.TabIndex = 21;
            this.dTGrvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dTGrvClientes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dTGrvClientes_CellMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::ProjetoLocadoraFema.Properties.Resources.seta;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoLocadoraFema.Properties.Resources.fundoblack;
            this.ClientSize = new System.Drawing.Size(726, 424);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dTGrvClientes);
            this.Controls.Add(this.btnProcurarCliente);
            this.Controls.Add(this.txtProcurarClientes);
            this.Controls.Add(this.rBNome);
            this.Controls.Add(this.rBID);
            this.Controls.Add(this.btnAtualizarClientes);
            this.Controls.Add(this.btnCadastrarClientes);
            this.Controls.Add(this.btnRemoverClientes);
            this.Controls.Add(this.btnEditarClientes);
            this.Controls.Add(this.btnLimparClientes);
            this.Controls.Add(this.txtTelCliente);
            this.Controls.Add(this.txtEnderCliente);
            this.Controls.Add(this.txtCPFCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dTGrvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtCPFCliente;
        private System.Windows.Forms.TextBox txtEnderCliente;
        private System.Windows.Forms.TextBox txtTelCliente;
        private System.Windows.Forms.Button btnLimparClientes;
        private System.Windows.Forms.Button btnEditarClientes;
        private System.Windows.Forms.Button btnRemoverClientes;
        private System.Windows.Forms.Button btnCadastrarClientes;
        private System.Windows.Forms.Button btnAtualizarClientes;
        private System.Windows.Forms.RadioButton rBID;
        private System.Windows.Forms.RadioButton rBNome;
        private System.Windows.Forms.TextBox txtProcurarClientes;
        private System.Windows.Forms.Button btnProcurarCliente;
        private System.Windows.Forms.DataGridView dTGrvClientes;
        private System.Windows.Forms.Button button1;
    }
}