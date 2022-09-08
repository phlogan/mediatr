namespace Domain.Entities.Escolaridade
{
    public class Escolaridade : BaseEntity
    {
        public Escolaridade(string descricao)
        {
            Descricao = descricao;
        }

        public Escolaridade() { }

        public string Descricao { get; set; }
    }
}
