using Domain.DTO.Usuario;

namespace Domain.Interfaces.Repository.Usuario
{
    public interface IUsuarioRepository
    {
        Entities.Usuario.Usuario Add(Entities.Usuario.Usuario usuario);
        public Entities.Usuario.Usuario GetById(int id);
        public IEnumerable<Entities.Usuario.Usuario> GetAll();
        public Entities.Usuario.Usuario Update(Entities.Usuario.Usuario entity);
        public Entities.Usuario.Usuario Delete(int id);
        int GetEscolaridadeIdById(int usuarioId);
        UsuarioBasicInfoDTO GetBasicInfoDTOById(int id);
    }
}
