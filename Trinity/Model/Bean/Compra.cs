using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinity.Model.Bean
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public DateTime DataCompra { get; set; }
        public double Desconto { get; set; }
        public string ChaveAcesso { get; set; }
        public double ValorTotal { get; set; }
        public Usuario Usuario { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}
