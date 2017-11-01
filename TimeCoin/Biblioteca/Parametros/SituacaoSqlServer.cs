using Biblioteca.ConexaoBanco;
using Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.ClassesBasicas;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca.Parametros
{
    public class SituacaoSqlServer : ConexaoSqlServer, ISituacao
    {
        public void Delete(Situacao situacao)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "delete from Situacao where id = @id";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = situacao.id;
                #endregion

                #region executando a instrucao 
                cmd.ExecuteNonQuery();
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
                throw new Exception("Erro ao conectar e excluir a situação. " + ex.Message);
            }
        }

        public void Insert(Situacao situacao)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "insert into Situacao (nome, descricao) values (@nome, @descricao)";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = situacao.status;

                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                cmd.Parameters["@descricao"].Value = situacao.descricao;
                #endregion

                #region executando a instrucao 
                cmd.ExecuteNonQuery();
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
                throw new Exception("Erro ao conectar e inserir situação. " + ex.Message);
            }
        }

        public List<Situacao> Select(Situacao filtro)
        {
            List<Situacao> retorno = new List<Situacao>();
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "SELECT id, nome, descricao from Situacao ";
                #endregion
                
                if (filtro.descricao != null && !filtro.descricao.Trim().Equals(""))
                {
                    sql += " and descricao like '%" + filtro.descricao + "%'";
                }

                SqlCommand cmd = new SqlCommand(sql, sqlConexao);                
                SqlDataReader DbReader = cmd.ExecuteReader();
                
                while (DbReader.Read())
                {
                    Situacao situacao = new Situacao();                    
                    situacao.id = DbReader.GetInt32(DbReader.GetOrdinal("id"));
                    situacao.status = DbReader.GetString(DbReader.GetOrdinal("nome"));
                    situacao.descricao = DbReader.GetString(DbReader.GetOrdinal("descricao"));
                    retorno.Add(situacao);
                }
                
                DbReader.Close();

                cmd.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e selecionar a situação." + ex.Message);
            }
            return retorno;
        }

        public void Update(Situacao situacao)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "update Situacao set descricao = @descricao where id = @id";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = situacao.id;

                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = situacao.status;

                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                cmd.Parameters["@descricao"].Value = situacao.descricao;
                #endregion

                #region executando a instrucao 
                cmd.ExecuteNonQuery();
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
                throw new Exception("Erro ao conectar e alterar a situação. " + ex.Message);
            }
        }

        public bool VerificaDuplicidade(Situacao situacao)
        {
            bool retorno = false;
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "SELECT id, nome, descricao from Situacao where nome = " + situacao.descricao;
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, sqlConexao);
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
                throw new Exception("Erro ao conectar e selecionar a situacao. " + ex.Message);
            }
            return retorno;
        }
    }
}
