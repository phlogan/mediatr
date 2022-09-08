using Domain.Entities.Escolaridade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EntityConfig
{
    public class EscolaridadeConfig : IEntityTypeConfiguration<Escolaridade>
    {
        public void Configure(EntityTypeBuilder<Escolaridade> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Descricao).HasMaxLength(8000);
        }
    }
}
