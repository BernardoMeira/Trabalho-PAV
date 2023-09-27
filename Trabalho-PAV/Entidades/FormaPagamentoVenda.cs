using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TrabalhoPAV.Persistencia;
using MySql.Data.MySqlClient;


namespace TrabalhoPAV.Entidades
{
    public class FormaPagamentoVenda : Entidade
    {
        public const string ATRIBUTO_ID_VENDA = "ID_VENDA";
        public const string ATRIBUTO_ID_FORMA_PAGAMENTO_VENDA = "ID_FORMAPAGAMENTOVENDA";
        public const string ATRIBUTO_VALOR = "VALOR";

        private int idVenda;
        private string idFormaPagamentoVenda;
        private double valor;
     

        public override void transferirDados(MySqlCommand comando)
        {

            comando.Parameters[ATRIBUTO_ID_VENDA].Value = idVenda;
            comando.Parameters[ATRIBUTO_ID_FORMA_PAGAMENTO_VENDA].Value = idFormaPagamentoVenda;
            comando.Parameters[ATRIBUTO_VALOR].Value = valor;
   
        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_VENDA].Value = idVenda;
        }
        public override void lerDados(MySqlDataReader leitorDados)
        {
            idVenda = int.Parse(leitorDados[ATRIBUTO_ID_VENDA].ToString());
            idFormaPagamentoVenda = leitorDados[ATRIBUTO_ID_FORMA_PAGAMENTO_VENDA].ToString();
            valor = double.Parse(leitorDados[ATRIBUTO_VALOR].ToString());
        }

        public int obterIDVenda()
        {
            return idVenda;
        }
        public string obterFormaPagamentoVenda()
        {
            return idFormaPagamentoVenda;
        }
        public double obterValor()
        {
            return valor;
        }
        public void alterarIDVenda(int idVenda)
        {
            this.idVenda = idVenda;
        }
        public void alterarFormaPagamentoVenda(string idFormaPagamentoVenda)
        {
            this.idFormaPagamentoVenda = idFormaPagamentoVenda;
        }
        public void alterarValor(double valor)
        {
            this.valor = valor;
        }
    }
}
