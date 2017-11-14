using System;
using System.Runtime.Serialization;

namespace Biblioteca.ClassesBasicas
{
    [Serializable]
    public class TipoAnuncio
    {
        [DataMember(IsRequired = true)]
        public int id { get; set; }
        [DataMember(IsRequired = true)]
        public string descricao { get; set; }
    }
}
