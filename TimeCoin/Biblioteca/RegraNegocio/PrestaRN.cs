using Biblioteca.ClassesBasicas;
using Biblioteca.Interfaces;
using Biblioteca.Parametros;
using System;
using System.Collections.Generic;

namespace Biblioteca.RegraNegocio
{
    public class PrestaRN : IPresta
    {
        public void Insert(Presta presta)
        {
            ValidarDadosBasicos(presta);

            if (presta.qtdHora == 0)
            {
                throw new Exception("Erro! Valor de horas não depositado. Favor, depositar horas por serviço prestado pelo usuário.");
            }

            PrestaSqlServer dados = new PrestaSqlServer();
            dados.Insert(presta);
        }

        public void Delete(Presta presta)
        {
            if (presta == null)
            {
                throw new Exception("Erro! Favor, instanciar serviço prestado pelo usuário.");
            }

            PrestaSqlServer dados = new PrestaSqlServer();
            dados.Delete(presta);
        }

        public List<Presta> Select(Presta filtro)
        {
            PrestaSqlServer dados = new PrestaSqlServer();
            return dados.Select(filtro);
        }

        private void ValidarDadosBasicos(Presta presta)
        {
            if (presta == null)
            {
                throw new Exception("Erro! Campo nulo. Favor, instanciar serviço prestado pelo usuário.");
            }

            if (presta.qtdHora == 0)
            {
                throw new Exception("Erro! Número de horas vazio. Favor, instanciar a quantidade de horas recebidas pelo serviço prestado.");
            }

            if (presta.avaliacao == 0)
            {
                throw new Exception("Erro! Avaliação não realizada. Favor, instanciar a avaliação do serviço prestado.");
            }

            if (presta.avaliacao < 0 || presta.avaliacao > 5)
            {
                throw new Exception("Erro! Avaliação inválida. Favor, avaliar entre 0 e 5 estrelas.");
            }

            if (presta.data == null)
            {
                throw new Exception("Erro! Campo nulo. Favor, preencher a data.");
            }
        }
    }
}
