using System.Collections.Generic;
using Biblioteca.ClassesBasicas;
// teste
namespace Biblioteca.Interfaces
{
    public interface ITipoUsuario
	{
		void Insert(TipoUsuario tipoUsuario);
		void Update(TipoUsuario tipoUsuario);
		void Delete(TipoUsuario tipoUsuario);
		bool VerificaDuplicidade(TipoUsuario tipoUsuario);
		List<TipoUsuario> Select(TipoUsuario filtro);
	}
}
