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
    public partial class FrmGrupo : Form
    {
        private bool boolEditando;
        public FrmGrupo(byte type = 0)
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
                Grupo grupo = new GrupoDAO().Pesquisar();
                if(grupo != null)
                {
                    txtId.Text = grupo.IdGrupo.ToString("D3");
                    txtGrupo.Text = grupo.grupo;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar o grupo.\n Erro: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HabilitaBotoes(bool state)
        {
            txtGrupo.Enabled = !state;
            btnNovo.Enabled = state;
            btnSalvar.Enabled = !state && boolEditando;
            btnExcluir.Enabled = state && !string.IsNullOrWhiteSpace(txtId.Text);
            btnEditar.Enabled = state && !string.IsNullOrWhiteSpace(txtId.Text);
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
            if (!validaCampo())
            {
                Grupo grupo = new Grupo();
                grupo.grupo = txtGrupo.Text.Trim();

                bool gravou = false;
                if (string.IsNullOrWhiteSpace(txtId.Text))
                    gravou = new GrupoDAO().AdicionaGrupo(grupo);
                else
                {
                    grupo.IdGrupo = Convert.ToInt32(txtId.Text);
                    gravou = new GrupoDAO().Alterar(grupo);
                }
                
                if(gravou)
                    this.Close();
            } else MessageBox.Show("Não foi possível realizar a operação.\nHá CAMPOS OBRIGATÓRIOS que não foram preenchidos!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool validaCampo()
        {
            bool hasErrors = false;
            epGrupo.Clear();

            if (string.IsNullOrWhiteSpace(txtGrupo.Text))
            {
                epGrupo.SetError(lblGrupo, "O grupo é obrigatório.");
                hasErrors = true;
            }

            return hasErrors;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (boolEditando && MessageBox.Show("Deseja desfazer as alterações?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                boolEditando = false;
                Pesquisa();
                HabilitaBotoes(true);
            }
            else
                this.Close();
        }

        private void FrmGrupo_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            boolEditando = true;
            HabilitaBotoes(false);
            txtGrupo.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            boolEditando = true;
            HabilitaBotoes(false);
            txtId.Text = string.Empty;
            txtGrupo.Text = string.Empty;
            txtGrupo.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir este grupo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (new GrupoDAO().Excluir(Convert.ToInt32(txtId.Text)))
                    {
                        MessageBox.Show("Grupo deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Pesquisa();
                        HabilitaBotoes(true);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
