using Data.Context;
using Data.Repositories.Escolaridade;
using Data.Repositories.Usuario;
using Domain.Interfaces;
using Domain.Interfaces.Repository.Escolaridade;
using Domain.Interfaces.Repository.Usuario;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace IoC.Injectors
{
    public static class DataInjector
    {
        public static IServiceCollection RegisterData(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<MediatorDataContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IEscolaridadeRepository, EscolaridadeRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
