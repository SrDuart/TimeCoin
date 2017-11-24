using System;
using System.Runtime.Serialization;

namespace Biblioteca.ClassesBasicas
{
    [Serializable]
    [DataContract]
    public class Presta
	{
        [DataMember(IsRequired = true)]
        public Usuario usuario { get; set; }
        [DataMember(IsRequired = true)]
        public Servico servico { get; set; }
        [DataMember(IsRequired = true)]
        public int qtdHora { get; set; }
        [DataMember(IsRequired = true)]
        public double avaliacao { get; set; }
        [DataMember(IsRequired = true)]
        public DateTime data { get; set; }
    }
}
