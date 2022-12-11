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
using Dapper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Floricultura
{
    public partial class Estoque : Form
    {
        Tipo_produto _tp;
        Produto pro;


        public Estoque()
        {
            InitializeComponent();


        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {


            var Conexao = conexao.getconexao();
            string sqladc = "insert into tb_produto (nome_produto,id_tp,preco,qtd_estoque) values('" + box_nome_p.Text + "','" + cb_tp.SelectedValue + "','" + box_preco.Text + "','" + box_qtd.Text + "')";
            Conexao.Execute(sqladc);
            Close();

        }

        private void Estoque_Load(object sender, EventArgs e)
        {

            Tipo_produto tipo_Produto;
       

            string sqltp = "select id_tp, tipo_produto from tb_tipo_produto" ;
            var Conexao = conexao.getconexao();
            cb_tp.DataSource = Conexao.Query<Tipo_produto>(sqltp);
            cb_tp.DisplayMember = "tipo_produto";
            cb_tp.ValueMember = "id_tp";
            dataGridView1.AutoGenerateColumns=false;
            getEstoque();

        }


        private void getEstoque()
        {
          
            var Conexao = conexao.getconexao();
            string sqlEtq = "select id_produto,nome_produto,tb_tipo_produto.tipo_produto,preco,qtd_estoque from tb_produto inner join tb_tipo_produto on tb_produto.id_tp=tb_tipo_produto.id_tp";
            dataGridView1.DataSource = Conexao.Query<Produto>(sqlEtq);




        }
  

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Produto selecionado = (Produto)dataGridView1.CurrentRow.DataBoundItem;
            //string sqlED = "update tb_produto set nome_produto='" + box_nome_p.Text + "',id_tp='"+cb_tp.SelectedValue+"',preco='"+box_preco.Text+"',qtd_estoque='"+box_qtd.Text+"'";
            string sqlEd = "update tb_produto set nome_produto='" + box_nome_p.Text + "',id_tp='"+cb_tp.SelectedValue+ "',preco='"+box_preco.Text+ "',qtd_estoque='"+box_qtd.Text+"' where id_produto=" + selecionado.id_produto;
            var Conexao = conexao.getconexao();
            Conexao.Execute(sqlEd);
            Close();


        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            var Conexao = conexao.getconexao();
            Produto selecionado = (Produto)dataGridView1.CurrentRow.DataBoundItem;
            string cou = "select COUNT(id_produto)from tb_vendas where id_produto = "+ selecionado.id_produto;
            string sqlDel = "Delete from tb_produto where id_produto="+ selecionado.id_produto;
            int quantidade_vendas = Conexao.QueryFirstOrDefault<int>(cou);
            if(quantidade_vendas>0)
            {
                MessageBox.Show("Não e possivel apagar um item que já tenha venda registrada!", "Falha!", MessageBoxButtons.OK);
                return;
            }



            Conexao.Execute(sqlDel);
            Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Produto selecionado = (Produto)dataGridView1.CurrentRow.DataBoundItem;
            box_nome_p.Text = selecionado.nome_produto;
            box_preco.Text = selecionado.preco.ToString();
            box_qtd.Text = selecionado.qtd_estoque.ToString();
        }
    }
}
