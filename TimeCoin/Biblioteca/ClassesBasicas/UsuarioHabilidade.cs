using System;
using System.Runtime.Serialization;

namespace Biblioteca.ClassesBasicas
{
    [Serializable]
    [DataContract]
    public class UsuarioHabilidade
	{
        [DataMember(IsRequired = true)]
        public int id { get; set; }
        [DataMember(IsRequired = true)]
        public Usuario usuario { get; set; }
        [DataMember(IsRequired = true)]
        public Habilidade habilidade { get; set; }
	}
}
