using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floricultura
{
    internal class Vendas
    {
        public int id_vendas { get; set; }
        public int id_produto { get; set; }
        public string nome_produto { get; set; }
        public string tipo_produto { get; set; }
        public int preco { get; set; }
        public int qtd_estoque { get; set; }
        public int id_cliente { get; set; }
        public string rg { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string endereco_rua { get; set; }
        public int qtd_vendida { get; set; }
        public DateTime data_venda { get; set; }
    }
}
