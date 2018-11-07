namespace Trinity.View
{
    partial class FrmFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFornecedor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.cmbUf = new System.Windows.Forms.ComboBox();
            this.lblUf = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.txtIm = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefoneCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefoneFixo = new System.Windows.Forms.MaskedTextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.lblRazao = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.epFornecedor = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 47);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(195)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(286, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTÃO DE FORNECEDOR";
            // 
            // cmbCidade
            // 
            this.cmbCidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCidade.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Location = new System.Drawing.Point(554, 95);
            this.cmbCidade.MaxLength = 120;
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(211, 26);
            this.cmbCidade.TabIndex = 6;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.Red;
            this.label35.Location = new System.Drawing.Point(610, 76);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(15, 19);
            this.label35.TabIndex = 51;
            this.label35.Text = "*";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.Red;
            this.label33.Location = new System.Drawing.Point(518, 76);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(15, 19);
            this.label33.TabIndex = 51;
            this.label33.Text = "*";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCidade.Location = new System.Drawing.Point(550, 76);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(64, 18);
            this.lblCidade.TabIndex = 49;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCep.Location = new System.Drawing.Point(387, 76);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(46, 18);
            this.lblCep.TabIndex = 50;
            this.lblCep.Text = "CEP:";
            // 
            // cmbUf
            // 
            this.cmbUf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbUf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUf.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbUf.FormattingEnabled = true;
            this.cmbUf.Location = new System.Drawing.Point(494, 95);
            this.cmbUf.MaxLength = 2;
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(54, 26);
            this.cmbUf.TabIndex = 5;
            this.cmbUf.SelectedIndexChanged += new System.EventHandler(this.cmbUf_SelectedIndexChanged);
            // 
            // lblUf
            // 
            this.lblUf.AutoSize = true;
            this.lblUf.Font = new System.Drawing.Font("Arial", 12F);
            this.lblUf.Location = new System.Drawing.Point(490, 76);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(33, 18);
            this.lblUf.TabIndex = 49;
            this.lblUf.Text = "UF:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(239, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 19);
            this.label19.TabIndex = 57;
            this.label19.Text = "*";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbCidade);
            this.groupBox2.Controls.Add(this.label35);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Controls.Add(this.lblCidade);
            this.groupBox2.Controls.Add(this.lblCep);
            this.groupBox2.Controls.Add(this.cmbUf);
            this.groupBox2.Controls.Add(this.lblUf);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txtCep);
            this.groupBox2.Controls.Add(this.txtBairro);
            this.groupBox2.Controls.Add(this.lblBairro);
            this.groupBox2.Controls.Add(this.txtComplemento);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.lblNumero);
            this.groupBox2.Controls.Add(this.txtLogradouro);
            this.groupBox2.Controls.Add(this.lblLogradouro);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(6, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 142);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(428, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 19);
            this.label6.TabIndex = 58;
            this.label6.Text = "*";
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCep.Location = new System.Drawing.Point(391, 95);
            this.txtCep.Mask = "00000-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.PromptChar = ' ';
            this.txtCep.Size = new System.Drawing.Size(97, 26);
            this.txtCep.TabIndex = 4;
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Font = new System.Drawing.Font("Arial", 12F);
            this.txtBairro.Location = new System.Drawing.Point(193, 95);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(192, 26);
            this.txtBairro.TabIndex = 3;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Arial", 12F);
            this.lblBairro.Location = new System.Drawing.Point(189, 76);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(55, 18);
            this.lblBairro.TabIndex = 55;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplemento.Font = new System.Drawing.Font("Arial", 12F);
            this.txtComplemento.Location = new System.Drawing.Point(11, 95);
            this.txtComplemento.MaxLength = 30;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(176, 26);
            this.txtComplemento.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F);
            this.label18.Location = new System.Drawing.Point(7, 76);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 18);
            this.label18.TabIndex = 52;
            this.label18.Text = "Complemento:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(668, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 19);
            this.label14.TabIndex = 51;
            this.label14.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(94, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 19);
            this.label9.TabIndex = 51;
            this.label9.Text = "*";
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumero.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNumero.Location = new System.Drawing.Point(611, 42);
            this.txtNumero.MaxLength = 8;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(155, 26);
            this.txtNumero.TabIndex = 1;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Arial", 12F);
            this.lblNumero.Location = new System.Drawing.Point(607, 23);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(67, 18);
            this.lblNumero.TabIndex = 49;
            this.lblNumero.Text = "Número:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogradouro.Font = new System.Drawing.Font("Arial", 12F);
            this.txtLogradouro.Location = new System.Drawing.Point(11, 42);
            this.txtLogradouro.MaxLength = 70;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(594, 26);
            this.txtLogradouro.TabIndex = 0;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Font = new System.Drawing.Font("Arial", 12F);
            this.lblLogradouro.Location = new System.Drawing.Point(7, 23);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(93, 18);
            this.lblLogradouro.TabIndex = 49;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Arial", 12F);
            this.label30.Location = new System.Drawing.Point(303, 134);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(104, 18);
            this.label30.TabIndex = 46;
            this.label30.Text = "Telefone Fixo:";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCnpj.Location = new System.Drawing.Point(607, 81);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(54, 18);
            this.lblCnpj.TabIndex = 42;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // txtIm
            // 
            this.txtIm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIm.Font = new System.Drawing.Font("Arial", 12F);
            this.txtIm.Location = new System.Drawing.Point(159, 153);
            this.txtIm.MaxLength = 25;
            this.txtIm.Name = "txtIm";
            this.txtIm.Size = new System.Drawing.Size(142, 26);
            this.txtIm.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F);
            this.label15.Location = new System.Drawing.Point(155, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 18);
            this.label15.TabIndex = 40;
            this.label15.Text = "Insc. Municipal:";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCnpj.Location = new System.Drawing.Point(611, 100);
            this.txtCnpj.Mask = "00,000,000/0000-00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.PromptChar = ' ';
            this.txtCnpj.Size = new System.Drawing.Size(155, 26);
            this.txtCnpj.TabIndex = 3;
            this.txtCnpj.TextChanged += new System.EventHandler(this.txtCnpj_TextChanged);
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFantasia.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNomeFantasia.Location = new System.Drawing.Point(11, 100);
            this.txtNomeFantasia.MaxLength = 80;
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(594, 26);
            this.txtNomeFantasia.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTelefoneCelular);
            this.groupBox1.Controls.Add(this.txtTelefoneFixo);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.lblCnpj);
            this.groupBox1.Controls.Add(this.txtIm);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtCnpj);
            this.groupBox1.Controls.Add(this.txtNomeFantasia);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtIe);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDataCadastro);
            this.groupBox1.Controls.Add(this.txtRazaoSocial);
            this.groupBox1.Controls.Add(this.lblRazao);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(6, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Fornecedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(656, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 19);
            this.label5.TabIndex = 50;
            this.label5.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(739, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 19);
            this.label3.TabIndex = 49;
            this.label3.Text = "*";
            // 
            // txtTelefoneCelular
            // 
            this.txtTelefoneCelular.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTelefoneCelular.Location = new System.Drawing.Point(457, 153);
            this.txtTelefoneCelular.Mask = "(99) 00000-0000";
            this.txtTelefoneCelular.Name = "txtTelefoneCelular";
            this.txtTelefoneCelular.PromptChar = ' ';
            this.txtTelefoneCelular.Size = new System.Drawing.Size(144, 26);
            this.txtTelefoneCelular.TabIndex = 7;
            // 
            // txtTelefoneFixo
            // 
            this.txtTelefoneFixo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTelefoneFixo.Location = new System.Drawing.Point(307, 153);
            this.txtTelefoneFixo.Mask = "(99) 0000-0000";
            this.txtTelefoneFixo.Name = "txtTelefoneFixo";
            this.txtTelefoneFixo.PromptChar = ' ';
            this.txtTelefoneFixo.Size = new System.Drawing.Size(144, 26);
            this.txtTelefoneFixo.TabIndex = 6;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Arial", 12F);
            this.label31.Location = new System.Drawing.Point(453, 134);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(123, 18);
            this.label31.TabIndex = 48;
            this.label31.Text = "Telefone Celular:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 12F);
            this.label27.Location = new System.Drawing.Point(7, 81);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(119, 18);
            this.label27.TabIndex = 36;
            this.label27.Text = "Nome Fantasia:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(106, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 19);
            this.label11.TabIndex = 16;
            this.label11.Text = "*";
            // 
            // txtIe
            // 
            this.txtIe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIe.Font = new System.Drawing.Font("Arial", 12F);
            this.txtIe.Location = new System.Drawing.Point(11, 153);
            this.txtIe.MaxLength = 25;
            this.txtIe.Name = "txtIe";
            this.txtIe.Size = new System.Drawing.Size(142, 26);
            this.txtIe.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F);
            this.label8.Location = new System.Drawing.Point(7, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Insc. Estadual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(607, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data de Cadastro:";
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Enabled = false;
            this.txtDataCadastro.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDataCadastro.Location = new System.Drawing.Point(611, 47);
            this.txtDataCadastro.Mask = "00/00/0000 90:00";
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.ReadOnly = true;
            this.txtDataCadastro.Size = new System.Drawing.Size(154, 26);
            this.txtDataCadastro.TabIndex = 1;
            this.txtDataCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazaoSocial.Font = new System.Drawing.Font("Arial", 12F);
            this.txtRazaoSocial.Location = new System.Drawing.Point(11, 47);
            this.txtRazaoSocial.MaxLength = 80;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(594, 26);
            this.txtRazaoSocial.TabIndex = 0;
            // 
            // lblRazao
            // 
            this.lblRazao.AutoSize = true;
            this.lblRazao.Font = new System.Drawing.Font("Arial", 12F);
            this.lblRazao.Location = new System.Drawing.Point(7, 28);
            this.lblRazao.Name = "lblRazao";
            this.lblRazao.Size = new System.Drawing.Size(105, 18);
            this.lblRazao.TabIndex = 0;
            this.lblRazao.Text = "Razão Social:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCancelar.Location = new System.Drawing.Point(680, 388);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(98, 29);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Arial", 12F);
            this.btnExcluir.Location = new System.Drawing.Point(576, 388);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(98, 29);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnEditar.Location = new System.Drawing.Point(216, 388);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(98, 29);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 12F);
            this.btnSalvar.Location = new System.Drawing.Point(112, 388);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(98, 29);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(6, 388);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(98, 29);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // epFornecedor
            // 
            this.epFornecedor.ContainerControl = this;
            // 
            // FrmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 424);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trinity: Gestão de Fornecedores";
            this.Load += new System.EventHandler(this.FrmFornecedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epFornecedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.ComboBox cmbUf;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.TextBox txtIm;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtIe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtDataCadastro;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.Label lblRazao;
        private System.Windows.Forms.MaskedTextBox txtTelefoneCelular;
        private System.Windows.Forms.MaskedTextBox txtTelefoneFixo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider epFornecedor;
    }
}