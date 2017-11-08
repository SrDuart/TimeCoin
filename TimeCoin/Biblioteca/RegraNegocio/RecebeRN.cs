using Biblioteca.ClassesBasicas;
using Biblioteca.Interfaces;
using Biblioteca.Parametros;
using System;
using System.Collections.Generic;

namespace Biblioteca.RegraNegocio
{
    public class RecebeRN : IRecebe
    {
        private void ValidarDadosBasicos(Recebe recebe)
        {
            if (recebe == null)
            {
                throw new Exception("Erro! Favor, instanciar serviço recebido pelo usuário.");
            }

            if (recebe.quantidadeHora == 0)
            {
                throw new Exception("Erro! Número de horas vazio. Favor, instanciar a quantidade de horas paga pelo serviço recebido.");
            }

            if (recebe.avaliacao == 0)
            {
                throw new Exception("Erro! Avaliação não realizada. Favor, instanciar a avaliação do serviço recebido.");
            }

            if (recebe.avaliacao < 0 || recebe.avaliacao > 5)
            {
                throw new Exception("Erro! Avaliação inválida. Favor, avaliar entre 0 e 5 estrelas.");
            }
        }

        public void Delete(Recebe recebe)
        {
            if (recebe == null)
            {
                throw new Exception("Erro! Favor, instanciar serviço recebido pelo usuário.");
            }

            RecebeSqlServer dados = new RecebeSqlServer();
            dados.Delete(recebe);
        }

        public void Insert(Recebe recebe)   
        {
            ValidarDadosBasicos(recebe);

            if (this.VerificaDuplicidade(recebe))
            {
                throw new Exception("Erro! Serviço recebido pelo usuário já existente.");
            }

            RecebeSqlServer dados = new RecebeSqlServer();
            dados.Insert(recebe);
        }

        public List<Recebe> Select(Recebe filtro)
        {
            RecebeSqlServer dados = new RecebeSqlServer();
            return dados.Select(filtro);
        }

        public void Update(Recebe recebe)
        {
            ValidarDadosBasicos(recebe);

            if (this.VerificaDuplicidade(recebe) == true)
            {
                throw new Exception("Erro! Serviço recebido pelo usuário já existente.");
            }
            
            RecebeSqlServer dados = new RecebeSqlServer();
            dados.Update(recebe);
        }

        public bool VerificaDuplicidade(Recebe recebe)
        {        
            if (recebe == null)
            {
                throw new Exception("Erro! Favor instanciar serviço recebido pelo usuário.");
            }

            if (recebe.data == null)
            {
                throw new Exception("Erro! Campo nulo. Favor preencher a data.");
            }

            if (recebe.usuario.id < 1)
            {
                throw new Exception("Erro! Campo nulo. Favor preencher o id do usuário.");
            }

            if (recebe.servico.id < 1)
            {
                throw new Exception("Erro! Campo nulo. Favor preencher o id de serviço.");
            }

            RecebeSqlServer dados = new RecebeSqlServer();
            return dados.VerificaDuplicidade(recebe);


        }
    }
}
