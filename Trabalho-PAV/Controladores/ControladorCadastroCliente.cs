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
    public class ControladorCadastroCliente : ControladorCadastro
    {
        override protected string criarComandoSelecao()
        {
            return "SELECT * FROM CLIENTE WHERE ID_CLIENTE = @ID_CLIENTE";
        }

        override protected string criarComandoInclusao()
        {
            return "INSERT INTO CLIENTE VALUES(@ID_CLIENTE, @NOME, @CPF_CNPJ, @LOGRADOURO," +
                                             " @NUMERO, @COMPLEMENTO, @BAIRRO, @CIDADE, " +
                                             " @ESTADO, @CEP, @TELEFONE, @EMAIL)";
        }
        override protected string criarComandoAtualizacao()
        {
            return " UPDATE CLIENTE " +
                   " SET    NOME = @NOME, " +
                   "        CPF_CNPJ = @CPF_CNPJ, " +
                   "        LOGRADOURO = @LOGRADOURO, " +
                   "        NUMERO = @NUMERO, " +
                   "        COMPLEMENTO = @COMPLEMENTO, " +
                   "        BAIRRO = @BAIRRO, " +
                   "        CIDADE = @CIDADE, " +
                   "        ESTADO = @ESTADO, " +
                   "        CEP = @CEP, " +
                   "        EMAIL = @EMAIL, " +
                   "        TELEFONE = @TELEFONE " +
                   " WHERE  ID_CLIENTE = @ID_CLIENTE";
        }
        override protected string criarComandoExclusao()
        {
            return "DELETE FROM CLIENTE WHERE ID_CLIENTE = @ID_CLIENTE";
        }

        override protected void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(Cliente.ATRIBUTO_ID_CLIENTE, MySqlDbType.Int32);
            comando.Parameters.Add(Cliente.ATRIBUTO_NOME, MySqlDbType.String);
            comando.Parameters.Add(Cliente.ATRIBUTO_CPF_CNPJ, MySqlDbType.String);
            comando.Parameters.Add(Cliente.ATRIBUTO_LOGRADOURO, MySqlDbType.String);
            comando.Parameters.Add(Cliente.ATRIBUTO_NUMERO, MySqlDbType.Int32);
            comando.Parameters.Add(Cliente.ATRIBUTO_COMPLEMENTO, MySqlDbType.String);
            comando.Parameters.Add(Cliente.ATRIBUTO_BAIRRO, MySqlDbType.String);
            comando.Parameters.Add(Cliente.ATRIBUTO_CIDADE, MySqlDbType.String);
            comando.Parameters.Add(Cliente.ATRIBUTO_ESTADO, MySqlDbType.String);
            comando.Parameters.Add(Cliente.ATRIBUTO_CEP, MySqlDbType.String);
            comando.Parameters.Add(Cliente.ATRIBUTO_EMAIL, MySqlDbType.String);
            comando.Parameters.Add(Cliente.ATRIBUTO_TELEFONE, MySqlDbType.String);
        }

        override protected void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(Cliente.ATRIBUTO_ID_CLIENTE, MySqlDbType.Int32);
        }

    }
}
