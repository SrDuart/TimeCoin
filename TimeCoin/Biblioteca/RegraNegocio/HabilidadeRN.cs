using Biblioteca.ClassesBasicas;
using Biblioteca.Interfaces;
using Biblioteca.Parametros;
using System;
using System.Collections.Generic;

namespace Biblioteca.RegraNegocio
{
    public class HabilidadeRN : IHabilidade
    {
        public void Insert(Habilidade habilidade)
        {
            ValidarDadosBasicos(habilidade);

            if (this.VerificaDuplicidade(habilidade))
            {
                throw new Exception("Erro! Habilidade do usuário já existente.");
            }

            HabilidadeSqlServer dados = new HabilidadeSqlServer();
            dados.Insert(habilidade);
        }

        public void Update(Habilidade habilidade)
        {
            if (habilidade == null)
            {
                throw new Exception("Erro! Habilidade já existente.");
            }

            HabilidadeSqlServer dados = new HabilidadeSqlServer();
            dados.Update(habilidade);
        }

        public void Delete(Habilidade habilidade)
        {
            if (habilidade == null)
            {
                throw new Exception("Erro! Habilidade não criada.");
            }

            HabilidadeSqlServer dados = new HabilidadeSqlServer();
            dados.Delete(habilidade);
        }

        public bool VerificaDuplicidade(Habilidade habilidade)

        {
            if (habilidade == null)
            {
                throw new Exception("Erro! Favor, instanciar a habilidade do usuário.");
            }

            HabilidadeSqlServer dados = new HabilidadeSqlServer();
            return dados.VerificaDuplicidade(habilidade);
        }

        public List<Habilidade> Select(Habilidade filtro)
        {
            HabilidadeSqlServer dados = new HabilidadeSqlServer();
            return dados.Select(filtro);
        }

        private void ValidarDadosBasicos(Habilidade habilidade)
        {
            if (habilidade == null)
            {
                throw new Exception("Erro! Favor, instanciar habilidade do usuário.");
            }

            if (String.IsNullOrEmpty(habilidade.nome) == true || String.IsNullOrWhiteSpace(habilidade.nome) == true)
            {
                throw new Exception("Erro! Campo vazio. Favor, informar nome da habilidade do usuário.");
            }

            if (habilidade.nome.Trim().Length < 1 || habilidade.nome.Trim().Length > 30)
            {
                throw new Exception("Erro! Número de caracteres não compatível. A descrição deve conter mais de 1 caracter e no máximo 30.");
            }

            if (String.IsNullOrEmpty(habilidade.descricao) == true || String.IsNullOrWhiteSpace(habilidade.descricao) == true)
            {
                throw new Exception("Erro! Campo vazio. Favor, informar uma descrição da atividade do usuário.");
            }

            if (habilidade.descricao.Trim().Length < 1 || habilidade.descricao.Trim().Length > 144)
            {
                throw new Exception("Erro! Número de caracteres não compatível. A descrição deve conter mais de um caracter e no máximo 144.");
            }
        }
    }
}

