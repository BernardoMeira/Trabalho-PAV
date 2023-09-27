using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TrabalhoPAV.Persistencia;
using MySql.Data.MySqlClient;


namespace TrabalhoPAV.Entidades
{
    public class Conta_Receber : Entidade
    {
        public const string ATRIBUTO_ID_CONTA_RECEBER = "ID_CONTA_RECEBER";
        public const string ATRIBUTO_DESCRICAO = "DESCRICAO";
        public const string ATRIBUTO_ID_CLIENTE = "ID_CLIENTE";
        public const string ATRIBUTO_DATA_LANCAMENTO = "DATA_LANCAMENTO";
        public const string ATRIBUTO_DATA_VENCIMENTO = "DATA_VENCIMENTO";
        public const string ATRIBUTO_VALOR_RECEBIDO = "VALOR_RECEBIDO";
        public const string ATRIBUTO_DATA_RECEBIMENTO = "DATA_RECEBIMENTO";
        public const string ATRIBUTO_VALOR_RECEBIMENTO = "VALOR_RECEBIMENTO";

        private int idConta_Receber;
        private string descricao;
        private string idCliente;
        private string data_lancamento;
        private string data_vencimento;
        private string valor_recebido;
        private string data_recebimento;
        private string valor_recebimento;


        public override void transferirDados(MySqlCommand comando)
        {

            comando.Parameters[ATRIBUTO_ID_CONTA_RECEBER].Value = idConta_Receber;
            comando.Parameters[ATRIBUTO_DESCRICAO].Value = descricao;
            comando.Parameters[ATRIBUTO_ID_CLIENTE].Value = idCliente;
            comando.Parameters[ATRIBUTO_DATA_LANCAMENTO].Value = data_lancamento;
            comando.Parameters[ATRIBUTO_DATA_VENCIMENTO].Value = data_vencimento;
            comando.Parameters[ATRIBUTO_VALOR_RECEBIDO].Value = valor_recebido;
            comando.Parameters[ATRIBUTO_DATA_RECEBIMENTO].Value = data_recebimento;
            comando.Parameters[ATRIBUTO_VALOR_RECEBIMENTO].Value = valor_recebimento;

        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_CONTA_RECEBER].Value = idConta_Receber;
        }
        public override void lerDados(MySqlDataReader leitorDados)
        {
            idConta_Receber = int.Parse(leitorDados[ATRIBUTO_ID_CONTA_RECEBER].ToString());
            descricao = leitorDados[ATRIBUTO_DESCRICAO].ToString();
            idCliente = leitorDados[ATRIBUTO_ID_CLIENTE].ToString();
            data_lancamento = leitorDados[ATRIBUTO_DATA_LANCAMENTO].ToString();
            data_vencimento = leitorDados[ATRIBUTO_DATA_VENCIMENTO].ToString();
            valor_recebido = leitorDados[ATRIBUTO_VALOR_RECEBIDO].ToString();
            data_recebimento = leitorDados[ATRIBUTO_DATA_RECEBIMENTO].ToString();
            valor_recebimento = leitorDados[ATRIBUTO_VALOR_RECEBIMENTO].ToString();
        }

        public string obterDescricao()
        {
            return descricao;
        }
        public string obteridCliente()
        {
            return idCliente;
        }
        public string obterDataLancamento()
        {
            return data_lancamento;
        }

        public string obterDataVencimento()
        {
            return data_vencimento;
        }
        public string obterValorRecebido()
        {
            return valor_recebido;
        }
        public string obterDataRecebimento()
        {
            return data_recebimento;
        }
        public string obterValorRecebimento()
        {
            return valor_recebimento;
        }


        public void alterarDescricao(string descricao)
        {
            this.descricao = descricao;
        }
        public void alteraridCliente(string idCliente)
        {
            this.idCliente = idCliente;
        }
        public void alterarDataLancamento(string data_lancamento)
        {
            this.data_lancamento = data_lancamento;
        }
        public void alterarDataVencimento(string data_vencimento)
        {
            this.data_vencimento = data_vencimento;
            ;
        }
        public void alterarValorRecebido(string valor_recebido)
        {
            this.valor_recebido = valor_recebido;
        }
        public void alterarDataRecebimento(string data_recebimento)
        {
            this.data_recebimento = data_recebimento;
        }
        public void alterarValorRecebimento(string valor_recebimento)
        {
            this.valor_recebimento = valor_recebimento;
        }
    }
}
