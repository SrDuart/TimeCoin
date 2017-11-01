using System.Collections.Generic;
using Biblioteca.ClassesBasicas;

namespace Biblioteca.Interfaces
{
    public interface IPresta
	{
        void Insert(Presta presta);
        void Update(Presta presta);
        void Delete(Presta presta);
        bool VerificaDuplicidade(Presta presta);
        List<Presta> Select(Presta filtro);
    }
}
