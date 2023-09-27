using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TrabalhoPAV.Persistencia;
using TrabalhoPAV.Entidades;
using MySql.Data.MySqlClient;

namespace TrabalhoPAV.Controladores
{
    public class ControladorCadastroItemVenda : ControladorCadastro
    {
        override protected string criarComandoSelecao()
        {
            return "SELECT * FROM ITEMVENDA WHERE ID_VENDA = @ID_VENDA";
        }

        override protected string criarComandoInclusao()
        {
            return "INSERT INTO ITEMVENDA VALUES(@ID_VENDA, @NUMERO_ITEM, @ID_PRODUTO, @QUANTIDADE," +
                                             " @VALOR_UNITARIO, @TOTAL_ITEM)";
        }
        override protected string criarComandoAtualizacao()
        {
            return " UPDATE ITEMVENDA " +
                   " SET    NUMERO_ITEM = @NUMERO_ITEM, " +
                   "        ID_PRODUTO = @ID_PRODUTO, " +
                   "        QUANTIDADE = @QUANTIDADE, " +
                   "        VALOR_UNITARIO = @VALOR_UNITARIO, " +
                   "        TOTAL_ITEM = @TOTAL_ITEM, " +
                   " WHERE  ID_VENDA = @ID_VENDA";
        }
        override protected string criarComandoExclusao()
        {
            return "DELETE FROM ITEMVENDA WHERE ID_VENDA = @ID_VENDA";
        }

        override protected void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(ItemVenda.ATRIBUTO_ID_VENDA, MySqlDbType.Int32);
            comando.Parameters.Add(ItemVenda.ATRIBUTO_ID_PRODUTO, MySqlDbType.Int32);
            comando.Parameters.Add(ItemVenda.ATRIBUTO_QUANTIDADE, MySqlDbType.Int32);
            comando.Parameters.Add(ItemVenda.ATRIBUTO_VALOR_UNITARIO, MySqlDbType.Float);
            comando.Parameters.Add(ItemVenda.ATRIBUTO_TOTAL_ITEM, MySqlDbType.Double);
        }

        override protected void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(ItemVenda.ATRIBUTO_ID_VENDA, MySqlDbType.Int32);
        }

    }
}