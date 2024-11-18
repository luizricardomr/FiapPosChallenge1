using FIAP.NET.Grupo13.CadastroDeContatos.Infrastructure.Middleware;

namespace FIAP.NET.Grupo13.CadastroDeContatos.Configuration
{
    public static class MiddlewareConfiguration
    {
        public static IApplicationBuilder UseMiddlerareConfiguration(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<LogMiddleware>();
            builder.UseMiddleware<CorrelationMiddleware>();
            return builder;
        }
    }
}
