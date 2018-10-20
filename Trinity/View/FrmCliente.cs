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
    public partial class FrmCliente : Form
    {
        bool editando;
        Cliente clienteCarregado;

        public FrmCliente(Cliente clienteCarregado)
        {
            InitializeComponent();
            this.clienteCarregado = clienteCarregado;
        }

        private void CarregaCliente()
        {
            if (clienteCarregado is ClientePF)
            {
                tbcClientes.SelectedIndex = 0;
                tbcClientes.TabPages.Remove(pageClientePJ);
                ClientePF clienteCarregadoPF = (ClientePF)this.clienteCarregado;
                txtNome.Text = clienteCarregadoPF.Nome;
                txtDataCadastroPF.Text = clienteCarregadoPF.DataCadastro.ToString();
                txtApelido.Text = clienteCarregadoPF.Apelido;
                cmbSexo.SelectedIndex = (clienteCarregadoPF.Sexo.Equals('M')) ? 0 : 1;
                txtCpf.Text = clienteCarregadoPF.Cpf;
                txtRG.Text = clienteCarregadoPF.Rg;
                txtTelefoneFixoPF.Text = this.clienteCarregado.TelefoneFixo;
                txtTelefoneCelularPF.Text = this.clienteCarregado.TelefoneCelular;
                txtDataNascimento.Text = clienteCarregadoPF.DataNascimento.ToShortDateString();
            }
            else
            {
                tbcClientes.SelectedIndex = 1;
                tbcClientes.TabPages.Remove(pageClientePF);
                ClientePJ clienteCarregadoPJ = (ClientePJ)this.clienteCarregado;
                txtRazaoSocial.Text = clienteCarregadoPJ.RazaoSocial;
                txtDataCadastroPJ.Text = clienteCarregadoPJ.DataCadastro.ToString();
                txtNomeFantasia.Text = clienteCarregadoPJ.NomeFantasia;
                txtCnpj.Text = clienteCarregadoPJ.Cnpj;
                txtIe.Text = clienteCarregadoPJ.Ie;
                txtIm.Text = clienteCarregadoPJ.Im;
                txtTelefoneFixoPJ.Text = this.clienteCarregado.TelefoneFixo;
                txtTelefoneCelularPJ.Text = this.clienteCarregado.TelefoneCelular;
                txtDataAbertura.Text = clienteCarregadoPJ.DataAbertura.ToShortDateString();
            }
            txtLogradouro.Text = this.clienteCarregado.Logradouro;
            txtNumero.Text = this.clienteCarregado.Numero;
            txtComplemento.Text = this.clienteCarregado.Complemento;
            txtBairro.Text = this.clienteCarregado.Bairro;
            txtCep.Text = this.clienteCarregado.Cep;
            txtObservacoes.Text = this.clienteCarregado.Observacoes;
            SelecionaEstado();
            SelecionaCidade();
        }

        private void DesabilitaCampos()
        {
            if (tbcClientes.SelectedIndex == 0)
            {
                txtNome.Enabled = false;
                txtApelido.Enabled = false;
                cmbSexo.Enabled = false;
                txtCpf.Enabled = false;
                txtRG.Enabled = false;
                txtTelefoneFixoPF.Enabled = false;
                txtTelefoneCelularPF.Enabled = false;
                txtDataNascimento.Enabled = false;
            }
            else
            {
                txtRazaoSocial.Enabled = false;
                txtNomeFantasia.Enabled = false;
                txtCnpj.Enabled = false;
                txtIe.Enabled = false;
                txtIm.Enabled = false;
                txtTelefoneFixoPJ.Enabled = false;
                txtTelefoneCelularPJ.Enabled = false;
                txtDataAbertura.Enabled = false;
            }
            txtLogradouro.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtBairro.Enabled = false;
            txtCep.Enabled = false;
            txtTelefoneFixoPJ.Enabled = false;
            txtTelefoneCelularPJ.Enabled = false;
            txtObservacoes.Enabled = false;
            cmbUf.Enabled = false;
            cmbCidade.Enabled = false;
        }

        private void HabilitaCampos()
        {
            if (tbcClientes.SelectedIndex == 0)
            {
                txtNome.Enabled = !false;
                txtApelido.Enabled = !false;
                cmbSexo.Enabled = !false;
                txtCpf.Enabled = !false;
                txtRG.Enabled = !false;
                txtTelefoneFixoPF.Enabled = true;
                txtTelefoneCelularPF.Enabled = true;
                txtDataNascimento.Enabled = !false;
                txtNome.Focus();
            }
            else
            {
                txtRazaoSocial.Enabled = !false;
                txtNomeFantasia.Enabled = !false;
                txtCnpj.Enabled = !false;
                txtIe.Enabled = !false;
                txtIm.Enabled = !false;
                txtTelefoneFixoPJ.Enabled = true;
                txtTelefoneCelularPJ.Enabled = true;
                txtDataAbertura.Enabled = !false;
                txtRazaoSocial.Focus();
            }
            txtLogradouro.Enabled = !false;
            txtNumero.Enabled = !false;
            txtComplemento.Enabled = !false;
            txtBairro.Enabled = !false;
            txtCep.Enabled = !false;
            txtTelefoneFixoPJ.Enabled = !false;
            txtTelefoneCelularPJ.Enabled = !false;
            txtObservacoes.Enabled = !false;
            cmbUf.Enabled = !false;
            cmbCidade.Enabled = !false;
        }

        private void HabilitaBotoes()
        {
            DesabilitaCampos();
            //btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            //btnEditar.Enabled = true;
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
            if (tbcClientes.SelectedIndex == 0)
            {
                txtNome.Text = String.Empty;
                txtDataCadastroPF.Text = Convert.ToString(DateTime.Now);
                //txtApelido.Text = String.Empty;
                cmbSexo.SelectedItem = null;
                txtCpf.Text = String.Empty;
                txtRG.Text = String.Empty;
                txtDataNascimento.Text = String.Empty;
            }
            else
            {
                txtRazaoSocial.Text = String.Empty;
                txtDataCadastroPJ.Text = Convert.ToString(DateTime.Now);
                txtNomeFantasia.Text = String.Empty;
                txtCnpj.Text = String.Empty;
                txtIe.Text = String.Empty;
                txtIm.Text = String.Empty;
                txtDataAbertura.Text = String.Empty;
            }
            txtLogradouro.Text = String.Empty;
            txtNumero.Text = String.Empty;
            txtComplemento.Text = String.Empty;
            txtBairro.Text = String.Empty;
            txtCep.Text = String.Empty;
            txtTelefoneFixoPJ.Text = String.Empty;
            txtTelefoneCelularPJ.Text = String.Empty;
            txtObservacoes.Text = String.Empty;
            //cmbUf.SelectedItem = null;
            //cmbCidade.SelectedItem = null;
            cmbUf.SelectedIndex = 0;
        }

        public void SelecionaCidade()
        {
            int idCidade = this.clienteCarregado.Cidade.IdCidade;
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
            int idEstado = this.clienteCarregado.Cidade.Estado.IdEstado;
            foreach (Estado item in cmbUf.Items)
                if (item.IdEstado == idEstado)
                {
                    cmbUf.SelectedItem = item;
                    break;
                }
        }

        private void maskedTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (!Validacao.ValidaCPF(txtCpf.Text))
                txtCpf.ForeColor = Color.Red;
            else txtCpf.ForeColor = Color.Green;
        }

        private void txtCnpj_TextChanged(object sender, EventArgs e)
        {
            if (!Validacao.ValidaCNPJ(txtCnpj.Text))
                txtCnpj.ForeColor = Color.Red;
            else txtCnpj.ForeColor = Color.Green;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidaCampos())
            {
                ClientePF clientePF = null;
                ClientePJ clientePJ = null;

                if (tbcClientes.SelectedTab.Name.Equals("pageClientePF"))
                {
                    clientePF = new ClientePF();
                    clientePF.Nome = txtNome.Text;
                    clientePF.DataCadastro = Convert.ToDateTime(txtDataCadastroPF.Text);
                    clientePF.Apelido = txtApelido.Text;
                    clientePF.Sexo = cmbSexo.SelectedText.Equals("MASCULINO") ? 'M' : 'F';
                    clientePF.Cpf = txtCpf.Text;
                    clientePF.Rg = txtRG.Text;
                    clientePF.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
                    clientePF.IdClientePF = (clienteCarregado != null) ? clienteCarregado.IdCliente : 0;
                    clientePF.TelefoneFixo = txtTelefoneFixoPF.Text;
                    clientePF.TelefoneCelular = txtTelefoneCelularPF.Text;
                    this.clienteCarregado = clientePF;
                }
                else
                {
                    clientePJ = new ClientePJ();
                    clientePJ.RazaoSocial = txtRazaoSocial.Text;
                    clientePJ.NomeFantasia = txtNomeFantasia.Text;
                    clientePJ.DataCadastro = Convert.ToDateTime(txtDataCadastroPJ.Text);
                    clientePJ.Cnpj = txtCnpj.Text;
                    clientePJ.Ie = txtIe.Text;
                    clientePJ.Im = txtIm.Text;
                    clientePJ.DataAbertura = Convert.ToDateTime(txtDataAbertura.Text);
                    clientePJ.IdClientePJ = (clienteCarregado != null) ? clienteCarregado.IdCliente : 0;
                    clientePJ.TelefoneFixo = txtTelefoneFixoPJ.Text;
                    clientePJ.TelefoneCelular = txtTelefoneCelularPJ.Text;
                    this.clienteCarregado = clientePJ;
                }
                clienteCarregado.Logradouro = txtLogradouro.Text;
                clienteCarregado.Numero = txtNumero.Text;
                clienteCarregado.Complemento = txtComplemento.Text;
                clienteCarregado.Bairro = txtBairro.Text;
                clienteCarregado.Cep = txtCep.Text;
                clienteCarregado.Observacoes = txtObservacoes.Text;
                clienteCarregado.Cidade = (Cidade)cmbCidade.SelectedItem;


                if (clientePF != null)
                {
                    if (!editando)
                        new ClienteDAO().AdicionaClientePF((ClientePF)clienteCarregado);
                    else
                    {
                        new ClienteDAO().AlterarClientePF((ClientePF)clienteCarregado);
                        Close();
                    }
                }
                else
                {
                    if (!editando)
                        new ClienteDAO().AdicionaClientePJ((ClientePJ)clienteCarregado);
                    else
                    {
                        new ClienteDAO().AlterarClientePJ((ClientePJ)clienteCarregado);
                        Close();
                    }

                }

                editando = false;
                DesabilitaCampos();
                btnNovo.Enabled = true;
                btnSalvar.Enabled = false;
            }
            else
                MessageBox.Show("Possuem algumas pendências de dados, favor verificar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private bool ValidaCampos()
        {
            epClientes.Clear();
            bool hasErros = false;

            if (tbcClientes.SelectedTab.Name.Equals("pageClientePF"))
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    epClientes.SetError(lblNome, "O nome é obrigatório!");
                    hasErros = true;
                }
                else
                    epClientes.SetError(lblNome, string.Empty);

                if (string.IsNullOrWhiteSpace(cmbSexo.Text))
                {
                    epClientes.SetError(lblSexo, "O sexo é obrigatório!");
                    hasErros = true;
                }
                else
                    epClientes.SetError(lblSexo, string.Empty);

                if (string.IsNullOrWhiteSpace(txtCpf.Text.Replace(".", "").Replace("-", "")))
                {
                    epClientes.SetError(lblCPF, "O CPF é obrigatório!");
                    hasErros = true;
                }
                else if (!Validacao.ValidaCPF(txtCpf.Text))
                {
                    epClientes.SetError(lblCPF, "CPF inválido!");
                    hasErros = true;
                }
                else
                    epClientes.SetError(lblCPF, string.Empty);

                if (string.IsNullOrWhiteSpace(txtDataNascimento.Text))
                {
                    epClientes.SetError(lblDataNasc, "A data de nascimento é obrigatória!");
                    hasErros = true;
                }
                else
                    epClientes.SetError(lblDataNasc, string.Empty);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtRazaoSocial.Text))
                {
                    epClientes.SetError(lblRazao, "A razão social é obrigatória!");
                    hasErros = true;
                }
                else
                    epClientes.SetError(lblRazao, string.Empty);

                if (string.IsNullOrWhiteSpace(txtCnpj.Text.Replace(".", "").Replace("/", "").Replace("-", "")))
                {
                    epClientes.SetError(lblCnpj, "O CNPJ é obrigatório!");
                    hasErros = true;
                }
                else if (!Validacao.ValidaCNPJ(txtCnpj.Text))
                {
                    epClientes.SetError(lblCnpj, "CNPJ inválido!");
                    hasErros = true;
                }
                else
                    epClientes.SetError(lblCnpj, string.Empty);

                if (string.IsNullOrWhiteSpace(txtDataAbertura.Text))
                {
                    epClientes.SetError(lblDataAbertura, "A data de abertura é obrigatória!");
                    hasErros = true;
                }
                else
                    epClientes.SetError(lblDataAbertura, string.Empty);
            }

            //Informações do Cliente
            if (string.IsNullOrWhiteSpace(txtLogradouro.Text))
            {
                epClientes.SetError(lblLogradouro, "O logradouro é obrigatório!");
                hasErros = true;
            }
            else
                epClientes.SetError(lblLogradouro, string.Empty);

            if (string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                epClientes.SetError(lblNumero, "O número é obrigatório!");
                hasErros = true;
            }
            else
                epClientes.SetError(lblNumero, string.Empty);

            if (string.IsNullOrWhiteSpace(txtBairro.Text))
            {
                epClientes.SetError(lblBairro, "O bairro é obrigatório!");
                hasErros = true;
            }
            else
                epClientes.SetError(lblBairro, string.Empty);

            if (string.IsNullOrWhiteSpace(txtCep.Text.Replace("-", "")))
            {
                epClientes.SetError(lblCep, "O cep é obrigatório!");
                hasErros = true;
            }
            else
                epClientes.SetError(lblCep, string.Empty);

            if (string.IsNullOrWhiteSpace(cmbUf.Text))
            {
                epClientes.SetError(lblUf, "UF obrigatória!");
                hasErros = true;
            }
            else
                epClientes.SetError(lblUf, string.Empty);

            if (string.IsNullOrWhiteSpace(cmbCidade.Text))
            {
                epClientes.SetError(lblCidade, "A cidade é obrigatória!");
                hasErros = true;
            }
            else
                epClientes.SetError(lblCidade, string.Empty);

            return hasErros;
        }

        private void cmbUf_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCidade.DisplayMember = "cidade";
            cmbCidade.DataSource = new CidadeDAO().GetListaCidade((Estado)cmbUf.SelectedItem);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editando = true;
            DesabilitaBotoes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            /*
            if (this.editando)
            {
                if (MessageBox.Show("Você realmente quer desfazer as alterações deste CLIENTE?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    HabilitaBotoes();
                    this.editando = false;
                    CarregaCliente();
                }
            }
            else this.Close();
            */
            if (editando)
            {
                if (MessageBox.Show("Você realmente quer desfazer as alterações deste CLIENTE?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    this.Close();
            }
            else
                this.Close();

        }

        private void tbcClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!editando)
            {
                if (tbcClientes.SelectedIndex == 0)
                    txtDataCadastroPF.Text = Convert.ToString(DateTime.Now);
                else
                    txtDataCadastroPJ.Text = Convert.ToString(DateTime.Now);
            }

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            DesabilitaBotoes();
            CarregaEstado();
            if (this.clienteCarregado != null)
            {
                this.editando = true;
                CarregaCliente();
            }
            else txtDataCadastroPF.Text = Convert.ToString(DateTime.Now);
        }
    }
}