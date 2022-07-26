using Domain.Refrescos.Repositories;
using Domain.Efectivo.Repositories;
using Infrastructure.Refrescos.Repositories;
using Infrastructure.Efectivo.Repositories;
using Microsoft.Extensions.DependencyInjection;


namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<IRefrescoRepository, RefrescoRepository>();
            services.AddScoped<IDineroRepository, DineroRepository>();
            return services;
        }
    }
}
