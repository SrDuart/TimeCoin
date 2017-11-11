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
    public class AnuncioSqlServer : ConexaoSqlServer, IAnuncio
    {
        public void Delete(Anuncio anuncio)
        {
            try
            {
                #region abrir conexao
                this.abrirConexao();
                string sql = "DELETE from Anuncio where Id = @id";
                #endregion

                #region instrucao a ser passada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passando parametros
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = anuncio.id;
                #endregion

                #region executando instrucao
                cmd.ExecuteNonQuery();
                #endregion

                #region liberando a memoria 
                cmd.Dispose();
                #endregion

                #region fechando a conexao
                this.fecharConexao();
                #endregion
            }
            catch(Exception e)
            {
                throw new Exception("Erro ao excluir o Anuncio. " + e.Message);
            }
        }

        public void Insert(Anuncio anuncio)
        {
            try
            {
                #region abrir conexão
                this.abrirConexao();
                string sql = "INSERT INTO Anuncio " +
                    "(Descricao, Data, PreRequisito, UF, Cidade, " +
                    "Bairro, Id_Usuario, Id_Situacao, Id_TipoAnuncio, Id_Servico) " +
                    "VALUES (@descricao, @data, @preRequisito, @uf, @cidade, " +
                    "@bairro, @id_usuario, @id_situacao, @id_tipoAnuncio, @id_servico)";
                #endregion

                #region instrução a ser passada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passando parametros
                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                cmd.Parameters["@descricao"].Value = anuncio.descricao;

                cmd.Parameters.Add("@data", SqlDbType.Date);
                cmd.Parameters["@data"].Value = anuncio.data;

                cmd.Parameters.Add("@preRequisito", SqlDbType.VarChar);
                cmd.Parameters["@preRequisito"].Value = anuncio.preRequisito;

                cmd.Parameters.Add("@uf", SqlDbType.Char);
                cmd.Parameters["@uf"].Value = anuncio.uf;

                cmd.Parameters.Add("@cidade", SqlDbType.VarChar);
                cmd.Parameters["@cidade"].Value = anuncio.cidade;

                cmd.Parameters.Add("@bairro", SqlDbType.VarChar);
                cmd.Parameters["@bairro"].Value = anuncio.bairro;

                cmd.Parameters.Add("@id_usuario", SqlDbType.Int);
                cmd.Parameters["@id_usuario"].Value = anuncio.usuario.id;

                cmd.Parameters.Add("@id_situacao", SqlDbType.Int);
                cmd.Parameters["@id_situacao"].Value = anuncio.situacao.id;

                cmd.Parameters.Add("@id_tipoAnuncio", SqlDbType.Int);
                cmd.Parameters["@id_tipoAnuncio"].Value = anuncio.tipoAnuncio.id;

                cmd.Parameters.Add("@id_servico", SqlDbType.Int);
                cmd.Parameters["@id_servico"].Value = anuncio.servico.id;
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
                throw new Exception("Erro ao inserir o Anúncio. " + e.Message);
            }
        }

        public List<Anuncio> Select(Anuncio filtro)
        {
            List<Anuncio> retorno = new List<Anuncio>();
            try
            {
                this.abrirConexao();

                string sql = "SELECT * from Anuncio";
                SqlCommand cmd = new SqlCommand(sql, sqlConexao);
                SqlDataReader DbReader = cmd.ExecuteReader();
                Anuncio anuncio;
                while (DbReader.Read())
                {
                    anuncio = new Anuncio();
                    anuncio.id = DbReader.GetInt32(DbReader.GetOrdinal("Id"));
                    anuncio.usuario.id = DbReader.GetInt32(DbReader.GetOrdinal("Id_Usuario"));
                    anuncio.situacao.id = DbReader.GetInt32(DbReader.GetOrdinal("Id_Situacao"));
                    anuncio.tipoAnuncio.id = DbReader.GetInt32(DbReader.GetOrdinal("Id_TipoAnuncio"));
                    anuncio.servico.id = DbReader.GetInt32(DbReader.GetOrdinal("Id_Servico"));
                    anuncio.descricao = DbReader.GetString(DbReader.GetOrdinal("Descricao"));
                    anuncio.data = DbReader.GetDateTime(DbReader.GetOrdinal("Data"));
                    anuncio.preRequisito = DbReader.GetString(DbReader.GetOrdinal("PreRequisito"));
                    anuncio.uf = DbReader.GetString(DbReader.GetOrdinal("UF"));
                    anuncio.bairro = DbReader.GetString(DbReader.GetOrdinal("Bairro"));
                    anuncio.cidade = DbReader.GetString(DbReader.GetOrdinal("Cidade"));
                    retorno.Add(anuncio);
                }
                DbReader.Close();
                cmd.Dispose();
                this.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao criar a listagem de Anuncios." + ex.Message);
            }
            return retorno;
        }

        public void Update(Anuncio anuncio)
        {
            try
            {
                #region abrir conexão
                this.abrirConexao();
                string sql = "UPDATE Anuncio SET" +
                    " Descricao = @descricao, Data = @data, PreRequisito = @preRequisito, UF = @uf, Cidade = @cidade, " +
                    "Bairro = @bairro, Id_Usuario = @id_usuario, Id_Situacao = @id_situacao, " +
                    "Id_TipoAnuncio = @id_tipoAnuncio, Id_Servico = @id_servico " +
                    "WHERE Id = @Id";
                #endregion

                #region instrução a ser passada
                SqlCommand cmd = new SqlCommand(sql, this.sqlConexao);
                #endregion

                #region passando parametros
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = anuncio.id;

                cmd.Parameters.Add("@descricao", SqlDbType.VarChar);
                cmd.Parameters["@descricao"].Value = anuncio.descricao;

                cmd.Parameters.Add("@data", SqlDbType.Date);
                cmd.Parameters["@data"].Value = anuncio.data;

                cmd.Parameters.Add("@preRequisito", SqlDbType.VarChar);
                cmd.Parameters["@preRequisito"].Value = anuncio.preRequisito;

                cmd.Parameters.Add("@uf", SqlDbType.Char);
                cmd.Parameters["@uf"].Value = anuncio.uf;

                cmd.Parameters.Add("@cidade", SqlDbType.VarChar);
                cmd.Parameters["@cidade"].Value = anuncio.cidade;

                cmd.Parameters.Add("@bairro", SqlDbType.VarChar);
                cmd.Parameters["@bairro"].Value = anuncio.bairro;

                cmd.Parameters.Add("@id_usuario", SqlDbType.Int);
                cmd.Parameters["@id_usuario"].Value = anuncio.usuario.id;

                cmd.Parameters.Add("@id_situacao", SqlDbType.Int);
                cmd.Parameters["@id_situacao"].Value = anuncio.situacao.id;

                cmd.Parameters.Add("@id_tipoAnuncio", SqlDbType.Int);
                cmd.Parameters["@id_tipoAnuncio"].Value = anuncio.tipoAnuncio.id;

                cmd.Parameters.Add("@id_servico", SqlDbType.Int);
                cmd.Parameters["@id_servico"].Value = anuncio.servico.id;
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
                throw new Exception("Erro ao atualizar o Anúncio. " + e.Message);
            }
        }

        public bool VerificaDuplicidade(Anuncio anuncio)
        {
            bool retorno = false;
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "SELECT * from Anuncio WHERE" +
                    " Data = @data AND  UF = @uf AND Cidade = @cidade AND " +
                    "Bairro = @bairro AND Id_Usuario = @id_usuario AND Id_Situacao = @id_situacao AND " +
                    "Id_TipoAnuncio = @id_tipoAnuncio AND Id_Servico = @id_servico ";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, sqlConexao);

                #endregion
                #region passar parametros

                cmd.Parameters.Add("@data", SqlDbType.Date);
                cmd.Parameters["@data"].Value = anuncio.data;

                cmd.Parameters.Add("@uf", SqlDbType.Char);
                cmd.Parameters["@uf"].Value = anuncio.uf;

                cmd.Parameters.Add("@cidade", SqlDbType.VarChar);
                cmd.Parameters["@cidade"].Value = anuncio.cidade;

                cmd.Parameters.Add("@bairro", SqlDbType.VarChar);
                cmd.Parameters["@bairro"].Value = anuncio.bairro;

                cmd.Parameters.Add("@id_usuario", SqlDbType.Int);
                cmd.Parameters["@id_usuario"].Value = anuncio.usuario.id;

                cmd.Parameters.Add("@id_situacao", SqlDbType.Int);
                cmd.Parameters["@id_situacao"].Value = anuncio.situacao.id;

                cmd.Parameters.Add("@id_tipoAnuncio", SqlDbType.Int);
                cmd.Parameters["@id_tipoAnuncio"].Value = anuncio.tipoAnuncio.id;

                cmd.Parameters.Add("@id_servico", SqlDbType.Int);
                cmd.Parameters["@id_servico"].Value = anuncio.servico.id;
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
                throw new Exception("Erro ao verificar duplicidade do Anuncio. " + ex.Message);
            }
            return retorno;
        }

        public bool VerificaExistencia(Anuncio anuncio)
        {
            bool retorno = false;
            try
            {
                #region abrir a conexão
                this.abrirConexao();
                string sql = "SELECT * from Anuncio WHERE" +
                    " Id = @id ";
                #endregion

                #region instrucao a ser executada
                SqlCommand cmd = new SqlCommand(sql, sqlConexao);

                #endregion
                #region passar parametros

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = anuncio.id;
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
                throw new Exception("Erro ao verificar a existência do Anuncio. " + ex.Message);
            }
            return retorno;
        }
    }
}
