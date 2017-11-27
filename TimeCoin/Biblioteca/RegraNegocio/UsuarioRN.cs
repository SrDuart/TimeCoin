using Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using Biblioteca.ClassesBasicas;
using Biblioteca.Parametros;

namespace Biblioteca.RegraNegocio
{
    public class UsuarioRN : IUsuario
    {
        public void Insert(Usuario usuario)
        {
            ValidarDadosBasicos(usuario);

            if (this.VerificaDuplicidade(usuario))
            {
                throw new Exception("Erro! Usuário já existente.");
            }

            UsuarioSqlServer dados = new UsuarioSqlServer();
            dados.Insert(usuario);
        }

        public void Update(Usuario usuario)
        {
            ValidarDadosBasicos(usuario);

            if (this.VerificaDuplicidade(usuario) == true)
            {
                UsuarioSqlServer dados = new UsuarioSqlServer();
                dados.Update(usuario);
            }
            else
            {
                throw new Exception("Erro! Usuário já existente.");
            }
        }

        public void Delete(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new Exception("Erro! Favor instanciar um usuário.");
            }

            UsuarioSqlServer dados = new UsuarioSqlServer();
            dados.Delete(usuario);
        }

        public bool VerificaDuplicidade(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new Exception("Erro! Campo nulo. Favor instanciar um usuário.");
            }

            if (usuario.userName == null)
            {
                throw new Exception("Erro! Campo nulo. Favor instanciar um userName do usuário.");
            }

            if (usuario.telefoneCelular == null)
            {
                throw new Exception("Erro! Campo nulo. Favor instanciar um telefone celular do usuário.");
            }

            if (usuario.email == null)
            {
                throw new Exception("Erro! Campo nulo. Favor instanciar um email do usuário.");
            }

            UsuarioSqlServer dados = new UsuarioSqlServer();
            return dados.VerificaDuplicidade(usuario);
        }        
        
        public void VerificaLogin(Usuario usuario)
        {
            try
            {
                UsuarioSqlServer dados = new UsuarioSqlServer();
                dados.VerificaLogin(usuario);
            }
            catch(Exception ex)
            {
                throw ex;
            }  
        }

        public List<Usuario> Select(Usuario filtro)
        {
            UsuarioSqlServer dados = new UsuarioSqlServer();
            return dados.Select(filtro);
        }

        private void ValidarDadosBasicos(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new Exception("Erro! Favor instanciar um usuário.");
            }

            if (String.IsNullOrEmpty(usuario.nome) == true || String.IsNullOrWhiteSpace(usuario.nome) == true)
            {
                throw new Exception("Erro! Campo vazio. Favor informar o nome do usuário.");
            }

            if (String.IsNullOrEmpty(usuario.userName) == true || String.IsNullOrWhiteSpace(usuario.userName) == true)
            {
                throw new Exception("Erro! Campo vazio. Favor informar o userName do usuário.");
            }

            if (String.IsNullOrEmpty(usuario.cpf_cnpj) == true || String.IsNullOrWhiteSpace(usuario.cpf_cnpj) == true)
            {
                throw new Exception("Erro! Campo vazio. Favor informar o cpf ou cnpj do usuário.");
            }

            if (String.IsNullOrEmpty(usuario.telefoneCelular) == true || String.IsNullOrWhiteSpace(usuario.telefoneCelular) == true)
            {
                throw new Exception("Erro! Campo vazio. Favor informar o telefone celular do usuário.");
            }

            if (String.IsNullOrEmpty(usuario.uf) == true || String.IsNullOrWhiteSpace(usuario.uf) == true)
            {
                throw new Exception("Erro! Campo vazio. Favor informar o Estado do usuário.");
            }

            if (String.IsNullOrEmpty(usuario.cidade) == true || String.IsNullOrWhiteSpace(usuario.cidade) == true)
            {
                throw new Exception("Erro! Campo vazio. Favor informar a Cidade do usuário.");
            }

            if (String.IsNullOrEmpty(usuario.bairro) == true || String.IsNullOrWhiteSpace(usuario.bairro) == true)
            {
                throw new Exception("Erro! Campo vazio. Favor informar o Bairro do usuário.");
            }

            if (String.IsNullOrEmpty(usuario.email) == true || String.IsNullOrWhiteSpace(usuario.email) == true)
            {
                throw new Exception("Erro! Campo vazio. Favor informar o email do usuário.");
            }

            if (String.IsNullOrEmpty(usuario.senha) == true || String.IsNullOrWhiteSpace(usuario.senha) == true)
            {
                throw new Exception("Erro! Campo vazio. Favor informar a senha do usuário.");
            }

            if (String.IsNullOrEmpty(usuario.descricao) == true || String.IsNullOrWhiteSpace(usuario.descricao) == true)
            {
                throw new Exception("Erro! Campo vazio. Favor informar a descrição do usuário.");
            }

            if (usuario.nome.Trim().Length < 1 || usuario.nome.Trim().Length > 50)
            {
                throw new Exception("Erro! número de caracteres não compatível. O nome deve conter mais de um caracter e no máximo 50.");
            }

            if (usuario.email.Trim().Length < 10 || usuario.email.Trim().Length > 25)
            {
                throw new Exception("Erro! número de caracteres não compatível. O email deve conter mais de um caracter e no máximo 20.");
            }

            if (usuario.userName.Trim().Length < 5 || usuario.userName.Trim().Length > 15)
            {
                throw new Exception("Erro! número de caracteres não compatível. O Nome de Usuário deve conter mais de um caracter e no máximo 40.");
            }

            if (usuario.cpf_cnpj.Trim().Length < 1 || usuario.cpf_cnpj.Trim().Length > 14)
            {
                throw new Exception("Erro! número de caracteres não compatível. O CPF/CNPJ deve conter mais de um caracter e no máximo 14.");
            }

            if (usuario.telefoneFixo.Trim().Length < 1 || usuario.telefoneFixo.Trim().Length > 10)
            {
                throw new Exception("Erro! número de caracteres não compatível. O Telefone Fixo deve conter mais de um caracter e no máximo 10.");
            }

            if (usuario.telefoneCelular.Trim().Length < 1 || usuario.telefoneCelular.Trim().Length > 11)
            {
                throw new Exception("Erro! número de caracteres não compatível. O Celular deve conter mais de um caracter e no máximo 11.");
            }

            if (usuario.uf.Trim().Length < 1 || usuario.uf.Trim().Length > 2)
            {
                throw new Exception("Erro! número de caracteres não compatível. A UF deve conter apenas 2 caracter.");
            }

            if (usuario.cidade.Trim().Length < 1 || usuario.cidade.Trim().Length > 25)
            {
                throw new Exception("Erro! número de caracteres não compatível. O nome da cidade deve conter mais de um caracter e no máximo 25.");
            }

            if (usuario.bairro.Trim().Length < 1 || usuario.bairro.Trim().Length > 25)
            {
                throw new Exception("Erro! número de caracteres não compatível. O nome do bairro deve conter mais de um caracter e no máximo 25.");
            }
            
            if (usuario.senha.Trim().Length < 1 || usuario.senha.Trim().Length > 25)
            {
                throw new Exception("Erro! número de caracteres não compatível. A senha deve conter mais de um caracter e no máximo 25.");
            }

            if (usuario.descricao.Trim().Length < 1 || usuario.descricao.Trim().Length > 144)
            {
                throw new Exception("Erro! número de caracteres não compatível. A descrição do usuário deve conter mais de um caracter e no máximo 144.");
            }
        }
    }
}
