using FIAP.NET.Grupo13.CadastroDeContatos.Configuration;
using FIAP.NET.Grupo13.CadastroDeContatos.Infrastructure;
using FIAP.NET.Grupo13.CadastroDeContatos.Infrastructure.Config;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Diagnostics.HealthChecks;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
#region DI
builder.Services.AddDependecyInjector();
#endregion

builder.Services.AddSwaggerConfiguration();


string postgresConnectionString = builder.Configuration.GetSection("ConnectionStrings:DefaultConnection").Value;
builder.Services.AddHealthChecks()
    .AddNpgSql(
        postgresConnectionString,
        name:"PostgreSql",
        failureStatus: HealthStatus.Unhealthy,
        tags: new[] {"db", "sql", "postgres"}
        );

builder.Services.Configure<ConnectionStrings>(builder.Configuration.GetSection("ConnectionStrings"));
builder.Services.AddSingleton<DbConnectionProvider>();

builder.AddJwtConfiguration();

var app = builder.Build();

#region Middleware
app.UseMiddlerareConfiguration();
#endregion

app.UseSwaggerConfiguration();

app.UseHealthChecks("/health", new HealthCheckOptions
{
    Predicate = _ => true,
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse,
});

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();


app.Run();
