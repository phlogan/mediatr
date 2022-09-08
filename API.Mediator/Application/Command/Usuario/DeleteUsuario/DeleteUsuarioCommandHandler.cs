using Application.Mappers;
using Domain.Interfaces;
using Domain.Interfaces.Services.Usuario;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.Usuario.DeleteUsuario
{
    public class DeleteUsuarioCommandHandler : IRequestHandler<DeleteUsuarioCommand, Unit>
    {
        private IUsuarioService _usuarioService;
        private IUnitOfWork _uow;
        public DeleteUsuarioCommandHandler(IUsuarioService usuarioService, IUnitOfWork uow)
        {
            _usuarioService = usuarioService;
            _uow = uow;
        }
        public Task<Unit> Handle(DeleteUsuarioCommand request, CancellationToken cancellationToken)
        {
            var result = _usuarioService.Delete(request.Id);
            _uow.SaveChanges();
            return Task.FromResult<Unit>(Unit.Value);
        }
    }
}
