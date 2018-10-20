using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trinity.View
{
    public partial class FrmConsultaVenda : Form
    {
        public FrmConsultaVenda()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmVenda telaVenda = new FrmVenda();
            telaVenda.ShowDialog();
        }
    }
}
