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
                string sql = "insert into Presta (id_usuario, id_servico, quantidadeHora, avaliacao) values (@id_usuario, @id_servico, @quantidadeHora, @avaliacao)";
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

                #region liberando a memoria 
                cmd.Dispose();
                #endregion

                #region fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e inserir serviço prestado pelo usuário. " + ex.Message);
            }
            #endregion
        }

        public void Update(Presta presta)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "update Presta set quantidadeHora = @quantidadeHora and avaliacao = @avaliacao where id_usuario = @id_usuario and id_servico = @id_servico";
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

                #region liberando a memoria 
                cmd.Dispose();
                #endregion

                #region fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e alterar serviço prestado pelo usuário." + ex.Message);
            }
            #endregion
        }

        public void Delete(Presta presta)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "delete from Presta where id_usuario = @id_usuario and id_servico = @id_servico";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@id_usuario", SqlDbType.Int);
                cmd.Parameters["@id_usuario"].Value = presta.usuario.id;

                cmd.Parameters.Add("@id_servico", SqlDbType.Int);
                cmd.Parameters["@id_servico"].Value = presta.servico.id;
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
                throw new Exception("Erro ao conectar e excluir serviço prestado pelo usuário." + ex.Message);
            }
            #endregion
        }

        public bool VerificaDuplicidade(Presta presta)
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
            //    throw new Exception("Erro ao conectar e selecionar serviço prestado pelo usuário. " + ex.Message);
            //}
            return retorno;
        }

        public List<Presta> Select(Presta filtro)
        {
            List<Presta> retorno = new List<Presta>();
            try
            {
                this.abrirConexao();
                //instrucao a ser executada
                string sql = "SELECT id_usuario, id_servico, quantidadeHora, avaliacao from Presta";

                string where = string.Empty; 
                if (filtro.usuario.id > 0)
                {
                    where += " id_usuario = @id_usuario ";
                }
                if (filtro.servico.id > 0)
                {
                    if (!string.IsNullOrEmpty(where))
                    {
                        where += " and ";
                    }
                    where += " id_servico = @id_servico ";
                }

                if (!string.IsNullOrEmpty(where))
                {
                    sql = " where " + where;
                }

                SqlCommand cmd = new SqlCommand(sql, sqlConexao);

                #region passar parametros
                if (filtro.usuario.id > 0)
                {
                    cmd.Parameters.Add("@id_usuario", SqlDbType.Int);
                    cmd.Parameters["@id_usuario"].Value = filtro.usuario.id;
                }
                if (filtro.servico.id > 0)
                {
                    cmd.Parameters.Add("@id_servico", SqlDbType.Int);
                    cmd.Parameters["@id_servico"].Value = filtro.servico.id;
                }
                #endregion

                //executando a instrucao e colocando o resultado em um leitor
                SqlDataReader DbReader = cmd.ExecuteReader();
                //lendo o resultado da consulta
                while (DbReader.Read())
                {
                    Presta presta = new Presta();
                    //acessando os valores das colunas do resultado
                    presta.usuario.id = DbReader.GetInt32(DbReader.GetOrdinal("id_usuario"));
                    presta.servico.id = DbReader.GetInt32(DbReader.GetOrdinal("id_servico"));
                    presta.quantidadeHora = DbReader.GetInt32(DbReader.GetOrdinal("quantidadeHora"));
                    presta.avaliacao = DbReader.GetDouble(DbReader.GetOrdinal("avaliacao"));
                    retorno.Add(presta);
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
                throw new Exception("Erro ao conectar e selecionar serviço prestado pelo usuário." + ex.Message);
            }
            return retorno;
        }
    }
}
