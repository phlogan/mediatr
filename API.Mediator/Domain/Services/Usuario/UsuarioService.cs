using Domain.DTO.Usuario;
using Domain.Interfaces.Repository.Usuario;
using Domain.Interfaces.Services.Usuario;

namespace Domain.Services.Usuario
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository _usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Entities.Usuario.Usuario Add(Entities.Usuario.Usuario usuario) => _usuarioRepository.Add(usuario);

        public Entities.Usuario.Usuario Delete(int id) => _usuarioRepository.Delete(id);

        public Entities.Usuario.Usuario GetById(int id) => _usuarioRepository.GetById(id);
        public UsuarioBasicInfoDTO GetBasicInfoDTOById(int id) => _usuarioRepository.GetBasicInfoDTOById(id);
        public int GetEscolaridadeIdById(int usuarioId) => _usuarioRepository.GetEscolaridadeIdById(usuarioId);

        public Entities.Usuario.Usuario Update(Entities.Usuario.Usuario usuario)
        {
            var usuarioDb = _usuarioRepository.GetById(usuario.Id);
            usuarioDb.Nome = usuario.Nome;
            usuarioDb.Sobrenome = usuario.Sobrenome;
            usuarioDb.DataNascimento = usuario.DataNascimento;
            usuarioDb.Escolaridade.Descricao = usuario.Escolaridade.Descricao;

            return _usuarioRepository.Update(usuarioDb);
        }
    }
}
