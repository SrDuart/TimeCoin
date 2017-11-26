﻿using Biblioteca.ClassesBasicas;
using Biblioteca.ConexaoBanco;
using Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca.Parametros
{
    public class HabilidadeSqlServer : ConexaoSqlServer, IHabilidade
    {
        public void Insert(Habilidade habilidade)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "INSERT INTO Habilidade (Nome, Descricao) VALUES (@nome, @Descricao)";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                cmd.Parameters["@Nome"].Value = habilidade.nome;

                cmd.Parameters.Add("@Descricao", SqlDbType.VarChar);
                cmd.Parameters["@Descricao"].Value = habilidade.descricao;
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
                throw new Exception("Erro ao conectar e inserir habilidade do usuário. " + ex.Message);
            }
            
        }
        public void Update(Habilidade habilidade)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "UPDATE Habilidade SET Nome = @Nome, Descricao = @Descricao where Id = @Id";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@Id", SqlDbType.Int);
                cmd.Parameters["@Id"].Value = habilidade.id;

                cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                cmd.Parameters["@Nome"].Value = habilidade.nome;

                cmd.Parameters.Add("@Descricao", SqlDbType.VarChar);
                cmd.Parameters["@Descricao"].Value = habilidade.descricao;
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
                throw new Exception("Erro ao conectar e alterar habilidade do usuário. " + ex.Message);
            }
            #endregion
        }

        public void Delete(Habilidade habilidade)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "DELETE FROM Habilidade where Id = @Id";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@Nome", SqlDbType.VarChar);
                cmd.Parameters["@Nome"].Value = habilidade.nome;

                cmd.Parameters.Add("@Descricao", SqlDbType.VarChar);
                cmd.Parameters["@Descricao"].Value = habilidade.descricao;
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
                throw new Exception("Erro ao conectar e excluir habilidade do usuário. " + ex.Message);
            }
            #endregion
        }
        
        public bool VerificaDuplicidade(Habilidade atividade)
        {
            bool retorno = false;
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "SELECT nome, descricao FROM Habilidade WHERE nome = @nome AND descricao = @descricao";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, sqlConexao);
                #endregion
                
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

        public List<Habilidade> Select(Habilidade filtro)
        {
            List<Habilidade> retorno = new List<Habilidade>();
            try
            {
                #region instrucao a ser executada
                this.abrirConexao();
                string sql = "SELECT * FROM Habilidade";
                #endregion

                #region executando instrucao e colocando o resultado em um leitor e lendo o resultado da consulta
                SqlCommand cmd = new SqlCommand(sql, sqlConexao);
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                #endregion

                {
                    #region acessando os valores das colunas do resultado
                    Habilidade habilidade = new Habilidade();
                    habilidade.id = DbReader.GetInt32(DbReader.GetOrdinal("Id"));
                    habilidade.nome = DbReader.GetString(DbReader.GetOrdinal("Nome"));
                    habilidade.descricao = DbReader.GetString(DbReader.GetOrdinal("Descricao"));
                    retorno.Add(habilidade);
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
                throw new Exception("Erro ao conectar e selecionar habilidade do usuário." + ex.Message);
            }
            return retorno;
        }
    }
}
