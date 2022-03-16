using Microsoft.Extensions.DependencyInjection;
using Pjus.Business.Interfaces;
using Pjus.Business.Services;
using Pjus.Data.Context;
using Pjus.Data.Repository;

namespace Pjus.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IEnderecoService, EnderecoService>();
            services.AddScoped<IViaCepService, ViaCepService>();

            return services;
        }
    }
}
