using Data.EntityConfig;
using Domain.Entities.Escolaridade;
using Domain.Entities.Usuario;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class MediatorDataContext : DbContext
    {
        public MediatorDataContext(DbContextOptions<MediatorDataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EscolaridadeConfig());
            modelBuilder.ApplyConfiguration(new UsuarioConfig());
        }

        #region :: Entities
        public DbSet<Escolaridade> Escolaridades { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        #endregion
    }
}
