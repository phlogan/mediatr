using Application.DTO.Usuario;
using Application.Mappers;
using Domain.Interfaces;
using Domain.Interfaces.Services.Usuario;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Query.Usuario.GetUsuarioBasicInfo
{
    public class GetUsuarioBasicInfoQueryHandler : IRequestHandler<GetUsuarioBasicInfoQuery, UsuarioBasicInfoDTO>
    {
        private IUsuarioService _usuarioService;
        public GetUsuarioBasicInfoQueryHandler(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public Task<UsuarioBasicInfoDTO> Handle(GetUsuarioBasicInfoQuery request, CancellationToken cancellationToken)
        {
            var result = _usuarioService.GetBasicInfoDTOById(request.IdUsuario);
            return Task.FromResult(result.Map());
        }
    }
}
