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
    public partial class GUI_CadastroCliente : Form
    {
        ControladorCadastroCliente controladorCadastroCliente = new ControladorCadastroCliente();
        private OperacaoCadastro operacaoCadastro;
        private Cliente cliente;

        public GUI_CadastroCliente(OperacaoCadastro operacaoCadastro, Cliente cliente)
        {
            this.operacaoCadastro = operacaoCadastro;
            this.cliente = cliente;
            InitializeComponent();

            if (operacaoCadastro == OperacaoCadastro.ocAlterar || operacaoCadastro == OperacaoCadastro.ocConsultar)
            {
                textNome.Text = cliente.obterNome();
                textCodigo.Text = (cliente.obterIdentificador()).ToString();
                textTelefone.Text = cliente.obterTelefone();
                textEmail.Text = cliente.obterEmail();
                textCEP.Text = cliente.obterCep();
                textCPF_CNPJ.Text = cliente.obterCPF_CNPJ();
                textCidade.Text = cliente.obterCidade();
                textBairro.Text = cliente.obterBairro();
                textEstado.Text = cliente.obterEstado();
                textComplemento.Text = cliente.obterComplemento();
                textLogradouro.Text = cliente.obterLogradouro();
                textNumero.Text = (cliente.obterNumero()).ToString();
            }
            if (operacaoCadastro == OperacaoCadastro.ocConsultar)
            {
                buCancelar.Enabled = false;
                textNome.Enabled = false;
                textTelefone.Enabled = false;
                textEmail.Enabled = false;
                textCEP.Enabled = false;
                textBairro.Enabled = false;
                textCidade.Enabled = false;
                textBairro.Enabled = false;
                textEstado.Enabled = false;
                textComplemento.Enabled = false;
                textLogradouro.Enabled = false;
                textCPF_CNPJ.Enabled = false;
                textNumero.Enabled = false;
            }
            if (operacaoCadastro == OperacaoCadastro.ocConsultar || operacaoCadastro == OperacaoCadastro.ocAlterar){
                textCodigo.Enabled = false;
            }
        }

    

        private void buOk_Click(object sender, EventArgs e)
        {
            if (textNome.Text == ("") || textTelefone.Text == ("")
                || textCodigo.Text == ("") || textEmail.Text == ("")
                || textCEP.Text == ("") || textCidade.Text == ("")
                || textBairro.Text == ("") || textCPF_CNPJ.Text == ("")
                || textEstado.Text == ("") )
            {
                MessageBox.Show("Um dos campos exigidos não está preenchido!");
            }
            else if (!VerificarCNPJCPF.IsValid(textCPF_CNPJ.ToString()))
            {
                if (operacaoCadastro != OperacaoCadastro.ocConsultar)
                {
                    cliente.alterarNome(textNome.Text);
                    cliente.alterarTelefone(textTelefone.Text);
                    cliente.alterarIdentificador(Int32.Parse(textCodigo.Text));
                    cliente.alterarEmail(textEmail.Text);
                    cliente.alterarCep(textCEP.Text);
                    cliente.alterarBairro(textBairro.Text);
                    cliente.alterarCidade(textCidade.Text);
                    cliente.alterarBairro(textBairro.Text);
                    cliente.alterarCPF_CNPJ(textCPF_CNPJ.Text);
                    cliente.alterarLogradouro(textLogradouro.Text);
                    cliente.alterarNumero(Int32.Parse(textNumero.Text));
                    cliente.alterarComplemento(textComplemento.Text);
                    cliente.alterarEstado(textEstado.Text);
                    if (operacaoCadastro == OperacaoCadastro.ocIncluir)
                    {
                        controladorCadastroCliente.incluir(cliente);
                    } else if(operacaoCadastro == OperacaoCadastro.ocAlterar)
                    {
                        controladorCadastroCliente.atualizar(cliente);
                    }
                }
                this.Close();
            } else
            {
                MessageBox.Show("CPF/CNPJ Invalido!");
            }
        }

        private void buCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
