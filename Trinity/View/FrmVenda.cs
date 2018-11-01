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
        bool editando;
        Venda vendaCarregada;
        List<ItemVendido> listaItemVendido = new List<ItemVendido>();
        List<ItemVendido> listaItemVendidoNovo = new List<ItemVendido>();
        List<ItemVendido> listaItemVendidoAlterado = new List<ItemVendido>();
        List<ItemVendido> listaItemVendidoDeletado = new List<ItemVendido>();
        List<Cliente> listaClientes;

        public FrmVenda(Venda vendaCarregada)
        {
            InitializeComponent();
            this.vendaCarregada = vendaCarregada;
        }

        private void CalculaTotalEQtd()
        {
            Double soma = 0;
            foreach (var item in listaItemVendido)
            {
                soma += item.QtdVendida * item.ValorVenda;
            }
            soma -= Convert.ToDouble(txtDesconto.Value);
            lblTotal.Text = soma.ToString("C");
        }

        public void CarregaListaItemVendido()
        {
            dgvItemVendido.AutoGenerateColumns = false;
            dgvItemVendido.DataSource = new BindingList<ItemVendido>(this.listaItemVendido);
            CalculaTotalEQtd();
        }

        public void DefineListaItemVendido()
        {
            dgvItemVendido.AutoGenerateColumns = false;
            vendaCarregada.ListaItemVendidos = new VendaDAO().GetListaItensVendidos(vendaCarregada.IdVenda);
            listaItemVendido = vendaCarregada.ListaItemVendidos;
            dgvItemVendido.DataSource = new BindingList<ItemVendido>(this.listaItemVendido);
            CalculaTotalEQtd();
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
            listaClientes = new ClienteDAO().GetListaClientes();
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
            LimpaCampos();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FrmConsultaCliente telaConsultaCliente = new FrmConsultaCliente(this);
            telaConsultaCliente.ShowDialog();
        }

        private bool ValidaCampos()
        {
            bool hasErros = false;
            epVendas.Clear();

            if (cmbCliente.SelectedItem == null)
            {
                epVendas.SetError(lblCliente, "O cliente é obrigatório.");
                hasErros = true;
            }
            else
                epVendas.SetError(lblCliente, string.Empty);

            if (dgvItemVendido.RowCount == 0)
            {
                epVendas.SetError(lblItemVendido, "Item vendido é obrigatório.");
                hasErros = true;
            }
            else
                epVendas.SetError(lblItemVendido, string.Empty);

            return hasErros;
        }

        private void ExibeListas()
        {
            string produtosNovos = "";
            string produtosAlterados = "";
            string produtosDeletados = "";

            foreach (var item in listaItemVendidoNovo)
            {
                produtosNovos += item.Produto.IdProduto + " - " + item.Produto.Descricao + "\n";
            }

            foreach (var item in listaItemVendidoAlterado)
            {
                produtosAlterados += item.Produto.IdProduto + " - " + item.Produto.Descricao + "\n";
            }

            foreach (var item in listaItemVendidoDeletado)
            {
                produtosDeletados += item.Produto.IdProduto + " - " + item.Produto.Descricao + "\n";
            }

            MessageBox.Show("Produtos Novos: \n" + 
                produtosNovos + 
                "\n------\n" + 
                "Produtos Alterados: \n" + 
                produtosAlterados + 
                "\n------\n" + 
                "Produtos Deletados: \n" + 
                produtosDeletados);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //ExibeListas();
            if (!ValidaCampos())
            {
                if (this.vendaCarregada == null)
                    this.vendaCarregada = new Venda();
                int idClienteSelecionado = ((ClientePF_PJ)cmbCliente.SelectedItem).Id;
                this.vendaCarregada.Cliente = listaClientes.Find(c => c.IdCliente == idClienteSelecionado);
                this.vendaCarregada.Usuario = FrmPrincipal.UsuarioSessaoAtual;
                this.vendaCarregada.DataVenda = Convert.ToDateTime(txtDataVenda.Text);
                this.vendaCarregada.Desconto = Convert.ToDouble(txtDesconto.Value);
                this.vendaCarregada.ListaItemVendidos = this.listaItemVendido;

                if (!this.editando)
                    new VendaDAO().AdicionaVenda(this.vendaCarregada);
                else
                    new VendaDAO().AlteraVenda(this.vendaCarregada, listaItemVendidoNovo, listaItemVendidoAlterado, listaItemVendidoDeletado);
                this.Close();
            }
            else
                MessageBox.Show("Possuem algumas pendências de dados, favor verificar.", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

            /*if(dgvItemVendido.RowCount != 0 && dgvItemVendido.CurrentRow.Selected)
            {
                int idProduto = Convert.ToInt32(dgvItemVendido.CurrentRow.Cells["Id"].Value);
                ItemVendido itemVendido = listaItemVendido.Find(iv => iv.Produto.IdProduto == idProduto);
                itemVendido.QtdVendida = float.Parse(txtQuantidade.Value.ToString());
                itemVendido.ValorVenda = Convert.ToDouble(txtPrecoVenda.Value);
                itemVendido.ValorTotal = Convert.ToDouble(txtPrecoTotal.Value);
            }*/
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
            if(cmbProduto.SelectedItem != null)
            {
                if(txtQuantidade.Value > 0)
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

                    if (itemVendidoExistente == null) //Novo
                    {
                        itemVendidoExistente = itemVendido;
                        this.listaItemVendido.Add(itemVendido);
                        this.listaItemVendidoNovo.Add(itemVendido);
                        //MessageBox.Show("Adicionado na ListaItemVendidoNovo");
                    }
                    else //Atualiza - Já existe
                    {
                        itemVendidoExistente.QtdVendida += itemVendido.QtdVendida;
                        itemVendidoExistente.ValorVenda = itemVendido.ValorVenda;
                        itemVendidoExistente.ValorTotal = itemVendidoExistente.QtdVendida * itemVendido.ValorVenda;
                        listaItemVendidoAlterado.Add(itemVendidoExistente);
                        //MessageBox.Show("Adicionado na ListaItemVendidoAlterado");
                    }

                    //Verifica se item vendido adicionado havia sido removido
                    foreach (var item in listaItemVendidoDeletado)
                    {
                        if (item.Produto.IdProduto == itemVendido.IdProduto)
                        {
                            listaItemVendidoDeletado.Remove(item);
                            //MessageBox.Show("Removido da ListaItemVendidoDeletado");
                            listaItemVendidoAlterado.Add(itemVendidoExistente);
                            //MessageBox.Show("Adicionado na ListaItemVendidoAlterado");
                            listaItemVendidoNovo.Remove(itemVendidoExistente);
                            //MessageBox.Show("Removido da ListaItemVendidoNovo");
                            break;
                        }
                    }
                    CarregaListaItemVendido();
                } else MessageBox.Show("Não foi possível realizar a operação.\nA QUANTIDADE deve ser maior que 0 (zero)!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum PRODUTO selecionado!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error); 
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
                            if (this.editando)
                            {
                                this.listaItemVendidoDeletado.Add(item);
                                //MessageBox.Show("Adicionado na ListaItemVendidoDeletado");
                            }
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

        private void DesabilitaCampos()
        {
            cmbCliente.Enabled = false;
            cmbProduto.Enabled = false;
            txtQuantidade.Enabled = false;
            txtPrecoVenda.Enabled = false;
            txtPrecoTotal.Enabled = false;
            txtDesconto.Enabled = false;
            dgvItemVendido.Enabled = false;

            lblBuscaCliente.Enabled = false;
            lblBuscaProduto.Enabled = false;

            cmbCliente.Focus();
        }

        private void HabilitaCampos()
        {
            cmbCliente.Enabled = !false;
            cmbProduto.Enabled = !false;
            txtQuantidade.Enabled = !false;
            txtPrecoVenda.Enabled = !false;
            txtPrecoTotal.Enabled = !false;
            txtDesconto.Enabled = !false;
            dgvItemVendido.Enabled = !false;

            lblBuscaCliente.Enabled = !false;
            lblBuscaProduto.Enabled = !false;

            cmbCliente.Focus();
        }

        private void HabilitaBotoes()
        {
            DesabilitaCampos();
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;

            btnAdicionarProduto.Enabled = false;
            btnRemoverProduto.Enabled = false;
            btnLimparSeleção.Enabled = false;
        }

        private void DesabilitaBotoes()
        {
            HabilitaCampos();
            btnNovo.Enabled = !true;
            btnSalvar.Enabled = !false;
            btnEditar.Enabled = !true;
            btnExcluir.Enabled = !true;

            btnAdicionarProduto.Enabled = !false;
            btnRemoverProduto.Enabled = !false;
            btnLimparSeleção.Enabled = !false;
        }

        public void SelecionaCliente()
        {
            if (this.vendaCarregada != null)
            {
                int idCliente = this.vendaCarregada.Cliente.IdCliente;
                foreach (ClientePF_PJ item in cmbCliente.Items)
                    if (item.Id == idCliente)
                    {
                        cmbCliente.SelectedItem = item;
                        break;
                    }
            }
        }

        private void CarregaVenda()
        {
            txtDataVenda.Text = this.vendaCarregada.DataVenda.ToString();
            SelecionaCliente();
            DefineListaItemVendido();
            txtDesconto.Value = decimal.Parse(this.vendaCarregada.Desconto.ToString());
        }

        private void FrmVenda_Load(object sender, EventArgs e)
        {
            DesabilitaBotoes();
            CarregaListaClientes();
            CarregaListaProdutos();
            if (this.vendaCarregada != null)
            {
                this.editando = true;
                CarregaVenda();
            } else txtDataVenda.Text = Convert.ToString(DateTime.Now);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.editando = true;
            DesabilitaBotoes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente quer excluir esta VENDA?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new VendaDAO().DeletaVenda(this.vendaCarregada.IdVenda);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (this.editando)
            {
                if (MessageBox.Show("Você realmente quer desfazer as alterações desta VENDA?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    HabilitaBotoes();
                    this.editando = false;
                    CarregaVenda();
                }
            }
            else this.Close();
        }

        private void dgvItemVendido_SelectionChanged(object sender, EventArgs e)
        {
            /*if(dgvItemVendido.RowCount != 0 && dgvItemVendido.CurrentRow.Selected)
            {
                int idProduto = Convert.ToInt32(dgvItemVendido.CurrentRow.Cells["Id"].Value);

                foreach (Produto produto in cmbProduto.Items)
                {
                    if (produto.IdProduto == idProduto)
                    {
                        cmbProduto.SelectedItem = produto;

                            foreach (var itemVendido in listaItemVendido)
                            {
                                if (itemVendido.Produto.IdProduto == idProduto)
                                {
                                    txtQuantidade.Value = decimal.Parse(itemVendido.QtdVendida.ToString());
                                    txtPrecoVenda.Value = decimal.Parse(itemVendido.ValorVenda.ToString());
                                    break;
                                }
                            }
                        break;
                    }
                }
            }*/
        }

        private void btnLimparSeleção_Click(object sender, EventArgs e)
        {

        }

        private void txtDesconto_ValueChanged(object sender, EventArgs e)
        {
            CalculaTotalEQtd();
        }
    }
}