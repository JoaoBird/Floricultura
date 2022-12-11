using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floricultura
{
    internal class Cliente
    {
        public int id_cliente { get; set; }
        public string rg { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string endereco_rua { get; set; }

        public int id_endereco { get; set; }
    }
}
