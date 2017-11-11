using Biblioteca.ClassesBasicas;
using System.Collections.Generic;

namespace Biblioteca.Interfaces
{
    public interface IUsuarioHabilidade
	{
        void Insert(UsuarioHabilidade usuarioHabilidade);
        void Update(UsuarioHabilidade usuarioHabilidade);
<<<<<<< HEAD
        void Delete(UsuarioHabilidade usuarioHabilidade);
=======
        void Delete(UsuarioHabilidade usuarioAtividade);
>>>>>>> 948ad0333051563b7044f56038c2f35a8f9d5dc3
        bool VerificaDuplicidade(UsuarioHabilidade usuarioHabilidade);
        List<UsuarioHabilidade> Select(UsuarioHabilidade filtro);
    }
}
