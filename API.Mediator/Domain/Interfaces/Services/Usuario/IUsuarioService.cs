using Domain.DTO.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsuarioEntity = Domain.Entities.Usuario.Usuario;
namespace Domain.Interfaces.Services.Usuario
{
    public interface IUsuarioService
    {
        UsuarioEntity GetById(int id);
        UsuarioBasicInfoDTO GetBasicInfoDTOById(int id);
        int GetEscolaridadeIdById(int usuarioId);
        UsuarioEntity Add(UsuarioEntity usuario);
        UsuarioEntity Update(UsuarioEntity usuario);
        UsuarioEntity Delete(int id);
    }
}
