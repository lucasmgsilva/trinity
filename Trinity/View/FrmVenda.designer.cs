namespace Trinity.View
{
    partial class FrmVenda
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenda));
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvItemVendido = new System.Windows.Forms.DataGridView();
            this.txtPrecoTotal = new System.Windows.Forms.NumericUpDown();
            this.txtPrecoVenda = new System.Windows.Forms.NumericUpDown();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lblitensVenda = new System.Windows.Forms.Label();
            this.lblPrecoTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimparSeleção = new System.Windows.Forms.Button();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataVenda = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdVendida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epVendas = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblItemVendido = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemVendido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(658, 523);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(104, 27);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(768, 523);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 27);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(116, 523);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 27);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(6, 523);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(104, 27);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblItemVendido);
            this.groupBox2.Controls.Add(this.dgvItemVendido);
            this.groupBox2.Controls.Add(this.txtPrecoTotal);
            this.groupBox2.Controls.Add(this.txtPrecoVenda);
            this.groupBox2.Controls.Add(this.txtQuantidade);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblitensVenda);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lblPrecoTotal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnLimparSeleção);
            this.groupBox2.Controls.Add(this.btnRemoverProduto);
            this.groupBox2.Controls.Add(this.btnAdicionarProduto);
            this.groupBox2.Controls.Add(this.cmbProduto);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F);
            this.groupBox2.Location = new System.Drawing.Point(6, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(866, 368);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Itens da Venda";
            // 
            // dgvItemVendido
            // 
            this.dgvItemVendido.AllowUserToAddRows = false;
            this.dgvItemVendido.AllowUserToDeleteRows = false;
            this.dgvItemVendido.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvItemVendido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemVendido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemVendido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.descricao,
            this.qtdVendida,
            this.valorVenda,
            this.valorTotal});
            this.dgvItemVendido.Location = new System.Drawing.Point(11, 134);
            this.dgvItemVendido.MultiSelect = false;
            this.dgvItemVendido.Name = "dgvItemVendido";
            this.dgvItemVendido.ReadOnly = true;
            this.dgvItemVendido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemVendido.Size = new System.Drawing.Size(849, 194);
            this.dgvItemVendido.TabIndex = 76;
            this.dgvItemVendido.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CellFormatting);
            // 
            // txtPrecoTotal
            // 
            this.txtPrecoTotal.DecimalPlaces = 2;
            this.txtPrecoTotal.Location = new System.Drawing.Point(690, 42);
            this.txtPrecoTotal.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtPrecoTotal.Name = "txtPrecoTotal";
            this.txtPrecoTotal.Size = new System.Drawing.Size(170, 26);
            this.txtPrecoTotal.TabIndex = 75;
            this.txtPrecoTotal.ValueChanged += new System.EventHandler(this.txtPrecoTotal_ValueChanged);
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.DecimalPlaces = 2;
            this.txtPrecoVenda.Location = new System.Drawing.Point(540, 42);
            this.txtPrecoVenda.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(144, 26);
            this.txtPrecoVenda.TabIndex = 74;
            this.txtPrecoVenda.ValueChanged += new System.EventHandler(this.txtPrecoVenda_ValueChanged);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.DecimalPlaces = 2;
            this.txtQuantidade.Location = new System.Drawing.Point(441, 42);
            this.txtQuantidade.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(93, 26);
            this.txtQuantidade.TabIndex = 73;
            this.txtQuantidade.ValueChanged += new System.EventHandler(this.txtQuantidade_ValueChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Chartreuse;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = global::Trinity.Properties.Resources.buscar_16px;
            this.label7.Location = new System.Drawing.Point(416, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 19);
            this.label7.TabIndex = 56;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblitensVenda
            // 
            this.lblitensVenda.AutoSize = true;
            this.lblitensVenda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitensVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.lblitensVenda.Location = new System.Drawing.Point(842, 331);
            this.lblitensVenda.Name = "lblitensVenda";
            this.lblitensVenda.Size = new System.Drawing.Size(0, 19);
            this.lblitensVenda.TabIndex = 72;
            // 
            // lblPrecoTotal
            // 
            this.lblPrecoTotal.AutoSize = true;
            this.lblPrecoTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.lblPrecoTotal.Location = new System.Drawing.Point(142, 331);
            this.lblPrecoTotal.Name = "lblPrecoTotal";
            this.lblPrecoTotal.Size = new System.Drawing.Size(0, 19);
            this.lblPrecoTotal.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 19);
            this.label5.TabIndex = 69;
            this.label5.Text = "PREÇO TOTAL: R$";
            // 
            // btnLimparSeleção
            // 
            this.btnLimparSeleção.Location = new System.Drawing.Point(349, 76);
            this.btnLimparSeleção.Name = "btnLimparSeleção";
            this.btnLimparSeleção.Size = new System.Drawing.Size(163, 27);
            this.btnLimparSeleção.TabIndex = 6;
            this.btnLimparSeleção.Text = "Limpar Seleção";
            this.btnLimparSeleção.UseVisualStyleBackColor = true;
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.Location = new System.Drawing.Point(180, 76);
            this.btnRemoverProduto.Name = "btnRemoverProduto";
            this.btnRemoverProduto.Size = new System.Drawing.Size(163, 27);
            this.btnRemoverProduto.TabIndex = 5;
            this.btnRemoverProduto.Text = "Remover Produto";
            this.btnRemoverProduto.UseVisualStyleBackColor = true;
            this.btnRemoverProduto.Click += new System.EventHandler(this.btnRemoverProduto_Click);
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(11, 76);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(163, 27);
            this.btnAdicionarProduto.TabIndex = 4;
            this.btnAdicionarProduto.Text = "Adicionar Produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(11, 42);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(405, 26);
            this.cmbProduto.TabIndex = 0;
            this.cmbProduto.SelectedValueChanged += new System.EventHandler(this.cmbProduto_SelectedValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(437, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 19);
            this.label17.TabIndex = 63;
            this.label17.Text = "Qtde.:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(536, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 19);
            this.label13.TabIndex = 60;
            this.label13.Text = "Preço de Venda:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(686, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 19);
            this.label16.TabIndex = 49;
            this.label16.Text = "Preço Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 19);
            this.label10.TabIndex = 49;
            this.label10.Text = "Produto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDataVenda);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da Venda";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Chartreuse;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::Trinity.Properties.Resources.buscar_16px;
            this.label6.Location = new System.Drawing.Point(842, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 19);
            this.label6.TabIndex = 55;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(171, 47);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(671, 26);
            this.cmbCliente.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(233, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 19);
            this.label9.TabIndex = 54;
            this.label9.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(130, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 19);
            this.label3.TabIndex = 49;
            this.label3.Text = "*";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(167, 28);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(68, 19);
            this.lblCliente.TabIndex = 36;
            this.lblCliente.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data de Venda:";
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.Enabled = false;
            this.txtDataVenda.Location = new System.Drawing.Point(11, 47);
            this.txtDataVenda.Mask = "00/00/0000 90:00";
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.ReadOnly = true;
            this.txtDataVenda.Size = new System.Drawing.Size(154, 26);
            this.txtDataVenda.TabIndex = 1;
            this.txtDataVenda.ValidatingType = typeof(System.DateTime);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 47);
            this.panel1.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(374, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTÃO DE VENDA";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnEditar.Location = new System.Drawing.Point(226, 523);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(104, 27);
            this.btnEditar.TabIndex = 77;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(617, 331);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(151, 19);
            this.label18.TabIndex = 71;
            this.label18.Text = "ITENS DE VENDA:";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "IdProduto";
            dataGridViewCellStyle2.Format = "00000";
            dataGridViewCellStyle2.NullValue = "565655";
            this.Id.DefaultCellStyle = dataGridViewCellStyle2;
            this.Id.FillWeight = 304.5685F;
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "Produto.Descricao";
            this.descricao.FillWeight = 121.8274F;
            this.descricao.HeaderText = "DESCRIÇÃO";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // qtdVendida
            // 
            this.qtdVendida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qtdVendida.DataPropertyName = "qtdVendida";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.qtdVendida.DefaultCellStyle = dataGridViewCellStyle3;
            this.qtdVendida.FillWeight = 38.17258F;
            this.qtdVendida.HeaderText = "QTD.";
            this.qtdVendida.Name = "qtdVendida";
            this.qtdVendida.ReadOnly = true;
            // 
            // valorVenda
            // 
            this.valorVenda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valorVenda.DataPropertyName = "valorVenda";
            dataGridViewCellStyle4.Format = "C2";
            this.valorVenda.DefaultCellStyle = dataGridViewCellStyle4;
            this.valorVenda.FillWeight = 38.17258F;
            this.valorVenda.HeaderText = "VALOR";
            this.valorVenda.Name = "valorVenda";
            this.valorVenda.ReadOnly = true;
            // 
            // valorTotal
            // 
            this.valorTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valorTotal.DataPropertyName = "valorTotal";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.valorTotal.DefaultCellStyle = dataGridViewCellStyle5;
            this.valorTotal.FillWeight = 38.17258F;
            this.valorTotal.HeaderText = "TOTAL";
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.ReadOnly = true;
            // 
            // epVendas
            // 
            this.epVendas.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(135, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 19);
            this.label2.TabIndex = 78;
            this.label2.Text = "*";
            // 
            // lblItemVendido
            // 
            this.lblItemVendido.AutoSize = true;
            this.lblItemVendido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemVendido.Location = new System.Drawing.Point(7, 112);
            this.lblItemVendido.Name = "lblItemVendido";
            this.lblItemVendido.Size = new System.Drawing.Size(128, 19);
            this.lblItemVendido.TabIndex = 77;
            this.lblItemVendido.Text = "Itens Vendidos:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(161, 331);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 19);
            this.lblTotal.TabIndex = 79;
            this.lblTotal.Text = "0,00";
            // 
            // FrmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trinity: Gestão de Venda";
            this.Load += new System.EventHandler(this.FrmVenda_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemVendido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblitensVenda;
        private System.Windows.Forms.Label lblPrecoTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimparSeleção;
        private System.Windows.Forms.Button btnRemoverProduto;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtDataVenda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.NumericUpDown txtPrecoTotal;
        private System.Windows.Forms.NumericUpDown txtPrecoVenda;
        private System.Windows.Forms.DataGridView dgvItemVendido;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdVendida;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotal;
        private System.Windows.Forms.ErrorProvider epVendas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblItemVendido;
        private System.Windows.Forms.Label lblTotal;
    }
}