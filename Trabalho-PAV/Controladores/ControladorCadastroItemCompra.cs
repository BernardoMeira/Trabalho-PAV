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
    public class ControladorCadastroItemCompra : ControladorCadastro
    {
        override protected string criarComandoSelecao()
        {
            return "SELECT * FROM ITEMCOMPRA WHERE ID_COMPRA = @ID_COMPRA";
        }

        override protected string criarComandoInclusao()
        {
            return "INSERT INTO ITEMCOMPRA VALUES(@ID_COMPRA, @NUMERO_ITEM, @ID_PRODUTO, @QUANTIDADE," +
                                             " @VALOR_UNITARIO, @TOTAL_ITEM)";
        }
        override protected string criarComandoAtualizacao()
        {
            return " UPDATE ITEMCOMPRA " +
                   " SET    NUMERO_ITEM = @NUMERO_ITEM, " +
                   "        ID_PRODUTO = @ID_PRODUTO, " +
                   "        QUANTIDADE = @QUANTIDADE, " +
                   "        VALOR_UNITARIO = @VALOR_UNITARIO, " +
                   "        TOTAL_ITEM = @TOTAL_ITEM, " +
                   " WHERE  ID_COMPRA = @ID_COMPRA";
        }
        override protected string criarComandoExclusao()
        {
            return "DELETE FROM ITEMCOMPRA WHERE ID_COMPRA = @ID_COMPRA";
        }

        override protected void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(ItemCompra.ATRIBUTO_ID_COMPRA, MySqlDbType.Int32);
            comando.Parameters.Add(ItemCompra.ATRIBUTO_ID_PRODUTO, MySqlDbType.Int32);
            comando.Parameters.Add(ItemCompra.ATRIBUTO_QUANTIDADE, MySqlDbType.Int32);
            comando.Parameters.Add(ItemCompra.ATRIBUTO_VALOR_UNITARIO, MySqlDbType.Float);
            comando.Parameters.Add(ItemCompra.ATRIBUTO_TOTAL_ITEM, MySqlDbType.Double);
        }

        override protected void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(ItemCompra.ATRIBUTO_ID_COMPRA, MySqlDbType.Int32);
        }

    }
}
