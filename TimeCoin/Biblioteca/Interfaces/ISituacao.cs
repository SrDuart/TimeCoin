using Biblioteca.ClassesBasicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
