using Biblioteca.ClassesBasicas;
using System.Collections.Generic;

namespace Biblioteca.Interfaces
{
    public interface IUsuarioHabilidade
	{
        void Insert(UsuarioHabilidade usuarioAtividade);
        void Update(UsuarioHabilidade usuarioAtividade);
        void Delete(UsuarioHabilidade usuarioAtividade);
        bool VerificaDuplicidade(UsuarioHabilidade usuarioAtividade);
        List<UsuarioHabilidade> Select(UsuarioHabilidade filtro);
    }
}
