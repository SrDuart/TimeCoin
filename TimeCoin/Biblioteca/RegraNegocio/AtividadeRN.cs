using Biblioteca.ClassesBasicas;
using Biblioteca.Interfaces;
using Biblioteca.Parametros;
using System;
using System.Collections.Generic;

namespace Biblioteca.RegraNegocio
{
    public class AtividadeRN : IAtividade
    {
        private void ValidarDadosBasicos(Atividade atividade)
        {
            if (atividade == null)
            {
                throw new Exception("Erro! Favor, instanciar atividade do usuário.");
            }

            if (String.IsNullOrEmpty(atividade.nome) == true || String.IsNullOrWhiteSpace(atividade.nome) == true)
            {
                throw new Exception("Erro! Campo vazio. Favor, informar nome da atividade do usuário.");
            }

            if (atividade.nome.Trim().Length < 1 || atividade.nome.Trim().Length > 30)
            {
                throw new Exception("Erro! Número de caracteres não compatível. A descrição deve conter mais de 1 caracter e no máximo 30.");
            }

            if (String.IsNullOrEmpty(atividade.descricao) == true || String.IsNullOrWhiteSpace(atividade.descricao) == true)
            {
                throw new Exception("Erro! Campo vazio. Favor, informar uma descrição da atividade do usuário.");
            }

            if (atividade.descricao.Trim().Length < 1 || atividade.descricao.Trim().Length > 144)
            {
                throw new Exception("Erro! Número de caracteres não compatível. A descrição deve conter mais de um caracter e no máximo 144.");
            }
        }

        public void Insert(Atividade atividade)
        {
            if (atividade == null)
            {
                throw new Exception("Erro! Atividade não criada.");
            }

            AtividadeSqlServer dados = new AtividadeSqlServer();
            dados.Insert(atividade);
        }
        
        public void Update(Atividade atividade)
        {
            if (atividade == null)
            {
                throw new Exception("Erro! Tipo de usuário já existente.");
            }

            AtividadeSqlServer dados = new AtividadeSqlServer();
            dados.Update(atividade);
        }

        public void Delete(Atividade atividade)
        {
            if (atividade == null)
            {
                throw new Exception("Erro! Favor, instanciar a atividade do usuário.");
            }

            AtividadeSqlServer dados = new AtividadeSqlServer();
            dados.Delete(atividade);
        }

        public List<Atividade> Select(Atividade filtro)
        {
            AtividadeSqlServer dados = new AtividadeSqlServer();
            return dados.Select(filtro);
        }
    }
}

