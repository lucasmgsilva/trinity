using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinity.Model.Bean
{
    public class Venda
    {
        public int IdVenda { get; set; }
        public Usuario Usuario { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataVenda { get; set; }
        public double Desconto { get; set; }
        public double ValorTotal { get; set; }
        public List<ItemVendido> ListaItemVendidos { get; set; }
    }
}
