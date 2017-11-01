using Biblioteca.ClassesBasicas;
using Biblioteca.Interfaces;
using Biblioteca.Parametros;
using System;
using System.Collections.Generic;

namespace Biblioteca.RegraNegocio
{
    public class PrestaRN : IPresta
    {
        public void Delete(Presta presta)
        {
            if (presta == null)
            {
                throw new Exception("Favor, instanciar serviço prestado pelo usuário.");
            }

            PrestaSqlServer dados = new PrestaSqlServer();
            dados.Delete(presta);
        }

        public void Insert(Presta presta)
        {

            if (presta == null)
            {
                throw new Exception("Favor, informar serviço prestado pelo usuário.");
            }           

            if (this.VerificaDuplicidade(presta) == true)
            {
                throw new Exception("O serviço prestado pelo usuário já existe.");
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
            if (presta == null)
            {
                throw new Exception("Favor, instanciar serviço prestado pelo usuário.");
            }

            if (this.VerificaDuplicidade(presta))
            {
                throw new Exception("O serviço prestado pelo usuário já existe.");
            }

            PrestaSqlServer dados = new PrestaSqlServer();
            dados.Update(presta);
        }

        public bool VerificaDuplicidade(Presta presta)
        {
            if (presta == null)
            {
                throw new Exception("Favor, informar serviço prestado pelo usuário.");
            }
            
            PrestaSqlServer dados = new PrestaSqlServer();
            return dados.VerificaDuplicidade(presta);
        }
    }
}
