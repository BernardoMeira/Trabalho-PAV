using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TrabalhoPAV.Persistencia;
using MySql.Data.MySqlClient;


namespace TrabalhoPAV.Entidades
{
    public class Venda : Entidade
    {
        public const string ATRIBUTO_ID_VENDA = "ID_VENDA";
        public const string ATRIBUTO_DATETIME = "DATETIME";
        public const string ATRIBUTO_ID_CLIENTE = "ID_CLIENTE";
        public const string ATRIBUTO_TOTAL_VENDA = "TOTAL_VENDA";
        public const string ATRIBUTO_SITUACAO_VENDA = "SITUACAO_VENDA";

        private int idVenda;
        private string datetime;
        private int idCliente;
        private double total_venda;
        private string situacao_venda;

        public override void transferirDados(MySqlCommand comando)
        {

            comando.Parameters[ATRIBUTO_ID_VENDA].Value = idVenda;
            comando.Parameters[ATRIBUTO_DATETIME].Value = datetime;
            comando.Parameters[ATRIBUTO_ID_CLIENTE].Value = idCliente;
            comando.Parameters[ATRIBUTO_TOTAL_VENDA].Value = total_venda;
            comando.Parameters[ATRIBUTO_SITUACAO_VENDA].Value = situacao_venda;
        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_VENDA].Value = idVenda;
        }
        public override void lerDados(MySqlDataReader leitorDados)
        {
            idVenda = int.Parse(leitorDados[ATRIBUTO_ID_VENDA].ToString());
            datetime = leitorDados[ATRIBUTO_DATETIME].ToString();
            idCliente = int.Parse(leitorDados[ATRIBUTO_ID_CLIENTE].ToString());
            total_venda = double.Parse(leitorDados[ATRIBUTO_TOTAL_VENDA].ToString());
            situacao_venda = leitorDados[ATRIBUTO_SITUACAO_VENDA].ToString();
        }

        public string obterDatetime()
        {
            return datetime;
        }
        public int obterIdCliente()
        {
            return idCliente;
        }
        public double obterTotalVenda()
        {
            return total_venda;
        }

        public string obterSituacaoVenda()
        {
            return situacao_venda;
        }
        public int obterIdentificador()
        {
            return idVenda;
        }
        public void alterarDateTime(string datetime)
        {
            this.datetime = datetime;
        }
        public void alterarIdCliente(int idCliente)
        {
            this.idCliente = idCliente;
        }
        public void alterarTotalVenda(double total_venda)
        {
            this.total_venda = total_venda;
        }
        public void alterarSituacaoVenda(string situacao_venda)
        {
            this.situacao_venda = situacao_venda;
        }
        public void alterarIdentificador(int idVenda)
        {
            this.idVenda = idVenda;
        }
    }
}