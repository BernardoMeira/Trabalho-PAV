using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TrabalhoPAV.Persistencia;
using MySql.Data.MySqlClient;


namespace TrabalhoPAV.Entidades
{
    public class Cliente : Entidade
    {
        public const string ATRIBUTO_ID_CLIENTE = "ID_CLIENTE";
        public const string ATRIBUTO_NOME = "NOME";
        public const string ATRIBUTO_CPF_CNPJ = "CPF_CNPJ";
        public const string ATRIBUTO_LOGRADOURO = "LOGRADOURO";
        public const string ATRIBUTO_NUMERO = "NUMERO";
        public const string ATRIBUTO_COMPLEMENTO = "COMPLEMENTO";
        public const string ATRIBUTO_BAIRRO = "BAIRRO";
        public const string ATRIBUTO_CIDADE = "CIDADE";
        public const string ATRIBUTO_ESTADO = "ESTADO";
        public const string ATRIBUTO_CEP = "CEP";
        public const string ATRIBUTO_EMAIL = "EMAIL";
        public const string ATRIBUTO_TELEFONE = "TELEFONE";

        private int idCliente;
        private string nome;
        private string cpf_cnpj;
        private string logradouro;
        private int numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private string estado;
        private string cep;
        private string telefone;
        private string email;


        public override void transferirDados(MySqlCommand comando)
        {

            comando.Parameters[ATRIBUTO_ID_CLIENTE].Value = idCliente;
            comando.Parameters[ATRIBUTO_NOME].Value = nome;
            comando.Parameters[ATRIBUTO_CPF_CNPJ].Value = cpf_cnpj;
            comando.Parameters[ATRIBUTO_LOGRADOURO].Value = logradouro;
            comando.Parameters[ATRIBUTO_NUMERO].Value = numero;
            comando.Parameters[ATRIBUTO_COMPLEMENTO].Value = complemento;
            comando.Parameters[ATRIBUTO_BAIRRO].Value = bairro;
            comando.Parameters[ATRIBUTO_CIDADE].Value = cidade;
            comando.Parameters[ATRIBUTO_ESTADO].Value = estado;
            comando.Parameters[ATRIBUTO_CEP].Value = cep;
            comando.Parameters[ATRIBUTO_EMAIL].Value = email;
            comando.Parameters[ATRIBUTO_TELEFONE].Value = telefone;

        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_CLIENTE].Value = idCliente;
        }
        public override void lerDados(MySqlDataReader leitorDados)
        {
            idCliente = int.Parse(leitorDados[ATRIBUTO_ID_CLIENTE].ToString());
            nome = leitorDados[ATRIBUTO_NOME].ToString();
            cpf_cnpj = leitorDados[ATRIBUTO_CPF_CNPJ].ToString();
            logradouro = leitorDados[ATRIBUTO_LOGRADOURO].ToString();
            numero = int.Parse(leitorDados[ATRIBUTO_NUMERO].ToString());
            complemento = leitorDados[ATRIBUTO_COMPLEMENTO].ToString();
            bairro = leitorDados[ATRIBUTO_BAIRRO].ToString();
            cidade = leitorDados[ATRIBUTO_CIDADE].ToString();
            estado = leitorDados[ATRIBUTO_ESTADO].ToString();
            cep = leitorDados[ATRIBUTO_CEP].ToString();
            email = leitorDados[ATRIBUTO_EMAIL].ToString();
            telefone = leitorDados[ATRIBUTO_TELEFONE].ToString();
        }

        public string obterNome()
        {
            return nome;
        }
        public string obterCPF_CNPJ()
        {
            return cpf_cnpj;
        }
        public string obterLogradouro()
        {
            return logradouro;
        }

        public int obterNumero()
        {
            return numero;
        }
        public string obterComplemento()
        {
            return complemento;
        }
        public string obterBairro()
        {
            return bairro;
        }
        public string obterCidade()
        {
            return cidade;
        }
        public string obterEstado()
        {
            return estado;
        }
        public string obterCep()
        {
            return cep;
        }
        public string obterEmail()
        {
            return email;
        }
        public string obterTelefone()
        {
            return telefone;
        }

        public int obterIdentificador()
        {
            return idCliente;
        }

        public void alterarNome(string nome)
        {
            this.nome = nome;
        }
        public void alterarCPF_CNPJ(string cpf_cnpj)
        {
            this.cpf_cnpj = cpf_cnpj;
        }
        public void alterarLogradouro(string logradouro)
        {
            this.logradouro = logradouro;
        }
        public void alterarNumero(int numero)
        {
            this.numero = numero;
        }
        public void alterarComplemento(string complemento)
        {
            this.complemento = complemento;
        }
        public void alterarBairro(string bairro)
        {
            this.bairro = bairro;
        }
        public void alterarCidade(string cidade)
        {
            this.cidade = cidade;
        }
        public void alterarEstado(string estado)
        {
            this.estado = estado;
        }
        public void alterarCep(string cep)
        {
            this.cep = cep;
        }
        public void alterarTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public void alterarEmail(string email)
        {
            this.email = email;
        }
        public void alterarIdentificador(int identificador)
        {
            this.idCliente = identificador;
        }
    }
}
