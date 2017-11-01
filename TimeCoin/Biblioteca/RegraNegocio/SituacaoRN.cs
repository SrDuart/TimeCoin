using Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.ClassesBasicas;
using Biblioteca.Parametros;

namespace Biblioteca.RegraNegocio
{
    public class SituacaoRN : ISituacao
    {
        public void Delete(Situacao situacao)
        {
            if (situacao == null)
            {
                throw new Exception("Favor, instanciar a situação.");
            }

            SituacaoSqlServer dados = new SituacaoSqlServer();
            dados.Delete(situacao);
        }

        public void Insert(Situacao situacao)
        {
            if (situacao == null)
            {
                throw new Exception("Favor, instanciar a situação.");
            }

            if (situacao.status == null || situacao.status.Trim().Equals("") || situacao.status.Length < 1)
            {
                throw new Exception("Favor, informar o nome da situação.");
            }

            if (situacao.descricao == null || situacao.descricao.Trim().Equals("") || situacao.descricao.Length < 1)
            {
                throw new Exception("Favor, informar a descrição da situação.");
            }

            if (situacao.status.Trim().Length > 1)
            {
                throw new Exception("O nome poderá conter até 1 caracter.");
            }

            if (situacao.descricao.Trim().Length > 20)
            {
                throw new Exception("A descrição poderá conter até 20 caracteres.");
            }

            if (this.VerificaDuplicidade(situacao))
            {
                throw new Exception("Tipo de situacao já existe.");
            }

            SituacaoSqlServer dados = new SituacaoSqlServer();
            dados.Insert(situacao);
        }

        public List<Situacao> Select(Situacao filtro)
        {
            SituacaoSqlServer dados = new SituacaoSqlServer();
            return dados.Select(filtro);
        }

        public void Update(Situacao situacao)
        {
            if (situacao == null)
            {
                throw new Exception("Favor, instanciar a situacao.");
            }

            if (situacao.status == null || situacao.status.Trim().Equals(""))
            {
                throw new Exception("Favor, informar o nome da situação.");
            }

            if (situacao.descricao == null || situacao.descricao.Trim().Equals(""))
            {
                throw new Exception("Favor, informar a descrição da situação.");
            }

            if (situacao.status.Trim().Length > 1)
            {
                throw new Exception("O nome poderá conter até 1 caracter.");
            }

            if (situacao.descricao.Trim().Length > 1)
            {
                throw new Exception("A descrição poderá conter até 20 caracteres.");
            }

            if (this.VerificaDuplicidade(situacao))
            {
                throw new Exception("Tipo de situação já existe.");
            }

            SituacaoSqlServer dados = new SituacaoSqlServer();
            dados.Update(situacao);
        }

        public bool VerificaDuplicidade(Situacao situacao)
        {
            if (situacao == null)
            {
                throw new Exception("Favor, instanciar a situação.");
            }

            if (situacao.status != null)
            {
                throw new Exception("Favor, informar o nome da situação.");
            }

            if (situacao.descricao != null)
            {
                throw new Exception("Favor, informar a descrição da situação.");
            }

            SituacaoSqlServer dados = new SituacaoSqlServer();
            return dados.VerificaDuplicidade(situacao);
        }
    }
}
