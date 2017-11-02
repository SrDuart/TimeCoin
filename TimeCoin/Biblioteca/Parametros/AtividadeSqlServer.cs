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
                string sql = "insert into atividade (nome, descricao) values (@nome, @descricao)";
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
                string sql = "update atividade set nome = @nome and descricao = @descricao where id = @id";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = atividade.id;

                cmd.Parameters.Add("@nome", SqlDbType.Int);
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
                string sql = "delete from atividade where id = @id";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = atividade.id;
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

        public bool VerificaDuplicidade(Atividade atividade)
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
            //    throw new Exception("Erro ao conectar e selecionar Atividade. " + ex.Message);
            //}
            return retorno;
        }

        public List<Atividade> Select(Atividade filtro)
        {
            List<Atividade> retorno = new List<Atividade>();
            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                string sql = "SELECT id, nome, descricao from atividade ";

                //se foi passada um descrição válido, entrará como critério de filtro
                if (filtro.nome != null && !filtro.nome.Trim().Equals(""))
                {
                    sql += " and nome like '%" + filtro.nome + "%'";
                }

                //se foi passada um descrição válido, entrará como critério de filtro
                if (filtro.descricao != null && !filtro.descricao.Trim().Equals(""))
                {
                    sql += " and descricao like '%" + filtro.descricao + "%'";
                }

                SqlCommand cmd = new SqlCommand(sql, sqlConexao);
                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Atividade atividade = new Atividade();
                    //acessando os valores das colunas do resultado
                    atividade.nome = DbReader.GetString(DbReader.GetOrdinal("nome"));
                    atividade.descricao = DbReader.GetString(DbReader.GetOrdinal("descricao"));
                    retorno.Add(atividade);
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
                throw new Exception("Erro ao conectar e selecionar atividade do usuário." + ex.Message);
            }
            return retorno;
        }
    }
}
