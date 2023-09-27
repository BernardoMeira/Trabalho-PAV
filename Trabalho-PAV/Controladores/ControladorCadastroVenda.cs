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
    public class ControladorCadastroVenda : ControladorCadastro
    {
        override protected string criarComandoSelecao()
        {
            return "SELECT * FROM VENDA WHERE ID_VENDA = @ID_VENDA";
        }

        override protected string criarComandoInclusao()
        {
            return "INSERT INTO VENDA VALUES(@ID_VENDA, @DATETIME, @ID_CLIENTE, @TOTAL_VENDA," +
                                             " @SITUACAO_VENDA)";
        }
        override protected string criarComandoAtualizacao()
        {
            return " UPDATE VENDA " +
                   " SET    DATETIME = @DATETIME, " +
                   "        ID_CLIENTE = @ID_CLIENTE, " +
                   "        TOTAL_VENDA = @TOTAL_VENDA, " +
                   "        SITUACAO_VENDA = @SITUACAO_VENDA, " +
                   " WHERE  ID_VENDA = @ID_VENDA";
        }
        override protected string criarComandoExclusao()
        {
            return "DELETE FROM VENDA WHERE ID_VENDA = @ID_VENDA";
        }

        override protected void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(Venda.ATRIBUTO_ID_VENDA, MySqlDbType.Int32);
            comando.Parameters.Add(Venda.ATRIBUTO_DATETIME, MySqlDbType.String);
            comando.Parameters.Add(Venda.ATRIBUTO_ID_CLIENTE, MySqlDbType.Int32);
            comando.Parameters.Add(Venda.ATRIBUTO_TOTAL_VENDA, MySqlDbType.Int32);
            comando.Parameters.Add(Venda.ATRIBUTO_SITUACAO_VENDA, MySqlDbType.String);
        }

        override protected void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(Venda.ATRIBUTO_ID_VENDA, MySqlDbType.Int32);
        }

    }
}
