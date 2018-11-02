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
    public partial class FrmConsultaVenda : Form
    {
        List<Venda> listaVendas;

        public FrmConsultaVenda()
        {
            InitializeComponent();
        }

        public void CarregaListaVendas()
        {
            dgvVendas.AutoGenerateColumns = false;
            listaVendas = new VendaDAO().GetListaVendas();
            dgvVendas.DataSource = new BindingList<Venda>(listaVendas);
        }

        public void CarregaListaVendasChave()
        {
            dgvVendas.AutoGenerateColumns = false;
            String palavraChave = txtPalavraChave.Text.Replace(" ", "%");
            listaVendas = new VendaDAO().GetListaVendasChave(palavraChave);
            dgvVendas.DataSource = new BindingList<Venda>(listaVendas);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmVenda telaVenda = new FrmVenda(null);
            telaVenda.ShowDialog();
            CarregaListaVendas();
        }

        private void FrmConsultaVenda_Load(object sender, EventArgs e)
        {
            CarregaListaVendas();
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
            if ((dgvVendas.Rows[e.RowIndex].DataBoundItem != null) && (dgvVendas.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
            {
                e.Value = BindProperty(dgvVendas.Rows[e.RowIndex].DataBoundItem, dgvVendas.Columns[e.ColumnIndex].DataPropertyName);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvVendas.RowCount != 0)
            {
                if (dgvVendas.CurrentRow.Selected)
                {
                    int idVenda = Convert.ToInt32(dgvVendas.CurrentRow.Cells["Id"].Value.ToString());
                    FrmVenda telaVenda = new FrmVenda(this.listaVendas.Find(p => p.IdVenda == idVenda));
                    telaVenda.ShowDialog();
                    CarregaListaVendas();
                }
                else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhuma VENDA selecionada!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhuma VENDA cadastrada!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvVendas.RowCount != 0)
            {
                if (dgvVendas.CurrentRow.Selected)
                {
                    if (MessageBox.Show("Você realmente quer excluir esta VENDA?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int idVenda = Convert.ToInt32(dgvVendas.CurrentRow.Cells["Id"].Value.ToString());
                        VendaDAO dao = new VendaDAO();
                        dao.DeletaVenda(idVenda);
                        CarregaListaVendas();
                    }
                }
                else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhuma VENDA selecionada!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhuma VENDA cadastrada!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtPalavraChave.Text == "")
            {
                CarregaListaVendas();
                //MessageBox.Show("Insira PALAVRAS-CHAVE!", "Atenção",  MessageBoxButtons.OK, MessageBoxIcon.Information);
                //txtPalavraChave.Focus();
            }
            else
            {
                CarregaListaVendasChave();
                txtPalavraChave.Text = String.Empty;
            }
        }
    }
}