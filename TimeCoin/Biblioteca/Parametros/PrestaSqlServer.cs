using Biblioteca.ClassesBasicas;
using Biblioteca.ConexaoBanco;
using Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca.Parametros
{
    public class PrestaSqlServer : ConexaoSqlServer, IPresta
    {
        public void Insert(Presta presta)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "INSERT INTO Presta (Id_usuario, Id_servico, QtdHora, avaliacao, data) ";
                sql += "VALUES (@Id_usuario, @Id_servico, @qtdHora, @avaliacao, @data)";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@id_usuario", SqlDbType.Int);
                cmd.Parameters["@id_usuario"].Value = presta.usuario.id;

                cmd.Parameters.Add("@id_servico", SqlDbType.Int);
                cmd.Parameters["@id_servico"].Value = presta.servico.id;

                cmd.Parameters.Add("@qtdHora", SqlDbType.Int);
                cmd.Parameters["@qtdHora"].Value = presta.qtdHora;

                cmd.Parameters.Add("@avaliacao", SqlDbType.Decimal);
                cmd.Parameters["@avaliacao"].Value = presta.avaliacao;

                cmd.Parameters.Add("@data", SqlDbType.DateTime);
                cmd.Parameters["@data"].Value = DateTime.Now;
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
                throw new Exception("Erro ao conectar e inserir serviço prestado pelo usuário. " + ex.Message);
            }
        }        
            
        public void Delete(Presta presta)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "DELETE FROM Presta WHERE Id_usuario = @Id_usuario, Id_servico = @Id_servico";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@Id_usuario", SqlDbType.Int);
                cmd.Parameters["@Id_usuario"].Value = presta.usuario.id;

                cmd.Parameters.Add("@Id_servico", SqlDbType.Int);
                cmd.Parameters["@Id_servico"].Value = presta.servico.id;
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
                throw new Exception("Erro ao conectar e excluir serviço prestado pelo usuário." + ex.Message);
            }
        }     
        
        public List<Presta> Select(Presta filtro)
        {
            List<Presta> retorno = new List<Presta>();
            try
            {
                #region instrucao a ser executada
                this.abrirConexao();
                string sql = "SELECT * FROM Presta";
                #endregion

                #region executando instrucao e colocando o resultado em um leitor e lendo o resultado da consulta
                SqlCommand cmd = new SqlCommand(sql, sqlConexao);
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                #endregion

                {
                    #region acessando os valores das colunas do resultado
                    Presta presta = new Presta();
                    presta.usuario.id = DbReader.GetInt32(DbReader.GetOrdinal("Id_usuario"));
                    presta.servico.id = DbReader.GetInt32(DbReader.GetOrdinal("Id_servico"));
                    presta.qtdHora = DbReader.GetInt32(DbReader.GetOrdinal("quantidadeHora"));
                    presta.avaliacao = DbReader.GetDouble(DbReader.GetOrdinal("avaliacao"));
                    presta.data = DbReader.GetDateTime(DbReader.GetOrdinal("data"));
                    retorno.Add(presta);
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
                throw new Exception("Erro ao conectar e selecionar serviço prestado pelo usuário." + ex.Message);
            }
            return retorno;
        }
    }
}
