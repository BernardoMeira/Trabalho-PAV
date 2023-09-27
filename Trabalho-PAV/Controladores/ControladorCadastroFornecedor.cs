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
    public class ControladorCadastroFornecedor : ControladorCadastro
    {
        override protected string criarComandoSelecao()
        {
            return "SELECT * FROM FORNECEDOR WHERE ID_FORNECEDOR = @ID_FORNECEDOR";
        }

        override protected string criarComandoInclusao()
        {
            return "INSERT INTO FORNECEDOR VALUES(@ID_FORNECEDOR, @NOME, @CPF_CNPJ, @LOGRADOURO," +
                                             " @NUMERO, @COMPLEMENTO, @BAIRRO, @CIDADE, " +
                                             " @ESTADO, @CEP, @TELEFONE, @EMAIL)";
        }
        override protected string criarComandoAtualizacao()
        {
            return " UPDATE FORNECEDOR " +
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
                   " WHERE  ID_FORNECEDOR = @ID_FORNECEDOR";
        }
        override protected string criarComandoExclusao()
        {
            return "DELETE FROM FORNECEDOR WHERE ID_FORNECEDOR = @ID_FORNECEDOR";
        }

        override protected void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(Fornecedor.ATRIBUTO_ID_FORNECEDOR, MySqlDbType.Int32);
            comando.Parameters.Add(Fornecedor.ATRIBUTO_NOME, MySqlDbType.String);
            comando.Parameters.Add(Fornecedor.ATRIBUTO_CPF_CNPJ, MySqlDbType.String);
            comando.Parameters.Add(Fornecedor.ATRIBUTO_LOGRADOURO, MySqlDbType.String);
            comando.Parameters.Add(Fornecedor.ATRIBUTO_NUMERO, MySqlDbType.Int32);
            comando.Parameters.Add(Fornecedor.ATRIBUTO_COMPLEMENTO, MySqlDbType.String);
            comando.Parameters.Add(Fornecedor.ATRIBUTO_BAIRRO, MySqlDbType.String);
            comando.Parameters.Add(Fornecedor.ATRIBUTO_CIDADE, MySqlDbType.String);
            comando.Parameters.Add(Fornecedor.ATRIBUTO_ESTADO, MySqlDbType.String);
            comando.Parameters.Add(Fornecedor.ATRIBUTO_CEP, MySqlDbType.String);
            comando.Parameters.Add(Fornecedor.ATRIBUTO_EMAIL, MySqlDbType.String);
            comando.Parameters.Add(Fornecedor.ATRIBUTO_TELEFONE, MySqlDbType.String);
        }

        override protected void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(Fornecedor.ATRIBUTO_ID_FORNECEDOR, MySqlDbType.Int32);
        }

    }
}