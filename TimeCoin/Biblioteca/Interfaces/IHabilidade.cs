using System.Collections.Generic;
using Biblioteca.ClassesBasicas;

namespace Biblioteca.Interfaces
{
    public interface IHabilidade
	{
        void Insert(Habilidade atividade);
        void Update(Habilidade atividade);
        void Delete(Habilidade atividade);
        bool VerificaDuplicidade(Habilidade atividade);
        List<Habilidade> Select(Habilidade atividadeo);
    }
}
