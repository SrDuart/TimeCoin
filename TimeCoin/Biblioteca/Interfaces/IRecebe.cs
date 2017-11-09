using System.Collections.Generic;
using Biblioteca.ClassesBasicas;

namespace Biblioteca.Interfaces
{
    public interface IRecebe
	{
        void Insert(Recebe recebe);        
        void Delete(Recebe recebe);        
        List<Recebe> Select(Recebe filtro);
    }
}
