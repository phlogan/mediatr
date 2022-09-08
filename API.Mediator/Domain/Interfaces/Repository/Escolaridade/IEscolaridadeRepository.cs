namespace Domain.Interfaces.Repository.Escolaridade
{
    public interface IEscolaridadeRepository
    {
        public Entities.Escolaridade.Escolaridade GetById(int id);
        public Entities.Escolaridade.Escolaridade Update(Entities.Escolaridade.Escolaridade escolaridade);
    }
}
