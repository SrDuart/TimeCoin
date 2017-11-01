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
                string sql = "insert into Recebe (id_usuario, id_servico, quantidadeHora, avaliacao) values (@id_usuario, @id_servico, @quantidadeHora, @avaliacao)";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@id_usuario", SqlDbType.VarChar);
                cmd.Parameters["@id_usuario"].Value = recebe.usuario.id;

                cmd.Parameters.Add("@id_servico", SqlDbType.VarChar);
                cmd.Parameters["@id_servico"].Value = recebe.servico.id;

                cmd.Parameters.Add("@quantidadeHora", SqlDbType.VarChar);
                cmd.Parameters["@quantidadeHora"].Value = recebe.quantidadeHora;

                cmd.Parameters.Add("@avaliacao", SqlDbType.VarChar);
                cmd.Parameters["@avaliacao"].Value = recebe.avaliacao;
                #endregion

                #region executando a instrucao 
                cmd.ExecuteNonQuery();
                #endregion

                #region liberando a memoria 
                cmd.Dispose();
                #endregion

                #region fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e inserir serviço recebido pelo usuário." + ex.Message);
            }
            #endregion
        }

        public void Update(Recebe recebe)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "update Recebe set quantidadeHora = @quantidadeHora and avaliacao = @avaliacao where servico = @servico";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@servico", SqlDbType.Int);
                cmd.Parameters["@servico"].Value = recebe.servico.id;

                cmd.Parameters.Add("@quantidadeHora", SqlDbType.Int);
                cmd.Parameters["@quantidadeHora"].Value = recebe.quantidadeHora;

                cmd.Parameters.Add("@avaliacao", SqlDbType.VarChar);
                cmd.Parameters["@avaliacao"].Value = recebe.avaliacao;
                #endregion

                #region executando a instrucao 
                cmd.ExecuteNonQuery();
                #endregion

                #region liberando a memoria 
                cmd.Dispose();
                #endregion

                #region fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e alterar serviço recebido pelo usuário. " + ex.Message);
            }
            #endregion
        }

        public void Delete(Recebe recebe)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "delete from Recebe where servico = @servico";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@servico", SqlDbType.Int);
                cmd.Parameters["@servico"].Value = recebe.servico.id;
                #endregion

                #region executando a instrucao 
                cmd.ExecuteNonQuery();
                #endregion

                #region liberando a memoria 
                cmd.Dispose();
                #endregion

                #region fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e excluir serviço recebido pelo usuário." + ex.Message);
            }
            #endregion
        }

        public bool VerificaDuplicidade(Recebe recebe)
        {
            bool retorno = false;
            //try
            //{
            //    this.abrirConexao();
            //    //instrucao a ser executada
            //    string sql = "SELECT nome, descricao from atividade where nome = " + atividade.nome;
            //    SqlCommand cmd = new SqlCommand(sql, sqlConexao);
            //    //executando a instrucao e colocando o resultado em um leitor
            //    SqlDataReader DbReader = cmd.ExecuteReader();
            //    //lendo o resultado da consulta
            //    while (DbReader.Read())
            //    {
            //        retorno = true;
            //        break;
            //    }
            //    //fechando o leitor de resultados
            //    DbReader.Close();
            //    //liberando a memoria 
            //    cmd.Dispose();
            //    //fechando a conexao
            //    this.fecharConexao();
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception("Erro ao conectar e selecionar serviço recebido pelo usuário. " + ex.Message);
            //}
            return retorno;
        }

        public List<Recebe> Select(Recebe filtro)
        {
            List<Recebe> retorno = new List<Recebe>();
            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                string sql = "SELECT id_usuario, id_servico, quantidadeHora, avaliacao from Recebe";
                                
                SqlCommand cmd = new SqlCommand(sql, sqlConexao);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Recebe recebe = new Recebe();
                    //acessando os valores das colunas do resultado
                    recebe.usuario.id = DbReader.GetInt32(DbReader.GetOrdinal("id_usuario"));
                    recebe.servico.id = DbReader.GetInt32(DbReader.GetOrdinal("id_servico"));
                    recebe.quantidadeHora = DbReader.GetInt32(DbReader.GetOrdinal("quantidadeHora"));
                    recebe.avaliacao = DbReader.GetDouble(DbReader.GetOrdinal("avaliacao"));
                    retorno.Add(recebe);
                }
                //fechando o leitor de resultados
                DbReader.Close();
                //liberando a memoria 
                cmd.Dispose();
                //fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e selecionar serviço recebido pelo usuário." + ex.Message);
            }
            return retorno;
        }
    }
}
