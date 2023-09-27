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
    public class ControladorCadastroFormaPagamentoVenda : ControladorCadastro
    {
        override protected string criarComandoSelecao()
        {
            return "SELECT * FROM FORMAPAGAMENTOVENDA WHERE ID_VENDA = @ID_VENDA";
        }

        override protected string criarComandoInclusao()
        {
            return "INSERT INTO FORMAPAGAMENTOVENDA VALUES(@ID_VENDA, @ID_FORMAPAGAMENTOVENDA, @VALOR)";
        }
        override protected string criarComandoAtualizacao()
        {
            return " UPDATE FORMAPAGAMENTOVENDA " +
                   " SET    ID_FORMAPAGAMENTOVENDA = @ID_FORMAPAGAMENTOVENDA, " +
                   "        VALOR, " + 
                   " WHERE  ID_VENDA = @ID_VENDA";
        }
        override protected string criarComandoExclusao()
        {
            return "DELETE FROM FORMAPAGAMENTOVENDA WHERE ID_VENDA = @ID_VENDA";
        }

        override protected void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(FormaPagamentoVenda.ATRIBUTO_ID_VENDA, MySqlDbType.Int32);
            comando.Parameters.Add(FormaPagamentoVenda.ATRIBUTO_ID_FORMA_PAGAMENTO_VENDA, MySqlDbType.Int32);
            comando.Parameters.Add(FormaPagamentoVenda.ATRIBUTO_VALOR, MySqlDbType.Float);

        }

        override protected void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(FormaPagamentoVenda.ATRIBUTO_ID_VENDA, MySqlDbType.Int32);
        }

    }
}
