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
    public class AnuncioRN : IAnuncio
    {
        private void ValidarDadosBasicos(Anuncio anuncio)
        {
            if (anuncio == null)
            {
                throw new Exception("Erro! Favor informar um anúncio.");
            }
            
            if(anuncio.descricao.Length > 144 || anuncio.descricao.Trim().Length == 0)
            {
                throw new Exception("Informa uma descrição válida");
            }
            if (anuncio.preRequisito.Length > 144 || anuncio.preRequisito.Trim().Length == 0)
            {
                throw new Exception("Informa prerrequisitos válidos");
            }

            if (anuncio.data == null)
            {
                throw new Exception("Data não pode ser vazia!");
            }

            if (anuncio.uf == null)
            {
                throw new Exception("UF não pode ser vazio!");
            }

            if (anuncio.bairro == null)
            {
                throw new Exception("Bairro não pode ser vazio!");
            }

            if (anuncio.cidade == null)
            {
                throw new Exception("Cidade não pode ser vazio!");
            }

            if (anuncio.usuario.id <= 0)
            {
                throw new Exception("Anuncio precisa está associado a um usuário!");
            }

            if (anuncio.servico.id <= 0)
            {
                throw new Exception("Anuncio precisa está associado a um serviço!");
            }

            if (anuncio.situacao.id <= 0)
            {
                throw new Exception("Anuncio precisa está associado a um situação!");
            }

            if (anuncio.tipoAnuncio.id <= 0)
            {
                throw new Exception("Anuncio precisa ter um tipo!");
            }
        }
        public void Delete(Anuncio anuncio)
        {
            if (anuncio.id <= 0)
            {
                throw new Exception("Informe um ID válido para exclusão");
            }
            AnuncioSqlServer dados = new AnuncioSqlServer();
            if (dados.VerificaExistencia(anuncio))
            {
                dados.Delete(anuncio);
            }
            else
            {
                throw new Exception("Este anuncio não existe");
            }
            
        }

        public void Insert(Anuncio anuncio)
        {            
            if (!this.VerificaDuplicidade(anuncio))
            {
                AnuncioSqlServer dados = new AnuncioSqlServer();
                dados.Insert(anuncio);
            } else
            {
                throw new Exception("Este anúncio já existe!");
            }            
        }

        public List<Anuncio> Select(Anuncio filtro)
        {
            AnuncioSqlServer dados = new AnuncioSqlServer();
            return dados.Select(filtro);
        }

        public void Update(Anuncio anuncio)
        {
            ValidarDadosBasicos(anuncio);
            AnuncioSqlServer dados = new AnuncioSqlServer();
            if (dados.VerificaExistencia(anuncio))
            {
                dados.Update(anuncio);
            }
            else
            {
                throw new Exception("Este anúncio não existe!");
            }
        }

        public bool VerificaDuplicidade(Anuncio anuncio)
        {
            ValidarDadosBasicos(anuncio);
            AnuncioSqlServer dados = new AnuncioSqlServer();
            return dados.VerificaDuplicidade(anuncio);
        }
    }
}
