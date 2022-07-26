using Infrastructure.Refrescos.Repositories;
using Domain.Refrescos.Repositories;
using Microsoft.Extensions.DependencyInjection;


namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, string connectionString)
        {
            services.AddScoped<IRefrescoRepository, RefrescoRepository>();
            return services;
        }
    }
}
