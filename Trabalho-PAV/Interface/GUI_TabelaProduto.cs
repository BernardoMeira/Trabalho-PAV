using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoPAV.Controladores;
using TrabalhoPAV.Entidades;

namespace TrabalhoPAV.Interface
{
    public partial class GUI_TabelaProduto : Form
    {
        public GUI_TabelaProduto()
        {
            InitializeComponent();
        }

        private void GUI_TabelaProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bancodadospavDataSet2.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.bancodadospavDataSet2.produto);
        }

        private void buIncluir_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            GUI_CadastroProduto GUI_Produto = new GUI_CadastroProduto(OperacaoCadastro.ocIncluir, produto);
            GUI_Produto.ShowDialog();
            this.produtoTableAdapter.Fill(this.bancodadospavDataSet2.produto);
            dataGridView1.Refresh();
        }

        private void buAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                ControladorCadastroProduto controladorCadastroProduto = new ControladorCadastroProduto();
                Produto produto = new Produto();
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                int index = Int32.Parse(row.Cells["idProdutoDataGridViewTextBoxColumn"].Value.ToString());
                produto.alterarIdentificador(index);
                controladorCadastroProduto.selecionar(produto);
                GUI_CadastroProduto GUI_Produto = new GUI_CadastroProduto(OperacaoCadastro.ocAlterar, produto);
                GUI_Produto.ShowDialog();
                this.produtoTableAdapter.Fill(this.bancodadospavDataSet2.produto);
                dataGridView1.Refresh();
            }
        }

        private void buExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                ControladorCadastroProduto controladorCadastroProduto = new ControladorCadastroProduto();
                Produto produto = new Produto();
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                int index = Int32.Parse(row.Cells["idProdutoDataGridViewTextBoxColumn"].Value.ToString());
                produto.alterarIdentificador(index);
                DialogResult dialogResult = MessageBox.Show("Deseja excluir?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    controladorCadastroProduto.excluir(produto);
                    this.produtoTableAdapter.Fill(this.bancodadospavDataSet2.produto);
                    dataGridView1.Refresh();
                }
            }
        }

        private void buSelecionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                ControladorCadastroProduto controladorCadastroProduto = new ControladorCadastroProduto();
                Produto produto = new Produto();
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                int index = Int32.Parse(row.Cells["idProdutoDataGridViewTextBoxColumn"].Value.ToString());
                produto.alterarIdentificador(index);
                controladorCadastroProduto.selecionar(produto);
                GUI_CadastroProduto GUI_Produto = new GUI_CadastroProduto(OperacaoCadastro.ocConsultar, produto);
                GUI_Produto.ShowDialog();
            }
        }

        private void buBuscar_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(this.bancodadospavDataSet2.produto);
            dv.RowFilter = string.Format("NOME LIKE '%{0}%'", tbFiltragem.Text);
            dataGridView1.DataSource = dv;
        }

        private void buFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
