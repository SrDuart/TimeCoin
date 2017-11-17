﻿using Biblioteca.Interfaces;
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
                throw new Exception("Erro! número de caracteres não compatível. A descrição deve conter mais de um caracter e no máximo 50.");
            }

            if (usuario.userName.Trim().Length < 1 || usuario.userName.Trim().Length > 40)
            {
                throw new Exception("Erro! número de caracteres não compatível. A descrição deve conter mais de um caracter e no máximo 40.");
            }

            if (usuario.cpf_cnpj.Trim().Length < 1 || usuario.cpf_cnpj.Trim().Length > 14)
            {
                throw new Exception("Erro! número de caracteres não compatível. A descrição deve conter mais de um caracter e no máximo 14.");
            }

            if (usuario.telefoneCelular.Trim().Length < 1 || usuario.telefoneCelular.Trim().Length > 10)
            {
                throw new Exception("Erro! número de caracteres não compatível. A descrição deve conter mais de um caracter e no máximo 10.");
            }

            if (usuario.telefoneCelular.Trim().Length < 1 || usuario.telefoneCelular.Trim().Length > 10)
            {
                throw new Exception("Erro! número de caracteres não compatível. A descrição deve conter mais de um caracter e no máximo 10.");
            }

            if (usuario.uf.Trim().Length < 1 || usuario.uf.Trim().Length > 25)
            {
                throw new Exception("Erro! número de caracteres não compatível. A descrição deve conter mais de um caracter e no máximo 25.");
            }

            if (usuario.cidade.Trim().Length < 1 || usuario.cidade.Trim().Length > 25)
            {
                throw new Exception("Erro! número de caracteres não compatível. A descrição deve conter mais de um caracter e no máximo 25.");
            }

            if (usuario.bairro.Trim().Length < 1 || usuario.bairro.Trim().Length > 25)
            {
                throw new Exception("Erro! número de caracteres não compatível. A descrição deve conter mais de um caracter e no máximo 25.");
            }

            if (usuario.email.Trim().Length < 1 || usuario.email.Trim().Length > 40)
            {
                throw new Exception("Erro! número de caracteres não compatível. A descrição deve conter mais de um caracter e no máximo 40.");
            }

            if (usuario.senha.Trim().Length < 1 || usuario.senha.Trim().Length > 40)
            {
                throw new Exception("Erro! número de caracteres não compatível. A descrição deve conter mais de um caracter e no máximo 40.");
            }

            if (usuario.descricao.Trim().Length < 1 || usuario.descricao.Trim().Length > 144)
            {
                throw new Exception("Erro! número de caracteres não compatível. A descrição deve conter mais de um caracter e no máximo 144.");
            }
        }
    }
}
