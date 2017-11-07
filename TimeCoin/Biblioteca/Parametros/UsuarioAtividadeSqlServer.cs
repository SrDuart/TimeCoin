﻿using Biblioteca.ConexaoBanco;
using Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.ClassesBasicas;
using System.Data.SqlClient;
using System.Data;

namespace Biblioteca.Parametros
{
    class UsuarioAtividadeSqlServer : ConexaoSqlServer, IUsuarioAtividade
    {        
        public void Insert(UsuarioAtividade usuarioAtividade)
        {
            try
            {
                #region abrir conexão
                this.abrirConexao();
                string sql = "INSERT INTO UsuarioAtividade (Id_Usuario, Id_Atividade) VALUES (@id_usuario, @id_atividade)";
                #endregion

                #region instrução a ser passada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passando parametros
                cmd.Parameters.Add("@id_usuario", SqlDbType.Int);
                cmd.Parameters["@id_usuario"].Value = usuarioAtividade.usuario.id;

                cmd.Parameters.Add("@id_atividade", SqlDbType.Int);
                cmd.Parameters["@id_atividade"].Value = usuarioAtividade.atividade.id;
                #endregion

                #region executando a instrução
                cmd.ExecuteNonQuery();
                #endregion  

                #region liberando a memoria 
                cmd.Dispose();
                #endregion

                #region fechando a conexao
                this.fecharConexao();
                #endregion
            } catch(Exception e)
            {
                throw new Exception("Erro ao inserir UsuarioAtividade. " + e.Message);
            }
        }

        public void Update(UsuarioAtividade usuarioAtividade)
        {
            try
            {
                #region abrir conexão
                this.abrirConexao();
                string sql = "UPDATE UsuarioAtividade SET Id_Usuario = @id_usuario, Id_Atividade = @id_atividade where Id = @id";
                #endregion

                #region instrução a ser passada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passando parametros
                cmd.Parameters.Add("@id_usuario", SqlDbType.Int);
                cmd.Parameters["@id_usuario"].Value = usuarioAtividade.usuario.id;

                cmd.Parameters.Add("@id_atividade", SqlDbType.Int);
                cmd.Parameters["@id_atividade"].Value = usuarioAtividade.atividade.id;

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = usuarioAtividade.id;
                #endregion

                #region executando a instrução
                cmd.ExecuteNonQuery();
                #endregion  

                #region liberando a memoria 
                cmd.Dispose();
                #endregion

                #region fechando a conexao
                this.fecharConexao();
                #endregion
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao alterar UsuarioAtividade. " + e.Message);
            }
        }

        public void Delete(UsuarioAtividade usuarioAtividade)
        {
            try
            {
                #region abrir conexão
                this.abrirConexao();
                string sql = "DELETE from UsuarioAtividade where Id = @id";
                #endregion

                #region instrução a ser passada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passando parametros
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = usuarioAtividade.id;
                #endregion

                #region executando a instrução
                cmd.ExecuteNonQuery();
                #endregion  

                #region liberando a memoria 
                cmd.Dispose();
                #endregion

                #region fechando a conexao
                this.fecharConexao();
                #endregion
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao excluir UsuarioAtividade. " + e.Message);
            }
        }

        public bool VerificaDuplicidade(UsuarioAtividade usuarioAtividade)
        {
            bool retorno = false;
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "SELECT Id_Usuario, Id_Atividade from usuarioAtividade where Id_Usuario = @id_usuario and Id_Atividade = @id_atividade";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, sqlConexao);

                #endregion
                #region passar parametros
                cmd.Parameters.Add("@id_usuario", SqlDbType.Int);
                cmd.Parameters["@id_usuario"].Value = usuarioAtividade.usuario;

                cmd.Parameters.Add("@id_atividade", SqlDbType.Int);
                cmd.Parameters["@id_atividade"].Value = usuarioAtividade.atividade;
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

                #region liberando a memoria 
                cmd.Dispose();
                #endregion

                #region fechando a conexao
                this.fecharConexao();
                #endregion
            }
            catch (Exception ex)
            {
                throw new Exception("Erro! Este tipo de usuário já existente. " + ex.Message);
            }
            return retorno;
        }

        public List<UsuarioAtividade> Select(UsuarioAtividade filtro)
        {
            throw new NotImplementedException();
        }
    }
}
