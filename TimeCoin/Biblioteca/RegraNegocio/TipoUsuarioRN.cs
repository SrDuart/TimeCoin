using Biblioteca.ClassesBasicas;
using Biblioteca.Interfaces;
using Biblioteca.Parametros;
using System;
using System.Collections.Generic;

namespace Biblioteca.RegraNegocio
{
    public class TipoUsuarioRN : ITipoUsuario
    {
        private void ValidarDadosBasicos(TipoUsuario tipoUsuario)
        {
            if (tipoUsuario == null)
            {
                throw new Exception("Erro! Favor informar um Tipo de usuário.");
            }

            if (String.IsNullOrEmpty(tipoUsuario.descricao) == true || String.IsNullOrWhiteSpace(tipoUsuario.descricao) == true)
            {
                throw new Exception("Erro! Campo vazio. Favor informar uma descrição do Tipo do usuário.");
            }

            if (tipoUsuario.descricao.Trim().Length < 1 || tipoUsuario.descricao.Trim().Length > 15)
            {
                throw new Exception("Erro! Número de caracteres não compatível. A descrição deve conter mais de um caracter e no máximo 15.");
            }
        }

        public void Delete(TipoUsuario tipoUsuario)
        {
            if (tipoUsuario == null)
            {
                throw new Exception("Erro! Favor, instanciar um Tipo de usuário.");
            }

            TipoUsuarioSqlServer dados = new TipoUsuarioSqlServer();
            if (dados.VerificaExistencia(tipoUsuario))
            {
                dados.Delete(tipoUsuario);
            }
            else
            {
                throw new Exception("Este tipo de usuário não existe ou já foi excluído");
            }
        }

        public void Insert(TipoUsuario tipoUsuario)
        {
            ValidarDadosBasicos(tipoUsuario);

            if (this.VerificaDuplicidade(tipoUsuario))
            {
                TipoUsuarioSqlServer dados = new TipoUsuarioSqlServer();
                dados.Insert(tipoUsuario);
            }
            else
            {
                throw new Exception("Erro! Tipo de usuário já existente.");
            }
            
            
        }

        public List<TipoUsuario> Select(TipoUsuario filtro)
        {
            TipoUsuarioSqlServer dados = new TipoUsuarioSqlServer();
            return dados.Select(filtro);
        }

        public void Update(TipoUsuario tipoUsuario)
        {
            ValidarDadosBasicos(tipoUsuario);
            TipoUsuarioSqlServer dados = new TipoUsuarioSqlServer();

            if (dados.VerificaDuplicidade(tipoUsuario) == false)
            {                
                dados.Update(tipoUsuario);
            }
            else
            {
                throw new Exception("Erro! Tipo de usuário já existente.");
            }            
        }

        public bool VerificaDuplicidade(TipoUsuario tipoUsuario)
        {
            if (tipoUsuario == null)
            {
                throw new Exception("Erro! Favor, instanciar um Tipo de usuário.");
            }

            if (tipoUsuario.descricao == null)
            {
                throw new Exception("Erro! Campo nulo. Favor, instanciar uma descrição do Tipo de usuário.");
            }

            TipoUsuarioSqlServer dados = new TipoUsuarioSqlServer();
            return dados.VerificaDuplicidade(tipoUsuario);
        }

        public bool VerificaExistencia(TipoUsuario tipoUsuario)
        {
            if (tipoUsuario == null)
            {
                throw new Exception("Erro! Favor, instanciar um Tipo de usuário.");
            }         

            TipoUsuarioSqlServer dados = new TipoUsuarioSqlServer();
            return dados.VerificaExistencia(tipoUsuario);
        }
    }
}

