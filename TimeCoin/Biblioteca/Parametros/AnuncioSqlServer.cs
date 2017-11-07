using Biblioteca.ConexaoBanco;
using Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.ClassesBasicas;

namespace Biblioteca.Parametros
{
    class AnuncioSqlServer : ConexaoSqlServer, IAnuncio
    {
        public void Delete(Anuncio anuncio)
        {
            throw new NotImplementedException();
        }

        public void Insert(Anuncio anuncio)
        {
            throw new NotImplementedException();
        }

        public List<Anuncio> Select(Anuncio filtro)
        {
            throw new NotImplementedException();
        }

        public void Update(Anuncio anuncio)
        {
            throw new NotImplementedException();
        }

        public bool VerificaDuplicidade(Anuncio anuncio)
        {
            throw new NotImplementedException();
        }
    }
}
