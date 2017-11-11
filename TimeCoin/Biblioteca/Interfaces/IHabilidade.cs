using System.Collections.Generic;
using Biblioteca.ClassesBasicas;

namespace Biblioteca.Interfaces
{
    public interface IHabilidade
	{
        void Insert(Habilidade habilidade);
        void Update(Habilidade habilidade);
        void Delete(Habilidade habilidade);
        bool VerificaDuplicidade(Habilidade habilidade);
        List<Habilidade> Select(Habilidade habilidade);
    }
}
