using Microsoft.Extensions.DependencyInjection;
using VSDev.MVC.Services;
using VSDev.MVC.Services.Interface;

namespace VSDev.MVC.Configuration
{
    public static class DepedencyInjectionConfiguration
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddTransient<IArtigoRepository, ArtigoRepository>();

            return services;
        }
    }
}
