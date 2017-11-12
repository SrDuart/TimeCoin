using Biblioteca.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.ClassesBasicas;
using Biblioteca.Parametros;

namespace Biblioteca.RegraNegocio
{
    public class UsuarioHabilidadeRN : IUsuarioHabilidade
    {
        public void VerificaDadosBasicos(UsuarioHabilidade usuarioHabilidade)
        {
            if (usuarioHabilidade == null)
            {
                throw new Exception("Erro! usuarioHabilidade vazio.");
            }
            if(usuarioHabilidade.usuario.id <= 0)
            {
                throw new Exception("Erro! Favor informar um usuario.");
            }
            if (usuarioHabilidade.habilidade.id <= 0)
            {
                throw new Exception("Erro! Favor informar um habilidade.");
            }
        }
        public void Delete(UsuarioHabilidade usuarioHabilidade)
        {
            if (usuarioHabilidade.id <= 0)
            {
                throw new Exception("Erro! Favor informar um ID válido.");
            }
            UsuarioHabilidadeSqlServer dados = new UsuarioHabilidadeSqlServer();
            if (dados.VerificaExistencia(usuarioHabilidade))
            {
                dados.Delete(usuarioHabilidade);
            } else
            {
                throw new Exception("Este usuário não existe ou já foi excluído");
            }

        }

        public void Insert(UsuarioHabilidade usuarioHabilidade)
        {
            VerificaDadosBasicos(usuarioHabilidade);            
            if (!this.VerificaDuplicidade(usuarioHabilidade))
            {
                UsuarioHabilidadeSqlServer dados = new UsuarioHabilidadeSqlServer();
                dados.Insert(usuarioHabilidade);
            } else
            {
                throw new Exception("Esta habilidade já está associada a este usuário");
            }

        }

        public List<UsuarioHabilidade> Select()
        {
            UsuarioHabilidadeSqlServer dados = new UsuarioHabilidadeSqlServer();
            return dados.Select();
        }

        public void Update(UsuarioHabilidade usuarioHabilidade)
        {
            if(usuarioHabilidade.id <= 0)
            {
                throw new Exception("Erro! ID de UsuarioHabilidade inválido");
            }
            this.VerificaDadosBasicos(usuarioHabilidade);
            UsuarioHabilidadeSqlServer dados = new UsuarioHabilidadeSqlServer();
            if (dados.VerificaExistencia(usuarioHabilidade))
            {
                dados.Update(usuarioHabilidade);
            } else
            {
                throw new Exception("Erro ao atualizar. ID não existe na base de dados");
            }
        }

        public bool VerificaDuplicidade(UsuarioHabilidade usuarioHabilidade)
        {
            VerificaDadosBasicos(usuarioHabilidade);
            UsuarioHabilidadeSqlServer dados = new UsuarioHabilidadeSqlServer();
            return dados.VerificaDuplicidade(usuarioHabilidade);
        }
    }
}
