using System;

namespace Biblioteca.ClassesBasicas
{
    public class Anuncio
	{
		public int id { get; set; }
		public Usuario usuario { get; set; }
        public Situacao situacao { get; set; }
        public TipoAnuncio tipoAnuncio { get; set; }
		public string descricao { get; set; }
		public DateTime data { get; set; }		
		public string preRequisito { get; set; }
        public string uf { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
	}
}
