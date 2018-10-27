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
    public partial class FrmConsultaCliente : Form
    {
        List<Cliente> listaClientes;
        List<ClientePF_PJ> listaClientesPreparados;
        Form formularioInvocador;

        public FrmConsultaCliente()
        {
            InitializeComponent();
        }

        public FrmConsultaCliente(Form formularioInvocador)
        {
            InitializeComponent();
            this.formularioInvocador = formularioInvocador;
        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {
            CarregaListaClientes();
        }

        public void CarregaListaClientes()
        {
            dgvClientes.AutoGenerateColumns = false;
            listaClientes = new ClienteDAO().GetListaClientes();

            listaClientesPreparados = new List<ClientePF_PJ>();
            foreach (var cliente in listaClientes)
            {
                ClientePF_PJ clientePreparado = new ClientePF_PJ();

                if(cliente is ClientePF)
                {
                    clientePreparado.Id = cliente.IdCliente;
                    clientePreparado.NomeRazaoSocial = ((ClientePF) cliente).Nome;
                    clientePreparado.ApelidoNomeFantasia = ((ClientePF) cliente).Apelido;
                    clientePreparado.CpfCnpj = ((ClientePF)cliente).Cpf;

                } else if (cliente is ClientePJ)
                {
                    clientePreparado.Id = cliente.IdCliente;
                    clientePreparado.NomeRazaoSocial = ((ClientePJ) cliente).RazaoSocial;
                    clientePreparado.ApelidoNomeFantasia = ((ClientePJ)cliente).NomeFantasia;
                    clientePreparado.CpfCnpj = ((ClientePJ)cliente).Cnpj;
                }

                listaClientesPreparados.Add(clientePreparado);
            }
            dgvClientes.DataSource = new BindingList<ClientePF_PJ>(listaClientesPreparados);
           
        }

        public void CarregaListaClientesChave() { 
            dgvClientes.AutoGenerateColumns = false;

            String palavraChave = txtPalavraChave.Text.Replace(" ", "%");
            listaClientes = new ClienteDAO().GetListaClientesChave(palavraChave);

            List<ClientePF_PJ> listaClientesPreparados = new List<ClientePF_PJ>();
            foreach (var cliente in listaClientes)
            {
                ClientePF_PJ clientePreparado = new ClientePF_PJ();
                clientePreparado.Id = cliente.IdCliente;

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

            dgvClientes.DataSource = new BindingList<ClientePF_PJ>(listaClientesPreparados);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCliente telaCliente = new FrmCliente(null);
            telaCliente.ShowDialog();
            CarregaListaClientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.RowCount != 0)
            {
                if (dgvClientes.CurrentRow.Selected)
                {
                    int idCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Id"].Value);
                    FrmCliente telaCliente = new FrmCliente(this.listaClientes.Find(f => f.IdCliente == idCliente));
                    telaCliente.ShowDialog();
                    CarregaListaClientes();
                }
                else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum CLIENTE selecionado!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum CLIENTE cadastrado!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvClientes.RowCount != 0)
            {
                if (dgvClientes.CurrentRow.Selected)
                {
                    if (MessageBox.Show("Você realmente quer excluir este CLIENTE?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int idCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Id"].Value);
                        //FornecedorDAO dao = new FornecedorDAO();
                        //dao.DeletaFornecedor(idCliente);
                        CarregaListaClientes();
                    }
                }
                else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum USUÁRIO selecionado!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum USUÁRIO cadastrado!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtPalavraChave.Text == "")
            {
                CarregaListaClientes();
                //MessageBox.Show("Insira PALAVRAS-CHAVE!", "Atenção",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                //txtPalavraChave.Focus();
            } else {
                CarregaListaClientesChave();
                txtPalavraChave.Text = String.Empty;
            }
        }

        private void dgvClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(this.formularioInvocador != null)
            {
            if (dgvClientes.RowCount != 0)
            {
                if (dgvClientes.CurrentRow.Selected)
                {
                    int idCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["Id"].Value);
                    ClientePF_PJ cliente = this.listaClientesPreparados.Find(c => c.Id == idCliente);
                    ((FrmVenda)formularioInvocador).DefineCliente(cliente);
                    this.Close();

                }
                else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum CLIENTE selecionado!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum CLIENTE cadastrado!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
