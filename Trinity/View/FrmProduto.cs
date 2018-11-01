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
using Trinity.View;

namespace Trinity
{
    public partial class FrmProduto : Form
    {
        bool editando;
        bool calculando = false;
        Produto produtoCarregado;

        public FrmProduto(Produto produtoCarregado)
        {
            InitializeComponent();
            this.produtoCarregado = produtoCarregado;
        }

        private void CarregaProduto()
        {
            txtDescricao.Text = this.produtoCarregado.Descricao;
            txtDataCadastro.Text = this.produtoCarregado.DataCadastro.ToString();
            SelecionaUnidadeMedida();
            SelecionaMarca();
            SelecionaGrupo();
            txtCodigoFabricante.Text = this.produtoCarregado.CodigoFabricante;
            txtQtdMinima.Text = this.produtoCarregado.QtdMinima.ToString();
            txtQtdDisponivel.Text = this.produtoCarregado.QtdDisponivel.ToString();
            txtValorCompra.Text = this.produtoCarregado.ValorCompra.ToString();
            txtValorVenda.Text = this.produtoCarregado.ValorVenda.ToString();
            txtObservacoes.Text = this.produtoCarregado.Observacoes;
        }

        public void CarregaUnidadeMedida()
        {
            cmbUnidadeMedida.DisplayMember = "sigla";
            cmbUnidadeMedida.DataSource = new UnidadeMedidaDAO().GetListaUnidadesMedida();
        }

        public void SelecionaUnidadeMedida()
        {
            if (this.produtoCarregado != null)
            {
                int idUnidadeMedida = this.produtoCarregado.UnidadeMedida.IdUnidadeMedida;
                foreach (UnidadeMedida item in cmbUnidadeMedida.Items)
                    if (item.IdUnidadeMedida == idUnidadeMedida)
                    {
                        cmbUnidadeMedida.SelectedItem = item;
                        break;
                    }
            }
        }

        public void CarregaMarca()
        {
            cmbMarca.DisplayMember = "marca";
            cmbMarca.DataSource = new MarcaDAO().GetListaMarcas();
        }

        public void SelecionaMarca()
        {
            if (this.produtoCarregado != null)
            {
                int idMarca = this.produtoCarregado.Marca.IdMarca;
                foreach (Marca item in cmbMarca.Items)
                    if (item.IdMarca == idMarca)
                    {
                        cmbMarca.SelectedItem = item;
                        break;
                    }
            }
        }
         
        public void CarregaGrupo ()
        {
            cmbGrupo.DisplayMember = "grupo";
            cmbGrupo.DataSource = new GrupoDAO().GetListaGrupos();
        }

