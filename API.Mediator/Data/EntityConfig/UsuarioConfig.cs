using Domain.Entities.Usuario;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EntityConfig
{
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nome).HasMaxLength(255);
            builder.Property(e => e.Sobrenome).HasMaxLength(255);
            builder.Property(e => e.Email).HasMaxLength(255);
        }
    }
}
