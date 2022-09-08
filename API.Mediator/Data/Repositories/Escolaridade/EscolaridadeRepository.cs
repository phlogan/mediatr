using Data.Context;
using Domain.Interfaces.Repository.Escolaridade;

namespace Data.Repositories.Escolaridade
{
    public class EscolaridadeRepository : BaseRepository<Domain.Entities.Escolaridade.Escolaridade>, IEscolaridadeRepository
    {
        public EscolaridadeRepository(MediatorDataContext context) : base(context) { }
    }
}
