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
    public partial class GUI_CadastroProduto : Form
    {
        ControladorCadastroProduto controladorCadastroProduto = new ControladorCadastroProduto();
        private OperacaoCadastro operacaoCadastro;
        private Produto produto;

        public GUI_CadastroProduto(OperacaoCadastro operacaoCadastro, Produto produto)
        {
            this.operacaoCadastro = operacaoCadastro;
            this.produto = produto;
            InitializeComponent();

            if (operacaoCadastro == OperacaoCadastro.ocAlterar || operacaoCadastro == OperacaoCadastro.ocConsultar)
            {
                tbNome.Text = produto.obterNome();
                tbCodigo.Text = (produto.obterIdentificador()).ToString();
                tbQuantidadeEstoque.Text = produto.obterQuantidade_estoque().ToString();
                tbPreco.Text = produto.obterPreco().ToString();
                tbUnidade.Text = produto.obterUnidade();
                tbCodigoFornecedor.Text = produto.obterId_fornecedor().ToString(); ;
            }
            if (operacaoCadastro == OperacaoCadastro.ocConsultar)
            {
                buCancelar.Enabled = false;
                tbNome.Enabled = false;
                tbCodigo.Enabled = false;
                tbQuantidadeEstoque.Enabled = false;
                tbPreco.Enabled = false;
                tbUnidade.Enabled = false;
                tbCodigoFornecedor.Enabled = false;
            }
            if (operacaoCadastro == OperacaoCadastro.ocConsultar || operacaoCadastro == OperacaoCadastro.ocAlterar)
            {
                tbCodigo.Enabled = false;
            }
        }

        private void buOk_Click_1(object sender, EventArgs e)
        {
            if (tbNome.Text == ("") || tbCodigo.Text == ("")
                || tbQuantidadeEstoque.Text == ("") || tbPreco.Text == ("")
                || tbUnidade.Text == ("") || tbCodigoFornecedor.Text == (""))
            {
                MessageBox.Show("Um dos campos exigidos não está preenchido!");
            }
            else if (operacaoCadastro != OperacaoCadastro.ocConsultar)
            {
                produto.alterarNome(tbNome.Text);
                produto.alterarQuantidade_estoque(Int32.Parse(tbQuantidadeEstoque.Text));
                produto.alterarIdentificador(Int32.Parse(tbCodigo.Text));
                produto.alterarPreco(Double.Parse(tbPreco.Text));
                produto.alterarUnidade(tbUnidade.Text);
                produto.alterarId_Fornecedor(Int32.Parse(tbCodigoFornecedor.Text));

                if (operacaoCadastro == OperacaoCadastro.ocIncluir)
                {
                    controladorCadastroProduto.incluir(produto);
                }
                else if (operacaoCadastro == OperacaoCadastro.ocAlterar)
                {
                    controladorCadastroProduto.atualizar(produto);
                }
            }
            this.Close();
        }

        private void buCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}