using Domain.Interfaces.Services.Escolaridade;
using Domain.Interfaces.Services.Usuario;
using Domain.Services.Escolaridade;
using Domain.Services.Usuario;
using Microsoft.Extensions.DependencyInjection;

namespace IoC.Injectors
{
    public static class DomainInjector
    {
        public static IServiceCollection RegisterDomain(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IEscolaridadeService, EscolaridadeService>();

            return services;
        }
    }
}
