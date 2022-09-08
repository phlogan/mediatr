using MediatR;

namespace Application.Command.Escolaridade.UpdateEscolaridade
{
    public class UpdateEscolaridadeCommand : IRequest<Unit>
    {
        public int IdUsuario { get; set; }
        public string Descricao { get; set; }
    }
}
