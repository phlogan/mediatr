namespace Domain.Entities.Usuario
{
    public class Usuario : BaseEntity
    {
        public Usuario() { }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public int EscolaridadeId { get; set; }
        public Escolaridade.Escolaridade Escolaridade { get; set; }
        public int HistoricoEscolarId { get; set; }
    }
}
