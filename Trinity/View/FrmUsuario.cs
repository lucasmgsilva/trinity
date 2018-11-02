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
using Trinity.Model.DAO;

namespace Trinity.View
{
    public partial class FrmUsuario : Form
    {
        bool editando;
        Usuario usuarioCarregado;

        public FrmUsuario(Usuario usuarioCarregado)
        {
            InitializeComponent();
            this.usuarioCarregado = usuarioCarregado;
            DesabilitaBotoes();
            CarregaCargo();
            CarregaRazaoSocial();
            if (this.usuarioCarregado != null)
            {
                this.editando = true;
                CarregaUsuario();
            }
        }

        private void CarregaUsuario ()
        {
            txtUsuario.Text = this.usuarioCarregado.usuario;
            txtSenha.Text = this.usuarioCarregado.Senha;
            txtConfirmacaoSenha.Text = this.usuarioCarregado.Senha;
            SelecionaCargo();
            SelecionaRazaoSocial();
        }

        public void CarregaCargo()
        {
            cmbCargo.DisplayMember = "cargo";
            cmbCargo.DataSource = new CargoDAO().GetListaCargos();
        }

        public void SelecionaCargo()
        {
            if (this.usuarioCarregado != null)
            {
                int idCargo = this.usuarioCarregado.Cargo.IdCargo;
                foreach (Cargo item in cmbCargo.Items)
                    if (item.IdCargo == idCargo)
                    {
                        cmbCargo.SelectedItem = item;
                        break;
                    }
            }
        }

        public void CarregaRazaoSocial()
        {
            cmbRazaoSocial.DisplayMember = "RazaoSocial";
            cmbRazaoSocial.DataSource = new EmpresaDAO().GetListaEmpresas();
        }

        public void SelecionaRazaoSocial()
        {
            if (this.usuarioCarregado != null)
            {
                int idEmpresa = this.usuarioCarregado.Empresa.IdEmpresa;
                foreach (Empresa item in cmbRazaoSocial.Items)
                    if (item.IdEmpresa == idEmpresa)
                    {
                        cmbRazaoSocial.SelectedItem = item;
                        break;
                    }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(!ValidaCampos())
            {
                if (ValidaSenha())
                {
                    if (this.usuarioCarregado == null)
                        this.usuarioCarregado = new Usuario();
                    this.usuarioCarregado.usuario = txtUsuario.Text.Trim();
                    this.usuarioCarregado.Senha = txtSenha.Text.Trim();
                    this.usuarioCarregado.Cargo = (Cargo) cmbCargo.SelectedItem;
                    this.usuarioCarregado.Empresa = (Empresa) cmbRazaoSocial.SelectedItem;

                    UsuarioDAO dao = new UsuarioDAO();
                    if (!this.editando)
                        dao.AdicionaUsuario(this.usuarioCarregado);
                    else dao.AlteraUsuario(this.usuarioCarregado);
                    this.Close();
                }
                else MessageBox.Show("Não foi possível realizar a operação.\nA SENHA não é igual a CONFIRMAÇÃO DE SENHA digitada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else MessageBox.Show("Possuem algumas pendências de dados, favor verificar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private bool ValidaCampos()
        {
            bool hasErrors = false;

            epUsuarios.Clear();

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                epUsuarios.SetError(lblUsuarios, "O usuário é obrigatório.");
                hasErrors = true;
            }
            else
                epUsuarios.SetError(lblUsuarios, string.Empty);

            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                epUsuarios.SetError(lblSenha, "A senha é obrigatória.");
                hasErrors = true;
            }
            else
                epUsuarios.SetError(lblSenha, string.Empty);

            if (string.IsNullOrWhiteSpace(txtConfirmacaoSenha.Text))
            {
                epUsuarios.SetError(lblConf, "A confirmação da senha é obrigatória.");
                hasErrors = true;
            }
            else
                epUsuarios.SetError(lblConf, string.Empty);

            if (string.IsNullOrWhiteSpace(cmbCargo.Text))
            {
                epUsuarios.SetError(lblCargo, "O cargo é obrigatório.");
                hasErrors = true;
            }
            else
                epUsuarios.SetError(lblCargo, string.Empty);

            if (string.IsNullOrWhiteSpace(cmbRazaoSocial.Text))
            {
                epUsuarios.SetError(lblRazao, "A razão social é obrigatória.");
                hasErrors = true;
            }
            else
                epUsuarios.SetError(lblRazao, string.Empty);

            return hasErrors;

        }

        private void Add_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Add_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new FrmCargo().ShowDialog();
            CarregaCargo();
            SelecionaCargo();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            new FrmEmpresa(null).ShowDialog();
            CarregaRazaoSocial();
            SelecionaRazaoSocial();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (this.editando)
            {
                if (MessageBox.Show("Você realmente quer desfazer as alterações deste USUÁRIO?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    /*
                    HabilitaBotoes();
                    this.editando = false;
                    CarregaUsuario();
                    */

                    Close();

                }
            }
            else this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.editando = true;
            DesabilitaBotoes();
        }

        private void DesabilitaCampos()
        {
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            txtConfirmacaoSenha.Enabled = false;
            cmbCargo.Enabled = false;
            //cmbRazaoSocial.Enabled = false;
        }

        private void HabilitaCampos()
        {
            txtUsuario.Enabled = !false;
            txtSenha.Enabled = !false;
            txtConfirmacaoSenha.Enabled = !false;
            cmbCargo.Enabled = !false;
            //cmbRazaoSocial.Enabled = !false;
            txtUsuario.Focus();
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
            txtUsuario.Text = String.Empty;
            txtSenha.Text = String.Empty;
            txtConfirmacaoSenha.Text = String.Empty;
            cmbCargo.SelectedItem = null;
            //cmbRazaoSocial.SelectedItem = null;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente quer excluir este USUÁRIO?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UsuarioDAO dao = new UsuarioDAO();
                dao.DeletaUsuario(this.usuarioCarregado.IdUsuario);
                this.Close();
            }
        }

        private bool ValidaSenha()
        {
            bool validado;
            if (txtSenha.Text == String.Empty || txtConfirmacaoSenha.Text == String.Empty || txtSenha.Text.Length != txtConfirmacaoSenha.Text.Length || !txtSenha.Text.Equals(txtConfirmacaoSenha.Text))
                return false;
            return true;
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (!ValidaSenha())
            {
                txtSenha.ForeColor = Color.Red;
                txtConfirmacaoSenha.ForeColor = Color.Red;
            }
            else
            {
                txtSenha.ForeColor = Color.Green;
                txtConfirmacaoSenha.ForeColor = Color.Green;
            }
        }

        private void txtConfirmacaoSenha_TextChanged(object sender, EventArgs e)
        {
            if (!ValidaSenha())
            {
                txtSenha.ForeColor = Color.Red;
                txtConfirmacaoSenha.ForeColor = Color.Red;
            }
            else {
                txtSenha.ForeColor = Color.Green;
                txtConfirmacaoSenha.ForeColor = Color.Green;
            }
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}