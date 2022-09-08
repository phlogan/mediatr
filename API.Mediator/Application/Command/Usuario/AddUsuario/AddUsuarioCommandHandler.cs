using Application.Mappers;
using Domain.Interfaces;
using Domain.Interfaces.Services.Usuario;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Command.Usuario.AddUsuario
{
    public class AddUsuarioCommandHandler : IRequestHandler<AddUsuarioCommand, Unit>
    {
        private IUsuarioService _usuarioService;
        private IUnitOfWork _uow;
        public AddUsuarioCommandHandler(IUsuarioService usuarioService, IUnitOfWork uow)
        {
            _usuarioService = usuarioService;
            _uow = uow;
        }
        public Task<Unit> Handle(AddUsuarioCommand request, CancellationToken cancellationToken)
        {
            var result = _usuarioService.Add(request.Map());
            _uow.SaveChanges();
            return Task.FromResult<Unit>(Unit.Value);
        }
    }
}
