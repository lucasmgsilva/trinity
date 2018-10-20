using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinity.Model.Bean
{
    public class ItemVendido
    {
        public int QtdVendida { get; set; }
        public double ValorVenda { get; set; }
        public Venda Venda { get; set; }
        public Produto Produto { get; set; }
    }
}
