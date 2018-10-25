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
    public partial class FrmUnidadeMedida : Form
    {

        private bool boolEditando;
        private bool boolEquals = false;
        
        public FrmUnidadeMedida(byte type = 0)
        {
            InitializeComponent();
            if (type == 1)
                HabilitaBotoesInclusao();
            else
            {
                Pesquisa();
                HabilitaBotoes(true);
            }
        }

        private void Pesquisa()
        {
            try
            {
                UnidadeMedida unidade = new UnidadeMedidaDAO().Pesquisar();
                if (unidade != null)
                    PreenchaCampos(unidade);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar a unidade de medida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreenchaCampos(UnidadeMedida unidade)
        {
            txtId.Text = unidade.IdUnidadeMedida.ToString("D3");
            txtSigla.Text = unidade.Sigla;
            txtUnidadeMedida.Text = unidade.unidadeMedida;
        }

        private void HabilitaBotoes(bool state)
        {
            HabilitaCampo(state);
            btnNovo.Enabled = state;
            btnSalvar.Enabled = !state && boolEditando;
            btnExcluir.Enabled = state && !string.IsNullOrWhiteSpace(txtSigla.Text);
            btnEditar.Enabled = state && !string.IsNullOrWhiteSpace(txtSigla.Text);
        }

        private void HabilitaCampo(bool state)
        {
            txtSigla.Enabled = !state;
            txtUnidadeMedida.Enabled = !state;
        }

        private void HabilitaBotoesInclusao()
        {
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(!validaCampos())
            {
                if (txtSigla.Text.Trim().Length == 2)
                {
                    if (!boolEquals)
                    {
                        UnidadeMedida unidadeMedida = new UnidadeMedida();
                        unidadeMedida.Sigla = txtSigla.Text.Trim();
                        unidadeMedida.unidadeMedida = txtUnidadeMedida.Text.Trim();

                        bool gravou = false;
                        if (txtId.Text.Equals(string.Empty))
                            gravou = new UnidadeMedidaDAO().AdicionaUnidadeMedida(unidadeMedida);
                        else
                        {
                            unidadeMedida.IdUnidadeMedida = Convert.ToInt32(txtId.Text);
                            gravou = new UnidadeMedidaDAO().AlterarUnidadeMedida(unidadeMedida);
                        }

                        if(gravou)
                            this.Close();
                    }
                    else
                        MessageBox.Show("Já existe uma unidade de medida com esta sigla.\n Não sendo possível inserir esta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                    MessageBox.Show("Não foi possível realizar a operação.\nO campo SIGLA deve obrigatoriamente ter 2 (dois) caracteres!!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else
                MessageBox.Show("Não foi possível realizar a operação.\nHá CAMPOS OBRIGATÓRIOS que não foram preenchidos!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
        }

        private bool validaCampos()
        {
            bool hasErrors = false;
            epUn.Clear();

            if (string.IsNullOrWhiteSpace(txtSigla.Text.Trim()))
            {
                hasErrors = true;
                epUn.SetError(lblSigla, "A sigla é obrigatória.");
            }

            if (string.IsNullOrWhiteSpace(txtUnidadeMedida.Text.Trim()))
            {
                hasErrors = true;
                epUn.SetError(lblUnidade, "A descrição é obrigatória.");
            }

            return hasErrors;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (boolEditando  && MessageBox.Show("Deseja desfazer as alterações?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                boolEditando = false;
                Pesquisa();
                HabilitaBotoes(true);
            }
            else
                this.Close();
                
        }

        private void FrmUnidadeMedida_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            boolEditando = true;
            HabilitaBotoes(false);
            txtId.Text = string.Empty;
            txtSigla.Text = string.Empty;
            txtUnidadeMedida.Text = string.Empty;
            txtSigla.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            boolEditando = true;
            HabilitaBotoes(false);
            txtSigla.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja excluir esta unidade de medida?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (new UnidadeMedidaDAO().Excluir(Convert.ToInt32(txtId.Text)))
                    {
                        MessageBox.Show("Unidade de Medida excluída com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Pesquisa();
                        HabilitaBotoes(true);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro.\nErro: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSigla_Leave(object sender, EventArgs e)
        {
            if(txtId.Text == string.Empty && txtSigla.Text.Trim().Length == 2)
            {
                if (new UnidadeMedidaDAO().verificaSigla(txtSigla.Text.Trim()))
                {
                    MessageBox.Show("Já existe uma unidade de medida com esta sigla.\n Não sendo possível inserir esta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    boolEquals = true;
                }
                else
                    boolEquals = false;
            }
        }
    }
}
