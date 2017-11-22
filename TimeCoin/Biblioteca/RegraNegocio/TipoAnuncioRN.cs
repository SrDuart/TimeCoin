using Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using Biblioteca.ClassesBasicas;
using Biblioteca.Parametros;

namespace Biblioteca.RegraNegocio
{
    public class TipoAnuncioRN : ITipoAnuncio
    {
        public void Insert(TipoAnuncio tipoAnuncio)
        {
            this.ValidarDadosBasicos(tipoAnuncio);
            if (!this.VerificaDuplicidade(tipoAnuncio))
            {
                TipoAnuncioSqlServer dados = new TipoAnuncioSqlServer();
                dados.Insert(tipoAnuncio);
            }
            else
            {
                throw new Exception("Este tipo de anúncio já existe");
            }
        }
        
        public void Update(TipoAnuncio tipoAnuncio)
        {
            this.ValidarDadosBasicos(tipoAnuncio);
            TipoAnuncioSqlServer dados = new TipoAnuncioSqlServer();
            if (dados.VerificaExistencia(tipoAnuncio))
            {
                dados.Update(tipoAnuncio);
            }
            else
            {
                throw new Exception("Este tipo de anúncio não existe");
            }
        }

        public void Delete(TipoAnuncio tipoAnuncio)
        {
            if (tipoAnuncio.id <= 0)
            {
                throw new Exception("Favor informar um ID válido");
            }
            TipoAnuncioSqlServer dados = new TipoAnuncioSqlServer();
            if (dados.VerificaExistencia(tipoAnuncio))
            {
                dados.Delete(tipoAnuncio);
            }
            else
            {
                throw new Exception("Este tipo de anúncio não existe ou já foi excluído");
            }
        }

        public bool VerificaDuplicidade(TipoAnuncio tipoAnuncio)
        {
            ValidarDadosBasicos(tipoAnuncio);
            TipoAnuncioSqlServer dados = new TipoAnuncioSqlServer();
            return dados.VerificaDuplicidade(tipoAnuncio);
        }

        public List<TipoAnuncio> Select()
        {
            TipoAnuncioSqlServer dados = new TipoAnuncioSqlServer();
            return dados.Select();
        }

        public void ValidarDadosBasicos(TipoAnuncio tipoAnuncio)
        {
            if (tipoAnuncio == null)
            {
                throw new Exception("Erro! TipoAnuncio não instanciado.");
            }

            if (tipoAnuncio.descricao.Length > 15 || tipoAnuncio.descricao.Trim().Length == 0)
            {
                throw new Exception("Informe uma descrição válida");
            }

        }
    }
}
