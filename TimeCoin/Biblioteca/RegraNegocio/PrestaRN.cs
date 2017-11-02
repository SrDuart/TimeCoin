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

            if (presta.quantidadeHora == 0) //CONFIRMAR SE ISSO ESTÁ CERTO
            {
                throw new Exception("Erro! Número de horas vazio. Favor, instanciar a quantidade de horas recebidas pelo serviço prestado.");
            }

            if (presta.avaliacao == 0) //CONFIRMAR SE ISSO ESTÁ CERTO
            {
                throw new Exception("Erro! Avaliação não realizada. Favor, instanciar a avaliação do serviço prestado.");
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
            
            PrestaSqlServer dados = new PrestaSqlServer();
            return dados.VerificaDuplicidade(presta);
        }
    }
}
