using Biblioteca.ConexaoBanco;
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
    class UsuarioAtividadeSqlServer : ConexaoSqlServer, IUsuarioHabilidade
    {        
        public void Insert(UsuarioHabilidade usuarioHabilidade)
        {
            try
            {
                #region abrir conexão
                this.abrirConexao();
                string sql = "INSERT INTO UsuarioHabilidade (Id_Usuario, Id_Habilidade) VALUES (@Id_Usuario, @Id_Habilidade)";
                #endregion

                #region instrução a ser passada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passando parametros
                cmd.Parameters.Add("@Id_Usuario", SqlDbType.Int);
                cmd.Parameters["@Id_Usuario"].Value = usuarioHabilidade.usuario.id;

                cmd.Parameters.Add("@Id_Habilidade", SqlDbType.Int);
                cmd.Parameters["@Id_Habilidade"].Value = usuarioHabilidade.atividade.id;
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
                throw new Exception("Erro ao inserir UsuarioHabilidade. " + e.Message);
            }
        }

        public void Update(UsuarioHabilidade usuarioHabilidade)
        {
            if (usuarioHabilidade == null)
            {
                throw new ArgumentNullException(nameof(usuarioHabilidade));
            }

            try
            {
                #region abrir conexão
                this.abrirConexao();
                string sql = "UPDATE UsuarioHabilidade SET Id_Usuario = @Id_Usuario, Id_Habilidade = @Id_Habilidade where Id = @Id";
                #endregion

                #region instrução a ser passada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passando parametros
                cmd.Parameters.Add("@Id_Usuario", SqlDbType.Int);
                cmd.Parameters["@id_usuario"].Value = usuarioHabilidade.usuario.id;

                cmd.Parameters.Add("@Id_Habilidade", SqlDbType.Int);
                cmd.Parameters["@Id_Habilidade"].Value = usuarioHabilidade.atividade.id;

                cmd.Parameters.Add("@Id", SqlDbType.Int);
                cmd.Parameters["@Id"].Value = usuarioHabilidade.id;
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
                throw new Exception("Erro ao alterar UsuarioHabilidade. " + e.Message);
            }
        }

        public void Delete(UsuarioHabilidade usuarioHabilidade)
        {
            try
            {
                #region abrir conexão
                this.abrirConexao();
                string sql = "DELETE from UsuarioHabilidade where Id = @Id";
                #endregion

                #region instrução a ser passada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passando parametros
                cmd.Parameters.Add("@Id", SqlDbType.Int);
                cmd.Parameters["@Id"].Value = usuarioHabilidade.id;
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
                throw new Exception("Erro ao excluir UsuarioHabilidade. " + e.Message);
            }
        }

        public bool VerificaDuplicidade(UsuarioHabilidade usuarioHabilidade)
        {
            bool retorno = false;
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "SELECT Id_Usuario, Id_Habilidade from usuarioHabilidade where Id_Usuario = @Id_Usuario and Id_Habilidade = @Id_Habilidade";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, sqlConexao);

                #endregion
                #region passar parametros
                cmd.Parameters.Add("@Id_Usuario", SqlDbType.Int);
                cmd.Parameters["@Id_Usuario"].Value = usuarioHabilidade.usuario;

                cmd.Parameters.Add("@Id_Habilidade", SqlDbType.Int);
                cmd.Parameters["@Id_Habilidade"].Value = usuarioHabilidade.atividade;
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

        public List<UsuarioHabilidade> Select(UsuarioHabilidade filtro)
        {
            throw new NotImplementedException();
        }
    }
}
