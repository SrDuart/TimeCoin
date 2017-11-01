using System;

namespace Biblioteca.ClassesBasicas
{
    public class Anuncio
	{
		public int id { get; set; }
		public Usuario usuario { get; set; }
        public Situacao situacao { get; set; }
        public string tipoAnuncio { get; set; }
		public string descricao { get; set; }
		public DateTime date { get; set; }		
		public string preRequisito { get; set; }
	}
}
