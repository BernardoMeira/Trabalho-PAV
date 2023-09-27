using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TrabalhoPAV.Persistencia;
using MySql.Data.MySqlClient;



namespace TrabalhoPAV.Entidades
{
    public class FormaPagamento : Entidade
    {
        public const string ATRIBUTO_ID_FORMA_PAGAMENTO = "ID_FORMAPAGAMENTO";
        public const string ATRIBUTO_NOME = "NOME";

        private string idFormaPagamento;
        private string nome;


        public override void transferirDados(MySqlCommand comando)
        {

            comando.Parameters[ATRIBUTO_ID_FORMA_PAGAMENTO].Value = idFormaPagamento;
            comando.Parameters[ATRIBUTO_NOME].Value = nome;

        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_FORMA_PAGAMENTO].Value = idFormaPagamento;
        }
        public override void lerDados(MySqlDataReader leitorDados)
        {
            idFormaPagamento = leitorDados[ATRIBUTO_ID_FORMA_PAGAMENTO].ToString();
            nome = leitorDados[ATRIBUTO_NOME].ToString();
        }

        public string obterFormaPagamento()
        {
            return idFormaPagamento;
        }
        public string obterNome()
        {
            return nome;
        }

        public void alterarFormaPagamento(string idFormaPagamento)
        {
            this.idFormaPagamento = idFormaPagamento;
        }
        public void alterarNome(string nome)
        {
            this.nome = nome;
        }
    }
}
