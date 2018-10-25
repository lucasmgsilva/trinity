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
    public partial class FrmMarca : Form
    {

        private bool boolEditando;

        public FrmMarca(byte type = 0)
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
                Marca marca = new MarcaDAO().Pesquisar();
                if(marca != null)
                {
                    txtId.Text = marca.IdMarca.ToString("D3");
                    txtMarca.Text = marca.marca;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Não foi possível pesquisar a marca.\nErro: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HabilitaBotoes(bool state)
        {
            txtMarca.Enabled = !state;
            btnNovo.Enabled = state;
            btnSalvar.Enabled = !state && boolEditando;
            btnExcluir.Enabled = state && !string.IsNullOrWhiteSpace(txtId.Text);
            btnEditar.Enabled = state && !string.IsNullOrWhiteSpace(txtId.Text);

        }

        private void HabilitaBotoesInclusao()
        {
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(!validaCampo())
            {
                Marca marca = new Marca();
                marca.marca = txtMarca.Text.Trim();

                bool gravou = false;
                if (string.IsNullOrWhiteSpace(txtId.Text))
                    gravou = new MarcaDAO().AdicionaMarca(marca);
                else
                {
                    marca.IdMarca = Convert.ToInt32(txtId.Text);
                    gravou = new MarcaDAO().Alterar(marca);
                }
                if(gravou)
                    this.Close();
            } else
                MessageBox.Show("Não foi possível realizar a operação.\nHá CAMPOS OBRIGATÓRIOS que não foram preenchidos!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private bool validaCampo()
        {
            bool hasErrors = false;
            epMarca.Clear();

            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                epMarca.SetError(lblMarca, "A marca é obrigatória.");
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

        private void FrmMarca_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja excluir esta marca?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if(new MarcaDAO().Excluir(Convert.ToInt32(txtId.Text)))
                    {
                        MessageBox.Show("Marca deletada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Pesquisa();
                        HabilitaBotoes(true);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            boolEditando = true;
            HabilitaBotoes(false);
            txtMarca.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            boolEditando = true;
            HabilitaBotoes(false);
            txtId.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtMarca.Focus();
        }
    }
}
