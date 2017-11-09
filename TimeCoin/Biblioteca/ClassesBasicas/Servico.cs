using System;
using System.Runtime.Serialization;

namespace Biblioteca.ClassesBasicas
{
    [Serializable]
    public class Servico
	{
        [DataMember(IsRequired = true)]
        public int id { get; set; }
        [DataMember(IsRequired = true)]
        public Situacao situacao { get; set; }
        [DataMember(IsRequired = true)]
        public string nome { get; set; }
	}
}
