using Biblioteca.ClassesBasicas;
using System.Collections.Generic;

namespace Biblioteca.Interfaces
{
    public interface ITipoAnuncio
    {
        void Insert(TipoAnuncio tipoAnuncio);
        void Update(TipoAnuncio tipoAnuncio);
        void Delete(TipoAnuncio tipoAnuncio);
        bool VerificaDuplicidade(TipoAnuncio tipoAnuncio);
        List<TipoAnuncio> Select();
    }
}
