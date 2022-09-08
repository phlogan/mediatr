using Domain.Interfaces.Repository.Escolaridade;
using Domain.Interfaces.Services.Escolaridade;

namespace Domain.Services.Escolaridade
{
    public class EscolaridadeService : IEscolaridadeService
    {
        private IEscolaridadeRepository _escolaridadeRepository;
        public EscolaridadeService(IEscolaridadeRepository escolaridadeRepository)
        {
            _escolaridadeRepository = escolaridadeRepository;
        }
        public Entities.Escolaridade.Escolaridade GetById(int id) => _escolaridadeRepository.GetById(id);

        public Entities.Escolaridade.Escolaridade Update(Entities.Escolaridade.Escolaridade escolaridade)
        {
            var escolaridadeDb = _escolaridadeRepository.GetById(escolaridade.Id);
            escolaridadeDb.Descricao = escolaridade.Descricao;

            return _escolaridadeRepository.Update(escolaridadeDb);
        }
    }
}
