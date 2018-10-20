using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trinity.Model.Bean
{
    public class Marca
    {
        public int IdMarca { get; set; }
        public string marca { get; set; }

        public override string ToString()
        {
            return this.marca;
        }
    }
}
