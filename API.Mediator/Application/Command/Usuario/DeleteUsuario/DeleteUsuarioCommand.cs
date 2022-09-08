using MediatR;

namespace Application.Command.Usuario.DeleteUsuario
{
    public class DeleteUsuarioCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
