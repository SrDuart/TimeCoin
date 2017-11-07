using System;

namespace Biblioteca.ClassesBasicas
{
    public class Recebe
	{
		public Usuario usuario { get; set; }
		public Servico servico { get; set; }
		public int quantidadeHora { get; set; }
		public double avaliacao { get; set; }
        public DateTime data { get; set; }
	}
}
