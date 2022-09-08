namespace Domain.Interfaces.Services.Escolaridade
{
    public interface IEscolaridadeService
    {
        Entities.Escolaridade.Escolaridade GetById(int id);
        Entities.Escolaridade.Escolaridade Update(Entities.Escolaridade.Escolaridade escolaridade);
    }
}
