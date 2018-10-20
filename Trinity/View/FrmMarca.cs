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
        public FrmMarca(byte type = 0)
        {
            InitializeComponent();
            if (type == 1)
                HabilitaBotoesInclusao();
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
            if (!String.IsNullOrEmpty(txtMarca.Text.Trim()))
            {
                Marca marca = new Marca();
                marca.marca = txtMarca.Text.Trim();

                MarcaDAO dao = new MarcaDAO();
                dao.AdicionaMarca(marca);
                this.Close();
            } else MessageBox.Show("Não foi possível realizar a operação.\nHá CAMPOS OBRIGATÓRIOS que não foram preenchidos!", "Fracasso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
