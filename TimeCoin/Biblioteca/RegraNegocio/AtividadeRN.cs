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
                throw new Exception("Erro! Campo nulo. Favor, instanciar atividade do usuário.");
            }

            if (String.IsNullOrEmpty(atividade.nome) == true || String.IsNullOrWhiteSpace(atividade.nome) == true)
            {
                throw new Exception("Erro! Campo vazio. Favor, informar nome da atividade do usuário.");
            }

            if (atividade.nome.Trim().Length < 1 || atividade.nome.Trim().Length > 20)
            {
                throw new Exception("Erro! Número de caracteres não compatível. A descrição deve conter mais de um caracter e no máximo 20.");
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

        public void Delete(Atividade atividade)
        {
            if (atividade == null)
            {
                throw new Exception("Erro! Campo nulo. Favor, instanciar a atividade do usuário.");
            }

            AtividadeSqlServer dados = new AtividadeSqlServer();
            dados.Delete(atividade);
        }

        public void Insert(Atividade atividade)
        {
            ValidarDadosBasicos(atividade);

            if (this.VerificaDuplicidade(atividade))
            {
                throw new Exception("Erro! Atividade do usuário já existente.");
            }

            AtividadeSqlServer dados = new AtividadeSqlServer();
            dados.Insert(atividade);
        }

        public List<Atividade> Select(Atividade filtro)
        {
            AtividadeSqlServer dados = new AtividadeSqlServer();
            return dados.Select(filtro);
        }

        public void Update(Atividade atividade)
        {
            ValidarDadosBasicos(atividade);

            if (this.VerificaDuplicidade(atividade) == true)
            {
                throw new Exception("Erro! Atividade do usuário já existente.");
            }

            AtividadeSqlServer dados = new AtividadeSqlServer();
            dados.Update(atividade);
        }

        public bool VerificaDuplicidade(Atividade atividade)
        {
            if (atividade == null)
            {
                throw new Exception("Erro! Campo nulo. Favor, instanciar a atividade do usuário.");
            }
            if (atividade.nome == null)
            {
                throw new Exception("Erro! Campo nulo. Favor, informar o nome da atividade do usuário.");
            }
            if (atividade.descricao == null)
            {
                throw new Exception("Erro! Campo nulo. Favor, informar a descrição da atividade do usuário.");
            }

            AtividadeSqlServer dados = new AtividadeSqlServer();
            return dados.VerificaDuplicidade(atividade);
        }
    }
}

