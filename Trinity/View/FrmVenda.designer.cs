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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenda));
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDesconto = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblItemVendido = new System.Windows.Forms.Label();
            this.dgvItemVendido = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdVendida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrecoTotal = new System.Windows.Forms.NumericUpDown();
            this.txtPrecoVenda = new System.Windows.Forms.NumericUpDown();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblBuscaProduto = new System.Windows.Forms.Label();
            this.lblitensVenda = new System.Windows.Forms.Label();
            this.lblPrecoTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemoverProduto = new System.Windows.Forms.Button();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBuscaCliente = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataVenda = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.epVendas = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto)).BeginInit();
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
            this.btnExcluir.TabIndex = 5;
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
            this.btnCancelar.TabIndex = 6;
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
            this.groupBox2.Controls.Add(this.txtDesconto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblItemVendido);
            this.groupBox2.Controls.Add(this.dgvItemVendido);
            this.groupBox2.Controls.Add(this.txtPrecoTotal);
            this.groupBox2.Controls.Add(this.txtPrecoVenda);
            this.groupBox2.Controls.Add(this.txtQuantidade);
            this.groupBox2.Controls.Add(this.lblBuscaProduto);
            this.groupBox2.Controls.Add(this.lblitensVenda);
            this.groupBox2.Controls.Add(this.lblPrecoTotal);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnRemoverProduto);
            this.groupBox2.Controls.Add(this.btnAdicionarProduto);
            this.groupBox2.Controls.Add(this.cmbProduto);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(866, 368);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Itens da Venda";
            // 
            // txtDesconto
            // 
            this.txtDesconto.DecimalPlaces = 2;
            this.txtDesconto.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDesconto.Location = new System.Drawing.Point(716, 329);
            this.txtDesconto.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(144, 26);
            this.txtDesconto.TabIndex = 8;
            this.txtDesconto.ValueChanged += new System.EventHandler(this.txtDesconto_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(584, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 19);
            this.label6.TabIndex = 80;
            this.label6.Text = "DESCONTO: R$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(136, 331);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(65, 19);
            this.lblTotal.TabIndex = 79;
            this.lblTotal.Text = "R$ 0,00";
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
            // dgvItemVendido
            // 
            this.dgvItemVendido.AllowUserToAddRows = false;
            this.dgvItemVendido.AllowUserToDeleteRows = false;
            this.dgvItemVendido.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvItemVendido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemVendido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItemVendido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemVendido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.descricao,
            this.qtdVendida,
            this.valorVenda,
            this.valorTotal});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItemVendido.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvItemVendido.Location = new System.Drawing.Point(11, 134);
            this.dgvItemVendido.MultiSelect = false;
            this.dgvItemVendido.Name = "dgvItemVendido";
            this.dgvItemVendido.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItemVendido.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvItemVendido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemVendido.Size = new System.Drawing.Size(849, 194);
            this.dgvItemVendido.TabIndex = 7;
            this.dgvItemVendido.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvItemVendido_DataBindingComplete);
            this.dgvItemVendido.SelectionChanged += new System.EventHandler(this.dgvItemVendido_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "IdProduto";
            dataGridViewCellStyle3.Format = "00000";
            dataGridViewCellStyle3.NullValue = "565655";
            this.Id.DefaultCellStyle = dataGridViewCellStyle3;
            this.Id.FillWeight = 304.5685F;
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.FillWeight = 121.8274F;
            this.descricao.HeaderText = "DESCRIÇÃO";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // qtdVendida
            // 
            this.qtdVendida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qtdVendida.DataPropertyName = "qtdVendida";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.qtdVendida.DefaultCellStyle = dataGridViewCellStyle4;
            this.qtdVendida.FillWeight = 38.17258F;
            this.qtdVendida.HeaderText = "QTD.";
            this.qtdVendida.Name = "qtdVendida";
            this.qtdVendida.ReadOnly = true;
            // 
            // valorVenda
            // 
            this.valorVenda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valorVenda.DataPropertyName = "valorVenda";
            dataGridViewCellStyle5.Format = "C2";
            this.valorVenda.DefaultCellStyle = dataGridViewCellStyle5;
            this.valorVenda.FillWeight = 38.17258F;
            this.valorVenda.HeaderText = "VALOR";
            this.valorVenda.Name = "valorVenda";
            this.valorVenda.ReadOnly = true;
            // 
            // valorTotal
            // 
            this.valorTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valorTotal.DataPropertyName = "valorTotal";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.valorTotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.valorTotal.FillWeight = 38.17258F;
            this.valorTotal.HeaderText = "TOTAL";
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.ReadOnly = true;
            // 
            // txtPrecoTotal
            // 
            this.txtPrecoTotal.DecimalPlaces = 2;
            this.txtPrecoTotal.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPrecoTotal.Location = new System.Drawing.Point(690, 42);
            this.txtPrecoTotal.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtPrecoTotal.Name = "txtPrecoTotal";
            this.txtPrecoTotal.Size = new System.Drawing.Size(170, 26);
            this.txtPrecoTotal.TabIndex = 3;
            this.txtPrecoTotal.ValueChanged += new System.EventHandler(this.txtPrecoTotal_ValueChanged);
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.DecimalPlaces = 2;
            this.txtPrecoVenda.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPrecoVenda.Location = new System.Drawing.Point(540, 42);
            this.txtPrecoVenda.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(144, 26);
            this.txtPrecoVenda.TabIndex = 2;
            this.txtPrecoVenda.ValueChanged += new System.EventHandler(this.txtPrecoVenda_ValueChanged);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.DecimalPlaces = 2;
            this.txtQuantidade.Font = new System.Drawing.Font("Arial", 12F);
            this.txtQuantidade.Location = new System.Drawing.Point(441, 42);
            this.txtQuantidade.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(93, 26);
            this.txtQuantidade.TabIndex = 1;
            this.txtQuantidade.ValueChanged += new System.EventHandler(this.txtQuantidade_ValueChanged);
            // 
            // lblBuscaProduto
            // 
            this.lblBuscaProduto.BackColor = System.Drawing.Color.Chartreuse;
            this.lblBuscaProduto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaProduto.Image = global::Trinity.Properties.Resources.buscar_16px;
            this.lblBuscaProduto.Location = new System.Drawing.Point(416, 46);
            this.lblBuscaProduto.Name = "lblBuscaProduto";
            this.lblBuscaProduto.Size = new System.Drawing.Size(18, 19);
            this.lblBuscaProduto.TabIndex = 56;
            this.lblBuscaProduto.Click += new System.EventHandler(this.label7_Click);
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
            this.label5.Size = new System.Drawing.Size(129, 19);
            this.label5.TabIndex = 69;
            this.label5.Text = "PREÇO TOTAL:";
            // 
            // btnRemoverProduto
            // 
            this.btnRemoverProduto.Font = new System.Drawing.Font("Arial", 12F);
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
            this.btnAdicionarProduto.Font = new System.Drawing.Font("Arial", 12F);
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
            this.cmbProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProduto.Font = new System.Drawing.Font("Arial", 12F);
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
            this.label17.Font = new System.Drawing.Font("Arial", 12F);
            this.label17.Location = new System.Drawing.Point(437, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 18);
            this.label17.TabIndex = 63;
            this.label17.Text = "Qtde.:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F);
            this.label13.Location = new System.Drawing.Point(536, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 18);
            this.label13.TabIndex = 60;
            this.label13.Text = "Preço de Venda:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F);
            this.label16.Location = new System.Drawing.Point(686, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 18);
            this.label16.TabIndex = 49;
            this.label16.Text = "Preço Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F);
            this.label10.Location = new System.Drawing.Point(7, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 18);
            this.label10.TabIndex = 49;
            this.label10.Text = "Produto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBuscaCliente);
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDataVenda);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(6, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da Venda";
            // 
            // lblBuscaCliente
            // 
            this.lblBuscaCliente.BackColor = System.Drawing.Color.Chartreuse;
            this.lblBuscaCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaCliente.Image = global::Trinity.Properties.Resources.buscar_16px;
            this.lblBuscaCliente.Location = new System.Drawing.Point(842, 51);
            this.lblBuscaCliente.Name = "lblBuscaCliente";
            this.lblBuscaCliente.Size = new System.Drawing.Size(18, 19);
            this.lblBuscaCliente.TabIndex = 55;
            this.lblBuscaCliente.Click += new System.EventHandler(this.label6_Click);
            // 
            // cmbCliente
            // 
            this.cmbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCliente.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(171, 47);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(671, 26);
            this.cmbCliente.TabIndex = 1;
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
            this.lblCliente.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCliente.Location = new System.Drawing.Point(167, 28);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(61, 18);
            this.lblCliente.TabIndex = 36;
            this.lblCliente.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(7, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
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
            this.txtDataVenda.TabIndex = 0;
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
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // epVendas
            // 
            this.epVendas.ContainerControl = this;
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
            ((System.ComponentModel.ISupportInitialize)(this.txtDesconto)).EndInit();
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
        private System.Windows.Forms.Label lblBuscaCliente;
        private System.Windows.Forms.Label lblBuscaProduto;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.NumericUpDown txtPrecoTotal;
        private System.Windows.Forms.NumericUpDown txtPrecoVenda;
        private System.Windows.Forms.DataGridView dgvItemVendido;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ErrorProvider epVendas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblItemVendido;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.NumericUpDown txtDesconto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdVendida;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotal;
    }
}