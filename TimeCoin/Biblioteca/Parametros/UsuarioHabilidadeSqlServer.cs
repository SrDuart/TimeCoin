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
<<<<<<< HEAD:TimeCoin/Biblioteca/Parametros/UsuarioHabilidadeSqlServer.cs
    public class UsuarioHabilidadeSqlServer : ConexaoSqlServer, IUsuarioHabilidade
=======
    class UsuarioAtividadeSqlServer : ConexaoSqlServer, IUsuarioHabilidade
>>>>>>> 948ad0333051563b7044f56038c2f35a8f9d5dc3:TimeCoin/Biblioteca/Parametros/UsuarioAtividadeSqlServer.cs
    {        
        public void Insert(UsuarioHabilidade usuarioHabilidade)
        {
            try
            {
                #region abrir conexão
                this.abrirConexao();
<<<<<<< HEAD:TimeCoin/Biblioteca/Parametros/UsuarioHabilidadeSqlServer.cs
                string sql = "INSERT INTO UsuarioHabilidade (Id_Usuario, Id_Habilidade) VALUES (@id_usuario, @id_habilidade)";
=======
                string sql = "INSERT INTO UsuarioHabilidade (Id_Usuario, Id_Habilidade) VALUES (@Id_Usuario, @Id_Habilidade)";
>>>>>>> 948ad0333051563b7044f56038c2f35a8f9d5dc3:TimeCoin/Biblioteca/Parametros/UsuarioAtividadeSqlServer.cs
                #endregion

                #region instrução a ser passada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passando parametros
<<<<<<< HEAD:TimeCoin/Biblioteca/Parametros/UsuarioHabilidadeSqlServer.cs
                cmd.Parameters.Add("@id_usuario", SqlDbType.Int);
                cmd.Parameters["@id_usuario"].Value = usuarioHabilidade.usuario.id;

                cmd.Parameters.Add("@id_habilidade", SqlDbType.Int);
                cmd.Parameters["@id_habilidade"].Value = usuarioHabilidade.habilidade.id;
=======
                cmd.Parameters.Add("@Id_Usuario", SqlDbType.Int);
                cmd.Parameters["@Id_Usuario"].Value = usuarioHabilidade.usuario.id;

                cmd.Parameters.Add("@Id_Habilidade", SqlDbType.Int);
                cmd.Parameters["@Id_Habilidade"].Value = usuarioHabilidade.atividade.id;
>>>>>>> 948ad0333051563b7044f56038c2f35a8f9d5dc3:TimeCoin/Biblioteca/Parametros/UsuarioAtividadeSqlServer.cs
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
<<<<<<< HEAD:TimeCoin/Biblioteca/Parametros/UsuarioHabilidadeSqlServer.cs
                string sql = "UPDATE UsuarioHabilidade SET Id_Usuario = @id_usuario, Id_Habilidade = @id_habilidade where Id = @id";
=======
                string sql = "UPDATE UsuarioHabilidade SET Id_Usuario = @Id_Usuario, Id_Habilidade = @Id_Habilidade where Id = @Id";
>>>>>>> 948ad0333051563b7044f56038c2f35a8f9d5dc3:TimeCoin/Biblioteca/Parametros/UsuarioAtividadeSqlServer.cs
                #endregion

                #region instrução a ser passada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passando parametros
<<<<<<< HEAD:TimeCoin/Biblioteca/Parametros/UsuarioHabilidadeSqlServer.cs
                cmd.Parameters.Add("@id_usuario", SqlDbType.Int);
                cmd.Parameters["@id_usuario"].Value = usuarioHabilidade.usuario.id;

                cmd.Parameters.Add("@id_habilidade", SqlDbType.Int);
                cmd.Parameters["@id_habilidade"].Value = usuarioHabilidade.habilidade.id;

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = usuarioHabilidade.id;
=======
                cmd.Parameters.Add("@Id_Usuario", SqlDbType.Int);
                cmd.Parameters["@id_usuario"].Value = usuarioHabilidade.usuario.id;

                cmd.Parameters.Add("@Id_Habilidade", SqlDbType.Int);
                cmd.Parameters["@Id_Habilidade"].Value = usuarioHabilidade.atividade.id;

                cmd.Parameters.Add("@Id", SqlDbType.Int);
                cmd.Parameters["@Id"].Value = usuarioHabilidade.id;
>>>>>>> 948ad0333051563b7044f56038c2f35a8f9d5dc3:TimeCoin/Biblioteca/Parametros/UsuarioAtividadeSqlServer.cs
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
<<<<<<< HEAD:TimeCoin/Biblioteca/Parametros/UsuarioHabilidadeSqlServer.cs
                throw new Exception("Erro ao alterar usuarioHabilidade. " + e.Message);
=======
                throw new Exception("Erro ao alterar UsuarioHabilidade. " + e.Message);
>>>>>>> 948ad0333051563b7044f56038c2f35a8f9d5dc3:TimeCoin/Biblioteca/Parametros/UsuarioAtividadeSqlServer.cs
            }
        }

        public void Delete(UsuarioHabilidade usuarioHabilidade)
        {
            try
            {
                #region abrir conexão
                this.abrirConexao();
<<<<<<< HEAD:TimeCoin/Biblioteca/Parametros/UsuarioHabilidadeSqlServer.cs
                string sql = "DELETE from UsuarioHabilidade where Id = @id";
=======
                string sql = "DELETE from UsuarioHabilidade where Id = @Id";
>>>>>>> 948ad0333051563b7044f56038c2f35a8f9d5dc3:TimeCoin/Biblioteca/Parametros/UsuarioAtividadeSqlServer.cs
                #endregion

                #region instrução a ser passada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passando parametros
<<<<<<< HEAD:TimeCoin/Biblioteca/Parametros/UsuarioHabilidadeSqlServer.cs
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = usuarioHabilidade.id;
=======
                cmd.Parameters.Add("@Id", SqlDbType.Int);
                cmd.Parameters["@Id"].Value = usuarioHabilidade.id;
>>>>>>> 948ad0333051563b7044f56038c2f35a8f9d5dc3:TimeCoin/Biblioteca/Parametros/UsuarioAtividadeSqlServer.cs
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
<<<<<<< HEAD:TimeCoin/Biblioteca/Parametros/UsuarioHabilidadeSqlServer.cs
                string sql = "SELECT Id_Usuario, Id_Habilidade from usuarioHabilidade where Id_Usuario = @id_usuario and Id_Habilidade = @id_Habilidade";
=======
                string sql = "SELECT Id_Usuario, Id_Habilidade from usuarioHabilidade where Id_Usuario = @Id_Usuario and Id_Habilidade = @Id_Habilidade";
>>>>>>> 948ad0333051563b7044f56038c2f35a8f9d5dc3:TimeCoin/Biblioteca/Parametros/UsuarioAtividadeSqlServer.cs
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, sqlConexao);

                #endregion
                #region passar parametros
<<<<<<< HEAD:TimeCoin/Biblioteca/Parametros/UsuarioHabilidadeSqlServer.cs
                cmd.Parameters.Add("@id_usuario", SqlDbType.Int);
                cmd.Parameters["@id_usuario"].Value = usuarioHabilidade.usuario.id;

                cmd.Parameters.Add("@id_habilidade", SqlDbType.Int);
                cmd.Parameters["@id_habilidade"].Value = usuarioHabilidade.habilidade.id;
=======
                cmd.Parameters.Add("@Id_Usuario", SqlDbType.Int);
                cmd.Parameters["@Id_Usuario"].Value = usuarioHabilidade.usuario;

                cmd.Parameters.Add("@Id_Habilidade", SqlDbType.Int);
                cmd.Parameters["@Id_Habilidade"].Value = usuarioHabilidade.atividade;
>>>>>>> 948ad0333051563b7044f56038c2f35a8f9d5dc3:TimeCoin/Biblioteca/Parametros/UsuarioAtividadeSqlServer.cs
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
                throw new Exception("Erro ao verificar a duplicidade do UsuarioHabilidade. " + ex.Message);
            }
            return retorno;
        }

        public List<UsuarioHabilidade> Select(UsuarioHabilidade filtro)
        {
            List<UsuarioHabilidade> retorno = new List<UsuarioHabilidade>();
            try
            {
                this.abrirConexao();
         
                string sql = "SELECT id, usuario, habilidade from UsuarioHabilidade";
                SqlCommand cmd = new SqlCommand(sql, sqlConexao);
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    UsuarioHabilidade usuarioHabilidade = new UsuarioHabilidade();
                    usuarioHabilidade.id = DbReader.GetInt32(DbReader.GetOrdinal("id"));
                    usuarioHabilidade.usuario.id = DbReader.GetInt32(DbReader.GetOrdinal("usuario"));
                    usuarioHabilidade.habilidade.id = DbReader.GetInt32(DbReader.GetOrdinal("habilidade"));
                    retorno.Add(usuarioHabilidade);
                }
                DbReader.Close();
                cmd.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar os UsuariosHabilidade." + ex.Message);
            }
            return retorno;
        }
    }
}
