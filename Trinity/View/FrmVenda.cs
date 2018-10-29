using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trinity.Model.Bean;
using Trinity.Model.DAO;

namespace Trinity.View
{
    public partial class FrmVenda : Form
    {
        List<ItemVendido> listaItemVendido = new List<ItemVendido>();

        public FrmVenda()
        {
            InitializeComponent();
            CarregaListaClientes();
            CarregaListaProdutos();
            CarregaListaItemVendido();
            LimpaCampos();
        }

        public void CarregaListaItemVendido()
        {
            dgvItemVendido.AutoGenerateColumns = false;
            //this.listaProdutos = new ProdutoDAO().GetListaProdutos();
            dgvItemVendido.DataSource = new BindingList<ItemVendido>(this.listaItemVendido);
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
            {
                txtQuantidade.Value = 0;
                txtPrecoVenda.Value = decimal.Parse(produtoSelecionado.ValorVenda.ToString());
            }
                
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
            ItemVendido itemVendido = new ItemVendido()
            {
                Produto = (Produto)cmbProduto.SelectedItem,
                QtdVendida = Convert.ToDouble(txtQuantidade.Value),
                ValorVenda = Convert.ToDouble(txtPrecoVenda.Value),
            };
            itemVendido.IdProduto = itemVendido.Produto.IdProduto;
            itemVendido.ValorTotal = itemVendido.QtdVendida * itemVendido.ValorVenda;

            ItemVendido itemVendidoExistente = null; //Novo

            foreach (ItemVendido item in listaItemVendido)
            {
                if (item.Produto.IdProduto == itemVendido.Produto.IdProduto)
                {
                    itemVendidoExistente = item;
                    break;
                }
            }

            if(itemVendidoExistente == null) //Novo
            {
                this.listaItemVendido.Add(itemVendido);
            } else //Atualiza - Já existe
            {
                itemVendidoExistente.QtdVendida += itemVendido.QtdVendida;
                itemVendidoExistente.ValorVenda = itemVendido.ValorVenda;
                itemVendidoExistente.ValorTotal = itemVendidoExistente.QtdVendida * itemVendido.ValorVenda;
            }
            CarregaListaItemVendido();
        }

        private string BindProperty(object property, string propertyName)
        {
            string retValue = "";
            if (propertyName.Contains("."))
            {
                PropertyInfo[] arrayProperties;
                string leftPropertyName;
                leftPropertyName = propertyName.Substring(0, propertyName.IndexOf("."));
                arrayProperties = property.GetType().GetProperties();
                foreach (PropertyInfo propertyInfo in arrayProperties)
                {
                    if (propertyInfo.Name == leftPropertyName)
                    {
                        retValue = BindProperty(
                          propertyInfo.GetValue(property, null),
                          propertyName.Substring(propertyName.IndexOf(".") + 1));
                        break;
                    }
                }
            }
            else
            {
                Type propertyType;
                PropertyInfo propertyInfo;
                propertyType = property.GetType();
                propertyInfo = propertyType.GetProperty(propertyName);
                retValue = propertyInfo.GetValue(property, null).ToString();
            }
            return retValue;
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dgvItemVendido.Rows[e.RowIndex].DataBoundItem != null) && (dgvItemVendido.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(dgvItemVendido.Rows[e.RowIndex].DataBoundItem, dgvItemVendido.Columns[e.ColumnIndex].DataPropertyName);
            }
        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            if (dgvItemVendido.RowCount != 0)
            {
                if (dgvItemVendido.CurrentRow.Selected)
                {
                    int idProduto = Convert.ToInt32(dgvItemVendido.CurrentRow.Cells["Id"].Value.ToString());

                    foreach (ItemVendido item in this.listaItemVendido)
                    {
                        if(item.Produto.IdProduto == idProduto)
                        {
                            this.listaItemVendido.Remove(item);
                            break;
                        }
                    }
                    CarregaListaItemVendido();
                }
                else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum ITEM VENDIDO selecionado!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum ITEM VENDIDO cadastrado!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
