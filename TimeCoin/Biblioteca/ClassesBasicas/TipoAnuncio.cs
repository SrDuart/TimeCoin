using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

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
