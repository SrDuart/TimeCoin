using Biblioteca.ClassesBasicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Interfaces
{
    public interface ITipoAnuncio
    {
        void Insert(TipoAnuncio tipoAnuncio);
        void Update(TipoAnuncio tipoAnuncio);
        void Delete(TipoAnuncio tipoAnuncio);
        bool VerificaDuplicidade(TipoAnuncio tipoAnuncio);
        List<TipoAnuncio> Select(TipoAnuncio filtro);
    }
}
