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
                string sql = "insert into Recebe (Id_usuario, Id_servico, quantidadeHora, avaliacao) values (@Id_usuario, @Id_servico, @quantidadeHora, @avaliacao)";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@id_usuario", SqlDbType.Int);
                cmd.Parameters["@id_usuario"].Value = recebe.usuario.id;

                cmd.Parameters.Add("@id_servico", SqlDbType.Int);
                cmd.Parameters["@id_servico"].Value = recebe.servico.id;

                cmd.Parameters.Add("@quantidadeHora", SqlDbType.Int);
                cmd.Parameters["@quantidadeHora"].Value = recebe.quantidadeHora;

                cmd.Parameters.Add("@avaliacao", SqlDbType.Decimal);
                cmd.Parameters["@avaliacao"].Value = recebe.avaliacao;
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

        public void Update(Recebe recebe)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "update Recebe set quantidadeHora = @quantidadeHora and avaliacao = @avaliacao where Id_usuario = @Id_usuario and Id_servico = @Id_servico";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@Id_usuario", SqlDbType.Int);
                cmd.Parameters["@Id_usuario"].Value = recebe.servico.id;

                cmd.Parameters.Add("@Id_servico", SqlDbType.Int);
                cmd.Parameters["@Id_servico"].Value = recebe.servico.id;

                cmd.Parameters.Add("@quantidadeHora", SqlDbType.Int);
                cmd.Parameters["@quantidadeHora"].Value = recebe.quantidadeHora;

                cmd.Parameters.Add("@avaliacao", SqlDbType.Decimal);
                cmd.Parameters["@avaliacao"].Value = recebe.avaliacao;
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
                throw new Exception("Erro ao conectar e alterar serviço recebido pelo usuário. " + ex.Message);
            }
        }

        public void Delete(Recebe recebe)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "delete from Recebe where Id_usuario = @Id_usuario and Id_servico = @Id_servico";
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
        
        public bool VerificaDuplicidade(Recebe recebe)
        {
            bool retorno = false;
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "SELECT quantidadeHora, avaliacao from Recebe where Id_usuario = @Id_usuario and Id_servico = @Id_servico";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, sqlConexao);
                #endregion
                
                #region passar parametros
                cmd.Parameters.Add("@quantidadeHora", SqlDbType.Int);
                cmd.Parameters["@quantidadeHora"].Value = recebe.quantidadeHora;

                cmd.Parameters.Add("@avaliacao", SqlDbType.Decimal);
                cmd.Parameters["@avaliacao"].Value = recebe.avaliacao;

                cmd.Parameters.Add("@Id_usuario", SqlDbType.Int);
                cmd.Parameters["@Id_usuario"].Value = recebe.usuario.id;

                cmd.Parameters.Add("@Id_servico", SqlDbType.Int);
                cmd.Parameters["@Id_servico"].Value = recebe.servico.id;
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
                throw new Exception("Erro! Este serviço recebido pelo usuário já existe." + ex.Message);
            }
            return retorno;
        }

        public List<Recebe> Select(Recebe filtro)
        {
            List<Recebe> retorno = new List<Recebe>();
            try
            {
                #region instrucao a ser executada
                this.abrirConexao();              
                string sql = "SELECT * from Recebe";
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
                    recebe.quantidadeHora = DbReader.GetInt32(DbReader.GetOrdinal("quantidadeHora"));
                    recebe.avaliacao = DbReader.GetDouble(DbReader.GetOrdinal("avaliacao"));
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
