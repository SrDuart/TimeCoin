using Biblioteca.ClassesBasicas;
using System.Collections.Generic;

namespace Biblioteca.Interfaces
{
    public interface IAnuncio
	{
        void Insert(Anuncio anuncio);
        void Update(Anuncio anuncio);
        void Delete(Anuncio anuncio);
        bool VerificaDuplicidade(Anuncio anuncio);
        List<Anuncio> Select();
    }
}
