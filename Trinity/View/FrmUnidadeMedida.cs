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
    public partial class FrmUnidadeMedida : Form
    {
        public FrmUnidadeMedida(byte type = 0)
        {
            InitializeComponent();
            if (type == 1)
                HabilitaBotoesInclusao();
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
            if (!String.IsNullOrEmpty(txtSigla.Text.Trim()) && !String.IsNullOrEmpty(txtUnidadeMedida.Text.Trim()))
            {
                if (txtSigla.Text.Trim().Length == 2)
                {
                    UnidadeMedida unidadeMedida = new UnidadeMedida();
                    unidadeMedida.Sigla = txtSigla.Text.Trim();
                    unidadeMedida.unidadeMedida = txtUnidadeMedida.Text.Trim();

                    UnidadeMedidaDAO dao = new UnidadeMedidaDAO();
                    dao.AdicionaUnidadeMedida(unidadeMedida);
                    this.Close();
                } else MessageBox.Show("Não foi possível realizar a operação.\nO campo SIGLA deve obrigatoriamente ter 2 (dois) caracteres!!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else MessageBox.Show("Não foi possível realizar a operação.\nHá CAMPOS OBRIGATÓRIOS que não foram preenchidos!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
