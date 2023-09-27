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
    public class ControladorCadastroCaixa : ControladorCadastro
    {
        override protected string criarComandoSelecao()
        {
            return "SELECT * FROM CAIXA WHERE ID_CAIXA = @ID_CAIXA";
        }

        override protected string criarComandoInclusao()
        {
            return "INSERT INTO CAIXA VALUES(@ID_CAIXA, @NOME, @SALDO)";
        }
        override protected string criarComandoAtualizacao()
        {
            return " UPDATE CAIXA " +
                   " SET    NOME = @NOME, " +
                   "        SALDO = @SALDO, " +
                   " WHERE  ID_CAIXA = @ID_CAIXA";
        }
        override protected string criarComandoExclusao()
        {
            return "DELETE FROM CAIXA WHERE ID_CAIXA = @ID_CAIXA";
        }

        override protected void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(Caixa.ATRIBUTO_ID_CAIXA, MySqlDbType.Int32);
            comando.Parameters.Add(Caixa.ATRIBUTO_NOME, MySqlDbType.String);
            comando.Parameters.Add(Caixa.ATRIBUTO_SALDO, MySqlDbType.Float);
        }

        override protected void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(Caixa.ATRIBUTO_ID_CAIXA, MySqlDbType.Int32);
        }

    }
}
