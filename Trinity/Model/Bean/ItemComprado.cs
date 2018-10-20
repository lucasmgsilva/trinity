using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinity.Model.Bean
{
    public class ItemComprado
    {
        public int QtdComprada { get; set; }
        public double ValorCompra { get; set; }
        public Compra Compra { get; set; }
        public Produto Produto { get; set; }
    }
}
