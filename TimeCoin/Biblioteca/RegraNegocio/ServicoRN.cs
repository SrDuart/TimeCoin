using Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using Biblioteca.ClassesBasicas;
using Biblioteca.Parametros;

namespace Biblioteca.RegraNegocio
{
    public class ServicoRN : IServico
    {
        public void Insert(Servico servico)
        {
            if (servico == null)
            {
                throw new Exception("Favor, instanciar o serviço.");
            }

            if (servico.nome == null || servico.nome.Trim().Equals("") || servico.nome.Trim().Length < 60)
            {
                throw new Exception("Favor, informar o descrição do serviço.");
            }

            if (this.VerificaDuplicidade(servico))
            {
                throw new Exception("Tipo de serviço já existente.");
            }

            ServicoSqlServer dados = new ServicoSqlServer();
            dados.Insert(servico);
        }

        public void Update(Servico servico)
        {
            if (servico == null)
            {
                throw new Exception("Favor, instanciar o serviço.");
            }

            if (servico.nome == null || servico.nome.Trim().Equals("") || servico.nome.Trim().Length < 60)
            {
                throw new Exception("Favor, informar o serviço.");
            }

            if (this.VerificaDuplicidade(servico))
            {
                throw new Exception("Tipo de serviço já existente.");
            }

            ServicoSqlServer dados = new ServicoSqlServer();
            dados.Update(servico);
        }

        public void Delete(Servico servico)
        {
            if (servico == null)
            {
                throw new Exception("Favor, instanciar o serviço.");
            }

            ServicoSqlServer dados = new ServicoSqlServer();
            dados.Delete(servico);
        }

        public bool VerificaDuplicidade(Servico servico)
        {
            if (servico == null)
            {
                throw new Exception("Favor, instanciar o serviço.");
            }
            if (servico.nome != null)
            {
                throw new Exception("Favor, informar a descrição do serviço.");
            }

            ServicoSqlServer dados = new ServicoSqlServer();
            return dados.VerificaDuplicidade(servico);
        }

        public List<Servico> Select(Servico filtro)
        {
            ServicoSqlServer dados = new ServicoSqlServer();
            return dados.Select(filtro);
        }        
    }
}
