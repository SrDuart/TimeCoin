namespace Biblioteca.ClassesBasicas
{
    public class UsuarioHabilidade
	{
		public int id { get; set; }
		public Usuario usuario { get; set; }
		public Habilidade atividade { get; set; }
	}
}
