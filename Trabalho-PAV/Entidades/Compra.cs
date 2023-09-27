using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TrabalhoPAV.Persistencia;
using MySql.Data.MySqlClient;


namespace TrabalhoPAV.Entidades
{
    public class Compra : Entidade
    {
        public const string ATRIBUTO_ID_COMPRA = "ID_COMPRA";
        public const string ATRIBUTO_DATETIME = "DATETIME";
        public const string ATRIBUTO_ID_FORNECEDOR = "ID_FORNECEDOR";
        public const string ATRIBUTO_TOTAL_COMPRA = "TOTAL_COMPRA";
        public const string ATRIBUTO_SITUACAO_COMPRA = "SITUACAO_COMPRA";

        private int idCompra;
        private string datetime;
        private string idFornecedor;
        private string total_compra;
        private string situacao_compra;

        public override void transferirDados(MySqlCommand comando)
        {

            comando.Parameters[ATRIBUTO_ID_COMPRA].Value = idCompra;
            comando.Parameters[ATRIBUTO_DATETIME].Value = datetime;
            comando.Parameters[ATRIBUTO_ID_FORNECEDOR].Value = idFornecedor;
            comando.Parameters[ATRIBUTO_TOTAL_COMPRA].Value = total_compra;
            comando.Parameters[ATRIBUTO_SITUACAO_COMPRA].Value = situacao_compra;
        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_COMPRA].Value = idCompra;
        }
        public override void lerDados(MySqlDataReader leitorDados)
        {
            idCompra = int.Parse(leitorDados[ATRIBUTO_ID_COMPRA].ToString());
            datetime = leitorDados[ATRIBUTO_DATETIME].ToString();
            idFornecedor = leitorDados[ATRIBUTO_ID_FORNECEDOR].ToString();
            total_compra = leitorDados[ATRIBUTO_TOTAL_COMPRA].ToString();
            situacao_compra = leitorDados[ATRIBUTO_SITUACAO_COMPRA].ToString();
        }

        public string obterDatetime()
        {
            return datetime;
        }
        public string obterIdFornecedor()
        {
            return idFornecedor;
        }
        public string obterTotalCompra()
        {
            return total_compra;
        }

        public string obterSituacaoCompra()
        {
            return situacao_compra;
        }

        public void alterarDateTime(string datetime)
        {
            this.datetime = datetime;
        }
        public void alterarIdFornecedor(string idFornecedor)
        {
            this.idFornecedor = idFornecedor;
        }
        public void alterarTotalCompra(string total_compra)
        {
            this.total_compra = total_compra;
        }
        public void alterarSituacaoCompra(string situacao_compra)
        {
            this.situacao_compra = situacao_compra;
        }
    }
}