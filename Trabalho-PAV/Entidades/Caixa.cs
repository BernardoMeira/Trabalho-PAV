using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TrabalhoPAV.Persistencia;
using MySql.Data.MySqlClient;



namespace TrabalhoPAV.Entidades
{
    public class Caixa : Entidade
    {
        public const string ATRIBUTO_ID_CAIXA = "ID_CAIXA";
        public const string ATRIBUTO_NOME = "NOME";
        public const string ATRIBUTO_SALDO = "SALDO";

        private string idCaixa;
        private string nome;
        private string saldo;


        public override void transferirDados(MySqlCommand comando)
        {

            comando.Parameters[ATRIBUTO_ID_CAIXA].Value = idCaixa;
            comando.Parameters[ATRIBUTO_NOME].Value = nome;
            comando.Parameters[ATRIBUTO_SALDO].Value = saldo;


        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_CAIXA].Value = idCaixa;
        }
        public override void lerDados(MySqlDataReader leitorDados)
        {
            idCaixa = leitorDados[ATRIBUTO_ID_CAIXA].ToString();
            nome = leitorDados[ATRIBUTO_NOME].ToString();
            saldo = leitorDados[ATRIBUTO_SALDO].ToString();
        }

        public string obterCaixa()
        {
            return idCaixa;
        }
        public string obterNome()
        {
            return nome;
        }
        public string obterSaldo()
        {
            return saldo;
        }

        public void alterarCaixa(string idCaixa)
        {
            this.idCaixa = idCaixa;
        }
        public void alterarNome(string nome)
        {
            this.nome = nome;
        }
        public void alterarSaldo(string saldo)
        {
            this.saldo = saldo;
        }
    }
}
