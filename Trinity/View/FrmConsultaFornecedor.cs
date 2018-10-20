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
    public partial class FrmConsultaFornecedor : Form
    {
        List<Fornecedor> listaFornecedores;

        public FrmConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void TelaConsultaFornecedor_Load(object sender, EventArgs e)
        {
            CarregaListaFornecedores();
        }

        public void CarregaListaFornecedores()
        {
            dgvFornecedores.AutoGenerateColumns = false;
            listaFornecedores = new FornecedorDAO().GetListaFornecedores();
            dgvFornecedores.DataSource = new BindingList<Fornecedor>(listaFornecedores);
        }

        public void CarregaListaFornecedoresChave()
        {
            dgvFornecedores.AutoGenerateColumns = false;
            String palavraChave = txtPalavraChave.Text.Replace(" ", "%");
            listaFornecedores = new FornecedorDAO().GetListaFornecedoresChave(palavraChave);
            dgvFornecedores.DataSource = new BindingList<Fornecedor>(listaFornecedores);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmFornecedor telaFornecedor = new FrmFornecedor(null);
            telaFornecedor.ShowDialog();
            CarregaListaFornecedores();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvFornecedores.RowCount != 0)
            {
                if (dgvFornecedores.CurrentRow.Selected)
                {
                    if (MessageBox.Show("Você realmente quer excluir este FORNECEDOR?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int idFornecedor = Convert.ToInt32(dgvFornecedores.CurrentRow.Cells["idFornecedor"].Value.ToString());
                        FornecedorDAO dao = new FornecedorDAO();
                        dao.DeletaFornecedor(idFornecedor);
                        CarregaListaFornecedores();
                    }
                }
                else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum USUÁRIO selecionado!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum USUÁRIO cadastrado!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvFornecedores.RowCount != 0)
            {
                if (dgvFornecedores.CurrentRow.Selected)
                {
                    int idFornecedor = Convert.ToInt32(dgvFornecedores.CurrentRow.Cells["idFornecedor"].Value.ToString());
                    FrmFornecedor telaFornecedor = new FrmFornecedor(this.listaFornecedores.Find(f => f.IdFornecedor == idFornecedor));
                    telaFornecedor.ShowDialog();
                    CarregaListaFornecedores();
                }
                else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum FORNECEDOR selecionado!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum FORNECEDOR cadastrado!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtPalavraChave.Text == "")
            {
                CarregaListaFornecedores();
                //MessageBox.Show("Insira PALAVRAS-CHAVE!", "Atenção",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                //txtPalavraChave.Focus();
            }
            else
            {
                CarregaListaFornecedoresChave();
                txtPalavraChave.Text = String.Empty;
            }
        }
    }
}
