using Biblioteca.ClassesBasicas;
using System.Collections.Generic;

namespace Biblioteca.Interfaces
{
    public interface ISituacao
    {
        void Insert(Situacao situacao);
        void Update(Situacao situacao);
        void Delete(Situacao situacao);
        bool VerificaDuplicidade(Situacao situacao);
        List<Situacao> Select(Situacao situacao);
    }
}
