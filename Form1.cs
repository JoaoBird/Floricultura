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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            Comprar sistema = new Comprar();
            sistema.ShowDialog();
        }

        private void btn_estoque_Click(object sender, EventArgs e)
        {
            Estoque sistema = new Estoque();
            sistema.ShowDialog();
        }

        private void btn_historico_c_Click(object sender, EventArgs e)
        {
            Historico_cliente sistema = new Historico_cliente();
            sistema.ShowDialog();
        }
    }
}
