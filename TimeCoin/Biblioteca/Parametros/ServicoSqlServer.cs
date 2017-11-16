using Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using Biblioteca.ClassesBasicas;
using Biblioteca.ConexaoBanco;
using System.Data.SqlClient;
using System.Data;

namespace Biblioteca.Parametros
{
    public class ServicoSqlServer : ConexaoSqlServer, IServico
    {
        public void Insert(Servico servico)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "INSERT INTO Servico (nome, Id_Situacao) VALUES (@nome, @Id_Situacao)";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = servico.nome;

                cmd.Parameters.Add("@Id_Situacao", SqlDbType.Int);
                cmd.Parameters["@Id_Situacao"].Value = servico.situacao.id;
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
                throw new Exception("Erro ao conectar e inserir um serviço." + ex.Message);
            }
        }

        public void Update(Servico servico)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "UPDATE Servico SET nome = @nome, Id_Situacao = @Id_Situacao WHERE id = @id";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = servico.id;

                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = servico.nome;

                cmd.Parameters.Add("@Id_Situacao", SqlDbType.VarChar);
                cmd.Parameters["@Id_Situacao"].Value = servico.situacao.id;
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
                throw new Exception("Erro ao conectar e alterar um serviço." + ex.Message);
            }
        }

        public void Delete(Servico servico)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "DELETE FROM Servico WHERE id = @id";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = servico.id;
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
                throw new Exception("Erro ao conectar e excluir um serviço." + ex.Message);
            }
        }

        public bool VerificaDuplicidade(Servico servico)
        {
            bool retorno = false;
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "SELECT nome FROM Servico WHERE id = @id";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = servico.id;

                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = servico.nome;                
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
                throw new Exception("Erro! Este tipo de serviço já existe." + ex.Message);
            }
            return retorno;
        }

        public List<Servico> Select(Servico filtro)
        {
            List<Servico> retorno = new List<Servico>();
            try
            {
                this.abrirConexao();
                string sql = "SELECT * FROM Servico";

                SqlCommand cmd = new SqlCommand(sql, sqlConexao);
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    Servico servico = new Servico();
                    servico.id = DbReader.GetInt32(DbReader.GetOrdinal("id"));
                    servico.nome = DbReader.GetString(DbReader.GetOrdinal("nome"));
                    servico.situacao.id = DbReader.GetInt32(DbReader.GetOrdinal("Id_Situacao"));
                    retorno.Add(servico);
                }
                DbReader.Close();
                cmd.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e selecionar um serviço." + ex.Message);
            }
            return retorno;
        }
    }
}
