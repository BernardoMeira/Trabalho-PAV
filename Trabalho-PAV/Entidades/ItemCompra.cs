using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TrabalhoPAV.Persistencia;
using MySql.Data.MySqlClient;


namespace TrabalhoPAV.Entidades
{
    public class ItemCompra : Entidade
    {
        public const string ATRIBUTO_ID_COMPRA = "ID_COMPRA";
        public const string ATRIBUTO_NUMERO_ITEM = "NUMERO_ITEM";
        public const string ATRIBUTO_ID_PRODUTO = "ID_PRODUTO";
        public const string ATRIBUTO_QUANTIDADE = "QUANTIDADE";
        public const string ATRIBUTO_VALOR_UNITARIO = "VALOR_UNITARIO";
        public const string ATRIBUTO_TOTAL_ITEM = "TOTAL_ITEM";

        private int idCompra;
        private string numero_item;
        private string id_produto;
        private string quantidade;
        private string valor_unitario;
        private string total_item;


        public override void transferirDados(MySqlCommand comando)
        {

            comando.Parameters[ATRIBUTO_ID_COMPRA].Value = idCompra;
            comando.Parameters[ATRIBUTO_NUMERO_ITEM].Value = numero_item;
            comando.Parameters[ATRIBUTO_ID_PRODUTO].Value = id_produto;
            comando.Parameters[ATRIBUTO_QUANTIDADE].Value = quantidade;
            comando.Parameters[ATRIBUTO_VALOR_UNITARIO].Value = valor_unitario;
            comando.Parameters[ATRIBUTO_TOTAL_ITEM].Value = total_item;

        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_COMPRA].Value = idCompra;
        }
        public override void lerDados(MySqlDataReader leitorDados)
        {
            idCompra = int.Parse(leitorDados[ATRIBUTO_ID_COMPRA].ToString());
            numero_item = leitorDados[ATRIBUTO_NUMERO_ITEM].ToString();
            id_produto = leitorDados[ATRIBUTO_ID_PRODUTO].ToString();
            quantidade = leitorDados[ATRIBUTO_QUANTIDADE].ToString();
            valor_unitario = leitorDados[ATRIBUTO_VALOR_UNITARIO].ToString();
            total_item = leitorDados[ATRIBUTO_TOTAL_ITEM].ToString();
        }

        public string obterNumeroItem()
        {
            return numero_item;
        }
        public string obterIdProduto()
        {
            return id_produto;
        }
        public string obterQuantidade()
        {
            return quantidade;
        }

        public string obterValorUnitario()
        {
            return valor_unitario;
        }
        public string obterTotalItem()
        {
            return total_item;
        }

        public void alterarNumeroItem(string numero_item)
        {
            this.numero_item = numero_item;
        }
        public void alterarIdProduto(string id_produto)
        {
            this.id_produto = id_produto;
        }
        public void alterarQuantidade(string quantidade)
        {
            this.quantidade = quantidade;
        }
        public void alterarValorUnitario(string valor_unitario)
        {
            this.valor_unitario = valor_unitario;
        }
        public void alterarTotalItem(string total_item)
        {
            this.total_item = total_item;
        }
    }
}
