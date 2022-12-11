using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floricultura
{
    internal class Tipo_produto
    {
        public int id_tp { get; set; }
        public string tipo_produto { get; set; }
        public Tipo_produto(int id_tp, string tipo_produto)
        {
            this.id_tp = id_tp;

            this.tipo_produto = tipo_produto;
           
        }
    }
}
