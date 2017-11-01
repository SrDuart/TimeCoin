using Biblioteca.ClassesBasicas;
using Biblioteca.ConexaoBanco;
using Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca.Parametros
{
    public class UsuarioSqlServer : ConexaoSqlServer, IUsuario
    {
        public void Insert(Usuario usuario)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "insert into Usuario (nome , userName, cpf_cnpj, telefoneFixo, telefoneCelular, ";
                sql += " estado, cidade, bairro, email, senha, descricao, Id_Situacao, Id_TipoUsuario) values (@nome , @userName, @cpf_cnpj, ";
                sql += "  @telefoneFixo, @telefoneCelular, @estado, @cidade, @bairro, @email, @senha, @descricao, @Id_Situacao, @Id_TipoUsuario)";               
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = usuario.nome;

                cmd.Parameters.Add("@userName", SqlDbType.VarChar);
                cmd.Parameters["@userName"].Value = usuario.userName;

                cmd.Parameters.Add("@cpf_cnpj", SqlDbType.VarChar);
                cmd.Parameters["@cpf_cnpj"].Value = usuario.cpf_cnpj;

                cmd.Parameters.Add("@telefoneFixo", SqlDbType.VarChar);
                cmd.Parameters["@telefoneFixo"].Value = usuario.telefoneFixo;

                cmd.Parameters.Add("@telefoneCelular", SqlDbType.VarChar);
                cmd.Parameters["@telefoneCelular"].Value = usuario.telefoneCelular;

                cmd.Parameters.Add("@estado", SqlDbType.VarChar);
                cmd.Parameters["@estado"].Value = usuario.estado;

                cmd.Parameters.Add("@cidade", SqlDbType.VarChar);
                cmd.Parameters["@cidade"].Value = usuario.cidade;

                cmd.Parameters.Add("@bairro", SqlDbType.VarChar);
                cmd.Parameters["@bairro"].Value = usuario.bairro;

                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = usuario.email;

                cmd.Parameters.Add("@senha", SqlDbType.VarChar);
                cmd.Parameters["@senha"].Value = usuario.senha;

                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                cmd.Parameters["@descricao"].Value = usuario.descricao;                

                cmd.Parameters.Add("@Id_Situacao", SqlDbType.Int);
                cmd.Parameters["@Id_Situacao"].Value = usuario.situacao.id;

                cmd.Parameters.Add("@Id_TipoUsuario", SqlDbType.Int);
                cmd.Parameters["@Id_TipoUsuario"].Value = usuario.tipoUsuario.id;
                #endregion

                #region executando a instrucao 
                cmd.ExecuteNonQuery();
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
                throw new Exception("Erro ao conectar e inserir o usuário. " + ex.Message);
            }
        }
        
        public void Update(Usuario usuario)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "update Usuario set nome = @nome, userName = #userName, cpf_cnpj = @cpf_cnpj, ";
                sql += " telefoneFixo = @telefonefixo, telefoneCelular = @telefoneCelular, estado = @estado, ";
                sql += " cidade = @cidade, bairro = @bairro, email = @email, senha = @senha, descricao = @descricao ";
                sql += " where id = @id";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = usuario.id;

                cmd.Parameters.Add("@nome", SqlDbType.VarChar);
                cmd.Parameters["@nome"].Value = usuario.nome;

                cmd.Parameters.Add("@userName", SqlDbType.VarChar);
                cmd.Parameters["@userName"].Value = usuario.userName;

                cmd.Parameters.Add("@cpf_cnpj", SqlDbType.VarChar);
                cmd.Parameters["@cpf_cnpj"].Value = usuario.cpf_cnpj;

                cmd.Parameters.Add("@telefoneFixo", SqlDbType.VarChar);
                cmd.Parameters["@telefoneFixo"].Value = usuario.telefoneFixo;

                cmd.Parameters.Add("@telefoneCelular", SqlDbType.VarChar);
                cmd.Parameters["@telefoneCelular"].Value = usuario.telefoneCelular;

                cmd.Parameters.Add("@estado", SqlDbType.VarChar);
                cmd.Parameters["@estado"].Value = usuario.estado;

                cmd.Parameters.Add("@cidade", SqlDbType.VarChar);
                cmd.Parameters["@cidade"].Value = usuario.cidade;

                cmd.Parameters.Add("@bairro", SqlDbType.VarChar);
                cmd.Parameters["@bairro"].Value = usuario.bairro;

                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = usuario.email;

                cmd.Parameters.Add("@senha", SqlDbType.VarChar);
                cmd.Parameters["@senha"].Value = usuario.senha;

                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                cmd.Parameters["@descricao"].Value = usuario.descricao;
                #endregion

                #region executando a instrucao 
                cmd.ExecuteNonQuery();
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
                throw new Exception("Erro ao conectar e alterar usuário. " + ex.Message);
            }

        }

        public void Delete(Usuario usuario)
        {
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "delete from TipoUsuario where userName = @userName";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passar parametros
                cmd.Parameters.Add("@userName", SqlDbType.VarChar);
                cmd.Parameters["@userName"].Value = usuario.userName;
                #endregion

                #region executando a instrucao 
                cmd.ExecuteNonQuery();
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
                throw new Exception("Erro ao conectar e excluir o usuário. " + ex.Message);
            }
        }

        public bool VerificaDuplicidade(Usuario usuario)
        {
            bool retorno = false;
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "SELECT userName, telefoneCelular, email from Usuario where userName = @userName";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, sqlConexao);

                #endregion
                #region passar parametros
                cmd.Parameters.Add("@userName", SqlDbType.VarChar);
                cmd.Parameters["@userName"].Value = usuario.userName;

                cmd.Parameters.Add("@telefoneCelular", SqlDbType.VarChar);
                cmd.Parameters["@telefoneCelular"].Value = usuario.telefoneCelular;

                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = usuario.email;
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
                throw new Exception("Erro! Este usuário já existente. " + ex.Message);
            }
            return retorno;
        }

        public List<Usuario> Select(Usuario filtro)
        {
            List<Usuario> retorno = new List<Usuario>();
            try
            {
                this.abrirConexao();
                string sql = "SELECT * FROM usuario where userName = userName ";                
                
                SqlCommand cmd = new SqlCommand(sql, sqlConexao);              
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.id = DbReader.GetInt32(DbReader.GetOrdinal("id"));
                    usuario.nome = DbReader.GetString(DbReader.GetOrdinal("nome"));
                    usuario.userName = DbReader.GetString(DbReader.GetOrdinal("userName"));
                    usuario.cpf_cnpj = DbReader.GetString(DbReader.GetOrdinal("cpf_cnpj"));
                    usuario.telefoneFixo = DbReader.GetString(DbReader.GetOrdinal("telefoneFixo"));
                    usuario.telefoneCelular = DbReader.GetString(DbReader.GetOrdinal("telefoneCelular"));
                    usuario.estado = DbReader.GetString(DbReader.GetOrdinal("estado"));
                    usuario.cidade = DbReader.GetString(DbReader.GetOrdinal("cidade"));
                    usuario.bairro = DbReader.GetString(DbReader.GetOrdinal("bairro"));
                    usuario.email = DbReader.GetString(DbReader.GetOrdinal("email"));
                    usuario.dataCadastro = DbReader.GetDateTime(DbReader.GetOrdinal("dataCadastro"));
                    usuario.senha = DbReader.GetString(DbReader.GetOrdinal("senha"));
                    usuario.email = DbReader.GetString(DbReader.GetOrdinal("email"));
                    usuario.quantidadeHoraTrabalhada = DbReader.GetInt32(DbReader.GetOrdinal("quantidadeHoraTrabalhada"));
                    usuario.quantidadeHoraDisponivel = DbReader.GetInt32(DbReader.GetOrdinal("quantidadeHoraDisponivel"));
                    usuario.descricao = DbReader.GetString(DbReader.GetOrdinal("descricao"));
                    retorno.Add(usuario);
                }
                DbReader.Close();
                cmd.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e selecionar um usuário " + ex.Message);
            }
            return retorno;
        }
    }
}
