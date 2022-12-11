using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floricultura
{
    public partial class Historico_cliente : Form
    {
        public Historico_cliente()
        {
            InitializeComponent();
            dataGridView2.AutoGenerateColumns= false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Historico_cliente_Load(object sender, EventArgs e)
        {
            var Conexao = conexao.getconexao();
            string sqlEtq = "select tb_produto.id_produto,tb_produto.nome_produto,tb_tipo_produto.tipo_produto,tb_produto.preco,tb_produto.qtd_estoque,tb_cliente.nome,qtd_vendida,data_venda from tb_vendas inner join tb_produto on tb_produto.id_produto=tb_vendas.id_produto join tb_tipo_produto on tb_produto.id_tp=tb_tipo_produto.id_tp inner join tb_cliente on tb_vendas.id_cliente=tb_cliente.id_cliente";
           
            dataGridView2.DataSource = Conexao.Query<Vendas>(sqlEtq);
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
