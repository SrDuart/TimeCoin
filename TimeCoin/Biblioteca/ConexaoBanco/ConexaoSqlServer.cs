using System;
using System.Data.SqlClient;

namespace Biblioteca.ConexaoBanco
{
    public class ConexaoSqlServer
    {
        #region Variáveis
        public SqlConnection sqlConexao;

        private const String usuario = "aluno";
        private const String senha = "aluno";
        private const String banco = "TimeCoin";
        private const String localhost = "localhost";
        #endregion

        #region String de Conexão
        private String stringConexaoSqlServer = @"Data Source = " + localhost + "; Initial Catalog = " + banco + "; UId = " + usuario + "; Password = " + senha + ";";
        #endregion

        #region Abrir Conexão
        public void abrirConexao()
        {
            this.sqlConexao = new SqlConnection(stringConexaoSqlServer);
            this.sqlConexao.Open();
        }
        #endregion

        #region Fechar Conexão
        public void fecharConexao()
        {
            sqlConexao.Close();
            sqlConexao.Dispose();
        }
        #endregion
    }
}
