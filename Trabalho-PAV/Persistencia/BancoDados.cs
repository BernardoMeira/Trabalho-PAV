using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TrabalhoPAV.Persistencia
{
    public class BancoDados
    {
        private int porta = 3307;
        private string servidor = "localhost";
        private string nomeBancoDados = "bancodadospav";
        private MySqlConnection conexao;
        private static BancoDados instancia = null; 
        private MySqlTransaction transacao;

        private string criarStringConexao(string usuario, string senha)
        {
            return "server = " + servidor +
                   ";port = " + porta.ToString() +
                   ";database = " + nomeBancoDados +
                   ";user id = " + usuario +
                   ";password = " + senha +
                   ";convert zero datetime=True";
        }

        public void conectar(string usuario, string senha)
        {
            try
            {
                conexao = new MySqlConnection(criarStringConexao(usuario, senha));
                conexao.Open();
                MessageBox.Show("Conexão realizada com sucesso");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void conectar()
        {
            conectar("root", "usbw");
        }

        public void desconectar()
        {
            if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
                conexao.Dispose();
                MessageBox.Show("Desconectado!");
            } else {
                MessageBox.Show("Conexão não encontrada!");
            }
        }

        public MySqlConnection obterConexao()
        {
            return conexao;
        }


        public void iniciarTransacao()
        {
            transacao = conexao.BeginTransaction();
        }

        public void confirmarTransacao()
        {
            if (transacao != null)
            {
                transacao.Commit();
                transacao.Dispose();
            }
        }

        public void cancelarTransacao()
        {
            if (transacao != null)
            {
                transacao.Rollback();
                transacao.Dispose();
            }

        }

        public static BancoDados obterInstancia()
        {
            if (instancia == null)
            {
                instancia = new BancoDados();
            }
            return instancia;
        }

    }

}
