using Data.Context;
using Domain.DTO.Usuario;
using Domain.Interfaces.Repository.Usuario;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.Usuario
{
    public class UsuarioRepository : BaseRepository<Domain.Entities.Usuario.Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(MediatorDataContext context) : base(context) { }

        public int GetEscolaridadeIdById(int usuarioId) => Db.Usuarios.Where(e => e.Id == usuarioId).Select(e => e.EscolaridadeId).FirstOrDefault();
        public UsuarioBasicInfoDTO GetBasicInfoDTOById(int id)
        {
            return Db.Usuarios
                .Include(e => e.Escolaridade)
                .Where(e => e.Id == id)
                .Select(e => new UsuarioBasicInfoDTO
                {
                    Id = e.Id,
                    DataNascimento = e.DataNascimento,
                    Escolaridade = e.Escolaridade.Descricao,
                    NomeCompleto = string.Format("{0} {1}", e.Nome, e.Sobrenome)
                }).FirstOrDefault();
        }
    }
}
