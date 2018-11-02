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
        List<Grupo> listaGrupos;
        bool editando;
        Grupo grupoCarregado;

        public FrmGrupo()
        {
            InitializeComponent();
            this.editando = false;
            LimpaCampos();
        }

        private void DesabilitaCampos()
        {
            txtGrupo.Enabled = false;
        }

        private void HabilitaCampos()
        {
            txtGrupo.Enabled = !false;
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
            HabilitaBotoes();
            txtGrupo.Text = String.Empty;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtGrupo.Text))
            {
                if (this.grupoCarregado == null)
                    this.grupoCarregado = new Grupo();

                this.grupoCarregado.grupo = txtGrupo.Text;

                GrupoDAO dao = new GrupoDAO();
                if (!this.editando)
                    dao.AdicionaGrupo(this.grupoCarregado);
                else dao.AlteraGrupo(this.grupoCarregado);
                CarregaListaGrupos();
            } else MessageBox.Show("Não foi possível realizar a operação.\nHá CAMPOS OBRIGATÓRIOS que não foram preenchidos!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (this.editando)
            {
                if (MessageBox.Show("Você realmente quer desfazer as alterações deste GRUPO?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    HabilitaBotoes();
                    this.editando = false;
                    CarregaGrupo();
                }
            }
            else this.Close();
        }

        private void FrmGrupo_Load(object sender, EventArgs e)
        {
            CarregaListaGrupos();
        }

        public void CarregaListaGrupos()
        {
            dgvGrupos.AutoGenerateColumns = false;
            listaGrupos = new GrupoDAO().GetListaGrupos();
            dgvGrupos.DataSource = new BindingList<Grupo>(listaGrupos);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.RowCount != 0)
            {
                if (dgvGrupos.CurrentRow.Selected)
                {
                    this.editando = true;
                    DesabilitaBotoes();
                }
                else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum GRUPO selecionada!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum GRUPO cadastrada!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvGrupos_SelectionChanged(object sender, EventArgs e)
        {
            LimpaCampos();
            if (dgvGrupos.RowCount != 0)
            {
                if (dgvGrupos.CurrentRow.Selected)
                {
                    this.editando = false;
                    int idGrupo = Convert.ToInt32(dgvGrupos.CurrentRow.Cells["Id"].Value.ToString());
                    this.grupoCarregado = this.listaGrupos.Find(g => g.IdGrupo == idGrupo);
                    CarregaGrupo();
                }
            }
            else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum GRUPO cadastrada!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CarregaGrupo()
        {
            txtGrupo.Text = grupoCarregado.grupo;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.editando = false;
            LimpaCampos();
            DesabilitaBotoes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvGrupos.RowCount != 0)
            {
                if (dgvGrupos.CurrentRow.Selected)
                {
                    if (MessageBox.Show("Você realmente quer excluir este GRUPO?", "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        GrupoDAO dao = new GrupoDAO();
                        dao.DeletaGrupo(this.grupoCarregado.IdGrupo);
                        CarregaListaGrupos();
                    }
                }
                else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum GRUPO selecionada!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Não foi possível realizar a operação.\nNão há nenhum GRUPO cadastrada!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
