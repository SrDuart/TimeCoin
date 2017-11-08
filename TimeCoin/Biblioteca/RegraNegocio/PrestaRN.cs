using Biblioteca.ClassesBasicas;
using Biblioteca.Interfaces;
using Biblioteca.Parametros;
using System;
using System.Collections.Generic;

namespace Biblioteca.RegraNegocio
{
    public class PrestaRN : IPresta
    {
        private void ValidarDadosBasicos(Presta presta)
        {
            if (presta == null)
            {
                throw new Exception("Erro! Campo nulo. Favor, instanciar serviço prestado pelo usuário.");
            }

            if (presta.quantidadeHora == 0)
            {
                throw new Exception("Erro! Número de horas vazio. Favor, instanciar a quantidade de horas recebidas pelo serviço prestado.");
            }
            
            if (presta.avaliacao == 0)
            {
                throw new Exception("Erro! Avaliação não realizada. Favor, instanciar a avaliação do serviço prestado.");
            }

            if (presta.avaliacao < 0 || presta.avaliacao > 5)
            {
                throw new Exception("Erro! Avaliação inválida. Favor, avaliar entre 0 e 5.");
            }
        }

        public void Delete(Presta presta)
        {
            if (presta == null)
            {
                throw new Exception("Erro! Campo nulo. Favor, instanciar serviço prestado pelo usuário.");
            }

            PrestaSqlServer dados = new PrestaSqlServer();
            dados.Delete(presta);
        }

        public void Insert(Presta presta)
        {
            ValidarDadosBasicos(presta);

            if (this.VerificaDuplicidade(presta))
            {
                throw new Exception("Erro! Serviço prestado pelo usuário já existente.");
            }

            PrestaSqlServer dados = new PrestaSqlServer();
            dados.Insert(presta);
        }

        public List<Presta> Select(Presta filtro)
        {
            PrestaSqlServer dados = new PrestaSqlServer();
            return dados.Select(filtro);
        }

        public void Update(Presta presta)
        {
            ValidarDadosBasicos(presta);

            if (this.VerificaDuplicidade(presta) == true)
            {
                throw new Exception("Erro! Serviço prestado pelo usuário já existente.");
            }
            
            PrestaSqlServer dados = new PrestaSqlServer();
            dados.Update(presta);
        }

        public bool VerificaDuplicidade(Presta presta)
        {
            if (presta == null)
            {
                throw new Exception("Erro! Campo nulo. Favor, instanciar serviço prestado pelo usuário.");
            }

            if (presta.data == null)
            {
                throw new Exception("Erro! Campo nulo. Favor preencher a data.");
            }

            if (presta.usuario.id < 1)
            {
                throw new Exception("Erro! Campo nulo. Favor preencher o id do usuário.");
            }

            if (presta.servico.id < 1)
            {
                throw new Exception("Erro! Campo nulo. Favor preencher o id de serviço.");
            }

            PrestaSqlServer dados = new PrestaSqlServer();
            return dados.VerificaDuplicidade(presta);
        }
    }
}
