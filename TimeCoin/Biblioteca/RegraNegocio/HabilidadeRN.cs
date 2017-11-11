using Biblioteca.ClassesBasicas;
using Biblioteca.Interfaces;
using Biblioteca.Parametros;
using System;
using System.Collections.Generic;

namespace Biblioteca.RegraNegocio
{
    public class HabilidadeRN : IHabilidade
    {
        private void ValidarDadosBasicos(Habilidade atividade)
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

        public void Delete(Habilidade atividade)
        {
            if (atividade == null)
            {
                throw new Exception("Erro! Campo nulo. Favor, instanciar a atividade do usuário.");
            }

            HabilidadeSqlServer dados = new HabilidadeSqlServer();
            dados.Delete(atividade);
        }

        public void Insert(Habilidade atividade)
        {
            ValidarDadosBasicos(atividade);

            if (this.VerificaDuplicidade(atividade))
            {
                throw new Exception("Erro! Atividade do usuário já existente.");
            }

            HabilidadeSqlServer dados = new HabilidadeSqlServer();
            dados.Insert(atividade);
        }

        public List<Habilidade> Select(Habilidade filtro)
        {
            HabilidadeSqlServer dados = new HabilidadeSqlServer();
            return dados.Select(filtro);
        }

        public void Update(Habilidade atividade)
        {
            ValidarDadosBasicos(atividade);

            if (this.VerificaDuplicidade(atividade) == true)
            {
                throw new Exception("Erro! Atividade do usuário já existente.");
            }

            HabilidadeSqlServer dados = new HabilidadeSqlServer();
            dados.Update(atividade);
        }

        public bool VerificaDuplicidade(Habilidade atividade)
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

            HabilidadeSqlServer dados = new HabilidadeSqlServer();
            return dados.VerificaDuplicidade(atividade);
        }
    }
}

