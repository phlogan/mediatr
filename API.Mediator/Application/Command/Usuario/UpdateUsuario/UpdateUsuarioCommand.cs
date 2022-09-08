using MediatR;

namespace Application.Command.Usuario.UpdateUsuario
{
    public class UpdateUsuarioCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string DescricaoEscolaridade { get; set; }
    }
}
