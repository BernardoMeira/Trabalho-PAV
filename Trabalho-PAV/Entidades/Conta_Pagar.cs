using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TrabalhoPAV.Persistencia;
using MySql.Data.MySqlClient;


namespace TrabalhoPAV.Entidades
{
    public class Conta_Pagar : Entidade
    {
        public const string ATRIBUTO_ID_CONTA_PAGAR = "ID_CONTA_PAGAR";
        public const string ATRIBUTO_DESCRICAO = "DESCRICAO";
        public const string ATRIBUTO_ID_CLIENTE = "ID_CLIENTE";
        public const string ATRIBUTO_DATA_LANCAMENTO = "DATA_LANCAMENTO";
        public const string ATRIBUTO_DATA_VENCIMENTO = "DATA_VENCIMENTO";
        public const string ATRIBUTO_VALOR_PAGO = "VALOR_PAGO";
        public const string ATRIBUTO_DATA_PAGAMENTO = "DATA_PAGAMENTO";
        public const string ATRIBUTO_VALOR_PAGAMENTO = "VALOR_PAGAMENTO";

        private int idConta_Pagar;
        private string descricao;
        private string idCliente;
        private string data_lancamento;
        private string data_vencimento;
        private string valor_pago;
        private string data_pagamento;
        private string valor_pagamento;


        public override void transferirDados(MySqlCommand comando)
        {

            comando.Parameters[ATRIBUTO_ID_CONTA_PAGAR].Value = idConta_Pagar;
            comando.Parameters[ATRIBUTO_DESCRICAO].Value = descricao;
            comando.Parameters[ATRIBUTO_ID_CLIENTE].Value = idCliente;
            comando.Parameters[ATRIBUTO_DATA_LANCAMENTO].Value = data_lancamento;
            comando.Parameters[ATRIBUTO_DATA_VENCIMENTO].Value = data_vencimento;
            comando.Parameters[ATRIBUTO_VALOR_PAGO].Value = valor_pago;
            comando.Parameters[ATRIBUTO_DATA_PAGAMENTO].Value = data_pagamento;
            comando.Parameters[ATRIBUTO_VALOR_PAGAMENTO].Value = valor_pagamento;

        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_CONTA_PAGAR].Value = idConta_Pagar;
        }
        public override void lerDados(MySqlDataReader leitorDados)
        {
            idConta_Pagar = int.Parse(leitorDados[ATRIBUTO_ID_CONTA_PAGAR].ToString());
            descricao = leitorDados[ATRIBUTO_DESCRICAO].ToString();
            idCliente = leitorDados[ATRIBUTO_ID_CLIENTE].ToString();
            data_lancamento = leitorDados[ATRIBUTO_DATA_LANCAMENTO].ToString();
            data_vencimento = leitorDados[ATRIBUTO_DATA_VENCIMENTO].ToString();
            valor_pago = leitorDados[ATRIBUTO_VALOR_PAGO].ToString();
            data_pagamento = leitorDados[ATRIBUTO_DATA_PAGAMENTO].ToString();
            valor_pagamento = leitorDados[ATRIBUTO_VALOR_PAGAMENTO].ToString();
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
        public string obterValorPago()
        {
            return valor_pago;
        }
        public string obterDataPagamento()
        {
            return data_pagamento;
        }
        public string obterValorPagamento()
        {
            return valor_pagamento;
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
        public void alterarValorPago(string valor_pago)
        {
            this.valor_pago = valor_pago;
        }
        public void alterarDataPagamento(string data_pagamento)
        {
            this.data_pagamento = data_pagamento;
        }
        public void alterarValorPagamento(string valor_pagamento)
        {
            this.valor_pagamento = valor_pagamento;
        }
    }
}

