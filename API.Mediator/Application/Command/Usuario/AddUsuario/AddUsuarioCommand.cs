using MediatR;

namespace Application.Command.Usuario.AddUsuario
{
    public class AddUsuarioCommand : IRequest<Unit>
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string DescricaoEscolaridade { get; set; }
    }
}
