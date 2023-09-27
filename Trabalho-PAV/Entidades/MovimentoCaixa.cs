using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TrabalhoPAV.Persistencia;
using MySql.Data.MySqlClient;


namespace TrabalhoPAV.Entidades
{
    public class MovimentoCaixa : Entidade
    {
        public const string ATRIBUTO_ID_CAIXA = "ID_CAIXA";
        public const string ATRIBUTO_NUMERO_MOVIMENTO = "NUMERO_MOVIMENTO";
        public const string ATRIBUTO_DATA_MOVIMENTO = "DATA_MOVIMENTO";
        public const string ATRIBUTO_HORA_MOVIMENTO = "HORA_MOVIMENTO";
        public const string ATRIBUTO_DESCRICAO = "DESCRICAO";
        public const string ATRIBUTO_TIPO_MOVIMENTO = "TIPO_MOVIMENTO";
        public const string ATRIBUTO_VALOR = "VALOR";

        private int idCaixa;
        private string numero_movimento;
        private string data_movimento;
        private string hora_movimento;
        private string descricao;
        private string tipo_movimento;
        private string valor;


        public override void transferirDados(MySqlCommand comando)
        {

            comando.Parameters[ATRIBUTO_ID_CAIXA].Value = idCaixa;
            comando.Parameters[ATRIBUTO_NUMERO_MOVIMENTO].Value = numero_movimento;
            comando.Parameters[ATRIBUTO_DATA_MOVIMENTO].Value = data_movimento;
            comando.Parameters[ATRIBUTO_HORA_MOVIMENTO].Value = hora_movimento;
            comando.Parameters[ATRIBUTO_DESCRICAO].Value = descricao;
            comando.Parameters[ATRIBUTO_TIPO_MOVIMENTO].Value = tipo_movimento;
            comando.Parameters[ATRIBUTO_VALOR].Value = valor;

        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_CAIXA].Value = idCaixa;
        }
        public override void lerDados(MySqlDataReader leitorDados)
        {
            idCaixa = int.Parse(leitorDados[ATRIBUTO_ID_CAIXA].ToString());
            numero_movimento = leitorDados[ATRIBUTO_NUMERO_MOVIMENTO].ToString();
            data_movimento = leitorDados[ATRIBUTO_DATA_MOVIMENTO].ToString();
            hora_movimento = leitorDados[ATRIBUTO_HORA_MOVIMENTO].ToString();
            descricao = leitorDados[ATRIBUTO_DESCRICAO].ToString();
            tipo_movimento = leitorDados[ATRIBUTO_TIPO_MOVIMENTO].ToString();
            valor = leitorDados[ATRIBUTO_VALOR].ToString();
        }

        public string obterNumeroMovimento()
        {
            return numero_movimento;
        }
        public string obterDataMovimento()
        {
            return data_movimento;
        }
        public string obterHoraMovimento()
        {
            return hora_movimento;
        }

        public string obterDescricao()
        {
            return descricao;
        }
        public string obterTipoMovimento()
        {
            return tipo_movimento;
        }
        public string obterValor()
        {
            return valor;
        }

        public void alterarNumeroMovimento(string numero_movimento)
        {
            this.numero_movimento = numero_movimento;
        }
        public void alterarDataMovimento(string data_movimento)
        {
            this.data_movimento = data_movimento;
        }
        public void alterarHoraMovimento(string hora_movimento)
        {
            this.hora_movimento = hora_movimento;
        }
        public void alterarDescricao(string descricao)
        {
            this.descricao = descricao;
            ;
        }
        public void alterarTipoMovimento(string tipo_movimento)
        {
            this.tipo_movimento = tipo_movimento;
        }
        public void alterarValor(string valor)
        {
            this.valor = valor;
        }
    }
}
