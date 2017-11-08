using Biblioteca.ConexaoBanco;
using Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.ClassesBasicas;
using System.Data.SqlClient;
using System.Data;

namespace Biblioteca.Parametros
{
    class AnuncioSqlServer : ConexaoSqlServer, IAnuncio
    {
        public void Delete(Anuncio anuncio)
        {
            try
            {
                #region abrir conexao
                this.abrirConexao();
                string sql = "DELETE from Anuncio where Id = @id";
                #endregion

                #region instrucao a ser passada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passando parametros
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = anuncio.id;
                #endregion

                #region executando instrucao
                cmd.ExecuteNonQuery();
                #endregion

                #region liberando a memoria 
                cmd.Dispose();
                #endregion

                #region fechando a conexao
                this.fecharConexao();
                #endregion
            }
            catch(Exception e)
            {
                throw new Exception("Erro ao excluir o Anuncio. " + e.Message);
            }
        }

        public void Insert(Anuncio anuncio)
        {
            try
            {

            }
            catch
            {

            }
        }

        public List<Anuncio> Select(Anuncio filtro)
        {
            throw new NotImplementedException();
        }

        public void Update(Anuncio anuncio)
        {
            throw new NotImplementedException();
        }

        public bool VerificaDuplicidade(Anuncio anuncio)
        {
            throw new NotImplementedException();
        }
    }
}
