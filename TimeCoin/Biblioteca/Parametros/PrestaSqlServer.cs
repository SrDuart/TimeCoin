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
                string sql = "insert into Presta (Id_usuario, Id_servico, quantidadeHora, avaliacao) values (@Id_usuario, @Id_servico, @quantidadeHora, @avaliacao)";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@id_usuario", SqlDbType.Int);
                cmd.Parameters["@id_usuario"].Value = presta.usuario.id;

                cmd.Parameters.Add("@id_servico", SqlDbType.Int);
                cmd.Parameters["@id_servico"].Value = presta.servico.id;

                cmd.Parameters.Add("@quantidadeHora", SqlDbType.Int);
                cmd.Parameters["@quantidadeHora"].Value = presta.quantidadeHora;

                cmd.Parameters.Add("@avaliacao", SqlDbType.Decimal);
                cmd.Parameters["@avaliacao"].Value = presta.avaliacao;
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

        public void Update(Presta presta)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "update Presta set quantidadeHora = @quantidadeHora and avaliacao = @avaliacao where Id_usuario = @Id_usuario and Id_servico = @Id_servico";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@Id_usuario", SqlDbType.Int);
                cmd.Parameters["@Id_usuario"].Value = presta.usuario.id;

                cmd.Parameters.Add("@Id_servico", SqlDbType.Int);
                cmd.Parameters["@Id_servico"].Value = presta.servico.id;

                cmd.Parameters.Add("@quantidadeHora", SqlDbType.Int);
                cmd.Parameters["@quantidadeHora"].Value = presta.quantidadeHora;

                cmd.Parameters.Add("@avaliacao", SqlDbType.Decimal);
                cmd.Parameters["@avaliacao"].Value = presta.avaliacao;
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
                throw new Exception("Erro ao conectar e alterar serviço prestado pelo usuário." + ex.Message);
            }
        }
            
        public void Delete(Presta presta)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "delete from Presta where Id_usuario = @Id_usuario and Id_servico = @Id_servico";
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
        
        public bool VerificaDuplicidade(Presta presta)
        {
            bool retorno = false;
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "SELECT quantidadeHora, avaliacao from Presta where Id_usuario = @Id_usuario and Id_servico = @Id_servico";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, sqlConexao);
                #endregion
                
                #region passar parametros
                cmd.Parameters.Add("@quantidadeHora", SqlDbType.Int);
                cmd.Parameters["@quantidadeHora"].Value = presta.quantidadeHora;

                cmd.Parameters.Add("@avaliacao", SqlDbType.Decimal);
                cmd.Parameters["@avaliacao"].Value = presta.avaliacao;

                cmd.Parameters.Add("@Id_usuario", SqlDbType.Int);
                cmd.Parameters["@Id_usuario"].Value = presta.usuario.id;

                cmd.Parameters.Add("@Id_servico", SqlDbType.Int);
                cmd.Parameters["@Id_servico"].Value = presta.servico.id;
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
                throw new Exception("Erro! Este serviço prestado pelo usuário já existe." + ex.Message);
            }
            return retorno;
        }

        public List<Presta> Select(Presta filtro)
        {
            List<Presta> retorno = new List<Presta>();
            try
            {
                #region instrucao a ser executada
                this.abrirConexao();
                string sql = "SELECT * from Presta";
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
                    presta.quantidadeHora = DbReader.GetInt32(DbReader.GetOrdinal("quantidadeHora"));
                    presta.avaliacao = DbReader.GetDouble(DbReader.GetOrdinal("avaliacao"));
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
