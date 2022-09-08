using Application.Command.Usuario.AddUsuario;
using Application.Command.Usuario.UpdateUsuario;
using Application.DTO.Usuario;
using Domain.Entities.Escolaridade;
using Domain.Entities.Usuario;
namespace Application.Mappers
{
    public static class UsuarioMapper
    {
        public static Usuario Map(this AddUsuarioCommand usuario)
        {
            var escolaridade = new Escolaridade(usuario.DescricaoEscolaridade);
            return new Usuario
            {
                Nome = usuario.Nome,
                EscolaridadeId = escolaridade.Id,
                Escolaridade = escolaridade,
                DataNascimento = usuario.DataNascimento,
                Email = usuario.Email,
                Sobrenome = usuario.Sobrenome
            };
        }

        public static Usuario Map(this UpdateUsuarioCommand usuario)
        {
            var escolaridade = new Escolaridade(usuario.DescricaoEscolaridade);
            return new Usuario
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                EscolaridadeId = escolaridade.Id,
                Escolaridade = escolaridade,
                DataNascimento = usuario.DataNascimento,
                Email = usuario.Email,
                Sobrenome = usuario.Sobrenome
            };
        }
        public static UsuarioBasicInfoDTO Map(this Domain.DTO.Usuario.UsuarioBasicInfoDTO usuarioDto)
        {
            return new UsuarioBasicInfoDTO
            {
                Id = usuarioDto.Id,
                NomeCompleto = usuarioDto.NomeCompleto,
                Escolaridade = usuarioDto.Escolaridade,
                DataNascimento = usuarioDto.DataNascimento,
            };
        }
    }
}
