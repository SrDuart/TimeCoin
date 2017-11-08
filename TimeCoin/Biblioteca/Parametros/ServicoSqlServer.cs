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
                //string sql = "insert into Servico (descricao, data, situacao) values(@descricao, @data, @situacao)";
                string sql = "insert into Servico (descricao, situacao) values(@descricao, @situacao)";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                cmd.Parameters["@descricao"].Value = servico.nome;
                //cmd.Parameters.Add("@data", SqlDbType.Date);
                //cmd.Parameters["@data"].Value = servico.descricao;
                cmd.Parameters.Add("@situacao", SqlDbType.VarChar);
                cmd.Parameters["@situacao"].Value = servico.situacao;
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
                throw new Exception("Erro ao conectar e inserir o serviço. " + ex.Message);
            }            
        }

        public void Update(Servico servico)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "update Servico set descricao = @descricao where id = @id";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = servico.id;

                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                cmd.Parameters["@descricao"].Value = servico.nome;
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
                throw new Exception("Erro ao conectar e alterar o serviço. " + ex.Message);
            }
            #endregion
        }

        public void Delete(Servico servico)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "delete from Servico where id = @id";
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

                #region liberando a memoria 
                cmd.Dispose();
                #endregion

                #region fechando a conexao
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e excluir o serviço." + ex.Message);
            }
            #endregion
        }

        public bool VerificaDuplicidade(Servico servico)
        {
            bool retorno = false;            
            return retorno;
        }

        public List<Servico> Select(Servico filtro)
        {
            List<Servico> retorno = new List<Servico>();
            try
            {
                this.abrirConexao();
                string sql = "SELECT id, descricao, data, situacao from Servico";

                if (filtro.nome != null && !filtro.nome.Trim().Equals(""))
                {
                    sql += " and descricao like '%" + filtro.nome + "%'";
                }

                SqlCommand cmd = new SqlCommand(sql, sqlConexao);
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    Servico servico = new Servico();
                    servico.id = DbReader.GetInt32(DbReader.GetOrdinal("id"));
                    servico.nome = DbReader.GetString(DbReader.GetOrdinal("descricao"));
                    servico.situacao.id = DbReader.GetChar(DbReader.GetOrdinal("situacao"));
                    retorno.Add(servico);
                }
                DbReader.Close();
                cmd.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e selecionar o serviço." + ex.Message);
            }
            return retorno;
        }
    }
}
