using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trinity.Model;
using Trinity.Model.Bean;
using Trinity.Model.DAO;

namespace Trinity.View
{
    public partial class FrmFornecedor : Form
    {
        bool editando;
        Fornecedor fornecedorCarregado;

        public FrmFornecedor(Fornecedor fornecedorCarregado)
        {
            InitializeComponent();
            this.fornecedorCarregado = fornecedorCarregado;
            DesabilitaBotoes();
            CarregaEstado();
            if (this.fornecedorCarregado != null)
            {
                this.editando = true;
                CarregaFornecedor();
            } else txtDataCadastro.Text = Convert.ToString(DateTime.Now);
        }

        private void CarregaFornecedor()
        {
            txtRazaoSocial.Text = this.fornecedorCarregado.RazaoSocial;
            txtDataCadastro.Text = this.fornecedorCarregado.DataCadastro.ToString();
            txtNomeFantasia.Text = this.fornecedorCarregado.NomeFantasia;
            txtCnpj.Text = this.fornecedorCarregado.Cnpj;
            txtIe.Text = this.fornecedorCarregado.Ie;
            txtIm.Text = this.fornecedorCarregado.Im;
            txtTelefoneFixo.Text = this.fornecedorCarregado.TelefoneFixo;
            txtTelefoneCelular.Text = this.fornecedorCarregado.TelefoneCelular;
            txtLogradouro.Text = this.fornecedorCarregado.Logradouro;
            txtNumero.Text = this.fornecedorCarregado.Numero;
            txtComplemento.Text = this.fornecedorCarregado.Complemento;
            txtBairro.Text = this.fornecedorCarregado.Bairro;
            txtCep.Text = this.fornecedorCarregado.Cep;
            SelecionaEstado();
            SelecionaCidade();
        }

        public void SelecionaCidade()
        {
            int idCidade = this.fornecedorCarregado.Cidade.IdCidade;
            foreach (Cidade item in cmbCidade.Items)
                if (item.IdCidade == idCidade)
                {
                    cmbCidade.SelectedItem = item;

                    break;
                }
        }

        public void CarregaEstado()
        {
            cmbUf.DisplayMember = "uf";
            cmbUf.DataSource = new EstadoDAO().GetListaEstados();
        }

        public void SelecionaEstado()
        {
            int idEstado = this.fornecedorCarregado.Cidade.Estado.IdEstado;
            foreach (Estado item in cmbUf.Items)
                if (item.IdEstado == idEstado)
                {
                    cmbUf.SelectedItem = item;
                    break;
                }
        }

