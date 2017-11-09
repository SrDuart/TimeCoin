using System.Collections.Generic;
using Biblioteca.ClassesBasicas;

namespace Biblioteca.Interfaces
{
    public interface IPresta
	{
        void Insert(Presta presta);        
        void Delete(Presta presta);        
        List<Presta> Select(Presta filtro);
    }
}
