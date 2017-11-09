using Biblioteca.ClassesBasicas;
using Biblioteca.ConexaoBanco;
using Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca.Parametros
{
    public class TipoUsuarioSqlServer : ConexaoSqlServer, ITipoUsuario
    {        
        public void Insert(TipoUsuario tipoUsuario)
        {
            try
            { 
                #region abrir a conexão
                this.abrirConexao();
                string sql = "INSERT INTO TipoUsuario (descricao) VALUES (@descricao)";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                cmd.Parameters["@descricao"].Value = tipoUsuario.descricao;
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
                throw new Exception("Erro ao conectar e inserir Tipo de usuário. " + ex.Message);
            }
        }

        public void Update(TipoUsuario tipoUsuario)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "UPDATE TipoUsuario SET descricao = @descricao WHERE id = @id";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = tipoUsuario.id;

                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                cmd.Parameters["@descricao"].Value = tipoUsuario.descricao;
                #endregion

                #region executando a instrucao 
                cmd.ExecuteNonQuery();
                #endregion

                #region liberando a memoria e fechando conexão
                cmd.Dispose();              
                this.fecharConexao();
                #endregion
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e atualizar Tipo de usuário. " + ex.Message);
            }
            
        }

        public void Delete(TipoUsuario tipoUsuario)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "DELETE FROM TipoUsuario WHERE id = @id";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = tipoUsuario.id;
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
                throw new Exception("Erro ao conectar e excluir Tipo de usuário. " + ex.Message);
            }
            
        }

        public bool VerificaDuplicidade(TipoUsuario tipoUsuario)
        {
            bool retorno = false;
			try
			{
                #region abrir a conexão
                this.abrirConexao();				
				string sql = "SELECT descricao FROM TipoUsuario WHERE id = @id";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, sqlConexao);                
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = tipoUsuario.id;                
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
				throw new Exception("Erro! Este tipo de usuário já existe." + ex.Message);
			}
			return retorno;
        }

        public List<TipoUsuario> Select(TipoUsuario filtro)
        {
            List<TipoUsuario> retorno = new List<TipoUsuario>();
            try
            {
                #region abrir a conexão
                this.abrirConexao();                
                string sql = "SELECT * FROM TipoUsuario";
                #endregion
                
                SqlCommand cmd = new SqlCommand(sql, sqlConexao);                
                SqlDataReader DbReader = cmd.ExecuteReader();
                
                while (DbReader.Read())
                {
                    TipoUsuario tipoUsuario = new TipoUsuario();                    
                    tipoUsuario.id = DbReader.GetInt32(DbReader.GetOrdinal("id"));
                    tipoUsuario.descricao = DbReader.GetString(DbReader.GetOrdinal("descricao"));
                    retorno.Add(tipoUsuario);
                }               
                DbReader.Close();

                cmd.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e selecionar Tipo de usuário." + ex.Message);
            }
            return retorno;
        }
    }
}
