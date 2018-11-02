namespace Trinity
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnPrincipal = new System.Windows.Forms.MenuStrip();
            this.minhaEmpresaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosBaseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocaUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.mnPrincipal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 573);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(179)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.lblRazaoSocial);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 507);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(989, 63);
            this.panel2.TabIndex = 0;
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.BackColor = System.Drawing.Color.Transparent;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.Location = new System.Drawing.Point(33, 38);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(106, 20);
            this.lblRazaoSocial.TabIndex = 3;
            this.lblRazaoSocial.Text = "RAZÃO SOCIAL";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Trinity.Properties.Resources.empresa_32px;
            this.pictureBox2.Location = new System.Drawing.Point(9, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(33, 7);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "USUÁRIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Trinity.Properties.Resources.usuario_32px;
            this.pictureBox1.Location = new System.Drawing.Point(9, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mnPrincipal
            // 
            this.mnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minhaEmpresaToolStripMenuItem1,
            this.vendasToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.clientesToolStripMenuItem1,
            this.fornecedoresToolStripMenuItem1,
            this.produtosToolStripMenuItem1,
            this.usuariosToolStripMenuItem1,
            this.cadastrosBaseMenuItem,
            this.trocaUsuarioToolStripMenuItem,
            this.sobreOSistemaToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.mnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnPrincipal.Name = "mnPrincipal";
            this.mnPrincipal.Size = new System.Drawing.Size(995, 55);
            this.mnPrincipal.TabIndex = 1;
            this.mnPrincipal.Text = "menuStrip2";
            // 
            // minhaEmpresaToolStripMenuItem1
            // 
            this.minhaEmpresaToolStripMenuItem1.Enabled = false;
            this.minhaEmpresaToolStripMenuItem1.Image = global::Trinity.Properties.Resources.empresa_32px;
            this.minhaEmpresaToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.minhaEmpresaToolStripMenuItem1.Name = "minhaEmpresaToolStripMenuItem1";
            this.minhaEmpresaToolStripMenuItem1.Size = new System.Drawing.Size(113, 51);
            this.minhaEmpresaToolStripMenuItem1.Text = "MINHA EMPRESA";
            this.minhaEmpresaToolStripMenuItem1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.minhaEmpresaToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.minhaEmpresaToolStripMenuItem1.Click += new System.EventHandler(this.minhaEmpresaToolStripMenuItem1_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Enabled = false;
            this.vendasToolStripMenuItem.Image = global::Trinity.Properties.Resources.venda_32px;
            this.vendasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(63, 51);
            this.vendasToolStripMenuItem.Text = "VENDAS";
            this.vendasToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Enabled = false;
            this.clientesToolStripMenuItem1.Image = global::Trinity.Properties.Resources.clientes_32px;
            this.clientesToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(70, 51);
            this.clientesToolStripMenuItem1.Text = "CLIENTES";
            this.clientesToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // fornecedoresToolStripMenuItem1
            // 
            this.fornecedoresToolStripMenuItem1.Enabled = false;
            this.fornecedoresToolStripMenuItem1.Image = global::Trinity.Properties.Resources.fornecedor_32px;
            this.fornecedoresToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fornecedoresToolStripMenuItem1.Name = "fornecedoresToolStripMenuItem1";
            this.fornecedoresToolStripMenuItem1.Size = new System.Drawing.Size(106, 51);
            this.fornecedoresToolStripMenuItem1.Text = "FORNECEDORES";
            this.fornecedoresToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.fornecedoresToolStripMenuItem1.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem1_Click);
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.Enabled = false;
            this.produtosToolStripMenuItem1.Image = global::Trinity.Properties.Resources.produto_32px;
            this.produtosToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(79, 51);
            this.produtosToolStripMenuItem1.Text = "PRODUTOS";
            this.produtosToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.produtosToolStripMenuItem1.Click += new System.EventHandler(this.produtosToolStripMenuItem1_Click);
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.Enabled = false;
            this.usuariosToolStripMenuItem1.Image = global::Trinity.Properties.Resources.usuario_32px;
            this.usuariosToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(74, 51);
            this.usuariosToolStripMenuItem1.Text = "USUÁRIOS";
            this.usuariosToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.usuariosToolStripMenuItem1.Click += new System.EventHandler(this.usuariosToolStripMenuItem1_Click);
            // 
            // cadastrosBaseMenuItem
            // 
            this.cadastrosBaseMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unMedidaToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.grupoToolStripMenuItem});
            this.cadastrosBaseMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrosBaseMenuItem.Image")));
            this.cadastrosBaseMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cadastrosBaseMenuItem.Name = "cadastrosBaseMenuItem";
            this.cadastrosBaseMenuItem.Size = new System.Drawing.Size(116, 51);
            this.cadastrosBaseMenuItem.Text = "CADASTROS BASE";
            this.cadastrosBaseMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // unMedidaToolStripMenuItem
            // 
            this.unMedidaToolStripMenuItem.Name = "unMedidaToolStripMenuItem";
            this.unMedidaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unMedidaToolStripMenuItem.Text = "UN. MEDIDA";
            this.unMedidaToolStripMenuItem.Click += new System.EventHandler(this.uNMEDIDAToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.marcaToolStripMenuItem.Text = "MARCA";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.mARCAToolStripMenuItem_Click);
            // 
            // grupoToolStripMenuItem
            // 
            this.grupoToolStripMenuItem.Name = "grupoToolStripMenuItem";
            this.grupoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.grupoToolStripMenuItem.Text = "GRUPO";
            this.grupoToolStripMenuItem.Click += new System.EventHandler(this.gRUPOToolStripMenuItem_Click);
            // 
            // trocaUsuarioToolStripMenuItem
            // 
            this.trocaUsuarioToolStripMenuItem.Image = global::Trinity.Properties.Resources.trocarUsuario_32px;
            this.trocaUsuarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.trocaUsuarioToolStripMenuItem.Name = "trocaUsuarioToolStripMenuItem";
            this.trocaUsuarioToolStripMenuItem.Size = new System.Drawing.Size(117, 51);
            this.trocaUsuarioToolStripMenuItem.Text = "TROCAR USUÁRIO";
            this.trocaUsuarioToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.trocaUsuarioToolStripMenuItem.Click += new System.EventHandler(this.trocaUsuarioToolStripMenuItem_Click);
            // 
            // sobreOSistemaToolStripMenuItem
            // 
            this.sobreOSistemaToolStripMenuItem.Image = global::Trinity.Properties.Resources.sobre_32px;
            this.sobreOSistemaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sobreOSistemaToolStripMenuItem.Name = "sobreOSistemaToolStripMenuItem";
            this.sobreOSistemaToolStripMenuItem.Size = new System.Drawing.Size(116, 51);
            this.sobreOSistemaToolStripMenuItem.Text = "SOBRE O SISTEMA";
            this.sobreOSistemaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sobreOSistemaToolStripMenuItem.Click += new System.EventHandler(this.sobreOSistemaToolStripMenuItem_Click);
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Image = global::Trinity.Properties.Resources.sair_32px;
            this.sAIRToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(113, 51);
            this.sAIRToolStripMenuItem.Text = "SAIR DO SISTEMA";
            this.sAIRToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Enabled = false;
            this.comprasToolStripMenuItem.Image = global::Trinity.Properties.Resources.compra_32px;
            this.comprasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(75, 51);
            this.comprasToolStripMenuItem.Text = "COMPRAS";
            this.comprasToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.comprasToolStripMenuItem.Visible = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 573);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1011, 612);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trinity: Sistemas Matrix";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mnPrincipal.ResumeLayout(false);
            this.mnPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.MenuStrip mnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem minhaEmpresaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem trocaUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosBaseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unMedidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
    }
}