using System.Collections.Generic;
using Biblioteca.ClassesBasicas;

namespace Biblioteca.Interfaces
{
    public interface IAtividade
	{
        void Insert(Atividade atividade);
        void Update(Atividade atividade);
        void Delete(Atividade atividade);
        bool VerificaDuplicidade(Atividade atividade);
        List<Atividade> Select(Atividade atividadeo);
    }
}
