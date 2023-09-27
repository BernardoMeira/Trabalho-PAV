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
    public partial class GUI_CadastroFornecedor : Form
    {
        ControladorCadastroFornecedor controladorCadastroFornecedor = new ControladorCadastroFornecedor();
        private OperacaoCadastro operacaoCadastro;
        private Fornecedor fornecedor;

        public GUI_CadastroFornecedor(OperacaoCadastro operacaoCadastro, Fornecedor fornecedor)
        {
            this.operacaoCadastro = operacaoCadastro;
            this.fornecedor = fornecedor;
            InitializeComponent();

            if (operacaoCadastro == OperacaoCadastro.ocAlterar || operacaoCadastro == OperacaoCadastro.ocConsultar)
            {
                tbNome.Text = fornecedor.obterNome();
                tbCodigo.Text = (fornecedor.obterIdentificador()).ToString();
                tbTelefone.Text = fornecedor.obterTelefone();
                tbEmail.Text = fornecedor.obterEmail();
                tbCep.Text = fornecedor.obterCep();
                tbCpfCnpj.Text = fornecedor.obterCPF_CNPJ();
                tbCidade.Text = fornecedor.obterCidade();
                tbBairro.Text = fornecedor.obterBairro();
                tbEstado.Text = fornecedor.obterEstado();
                tbComplemento.Text = fornecedor.obterComplemento();
                tbLogradouro.Text = fornecedor.obterLogradouro();
                tbNumero.Text = (fornecedor.obterNumero()).ToString();
            }
            if (operacaoCadastro == OperacaoCadastro.ocConsultar)
            {
                buCancelar.Enabled = false;
                tbNome.Enabled = false;
                tbTelefone.Enabled = false;
                tbEmail.Enabled = false;
                tbCep.Enabled = false;
                tbBairro.Enabled = false;
                tbCidade.Enabled = false;
                tbBairro.Enabled = false;
                tbEstado.Enabled = false;
                tbComplemento.Enabled = false;
                tbLogradouro.Enabled = false;
                tbCpfCnpj.Enabled = false;
                tbNumero.Enabled = false;
            }
            if (operacaoCadastro == OperacaoCadastro.ocConsultar || operacaoCadastro == OperacaoCadastro.ocAlterar)
            {
                tbCodigo.Enabled = false;
            }
        }

        private void buOk_Click_1(object sender, EventArgs e)
        {
            {
                if (tbNome.Text == ("") || tbTelefone.Text == ("")
                    || tbCodigo.Text == ("") || tbEmail.Text == ("")
                    || tbCep.Text == ("") || tbCidade.Text == ("")
                    || tbBairro.Text == ("") || tbCpfCnpj.Text == ("")
                    || tbEstado.Text == (""))
                {
                    MessageBox.Show("Um dos campos exigidos não está preenchido!");
                }
                else if (!VerificarCNPJCPF.IsValid(tbCpfCnpj.ToString()))
                {
                    if (operacaoCadastro != OperacaoCadastro.ocConsultar)
                    {
                        fornecedor.alterarNome(tbNome.Text);
                        fornecedor.alterarTelefone(tbTelefone.Text);
                        fornecedor.alterarIdentificador(Int32.Parse(tbCodigo.Text));
                        fornecedor.alterarEmail(tbEmail.Text);
                        fornecedor.alterarCep(tbCep.Text);
                        fornecedor.alterarBairro(tbBairro.Text);
                        fornecedor.alterarCidade(tbCidade.Text);
                        fornecedor.alterarBairro(tbBairro.Text);
                        fornecedor.alterarCPF_CNPJ(tbCpfCnpj.Text);
                        fornecedor.alterarLogradouro(tbLogradouro.Text);
                        fornecedor.alterarNumero(Int32.Parse(tbNumero.Text));
                        fornecedor.alterarComplemento(tbComplemento.Text);
                        fornecedor.alterarEstado(tbEstado.Text);
                        if (operacaoCadastro == OperacaoCadastro.ocIncluir)
                        {
                            controladorCadastroFornecedor.incluir(fornecedor);
                        }
                        else if (operacaoCadastro == OperacaoCadastro.ocAlterar)
                        {
                            controladorCadastroFornecedor.atualizar(fornecedor);
                        }
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("CPF/CNPJ Invalido!");
                }
            }
        }

        private void buCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