        public void SelecionaGrupo()
        {
            if (this.produtoCarregado != null)
            {
                int idGrupo = this.produtoCarregado.Grupo.IdGrupo;
                foreach (Grupo item in cmbGrupo.Items)
                    if (item.IdGrupo == idGrupo)
                    {
                        cmbGrupo.SelectedItem = item;
                        break;
                    }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(!ValidaCampos())
            {
                if (this.produtoCarregado == null)
                    this.produtoCarregado = new Produto();
                this.produtoCarregado.Descricao = txtDescricao.Text.Trim();
                this.produtoCarregado.DataCadastro = Convert.ToDateTime(txtDataCadastro.Text);
                this.produtoCarregado.UnidadeMedida = (UnidadeMedida)cmbUnidadeMedida.SelectedItem;
                this.produtoCarregado.Marca = (Marca)cmbMarca.SelectedItem;
                this.produtoCarregado.Grupo = (Grupo)cmbGrupo.SelectedItem;
                this.produtoCarregado.CodigoFabricante = txtCodigoFabricante.Text.Trim();
                this.produtoCarregado.QtdMinima = float.Parse(txtQtdMinima.Text.Trim());
                this.produtoCarregado.QtdDisponivel = float.Parse(txtQtdDisponivel.Text.Trim());
                this.produtoCarregado.ValorCompra = Convert.ToDouble(txtValorCompra.Text.Trim());
                this.produtoCarregado.ValorVenda = Convert.ToDouble(txtValorVenda.Text.Trim());
                this.produtoCarregado.Observacoes = txtObservacoes.Text.Trim();

                if (!this.editando)
                    new ProdutoDAO().AdicionaProduto(this.produtoCarregado);
                else
                    new ProdutoDAO().AlteraProduto(this.produtoCarregado);
                this.Close();
            }
            else
                MessageBox.Show("Possuem algumas pendências de dados, favor verificar.", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private bool ValidaCampos()
        {
            bool hasErros = false;
            epProdutos.Clear();

            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                epProdutos.SetError(lblDescricao, "A descrição é obrigatória.");
                hasErros = true;
            }
            else
                epProdutos.SetError(lblDescricao, string.Empty);

            if (string.IsNullOrWhiteSpace(txtDataCadastro.Text))
            {
                epProdutos.SetError(lblDataCadastro, "A data de cadastro é obrigatória.");
                hasErros = true;
            }
            else
                epProdutos.SetError(lblDataCadastro, string.Empty);

            if (string.IsNullOrWhiteSpace(cmbUnidadeMedida.Text))
            {
                epProdutos.SetError(lblUn, "A unidade de medida é obrigatória.");
                hasErros = true;
            }
            else
                epProdutos.SetError(lblUn, string.Empty);

            if (string.IsNullOrWhiteSpace(cmbMarca.Text))
            {
                epProdutos.SetError(lblMarca, "A marca é obrigatória.");
                hasErros = true;
            }
            else
                epProdutos.SetError(lblMarca, string.Empty);

            if (string.IsNullOrWhiteSpace(cmbGrupo.Text))
            {
                epProdutos.SetError(lblGrupo, "O grupo é obrigatório.");
                hasErros = true;
            }
            else
                epProdutos.SetError(lblGrupo, string.Empty);

            if (string.IsNullOrWhiteSpace(txtQtdMinima.Text) || Convert.ToDouble(txtQtdMinima.Text) == 0)
            {
                epProdutos.SetError(lblQtdMinima, "A quantidade mínima deve ser maior que 0.");
                hasErros = true;
            }
            else
                epProdutos.SetError(lblQtdMinima, string.Empty);

            if (string.IsNullOrWhiteSpace(txtQtdDisponivel.Text) || Convert.ToDouble(txtQtdDisponivel.Text) == 0)
            {
                epProdutos.SetError(lblQtdDisp, "A quantidade disponível deve ser maior que 0.");
                hasErros = true;
            }
            else
                epProdutos.SetError(lblQtdDisp, string.Empty);

            if (string.IsNullOrWhiteSpace(txtValorCompra.Text) || Convert.ToDouble(txtValorCompra.Text) == 0)
            {
                epProdutos.SetError(lblVrCompra, "O valor de compra deve ser maior que 0.");
                hasErros = true;
            }
            else
                epProdutos.SetError(lblVrCompra, string.Empty);

            if (string.IsNullOrWhiteSpace(txtValorVenda.Text) || Convert.ToDouble(txtValorVenda.Text) == 0)
            {
                epProdutos.SetError(lblVrVenda, "O valor de venda deve ser maior que 0.");
                hasErros = true;
            }
            else
                epProdutos.SetError(lblVrVenda, string.Empty);

            return hasErros;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new FrmUnidadeMedida(1).ShowDialog();
            CarregaUnidadeMedida();
            SelecionaUnidadeMedida();
        }

        private void Add_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void Add_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new FrmMarca(1).ShowDialog();
            CarregaMarca();
            SelecionaMarca();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            new FrmGrupo(1).ShowDialog();
            CarregaGrupo();
            SelecionaGrupo();
        }

        private void DesabilitaCampos()
        {
            txtDescricao.Enabled = false;
            cmbUnidadeMedida.Enabled = false;
            cmbMarca.Enabled = false;
            cmbGrupo.Enabled = false;
            txtCodigoFabricante.Enabled = false;
            txtQtdMinima.Enabled = false;
            txtQtdDisponivel.Enabled = false;
            txtValorCompra.Enabled = false;
            txtLucro.Enabled = false;
            txtValorVenda.Enabled = false;
            txtObservacoes.Enabled = false;
        }

        private void HabilitaCampos()
        {
            txtDescricao.Enabled = !false;
            cmbUnidadeMedida.Enabled = !false;
            cmbMarca.Enabled = !false;
            cmbGrupo.Enabled = !false;
            txtCodigoFabricante.Enabled = !false;
            txtQtdMinima.Enabled = !false;
            txtQtdDisponivel.Enabled = !false;
            txtValorCompra.Enabled = !false;
            txtLucro.Enabled = !false;
            txtValorVenda.Enabled = !false;
            txtObservacoes.Enabled = !false;
            txtDescricao.Focus();
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
            txtDescricao.Text = String.Empty;
            cmbUnidadeMedida.SelectedItem = null;
            cmbMarca.SelectedItem = null;
            cmbGrupo.SelectedItem = null;
            txtCodigoFabricante.Text = String.Empty;
            txtQtdMinima.Text = String.Empty;
            txtQtdDisponivel.Text = String.Empty;
            txtValorCompra.Text = String.Empty;
            txtLucro.Text = String.Empty;
            txtValorVenda.Text = String.Empty;
            txtObservacoes.Text = String.Empty;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.editando = true;
            DesabilitaBotoes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente quer excluir este PRODUTO?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ProdutoDAO dao = new ProdutoDAO();
                dao.DeletaProduto(this.produtoCarregado.IdProduto);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (this.editando)
            {
                if (MessageBox.Show("Você realmente quer desfazer as alterações deste PRODUTO?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    HabilitaBotoes();
                    this.editando = false;
                    CarregaProduto();   
                    this.Close();
                }
            }
            else this.Close();
        }

        private void txtValorCompra_TextChanged(object sender, EventArgs e)
        {
            //txtLucro.Value = (decimal.Parse(txtValorVenda.Text) / decimal.Parse(txtValorCompra.Text) - 1) * 100;
        }

        private void txtValorVenda_TextChanged(object sender, EventArgs e)
        {
            if(!calculando)
                CalcularValores(1);
        }

        private void txtLucro_ValueChanged(object sender, EventArgs e)
        {
            //txtValorVenda.Text = (decimal.Parse(txtValorCompra.Text) * decimal.Parse(txtLucro.Value) / 100 + decimal.Parse(txtValorCompra.Text);
             
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            DesabilitaBotoes();
            CarregaUnidadeMedida();
            CarregaMarca();
            CarregaGrupo();
            if (this.produtoCarregado != null)
            {
                this.editando = true;
                CarregaProduto();
            }
            else txtDataCadastro.Text = Convert.ToString(DateTime.Now);
        }
        
        private void CalcularValores(byte type = 0)
        {
            calculando = true;

            if (string.IsNullOrWhiteSpace(txtValorCompra.Text) || txtValorCompra.Text.Equals("0,00"))
                return;

            double vrCompra = 0, lucro = 0, vrVenda = 0;

            if (!string.IsNullOrWhiteSpace(txtValorCompra.Text) && Convert.ToDouble(txtValorCompra.Text) > 0)
                vrCompra = Convert.ToDouble(txtValorCompra.Text);
            if (!string.IsNullOrWhiteSpace(txtLucro.Text) && Convert.ToDouble(txtLucro.Text) > 0)
                lucro = Convert.ToDouble(txtLucro.Text);
            if (!string.IsNullOrWhiteSpace(txtValorVenda.Text) && Convert.ToDouble(txtValorVenda.Text) > 0)
                vrVenda = Convert.ToDouble(txtValorVenda.Text);

            if (type == 0)
                txtValorVenda.Text = (vrCompra + (vrCompra * lucro / 100)).ToString();
            else
                txtLucro.Text = (vrVenda / vrCompra * 100 - 100) > 0 ? (vrVenda / vrCompra * 100 - 100).ToString("N2") : "0";

            calculando = false;
        }

        private void ZeraValores(ref TextBox txt)
        {
            txt.Text = "0,00";
        }

        private void txtValorCompra_Leave(object sender, EventArgs e)
        {
            if (txtValorCompra.Text.Equals(string.Empty))
                ZeraValores(ref txtValorCompra);
        }

        private void txtValorVenda_Leave(object sender, EventArgs e)
        {
            if (txtValorVenda.Text.Equals(string.Empty))
                ZeraValores(ref txtValorVenda);
        }

        private void txtLucro_TextChanged(object sender, EventArgs e)
        {
            if (!calculando)
                CalcularValores();
        }

        private void txtQtdDisponivel_Leave(object sender, EventArgs e)
        {
            if (txtQtdDisponivel.Text.Equals(string.Empty))
                ZeraValores(ref txtQtdDisponivel);
        }

        private void txtQtdMinima_Leave(object sender, EventArgs e)
        {
            if (txtQtdMinima.Text.Equals(string.Empty))
                ZeraValores(ref txtQtdMinima);
        }

        private void txtQtdMinima_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                e.Handled = true;
        }

        private void txtQtdDisponivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                e.Handled = true;
        }

        private void txtValorCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                e.Handled = true;
        }

        private void txtValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                e.Handled = true;
        }

        private void txtLucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                e.Handled = true;
        }
    }
}