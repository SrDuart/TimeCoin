using Biblioteca.ConexaoBanco;
using Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
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
                string sql = "DELETE FROM Situacao WHERE id = @id";
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

                #region liberando a memoria e fechando a conexao
                cmd.Dispose();
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
                string sql = "INSERT INTO Situacao (nome, descricao) VALUES (@nome, @descricao)";
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

                #region liberando a memoria e  fechando a conexão
                cmd.Dispose();                
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
                this.abrirConexao();
                string sql = "SELECT * FROM situacao";

                SqlCommand cmd = new SqlCommand(sql, sqlConexao);
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    Situacao situacao = new Situacao();
                    situacao.id = DbReader.GetInt32(DbReader.GetOrdinal("id"));
                    situacao.status = DbReader.GetString(DbReader.GetOrdinal("status"));
                    situacao.descricao = DbReader.GetString(DbReader.GetOrdinal("descricao"));                    
                    retorno.Add(situacao);
                }
                DbReader.Close();
                cmd.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e selecionar uma situação." + ex.Message);
            }
            return retorno;
        }

        public void Update(Situacao situacao)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "UPDATE Situacao SET status = @status, descricao = @descricao WHERE id = @id";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = situacao.id;

                cmd.Parameters.Add("@status", SqlDbType.VarChar);
                cmd.Parameters["@status"].Value = situacao.status;

                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                cmd.Parameters["@descricao"].Value = situacao.descricao;
                #endregion

                #region executando a instrucao 
                cmd.ExecuteNonQuery();
                #endregion

                #region liberando a memoria e  fechando a conexão
                cmd.Dispose();
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
                string sql = "SELECT status, descricao FROM Situacao WHERE id = @id";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = situacao.id;

                cmd.Parameters.Add("@status", SqlDbType.VarChar);
                cmd.Parameters["@status"].Value = situacao.status;

                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                cmd.Parameters["@descricao"].Value = situacao.descricao;
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

                #region liberando a memoria e fechando a conexao
                cmd.Dispose();
                this.fecharConexao();
                #endregion
            }
            catch (Exception ex)
            {
                throw new Exception("Erro! Este tipo de situação já existe." + ex.Message);
            }
            return retorno;
        }            
    }
}
