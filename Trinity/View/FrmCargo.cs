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
    public partial class FrmCargo : Form
    {
        public FrmCargo(byte type = 0)
        {
            InitializeComponent();

            if (type == 1)
                HabilitaBotoesInclusao();
        }

        private void HabilitaBotoesInclusao()
        {
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidaCampo())
            {
                string permissoes = String.Empty;
                if (chkEmpresas.Checked)
                    permissoes += "EM";
                if (chkVendas.Checked)
                    permissoes += "VE";
                if (chkCompras.Checked)
                    permissoes += "CO";
                if (chkClientes.Checked)
                    permissoes += "CL";
                if (chkFornecedores.Checked)
                    permissoes += "FO";
                if (chkProdutos.Checked)
                    permissoes += "PR";
                if (chkUsuarios.Checked)
                    permissoes += "US";

                Cargo cargo = new Cargo();
                cargo.cargo = txtCargo.Text;
                cargo.Permissoes = permissoes;

                CargoDAO dao = new CargoDAO();
                dao.AdicionaCargo(cargo);
                this.Close();
            } else MessageBox.Show("Possui uma pendência, favor verificar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private bool ValidaCampo()
        {
            bool hasErrors = false;
            epCargo.Clear();

            if (string.IsNullOrWhiteSpace(txtCargo.Text))
            {
                epCargo.SetError(lblCargo, "A descrição do cargo é obrigatória.");
                hasErrors = true;
            }
            else
                epCargo.SetError(lblCargo, string.Empty);

            return hasErrors;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
