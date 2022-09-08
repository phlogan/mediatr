using Application.DTO.Usuario;
using MediatR;

namespace Application.Query.Usuario.GetUsuarioBasicInfo
{
    public class GetUsuarioBasicInfoQuery : IRequest<UsuarioBasicInfoDTO>
    {
        public GetUsuarioBasicInfoQuery(int id)
        {
            IdUsuario = id;
        }
        public int IdUsuario { get; set; }
    }
}
