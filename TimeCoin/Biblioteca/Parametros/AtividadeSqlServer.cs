using Biblioteca.ClassesBasicas;
using Biblioteca.ConexaoBanco;
using Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca.Parametros
{
    public class AtividadeSqlServer : ConexaoSqlServer, IAtividade
    {
        public void Insert(Atividade atividade)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "insert into Atividade (nome, descricao) values (@nome, @descricao)";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = atividade.nome;

                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                cmd.Parameters["@descricao"].Value = atividade.descricao;
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
                throw new Exception("Erro ao conectar e inserir atividade do usuário. " + ex.Message);
            }
            
        }

        public void Update(Atividade atividade)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "update Atividade set nome = @nome and descricao = @descricao where id = @id";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = atividade.id;

                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = atividade.nome;

                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                cmd.Parameters["@descricao"].Value = atividade.descricao;
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
                throw new Exception("Erro ao conectar e alterar atividade do usuário. " + ex.Message);
            }
            #endregion
        }

        public void Delete(Atividade atividade)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "delete from Atividade where nome = @nome and descricao = @descricao";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = atividade.nome;

                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                cmd.Parameters["@descricao"].Value = atividade.descricao;
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
                throw new Exception("Erro ao conectar e excluir atividade do usuário. " + ex.Message);
            }
            #endregion
        }

        //CONFIRMAR SE ISSO ESTÁ CORRETO
        public bool VerificaDuplicidade(Atividade atividade)
        {
            bool retorno = false;
            try
            {
                //CONFIRMAR SE ISSO ESTÁ CORRETO
                #region abrir a conexão
                this.abrirConexao();
                string sql = "SELECT nome, descricao from Atividade where nome = @nome and descricao = @descricao";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, sqlConexao);
                #endregion

                //CONFIRMAR SE ISSO ESTÁ CORRETO
                #region passar parametros
                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = atividade.nome;

                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                cmd.Parameters["@descricao"].Value = atividade.descricao;
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
                throw new Exception("Erro! Esta atividade já existe." + ex.Message);
            }
            return retorno;
        }

        public List<Atividade> Select(Atividade filtro)
        {
            List<Atividade> retorno = new List<Atividade>();
            try
            {
                #region instrucao a ser executada
                this.abrirConexao();
                string sql = "SELECT * from Atividade";
                #endregion

                #region executando instrucao e colocando o resultado em um leitor e lendo o resultado da consulta
                SqlCommand cmd = new SqlCommand(sql, sqlConexao);
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                #endregion

                {
                    #region acessando os valores das colunas do resultado
                    Atividade atividade = new Atividade();
                    atividade.nome = DbReader.GetString(DbReader.GetOrdinal("nome"));
                    atividade.descricao = DbReader.GetString(DbReader.GetOrdinal("descricao"));
                    retorno.Add(atividade);
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
                throw new Exception("Erro ao conectar e selecionar atividade do usuário." + ex.Message);
            }
            return retorno;
        }
    }
}
