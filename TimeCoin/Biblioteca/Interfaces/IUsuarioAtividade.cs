using Biblioteca.ClassesBasicas;
using System.Collections.Generic;

namespace Biblioteca.Interfaces
{
    public interface IUsuarioAtividade
	{
        void Insert(UsuarioAtividade usuarioAtividade);
        void Update(UsuarioAtividade usuarioAtividade);
        void Delete(UsuarioAtividade usuarioAtividade);
        bool VerificaDuplicidade(UsuarioAtividade usuarioAtividade);
        List<UsuarioAtividade> Select(UsuarioAtividade filtro);
    }
}
