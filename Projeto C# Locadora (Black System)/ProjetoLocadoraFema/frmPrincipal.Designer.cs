namespace ProjetoLocadoraFema
{
    partial class frmPrincipal
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
            this.msPnl = new System.Windows.Forms.Panel();
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.msGerenciar = new System.Windows.Forms.ToolStripMenuItem();
            this.msClientesOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.msFilmesOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.contratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.msPnl.SuspendLayout();
            this.msPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPnl
            // 
            this.msPnl.Controls.Add(this.msPrincipal);
            this.msPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.msPnl.Location = new System.Drawing.Point(0, 0);
            this.msPnl.Name = "msPnl";
            this.msPnl.Size = new System.Drawing.Size(726, 25);
            this.msPnl.TabIndex = 1;
            // 
            // msPrincipal
            // 
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msGerenciar,
            this.sairToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(726, 24);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // msGerenciar
            // 
            this.msGerenciar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msClientesOpen,
            this.msFilmesOpen,
            this.contratosToolStripMenuItem});
            this.msGerenciar.Name = "msGerenciar";
            this.msGerenciar.Size = new System.Drawing.Size(69, 20);
            this.msGerenciar.Text = "Gerenciar";
            this.msGerenciar.Click += new System.EventHandler(this.msGerenciar_Click);
            // 
            // msClientesOpen
            // 
            this.msClientesOpen.Name = "msClientesOpen";
            this.msClientesOpen.Size = new System.Drawing.Size(122, 22);
            this.msClientesOpen.Text = "Clientes";
            this.msClientesOpen.Click += new System.EventHandler(this.filmesToolStripMenuItem_Click);
            // 
            // msFilmesOpen
            // 
            this.msFilmesOpen.Name = "msFilmesOpen";
            this.msFilmesOpen.Size = new System.Drawing.Size(122, 22);
            this.msFilmesOpen.Text = "Filmes";
            this.msFilmesOpen.Click += new System.EventHandler(this.filmesToolStripMenuItem1_Click);
            // 
            // contratosToolStripMenuItem
            // 
            this.contratosToolStripMenuItem.Name = "contratosToolStripMenuItem";
            this.contratosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contratosToolStripMenuItem.Text = "Compras";
            this.contratosToolStripMenuItem.Click += new System.EventHandler(this.contratosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.BackColor = System.Drawing.Color.Black;
            this.pnPrincipal.BackgroundImage = global::ProjetoLocadoraFema.Properties.Resources.BLACMIDT_login2;
            this.pnPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPrincipal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 25);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(726, 436);
            this.pnPrincipal.TabIndex = 2;
            this.pnPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnPrincipal_Paint);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(726, 461);
            this.ControlBox = false;
            this.Controls.Add(this.pnPrincipal);
            this.Controls.Add(this.msPnl);
            this.Name = "frmPrincipal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlackMidt ";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.msPnl.ResumeLayout(false);
            this.msPnl.PerformLayout();
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel msPnl;
        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem msGerenciar;
        private System.Windows.Forms.ToolStripMenuItem msClientesOpen;
        private System.Windows.Forms.ToolStripMenuItem msFilmesOpen;
        private System.Windows.Forms.ToolStripMenuItem contratosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Panel pnPrincipal;
    }
}