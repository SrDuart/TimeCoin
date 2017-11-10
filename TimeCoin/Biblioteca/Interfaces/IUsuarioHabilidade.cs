using Biblioteca.ClassesBasicas;
using System.Collections.Generic;

namespace Biblioteca.Interfaces
{
    public interface IUsuarioHabilidade
	{
        void Insert(UsuarioHabilidade usuarioHabilidade);
        void Update(UsuarioHabilidade usuarioHabilidade);
        void Delete(UsuarioHabilidade usuarioAtividade);
        bool VerificaDuplicidade(UsuarioHabilidade usuarioHabilidade);
        List<UsuarioHabilidade> Select(UsuarioHabilidade filtro);
    }
}
