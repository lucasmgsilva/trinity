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
    public partial class FrmVenda : Form
    {
        public FrmVenda()
        {
            InitializeComponent();
            CarregaListaClientes();
            CarregaListaProdutos();
            LimpaCampos();
        }

        public void DefineCliente(int IdCliente)
        {
            foreach (ClientePF_PJ item in cmbCliente.Items)
            {
                if(item.Id == IdCliente)
                {
                    cmbCliente.SelectedItem = item;
                    break;
                }
            }
        }

        public void DefineProduto(int IdProduto)
        {
            foreach (Produto item in cmbProduto.Items)
            {
                if (item.IdProduto == IdProduto)
                {
                    cmbProduto.SelectedItem = item;
                    break;
                }
            }
        }

        public void LimpaCampos()
        {
            txtDataVenda.Text = DateTime.Now.ToString();
            cmbCliente.SelectedItem = null;
            cmbProduto.SelectedItem = null;
            txtQuantidade.Value = 0;
            txtPrecoVenda.Value = 0;
            txtPrecoVenda.Value = 0;
        }

        public void CarregaListaClientes()
        {
            List<Cliente> listaClientes = new ClienteDAO().GetListaClientes();
            List<ClientePF_PJ> listaClientesPreparados = new List<ClientePF_PJ>();
            foreach (var cliente in listaClientes)
            {
                ClientePF_PJ clientePreparado = new ClientePF_PJ();

                if (cliente is ClientePF)
                {
                    clientePreparado.Id = cliente.IdCliente;
                    clientePreparado.NomeRazaoSocial = ((ClientePF)cliente).Nome;
                    clientePreparado.ApelidoNomeFantasia = ((ClientePF)cliente).Apelido;
                    clientePreparado.CpfCnpj = ((ClientePF)cliente).Cpf;

                }
                else if (cliente is ClientePJ)
                {
                    clientePreparado.Id = cliente.IdCliente;
                    clientePreparado.NomeRazaoSocial = ((ClientePJ)cliente).RazaoSocial;
                    clientePreparado.ApelidoNomeFantasia = ((ClientePJ)cliente).NomeFantasia;
                    clientePreparado.CpfCnpj = ((ClientePJ)cliente).Cnpj;
                }

                listaClientesPreparados.Add(clientePreparado);
            }
            listaClientes = null;
            cmbCliente.DisplayMember = "NomeRazaoSocial";
            cmbCliente.DataSource = listaClientesPreparados;
        }

        public void CarregaListaProdutos()
        {
            cmbProduto.DisplayMember = "Descricao";
            cmbProduto.DataSource = new ProdutoDAO().GetListaProdutos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            FrmConsultaCliente telaConsultaCliente = new FrmConsultaCliente(this);
            telaConsultaCliente.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            FrmConsultaProduto telaConsultaProduto = new FrmConsultaProduto(this);
            telaConsultaProduto.ShowDialog();
        }

        private void cmbProduto_SelectedValueChanged(object sender, EventArgs e)
        {
            Produto produtoSelecionado = (Produto) cmbProduto.SelectedItem;
            if(produtoSelecionado != null)
                txtPrecoVenda.Value = decimal.Parse(produtoSelecionado.ValorVenda.ToString());
        }

        private void txtQuantidade_ValueChanged(object sender, EventArgs e)
        {
            txtPrecoTotal.Value = txtQuantidade.Value * txtPrecoVenda.Value;
        }

        private void txtPrecoVenda_ValueChanged(object sender, EventArgs e)
        {
            txtPrecoTotal.Value = txtQuantidade.Value * txtPrecoVenda.Value;
        }

        private void txtPrecoTotal_ValueChanged(object sender, EventArgs e)
        {
            if(txtQuantidade.Value != 0)
                txtPrecoVenda.Value =  txtPrecoTotal.Value / txtQuantidade.Value;
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {

        }
    }
}
