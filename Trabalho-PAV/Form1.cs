using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoPAV.Interface;

namespace TrabalhoPAV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_TabelaCliente Cliente = new GUI_TabelaCliente();
            Cliente.ShowDialog();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_TabelaFornecedor Fornecedor = new GUI_TabelaFornecedor();
            Fornecedor.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_TabelaProduto Produto = new GUI_TabelaProduto();
            Produto.ShowDialog();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_TabelaVenda Venda = new GUI_TabelaVenda();
            Venda.ShowDialog();
        }
    }
}
