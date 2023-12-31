﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TrabalhoPAV.Persistencia;
using TrabalhoPAV.Entidades;
using MySql.Data.MySqlClient;

namespace TrabalhoPAV.Controladores
{
    public class ControladorCadastroFormaPagamento : ControladorCadastro
    {
        override protected string criarComandoSelecao()
        {
            return "SELECT * FROM FORMAPAGAMENTO WHERE ID_FORMA_PAGAMENTO = @ID_FORMA_PAGAMENTO";
        }

        override protected string criarComandoInclusao()
        {
            return "INSERT INTO FORMAPAGAMENTO VALUES(@ID_FORMA_PAGAMENTO, @NOME)";
        }
        override protected string criarComandoAtualizacao()
        {
            return " UPDATE FORMAPAGAMENTO " +
                   " SET    NOME = @NOME, " +
                   " WHERE  ID_FORMA_PAGAMENTO = @ID_FORMA_PAGAMENTO";
        }
        override protected string criarComandoExclusao()
        {
            return "DELETE FROM FORMAPAGAMENTO WHERE ID_FORMA_PAGAMENTO = @ID_FORMA_PAGAMENTO";
        }

        override protected void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(FormaPagamento.ATRIBUTO_ID_FORMA_PAGAMENTO, MySqlDbType.Int32);
            comando.Parameters.Add(FormaPagamento.ATRIBUTO_NOME, MySqlDbType.String);
        }

        override protected void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(FormaPagamento.ATRIBUTO_ID_FORMA_PAGAMENTO, MySqlDbType.Int32);
        }

    }
}