        private void cmbUf_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCidade.DisplayMember = "cidade";
            cmbCidade.DataSource = new CidadeDAO().GetListaCidade((Estado)cmbUf.SelectedItem);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtRazaoSocial.Text.Trim()) && !String.IsNullOrEmpty(txtCnpj.Text.Trim()) && !String.IsNullOrEmpty(txtLogradouro.Text.Trim()) && !String.IsNullOrEmpty(txtNumero.Text.Trim()) && !String.IsNullOrEmpty(txtBairro.Text.Trim()) && !String.IsNullOrEmpty(txtCep.Text.Trim()) && cmbUf.SelectedItem != null && cmbCidade.SelectedItem != null)
            {
                if (Validacao.ValidaCNPJ(txtCnpj.Text))
                {
                    if (this.fornecedorCarregado == null)
                        this.fornecedorCarregado = new Fornecedor();
                    this.fornecedorCarregado.RazaoSocial = txtRazaoSocial.Text.Trim();
                    this.fornecedorCarregado.DataCadastro = Convert.ToDateTime(txtDataCadastro.Text);
                    this.fornecedorCarregado.NomeFantasia = txtNomeFantasia.Text.Trim();
                    this.fornecedorCarregado.Cnpj = txtCnpj.Text;
                    this.fornecedorCarregado.Ie = txtIe.Text.Trim();
                    this.fornecedorCarregado.Im = txtIm.Text.Trim();
                    this.fornecedorCarregado.TelefoneFixo = txtTelefoneFixo.Text;
                    this.fornecedorCarregado.TelefoneCelular = txtTelefoneCelular.Text;
                    this.fornecedorCarregado.Logradouro = txtLogradouro.Text.Trim();
                    this.fornecedorCarregado.Numero = txtNumero.Text.Trim();
                    this.fornecedorCarregado.Complemento = txtComplemento.Text.Trim();
                    this.fornecedorCarregado.Bairro = txtBairro.Text.Trim();
                    this.fornecedorCarregado.Cep = txtCep.Text;
                    this.fornecedorCarregado.Cidade = (Cidade)cmbCidade.SelectedItem;
                    this.fornecedorCarregado.Cidade.Estado = (Estado)cmbUf.SelectedItem;

                    FornecedorDAO dao = new FornecedorDAO();
                    if (!this.editando)
                        dao.AdicionaFornecedor(this.fornecedorCarregado);
                    else dao.AlteraFornecedor(this.fornecedorCarregado);
                    this.Close();
                } else MessageBox.Show("Não foi possível realizar a operação.\nO CNPJ digitado é INVÁLIDO!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else MessageBox.Show("Não foi possível realizar a operação.\nHá CAMPOS OBRIGATÓRIOS que não foram preenchidos!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void DesabilitaCampos()
        {
            txtRazaoSocial.Enabled = false;
            txtDataCadastro.Enabled = false;
            txtNomeFantasia.Enabled = false;
            txtCnpj.Enabled = false;
            txtIe.Enabled = false;
            txtIm.Enabled = false;
            txtTelefoneFixo.Enabled = false;
            txtTelefoneCelular.Enabled = false;
            txtLogradouro.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtCep.Enabled = false;
            cmbUf.Enabled = false;
            cmbCidade.Enabled = false;
        }

        private void HabilitaCampos()
        {
            txtRazaoSocial.Enabled = !false;
            txtDataCadastro.Enabled = !false;
            txtNomeFantasia.Enabled = !false;
            txtCnpj.Enabled = !false;
            txtIe.Enabled = !false;
            txtIm.Enabled = !false;
            txtTelefoneFixo.Enabled = !false;
            txtTelefoneCelular.Enabled = !false;
            txtLogradouro.Enabled = !false;
            txtNumero.Enabled = !false;
            txtComplemento.Enabled = !false;
            txtBairro.Enabled = !false;
            txtCep.Enabled = !false;
            cmbUf.Enabled = !false;
            cmbCidade.Enabled = !false;
            txtRazaoSocial.Focus();
        }

        private void HabilitaBotoes()
        {
            DesabilitaCampos();
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void DesabilitaBotoes()
        {
            HabilitaCampos();
            btnNovo.Enabled = !true;
            btnSalvar.Enabled = !false;
            btnEditar.Enabled = !true;
            btnExcluir.Enabled = !true;
        }

        private void LimpaCampos()
        {
            DesabilitaBotoes();
            txtRazaoSocial.Text = String.Empty;
            txtDataCadastro.Text = String.Empty;
            txtNomeFantasia.Text = String.Empty;
            txtCnpj.Text = String.Empty;
            txtIe.Text = String.Empty;
            txtIm.Text = String.Empty;
            txtTelefoneFixo.Text = String.Empty;
            txtTelefoneCelular.Text = String.Empty;
            txtLogradouro.Text = String.Empty;
            txtNumero.Text = String.Empty;
            txtComplemento.Text = String.Empty;
            txtBairro.Text = String.Empty;
            txtCep.Text = String.Empty;
            cmbUf.SelectedItem = null;
            cmbCidade.SelectedItem = null;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente quer excluir este FORNECEDOR?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FornecedorDAO dao = new FornecedorDAO();
                dao.DeletaFornecedor(this.fornecedorCarregado.IdFornecedor);
                this.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.editando = true;
            DesabilitaBotoes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (this.editando)
            {
                if (MessageBox.Show("Você realmente quer desfazer as alterações deste FORNECEDOR?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    HabilitaBotoes();
                    this.editando = false;
                    CarregaFornecedor();
                }
            }
            else this.Close();
        }

        private void txtCnpj_TextChanged(object sender, EventArgs e)
        {
            if (!Validacao.ValidaCNPJ(txtCnpj.Text))
                txtCnpj.ForeColor = Color.Red;
            else txtCnpj.ForeColor = Color.Green;
        }
    }
}
