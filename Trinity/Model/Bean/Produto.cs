using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinity.Model.Bean
{
    public class Produto
    {

        public Produto()
        {
            UnidadeMedida = new UnidadeMedida();
            Grupo = new Grupo();
            Marca = new Marca();
        }
        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }
        public Grupo Grupo { get; set; }
        public double QtdMinima { get; set; }
        public double QtdDisponivel { get; set; }
        public double ValorCompra { get; set; }
        public double ValorVenda { get; set; }
        public Marca Marca { get; set; }
        public string CodigoFabricante { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Observacoes { get; set; }
    }
}
