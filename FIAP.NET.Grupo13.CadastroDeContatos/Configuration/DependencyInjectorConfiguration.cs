using FIAP.NET.Grupo13.CadastroDeContatos.Infrastructure;
using FIAP.NET.Grupo13.CadastroDeContatos.Infrastructure.Middleware;
using FIAP.NET.Grupo13.CadastroDeContatos.Infrastructure.Repository;
using FIAP.NET.Grupo13.CadastroDeContatos.Service;

namespace FIAP.NET.Grupo13.CadastroDeContatos.Configuration
{
    public static class DependencyInjectorConfiguration
    {
        public static IServiceCollection AddDependecyInjector(this IServiceCollection services)
        {
            services.AddScoped(typeof(BaseLogger<>));
            services.AddTransient<ICorrelationIdGenerator, CorrelationIdGenerator>();
            services.AddScoped<IContatoService, ContatoService>();
            services.AddScoped<IContatoRepository, ContatoRepository>();
            services.AddScoped<ICacheService, MemoCacheService>();
            return services;
        }       
    }
}
