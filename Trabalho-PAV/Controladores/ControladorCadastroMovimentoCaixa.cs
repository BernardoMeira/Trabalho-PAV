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
    public class ControladorCadastroMovimentoCaixa : ControladorCadastro
    {
        override protected string criarComandoSelecao()
        {
            return "SELECT * FROM MOVIMENTOCAIXA WHERE ID_CAIXA = @ID_CAIXA";
        }

        override protected string criarComandoInclusao()
        {
            return "INSERT INTO MOVIMENTOCAIXA VALUES(@ID_CAIXA, @NUMERO_MOVIMENTO, @DATA_MOVIMENTO, @HORA_MOVIMENTO," +
                                             " @DESCRICAO, @TIPO_MOVIMENTO, @VALOR)";
        }
        override protected string criarComandoAtualizacao()
        {
            return " UPDATE MOVIMENTOCAIXA " +
                   " SET    NUMERO_MOVIMENTO = @NUMERO_MOVIMENTO, " +
                   "        DATA_MOVIMENTO = @DATA_MOVIMENTO, " +
                   "        HORA_MOVIMENTO = @HORA_MOVIMENTO, " +
                   "        DESCRICAO = @DESCRICAO, " +
                   "        TIPO_MOVIMENTO = @TIPO_MOVIMENTO, " +
                   "        VALOR = @VALOR, " +
                   " WHERE  ID_CAIXA = @ID_CAIXA";
        }
        override protected string criarComandoExclusao()
        {
            return "DELETE FROM MOVIMENTOCAIXA WHERE ID_CAIXA = @ID_CAIXA";
        }

        override protected void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(MovimentoCaixa.ATRIBUTO_ID_CAIXA, MySqlDbType.Int32);
            comando.Parameters.Add(MovimentoCaixa.ATRIBUTO_NUMERO_MOVIMENTO, MySqlDbType.String);
            comando.Parameters.Add(MovimentoCaixa.ATRIBUTO_DATA_MOVIMENTO, MySqlDbType.Int32);
            comando.Parameters.Add(MovimentoCaixa.ATRIBUTO_HORA_MOVIMENTO, MySqlDbType.Int32);
            comando.Parameters.Add(MovimentoCaixa.ATRIBUTO_DESCRICAO, MySqlDbType.String);
            comando.Parameters.Add(MovimentoCaixa.ATRIBUTO_TIPO_MOVIMENTO, MySqlDbType.String);
            comando.Parameters.Add(MovimentoCaixa.ATRIBUTO_VALOR, MySqlDbType.String);
        }

        override protected void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(MovimentoCaixa.ATRIBUTO_ID_CAIXA, MySqlDbType.Int32);
        }

    }
}

