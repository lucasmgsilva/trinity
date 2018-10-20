using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinity.Model.Bean
{
    public class UnidadeMedida
    {
        public int IdUnidadeMedida { get; set; }
        public string Sigla { get; set; }
        public string unidadeMedida { get; set; }

        public override string ToString()
        {
            return this.Sigla;
        }
    }
}
