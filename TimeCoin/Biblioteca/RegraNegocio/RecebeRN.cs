using Biblioteca.ClassesBasicas;
using Biblioteca.Interfaces;
using Biblioteca.Parametros;
using System;
using System.Collections.Generic;

namespace Biblioteca.RegraNegocio
{
    public class RecebeRN : IRecebe
    {
        public void Delete(Recebe recebe)
        {
            if (recebe == null)
            {
                throw new Exception("Favor, instanciar serviço recebido pelo usuário.");
            }

            RecebeSqlServer dados = new RecebeSqlServer();
            dados.Delete(recebe);
        }

        public void Insert(Recebe recebe)
        {

            if (recebe == null)
            {
                throw new Exception("Favor, informar o serviço recebido pelo usuário.");
            }

            if (this.VerificaDuplicidade(recebe) == true)
            {
                throw new Exception("O serviço recebido pelo usuário já existe.");
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
            if (recebe == null)
            {
                throw new Exception("Favor, instanciar serviço recebido pelo usuário.");
            }            

            if (this.VerificaDuplicidade(recebe))
            {
                throw new Exception("O serviço recebido pelo usuário já existe.");
            }

            RecebeSqlServer dados = new RecebeSqlServer();
            dados.Update(recebe);
        }

        public bool VerificaDuplicidade(Recebe recebe)
        {
            if (recebe == null)
            {
                throw new Exception("Favor, informar serviço recebido pelo usuário.");
            }

            RecebeSqlServer dados = new RecebeSqlServer();
            return dados.VerificaDuplicidade(recebe);
        }
    }
}
