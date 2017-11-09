using Biblioteca.ClassesBasicas;
using Biblioteca.ConexaoBanco;
using Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca.Parametros
{
    public class RecebeSqlServer : ConexaoSqlServer, IRecebe
    {
        public void Insert(Recebe recebe)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "INSERT INTO Recebe (Id_usuario, Id_servico, qtdHora, avaliacao, data) ";
                sql += "VALUES (@Id_usuario, @Id_servico, @qtdHora, @avaliacao, @data)";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@id_usuario", SqlDbType.Int);
                cmd.Parameters["@id_usuario"].Value = recebe.usuario.id;

                cmd.Parameters.Add("@id_servico", SqlDbType.Int);
                cmd.Parameters["@id_servico"].Value = recebe.servico.id;

                cmd.Parameters.Add("@qtdHora", SqlDbType.Int);
                cmd.Parameters["@qtdHora"].Value = recebe.qtdHora;

                cmd.Parameters.Add("@avaliacao", SqlDbType.DateTime);
                cmd.Parameters["@avaliacao"].Value = recebe.avaliacao;

                cmd.Parameters.Add("@data", SqlDbType.DateTime);
                cmd.Parameters["@data"].Value = recebe.data;
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
                throw new Exception("Erro ao conectar e inserir serviço recebido pelo usuário." + ex.Message);
            }
        }      

        public void Delete(Recebe recebe)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "DELETE FROM Recebe WHERE Id_usuario = @Id_usuario and Id_servico = @Id_servico";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@Id_usuario", SqlDbType.Int);
                cmd.Parameters["@Id_usuario"].Value = recebe.servico.id;

                cmd.Parameters.Add("@Id_servico", SqlDbType.Int);
                cmd.Parameters["@Id_servico"].Value = recebe.servico.id;
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
                throw new Exception("Erro ao conectar e excluir serviço recebido pelo usuário." + ex.Message);
            }
        }      
        
        public List<Recebe> Select(Recebe filtro)
        {
            List<Recebe> retorno = new List<Recebe>();
            try
            {
                #region instrucao a ser executada
                this.abrirConexao();              
                string sql = "SELECT * FROM Recebe";
                #endregion

                #region executando instrucao e colocando o resultado em um leitor e lendo o resultado da consulta
                SqlCommand cmd = new SqlCommand(sql, sqlConexao);                
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                #endregion

                {
                    #region acessando os valores das colunas do resultado
                    Recebe recebe = new Recebe();                    
                    recebe.usuario.id = DbReader.GetInt32(DbReader.GetOrdinal("Id_usuario"));
                    recebe.servico.id = DbReader.GetInt32(DbReader.GetOrdinal("Id_servico"));
                    recebe.qtdHora = DbReader.GetInt32(DbReader.GetOrdinal("qtdHora"));
                    recebe.avaliacao = DbReader.GetDouble(DbReader.GetOrdinal("avaliacao"));
                    recebe.data = DbReader.GetDateTime(DbReader.GetOrdinal("data"));
                    retorno.Add(recebe);
                    #endregion
                }

                #region fechando o leitor de resultados
                DbReader.Close();
                #endregion

                #region liberando a memoria e fechando a conexao
                cmd.Dispose();
                this.fecharConexao();
                #endregion
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e selecionar serviço recebido pelo usuário." + ex.Message);
            }
            return retorno;
        }
    }
}
