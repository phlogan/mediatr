using IoC.Injectors;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public static class DependencyInjector
    {
        public static void InjectServices(this IServiceCollection services,
            string connectionString)
            => services
            .RegisterDomain()
            .RegisterData(connectionString);
    }
}
