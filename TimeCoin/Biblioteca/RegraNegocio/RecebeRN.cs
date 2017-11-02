﻿using Biblioteca.ClassesBasicas;
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
                throw new Exception("Erro! Campo nulo. Favor instanciar serviço recebido pelo usuário.");
            }
        }

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
                throw new Exception("Erro! Campo nulo. Favor instanciar serviço recebido pelo usuário.");
            }

            RecebeSqlServer dados = new RecebeSqlServer();
            return dados.VerificaDuplicidade(recebe);
        }
    }
}
