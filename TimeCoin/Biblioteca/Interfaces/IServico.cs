using System.Collections.Generic;
using Biblioteca.ClassesBasicas;

namespace Biblioteca.Interfaces
{
    public interface IServico
	{
		void Insert(Servico servico);
		void Update(Servico servico);
		void Delete(Servico servico);
		bool VerificaDuplicidade(Servico servico);
		List<Servico> Select(Servico filtro);
	}
}
