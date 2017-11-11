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
    public class TipoAnuncioSqlServer : ConexaoSqlServer, ITipoAnuncio
    {
        public void Delete(TipoAnuncio tipoAnuncio)
        {
            try
            {
                #region abrir conexao
                this.abrirConexao();
                string sql = "DELETE from TipoAnuncio where Id = @id";
                #endregion

                #region instrucao a ser passada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passando parametros
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = tipoAnuncio.id;
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
            catch (Exception e)
            {
                throw new Exception("Erro ao excluir o tipo de Anúncio. " + e.Message);
            }
        }

        public void Insert(TipoAnuncio tipoAnuncio)
        {
            try
            {
                #region abrir conexão
                this.abrirConexao();
                string sql = "INSERT INTO TipoAnuncio " +
                    "(Descricao) " +
                    "VALUES (@descricao)";
                #endregion

                #region instrução a ser passada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passando parametros
                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                cmd.Parameters["@descricao"].Value = tipoAnuncio.descricao;
                #endregion

                #region executando a instrução
                cmd.ExecuteNonQuery();
                #endregion  

                #region liberando a memoria 
                cmd.Dispose();
                #endregion

                #region fechando a conexao
                this.fecharConexao();
                #endregion
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao inserir o Tipo de Anúncio. " + e.Message);
            }
        }

        public List<TipoAnuncio> Select(TipoAnuncio filtro)
        {
            List<TipoAnuncio> retorno = new List<TipoAnuncio>();
            try
            {
                this.abrirConexao();

                string sql = "SELECT * from TipoAnuncio";
                SqlCommand cmd = new SqlCommand(sql, sqlConexao);
                SqlDataReader DbReader = cmd.ExecuteReader();
                TipoAnuncio tipoAnuncio;
                while (DbReader.Read())
                {
                    tipoAnuncio = new TipoAnuncio();
                    tipoAnuncio.id = DbReader.GetInt32(DbReader.GetOrdinal("Id"));
                    tipoAnuncio.descricao = DbReader.GetString(DbReader.GetOrdinal("Descricao"));
                    retorno.Add(tipoAnuncio);
                }
                DbReader.Close();
                cmd.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao criar a listagem de Tipos de Anuncios." + ex.Message);
            }
            return retorno;
        }

        public void Update(TipoAnuncio tipoAnuncio)
        {
            try
            {
                #region abrir conexão
                this.abrirConexao();
                string sql = "UPDATE TipoAnuncio SET" +
                    " Descricao = @descricao WHERE Id = @Id";
                #endregion

                #region instrução a ser passada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passando parametros  
                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                cmd.Parameters["@descricao"].Value = tipoAnuncio.descricao;

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = tipoAnuncio.id;
                #endregion

                #region executando a instrução
                cmd.ExecuteNonQuery();
                #endregion  

                #region liberando a memoria 
                cmd.Dispose();
                #endregion

                #region fechando a conexao
                this.fecharConexao();
                #endregion
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao atualizar o Tipo Anúncio. " + e.Message);
            }
        }

        public bool VerificaDuplicidade(TipoAnuncio tipoAnuncio)
        {
            bool retorno = false;
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "SELECT * from Anuncio WHERE Descricao = @descricao ";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, sqlConexao);

                #endregion
                #region passar parametros
                cmd.Parameters.Add("@descricao", SqlDbType.Date);
                cmd.Parameters["@descricao"].Value = tipoAnuncio.descricao;
                #endregion

                #region instrucao a ser executada
                SqlDataReader DbReader = cmd.ExecuteReader();
                #endregion

                #region executando a instrucao 
                while (DbReader.Read())
                {
                    retorno = true;
                    break;
                }
                DbReader.Close();
                #endregion

                #region liberando a memoria 
                cmd.Dispose();
                #endregion

                #region fechando a conexao
                this.fecharConexao();
                #endregion
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao verificar a duplicidade do tipo de anuncio. " + ex.Message);
            }
            return retorno;
        }
    }
}
