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
using TrabalhoPAV.Execucao;

namespace TrabalhoPAV.Interface

{
    public partial class GUI_CadastroVenda : Form
    {
        ControladorCadastroVenda controladorCadastroVenda = new ControladorCadastroVenda();
        ControladorCadastroFormaPagamentoVenda controladorCadastroFormaVenda = new ControladorCadastroFormaPagamentoVenda();
        private OperacaoCadastro operacaoCadastro;
        private Venda venda;
        private FormaPagamentoVenda formaVenda;
        int numeroitem = 0;
        List<ItemVenda> itemVenda = new List<ItemVenda>();

        public GUI_CadastroVenda(OperacaoCadastro operacaoCadastro, Venda venda, FormaPagamentoVenda formaVenda)
        {
            this.operacaoCadastro = operacaoCadastro;
            this.venda = venda;
            this.formaVenda = formaVenda;
            InitializeComponent();

            if (operacaoCadastro == OperacaoCadastro.ocAlterar || operacaoCadastro == OperacaoCadastro.ocConsultar)
            {
                tbDataHora.Text = venda.obterDatetime();
                tbCodigo.Text = (venda.obterIdentificador()).ToString();
                tbValorTotal.Text = venda.obterTotalVenda().ToString();
                tbCodigoCliente.Text = venda.obterIdCliente().ToString();
            }
            if (operacaoCadastro == OperacaoCadastro.ocConsultar)
            {
                buCancelar.Enabled = false;
                tbDataHora.Enabled = false;
                tbCodigo.Enabled = false;
                tbValorTotal.Enabled = false;
                tbCodigoCliente.Enabled = false;
            }
            if (operacaoCadastro == OperacaoCadastro.ocConsultar || operacaoCadastro == OperacaoCadastro.ocAlterar)
            {
                tbCodigo.Enabled = false;
            }
        }



        private void buOk_Click(object sender, EventArgs e)
        {
            if (tbDataHora.Text == ("") || tbCodigo.Text == ("")
                || tbValorTotal.Text == ("") || tbCodigoCliente.Text == (""))
            {
                MessageBox.Show("Um dos campos exigidos não está preenchido!");
            }
            else if (operacaoCadastro != OperacaoCadastro.ocConsultar)
            {
                venda.alterarDateTime(tbDataHora.Text);
                venda.alterarTotalVenda(Double.Parse(tbValorTotal.Text));
                venda.alterarIdentificador(Int32.Parse(tbCodigo.Text));
                venda.alterarIdCliente(Int32.Parse(tbCodigoCliente.Text));
                venda.alterarSituacaoVenda("Confirmada");
                formaVenda.alterarIDVenda(Int32.Parse(tbCodigo.Text));
                formaVenda.alterarValor(Double.Parse(tbValorTotal.Text));
                if (radioButton1.Checked)
                {
                    formaVenda.alterarFormaPagamentoVenda(radioButton1.Text);
                }
                else if (radioButton2.Checked)
                {
                    formaVenda.alterarFormaPagamentoVenda(radioButton2.Text);
                }
                if (operacaoCadastro == OperacaoCadastro.ocIncluir)
                {
                    controladorCadastroVenda.incluir(venda);
                    controladorCadastroFormaVenda.incluir(venda);
                }
                else if (operacaoCadastro == OperacaoCadastro.ocAlterar)
                {
                    controladorCadastroVenda.atualizar(venda);
                }
                this.Close();
            }
        }

        private void buCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_CadastroVenda_Load(object sender, EventArgs e)
        {
            
            //this.itemvendaTableAdapter.Fill(this.bancodadospavDataSet6.itemvenda);
            //dataGridView1.Columns[0].Visible = false;
            
            this.produtoTableAdapter1.Fill(this.bancodadospavDataSet5.produto);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buAdicionar_Click(object sender, EventArgs e)
        {
            //DataView dv = new DataView(this.bancodadospavDataSet6.itemvenda);
            //dv.RowFilter = string.Format("NOME LIKE '%{0}%'", tbFiltragem.Text);
            //dataGridView1.DataSource = dv;
            ControladorCadastroProduto controladorCadastroProduto = new ControladorCadastroProduto();
            ItemVenda itemvenda = new ItemVenda();
            Produto produto = new Produto();
            int index = Convert.ToInt32(comboBox1.SelectedValue);
            produto.alterarIdentificador(index);
            controladorCadastroProduto.selecionar(produto);
            itemvenda.alterarIdProduto(tbCodigo.Text);
            numeroitem++;
            itemvenda.alterarNumeroItem(numeroitem.ToString());
            itemvenda.alterarQuantidade(textQuantidade.Text);
            itemvenda.alterarTotalItem(produto.obterQuantidade_estoque().ToString());
            itemvenda.alterarValorUnitario((produto.obterPreco() * int.Parse(textQuantidade.Text)).ToString());
            itemvenda.alterarIdProduto(produto.obterIdentificador().ToString());
            itemVenda.Add(itemvenda);
            //dataGridView1.DataSource = null;
            dataGridView1.DataSource = itemVenda;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}