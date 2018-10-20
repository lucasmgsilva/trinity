namespace Trinity
{
    partial class FrmApresentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmApresentacao));
            this.pgbCarregamento = new System.Windows.Forms.ProgressBar();
            this.relogio = new System.Windows.Forms.Timer(this.components);
            this.lblGestaoDeVendas = new System.Windows.Forms.Label();
            this.lblTrinity = new System.Windows.Forms.Label();
            this.lblSistemasMatrix = new System.Windows.Forms.Label();
            this.lblDireitosReservados = new System.Windows.Forms.Label();
            this.pctMatrix = new System.Windows.Forms.PictureBox();
            this.pctTrinity = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTrinity)).BeginInit();
            this.SuspendLayout();
            // 
            // pgbCarregamento
            // 
            this.pgbCarregamento.Location = new System.Drawing.Point(12, 386);
            this.pgbCarregamento.Name = "pgbCarregamento";
            this.pgbCarregamento.Size = new System.Drawing.Size(786, 23);
            this.pgbCarregamento.TabIndex = 0;
            this.pgbCarregamento.Visible = false;
            // 
            // relogio
            // 
            this.relogio.Enabled = true;
            this.relogio.Interval = 25;
            this.relogio.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblGestaoDeVendas
            // 
            this.lblGestaoDeVendas.AutoSize = true;
            this.lblGestaoDeVendas.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestaoDeVendas.ForeColor = System.Drawing.Color.White;
            this.lblGestaoDeVendas.Location = new System.Drawing.Point(44, 89);
            this.lblGestaoDeVendas.Name = "lblGestaoDeVendas";
            this.lblGestaoDeVendas.Size = new System.Drawing.Size(210, 27);
            this.lblGestaoDeVendas.TabIndex = 1;
            this.lblGestaoDeVendas.Text = "Gestão de Vendas";
            // 
            // lblTrinity
            // 
            this.lblTrinity.AutoSize = true;
            this.lblTrinity.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrinity.ForeColor = System.Drawing.Color.White;
            this.lblTrinity.Location = new System.Drawing.Point(42, 52);
            this.lblTrinity.Name = "lblTrinity";
            this.lblTrinity.Size = new System.Drawing.Size(115, 37);
            this.lblTrinity.TabIndex = 2;
            this.lblTrinity.Text = "Trinity";
            // 
            // lblSistemasMatrix
            // 
            this.lblSistemasMatrix.AutoSize = true;
            this.lblSistemasMatrix.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistemasMatrix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.lblSistemasMatrix.Location = new System.Drawing.Point(46, 333);
            this.lblSistemasMatrix.Name = "lblSistemasMatrix";
            this.lblSistemasMatrix.Size = new System.Drawing.Size(180, 18);
            this.lblSistemasMatrix.TabIndex = 3;
            this.lblSistemasMatrix.Text = "© 2018 Sistemas Matrix.";
            // 
            // lblDireitosReservados
            // 
            this.lblDireitosReservados.AutoSize = true;
            this.lblDireitosReservados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireitosReservados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(149)))), ((int)(((byte)(152)))));
            this.lblDireitosReservados.Location = new System.Drawing.Point(46, 351);
            this.lblDireitosReservados.Name = "lblDireitosReservados";
            this.lblDireitosReservados.Size = new System.Drawing.Size(213, 18);
            this.lblDireitosReservados.TabIndex = 4;
            this.lblDireitosReservados.Text = "Todos os direitos reservados.";
            // 
            // pctMatrix
            // 
            this.pctMatrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctMatrix.Image = global::Trinity.Properties.Resources.logo_matrix;
            this.pctMatrix.Location = new System.Drawing.Point(408, 157);
            this.pctMatrix.Name = "pctMatrix";
            this.pctMatrix.Size = new System.Drawing.Size(100, 106);
            this.pctMatrix.TabIndex = 5;
            this.pctMatrix.TabStop = false;
            this.pctMatrix.Click += new System.EventHandler(this.pctMatrix_Click);
            // 
            // pctTrinity
            // 
            this.pctTrinity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctTrinity.Image = global::Trinity.Properties.Resources.logo_trinity;
            this.pctTrinity.Location = new System.Drawing.Point(302, 157);
            this.pctTrinity.Name = "pctTrinity";
            this.pctTrinity.Size = new System.Drawing.Size(100, 106);
            this.pctTrinity.TabIndex = 6;
            this.pctTrinity.TabStop = false;
            // 
            // FrmApresentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(810, 421);
            this.Controls.Add(this.pctTrinity);
            this.Controls.Add(this.pctMatrix);
            this.Controls.Add(this.lblDireitosReservados);
            this.Controls.Add(this.lblSistemasMatrix);
            this.Controls.Add(this.lblTrinity);
            this.Controls.Add(this.lblGestaoDeVendas);
            this.Controls.Add(this.pgbCarregamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmApresentacao";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trinity: Apresentação do Sistema";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pctMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTrinity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbCarregamento;
        private System.Windows.Forms.Timer relogio;
        private System.Windows.Forms.Label lblGestaoDeVendas;
        private System.Windows.Forms.Label lblTrinity;
        private System.Windows.Forms.Label lblSistemasMatrix;
        private System.Windows.Forms.Label lblDireitosReservados;
        private System.Windows.Forms.PictureBox pctMatrix;
        private System.Windows.Forms.PictureBox pctTrinity;
    }
}