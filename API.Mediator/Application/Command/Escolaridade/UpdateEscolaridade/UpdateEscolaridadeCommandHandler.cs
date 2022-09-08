using Domain.Interfaces;
using Domain.Interfaces.Services.Escolaridade;
using Domain.Interfaces.Services.Usuario;
using MediatR;

namespace Application.Command.Escolaridade.UpdateEscolaridade
{
    public class UpdateEscolaridadeCommandHandler : IRequestHandler<UpdateEscolaridadeCommand, Unit>
    {
        private IEscolaridadeService _escolaridadeService;
        private IUsuarioService _usuarioService;
        private IUnitOfWork _uow;
        public UpdateEscolaridadeCommandHandler(IUsuarioService usuarioService, IEscolaridadeService escolaridadeService, IUnitOfWork uow)
        {
            _escolaridadeService = escolaridadeService;
            _usuarioService = usuarioService;
            _uow = uow;
        }

        public Task<Unit> Handle(UpdateEscolaridadeCommand request, CancellationToken cancellationToken)
        {
            var escolaridadeId = _usuarioService.GetEscolaridadeIdById(request.IdUsuario);

            var result = _escolaridadeService.Update(new Domain.Entities.Escolaridade.Escolaridade
            {
                Id = escolaridadeId,
                Descricao = request.Descricao
            });
            _uow.SaveChanges();
            return Task.FromResult(Unit.Value);
        }
    }
}

