using Application.Refrescos;
using Application.Refrescos.Implementations;
using Application.Efectivo;
using Application.Efectivo.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddTransient<IRefrescoService, RefrescoService>();
            services.AddTransient<IDineroService, DineroService>();
            return services;
        }
    }
}
