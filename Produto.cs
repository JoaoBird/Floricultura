using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floricultura
{
    internal class Produto
    {
        public int id_produto { get; set; }
        public string nome_produto { get; set; }
        public int id_tp { get; set; }
        public string tipo_produto { get; set; }
        public int preco { get; set; }
        public int qtd_estoque { get; set; }
        
    }
}
