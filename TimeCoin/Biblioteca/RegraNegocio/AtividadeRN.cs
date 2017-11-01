using Biblioteca.ClassesBasicas;
using Biblioteca.Interfaces;
using Biblioteca.Parametros;
using System;
using System.Collections.Generic;

namespace Biblioteca.RegraNegocio
{
    public class AtividadeRN : IAtividade
    {
        public void Delete(Atividade atividade)
        {
            if (atividade == null)
            {
                throw new Exception("Favor, instanciar a atividade do usuário.");
            }

            AtividadeSqlServer dados = new AtividadeSqlServer();
            dados.Delete(atividade);
        }

        public void Insert(Atividade atividade)
        {

            if (atividade == null)
            {
                throw new Exception("Favor, instanciar a atividade do usuário.");
            }

            if (atividade.nome == null)
            {
                throw new Exception("Favor, informar o nome da atividade do usuário.");
            }

            if (atividade.nome.Trim().Equals("") == true)
            {
                throw new Exception("Favor, informar o nome da atividade do usuário.");
            }
            if (atividade.nome.Trim().Length > 20)
            {
                throw new Exception("O nome poderá conter até 20 caracteres.");
            }

            if (atividade.descricao == null)
            {
                throw new Exception("Favor, informar a descrição da atividade do usuário.");
            }

            if (atividade.descricao.Trim().Equals("") == true)
            {
                throw new Exception("Favor, informar a descrição da atividade do usuário.");
            }

            if (atividade.descricao.Trim().Length > 144)
            {
                throw new Exception("A descrição poderá conter até 144 caracteres.");
            }

            if (this.VerificaDuplicidade(atividade) == true)
            {
                throw new Exception("Atividade existente com o referido nome.");
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
            if (atividade == null)
            {
                throw new Exception("Favor, instanciar a Tipo de usuário.");
            }

            if (atividade.descricao == null || atividade.descricao.Trim().Equals(""))
            {
                throw new Exception("Favor, informar o descrição do Tipo do usuário.");
            }

            if (atividade.descricao.Trim().Length > 20)
            {
                throw new Exception("A descrição poderá conter até 20 caracteres.");
            }

            if (this.VerificaDuplicidade(atividade))
            {
                throw new Exception("Tipo de usuario já existe.");
            }

            AtividadeSqlServer dados = new AtividadeSqlServer();
            dados.Update(atividade);
        }

        public bool VerificaDuplicidade(Atividade atividade)
        {
            if (atividade == null)
            {
                throw new Exception("Favor, instanciar a atividade do usuário.");
            }
            if (atividade.nome != null)
            {
                throw new Exception("Favor, informar o nome da atividade do usuário.");
            }
            if (atividade.descricao != null)
            {
                throw new Exception("Favor, informar a descrição da atividade do usuário.");
            }

            AtividadeSqlServer dados = new AtividadeSqlServer();
            return dados.VerificaDuplicidade(atividade);
        }
    }
}

