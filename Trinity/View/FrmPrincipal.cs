using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trinity.Model.Bean;
using Trinity.View;

namespace Trinity
{
    public partial class FrmPrincipal : Form
    {
        public static Usuario UsuarioSessaoAtual { get; set; }

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public FrmPrincipal(Usuario usuario)
        {
            InitializeComponent();
            UsuarioSessaoAtual = usuario;
            lblUsuario.Text = UsuarioSessaoAtual.usuario;
            lblRazaoSocial.Text = UsuarioSessaoAtual.Empresa.RazaoSocial;
            HabilitaModulos();
        }

        public void HabilitaModulos()
        {
            string permissoes = UsuarioSessaoAtual.Cargo.Permissoes;
                for(int i = 0;i < permissoes.Length; i += 2)
                {
                    if (permissoes.Substring(i, 2) == "EM")
                        minhaEmpresaToolStripMenuItem1.Enabled = true;
                    else if (permissoes.Substring(i, 2) == "VE")
                        vendasToolStripMenuItem.Enabled = true;
                    else if (permissoes.Substring(i, 2) == "CO")
                        comprasToolStripMenuItem.Enabled = true;
                    else if (permissoes.Substring(i, 2) == "CL")
                        clientesToolStripMenuItem1.Enabled = true;
                    else if (permissoes.Substring(i, 2) == "FO")
                        fornecedoresToolStripMenuItem1.Enabled = true;
                    else if (permissoes.Substring(i, 2) == "PR")
                        produtosToolStripMenuItem1.Enabled = true;
                    else if (permissoes.Substring(i, 2) == "US")
                        usuariosToolStripMenuItem1.Enabled = true;
                }
        }

        private void soreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre sobre = new FrmSobre();
            sobre.ShowDialog();
        }

        private void sobreOSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre telaSobre = new FrmSobre();
            telaSobre.ShowDialog();
        }

        private void trocaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente quer TROCAR DE USUÁRIO?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                FrmAcesso telaAcesso = new FrmAcesso();
                telaAcesso.Show();
            }
        }

        private void minhaEmpresaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmEmpresa telaEmpresa;
            if (UsuarioSessaoAtual != null)
                telaEmpresa = new FrmEmpresa(UsuarioSessaoAtual.Empresa);
            else telaEmpresa = new FrmEmpresa(null);
            telaEmpresa.ShowDialog();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaUsuario telaConsultaUsuario = new FrmConsultaUsuario();
            telaConsultaUsuario.ShowDialog();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaProduto telaConsultaProduto = new FrmConsultaProduto();
            telaConsultaProduto.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaFornecedor telaConsultaFornecedor = new FrmConsultaFornecedor();
            telaConsultaFornecedor.ShowDialog();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente quer SAIR DO SISTEMA?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaCliente telaConsultaCliente = new FrmConsultaCliente();
            telaConsultaCliente.ShowDialog();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaVenda telaConsultaVenda = new FrmConsultaVenda();
            telaConsultaVenda.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void uNMEDIDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUnidadeMedida telaUnidadeMedida = new FrmUnidadeMedida();
            telaUnidadeMedida.ShowDialog();
        }

        private void mARCAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarca telaMarca = new FrmMarca();
            telaMarca.ShowDialog();
        }

        private void gRUPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGrupo telaGrupo = new FrmGrupo();
            telaGrupo.ShowDialog();
        }
    }
}
