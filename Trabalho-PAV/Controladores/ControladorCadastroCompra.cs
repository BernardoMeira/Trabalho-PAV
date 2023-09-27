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
    public class ControladorCadastroCompra : ControladorCadastro
    {
        override protected string criarComandoSelecao()
        {
            return "SELECT * FROM COMPRA WHERE ID_COMPRA = @ID_COMPRA";
        }

        override protected string criarComandoInclusao()
        {
            return "INSERT INTO COMPRA VALUES(@ID_COMPRA, @DATETIME, @ID_FORNECEDOR, @TOTAL_COMPRA," +
                                             " @SITUACAO_COMPRA)";
        }
        override protected string criarComandoAtualizacao()
        {
            return " UPDATE COMPRA " +
                   " SET    DATETIME = @DATETIME, " +
                   "        ID_FORNECEDOR = @ID_FORNECEDOR, " +
                   "        TOTAL_COMPRA = @TOTAL_COMPRA, " +
                   "        SITUACAO_COMPRA = @SITUACAO_COMPRA, " +
                   " WHERE  ID_COMPRA = @ID_COMPRA";
        }
        override protected string criarComandoExclusao()
        {
            return "DELETE FROM COMPRA WHERE ID_COMPRA = @ID_COMPRA";
        }

        override protected void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(Compra.ATRIBUTO_ID_COMPRA, MySqlDbType.Int32);
            comando.Parameters.Add(Compra.ATRIBUTO_DATETIME, MySqlDbType.String);
            comando.Parameters.Add(Compra.ATRIBUTO_ID_FORNECEDOR, MySqlDbType.Int32);
            comando.Parameters.Add(Compra.ATRIBUTO_TOTAL_COMPRA, MySqlDbType.Int32);
            comando.Parameters.Add(Compra.ATRIBUTO_SITUACAO_COMPRA, MySqlDbType.String);
        }

        override protected void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(Compra.ATRIBUTO_ID_COMPRA, MySqlDbType.Int32);
        }
        }
    }
