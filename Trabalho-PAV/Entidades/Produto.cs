using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TrabalhoPAV.Persistencia;
using MySql.Data.MySqlClient;


namespace TrabalhoPAV.Entidades
{
    public class Produto : Entidade
    {
        public const string ATRIBUTO_ID_PRODUTO = "ID_PRODUTO";
        public const string ATRIBUTO_NOME = "NOME";
        public const string ATRIBUTO_QUANTIDADE_ESTOQUE = "QUANTIDADE_ESTOQUE";
        public const string ATRIBUTO_PRECO = "PRECO";
        public const string ATRIBUTO_UNIDADE = "UNIDADE";
        public const string ATRIBUTO_ID_FORNECEDOR = "ID_FORNECEDOR";

        private int idProduto;
        private string nome;
        private int quantidade_estoque;
        private double preco;
        private string unidade;
        private int id_fornecedor;


        public override void transferirDados(MySqlCommand comando)
        {

            comando.Parameters[ATRIBUTO_ID_PRODUTO].Value = idProduto;
            comando.Parameters[ATRIBUTO_NOME].Value = nome;
            comando.Parameters[ATRIBUTO_QUANTIDADE_ESTOQUE].Value = quantidade_estoque;
            comando.Parameters[ATRIBUTO_PRECO].Value = preco;
            comando.Parameters[ATRIBUTO_UNIDADE].Value = unidade;
            comando.Parameters[ATRIBUTO_ID_FORNECEDOR].Value = id_fornecedor;

        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_PRODUTO].Value = idProduto;
        }
        public override void lerDados(MySqlDataReader leitorDados)
        {
            idProduto = int.Parse(leitorDados[ATRIBUTO_ID_PRODUTO].ToString());
            nome = leitorDados[ATRIBUTO_NOME].ToString();
            quantidade_estoque = int.Parse(leitorDados[ATRIBUTO_QUANTIDADE_ESTOQUE].ToString());
            preco = double.Parse(leitorDados[ATRIBUTO_PRECO].ToString());
            unidade = leitorDados[ATRIBUTO_UNIDADE].ToString();
            id_fornecedor = int.Parse(leitorDados[ATRIBUTO_ID_FORNECEDOR].ToString());
        }

        public string obterNome()
        {
            return nome;
        }
        public int obterQuantidade_estoque()
        {
            return quantidade_estoque;
        }
        public double obterPreco()
        {
            return preco;
        }

        public string obterUnidade()
        {
            return unidade;
        }
        public int obterId_fornecedor()
        {
            return id_fornecedor;
        }
        public int obterIdentificador()
        {
            return idProduto;
        }

        public void alterarNome(string nome)
        {
            this.nome = nome;
        }
        public void alterarQuantidade_estoque(int quantidade_estoque)
        {
            this.quantidade_estoque=quantidade_estoque;
        }
        public void alterarPreco(double preco)
        {
            this.preco = preco;
        }
        public void alterarUnidade(string unidade)
        {
            this.unidade = unidade;
        }
        public void alterarId_Fornecedor(int id_fornecedor)
        {
            this.id_fornecedor = id_fornecedor;
        }
        public void alterarIdentificador(int idProduto)
        {
            this.idProduto = idProduto;
        }
    }
}