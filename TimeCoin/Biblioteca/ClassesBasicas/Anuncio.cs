using System;
using System.Runtime.Serialization;

namespace Biblioteca.ClassesBasicas
{
    [Serializable]
    public class Anuncio
	{
        [DataMember(IsRequired = true)]
        public int id { get; set; }
        [DataMember(IsRequired = true)]
        public Usuario usuario { get; set; }
        [DataMember(IsRequired = true)]
        public Situacao situacao { get; set; }
        [DataMember(IsRequired = true)]
        public TipoAnuncio tipoAnuncio { get; set; }
        [DataMember(IsRequired = true)]
        public Servico servico { get; set; }
        [DataMember(IsRequired = true)]
        public string descricao { get; set; }
        [DataMember(IsRequired = true)]
        public DateTime data { get; set; }
        [DataMember(IsRequired = true)]
        public string preRequisito { get; set; }
        [DataMember(IsRequired = true)]
        public string uf { get; set; }
        [DataMember(IsRequired = true)]
        public string bairro { get; set; }
        [DataMember(IsRequired = true)]
        public string cidade { get; set; }
	}
}
