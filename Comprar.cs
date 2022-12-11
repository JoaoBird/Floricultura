using Dapper;
using MySqlX.XDevAPI;
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
    public partial class Comprar : Form
    {
        

        public Comprar()
        {
            
            
            InitializeComponent();
        }

        private void box_nome_c_TextChanged(object sender, EventArgs e)
        {

        }

        private void Comprar_Load(object sender, EventArgs e)
        {
            getEstoque();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void btn_com_Click(object sender, EventArgs e)
        {
            Produto selecionado = (Produto)dataGridView1.CurrentRow.DataBoundItem;
            int id_c;


            var Conexao = conexao.getconexao();
            string sqlCli = "insert into tb_cliente (rg,nome,telefone,endereco_rua) values('" + box_rg_c.Text + "','" + box_nome_c.Text + "','" + box_fone.Text + "','" + box_rua.Text + "');SELECT LAST_INSERT_ID();";
            
            id_c= Conexao.ExecuteScalar<int>(sqlCli);
            string sqlED = "update tb_produto set qtd_estoque=qtd_estoque-"+box_qtd_ven.Text+" where id_produto=" + selecionado.id_produto;
            Conexao.Execute(sqlED);
            string sqlVE = "insert into tb_vendas(id_produto,id_cliente,qtd_vendida,data_venda) values (" + selecionado.id_produto + "," + id_c + ",'" + box_qtd_ven.Text + "','"+DateTime.Now.ToString("yyyy-MM-dd")+"')";
            Conexao.Execute(sqlVE);
            MessageBox.Show("Sua compra foi de\nR$:" + Convert.ToInt32(box_qtd_ven.Text) * selecionado.preco);
            Close();
        }
        private void getEstoque()
        {

            string sqlEtq = "select id_produto,nome_produto,tb_tipo_produto.tipo_produto,preco,qtd_estoque from tb_produto inner join tb_tipo_produto on tb_produto.id_tp=tb_tipo_produto.id_tp";
            var Conexao = conexao.getconexao();
            dataGridView1.DataSource = Conexao.Query<Produto>(sqlEtq);
        }
    }
}
