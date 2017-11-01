using System.Collections.Generic;
using Biblioteca.ClassesBasicas;

namespace Biblioteca.Interfaces
{
    public interface IUsuario
	{
		void Insert(Usuario usuario);
		void Update(Usuario usuario);
		void Delete(Usuario usuario);
		bool VerificaDuplicidade(Usuario usuario);
		List<Usuario> Select(Usuario filtro);
	}
}
