using Biblioteca.ClassesBasicas;
using Biblioteca.Interfaces;
using Biblioteca.Parametros;
using System;
using System.Collections.Generic;

namespace Biblioteca.RegraNegocio
{
<<<<<<< HEAD:TimeCoin/Biblioteca/RegraNegocio/HabilidadeRN.cs
    public class HabilidadeRN : IHabilidade
=======
    public class AtividadeRN : IHabilidade
>>>>>>> 948ad0333051563b7044f56038c2f35a8f9d5dc3:TimeCoin/Biblioteca/RegraNegocio/AtividadeRN.cs
    {
        private void ValidarDadosBasicos(Habilidade atividade)
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

<<<<<<< HEAD:TimeCoin/Biblioteca/RegraNegocio/HabilidadeRN.cs
        public void Delete(Habilidade atividade)
=======
        public void Insert(Habilidade atividade)
>>>>>>> 948ad0333051563b7044f56038c2f35a8f9d5dc3:TimeCoin/Biblioteca/RegraNegocio/AtividadeRN.cs
        {
            if (atividade == null)
            {
                throw new Exception("Erro! Atividade não criada.");
            }

            HabilidadeSqlServer dados = new HabilidadeSqlServer();
<<<<<<< HEAD:TimeCoin/Biblioteca/RegraNegocio/HabilidadeRN.cs
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

=======
            dados.Insert(atividade);
        }
        
>>>>>>> 948ad0333051563b7044f56038c2f35a8f9d5dc3:TimeCoin/Biblioteca/RegraNegocio/AtividadeRN.cs
        public void Update(Habilidade atividade)
        {
            if (atividade == null)
            {
                throw new Exception("Erro! Tipo de usuário já existente.");
            }

            HabilidadeSqlServer dados = new HabilidadeSqlServer();
            dados.Update(atividade);
        }

<<<<<<< HEAD:TimeCoin/Biblioteca/RegraNegocio/HabilidadeRN.cs
        public bool VerificaDuplicidade(Habilidade atividade)
=======
        public void Delete(Habilidade atividade)
>>>>>>> 948ad0333051563b7044f56038c2f35a8f9d5dc3:TimeCoin/Biblioteca/RegraNegocio/AtividadeRN.cs
        {
            if (atividade == null)
            {
                throw new Exception("Erro! Favor, instanciar a atividade do usuário.");
            }

            HabilidadeSqlServer dados = new HabilidadeSqlServer();
<<<<<<< HEAD:TimeCoin/Biblioteca/RegraNegocio/HabilidadeRN.cs
            return dados.VerificaDuplicidade(atividade);
=======
            dados.Delete(atividade);
        }

        public List<Habilidade> Select(Habilidade filtro)
        {
            HabilidadeSqlServer dados = new HabilidadeSqlServer();
            return dados.Select(filtro);
>>>>>>> 948ad0333051563b7044f56038c2f35a8f9d5dc3:TimeCoin/Biblioteca/RegraNegocio/AtividadeRN.cs
        }
    }
}

