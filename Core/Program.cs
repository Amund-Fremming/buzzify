using Core.src.Features.Auth0;
using Core.src.Features.User;
using Core.src.Infrastructure;
using Core.src.Shared.Extensions;
using Core.src.Shared.TypeScript;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var services = builder.Services;

        services.AddEndpointsApiExplorer();
        services.AddControllers();
        services.AddLogging();
        services.AddResponseCompression(o => o.EnableForHttps = true);

        services.AddUserServices();
        services.AddAuth0Support();

        services.AddTypeScriptSupport(options =>
        {
            options.ClientLogging = true;
            options.RelativeFolderPath = "../app/src/features";
        });

        services.ConfigureSwaggerAuthentication();
        builder.ConfigureJwtValidation();
        builder.ConfigureNamedHttpClients();

        services.AddDbContext<AppDbContext>(o =>
        {
            var connectionString = builder.Configuration.GetConnectionString("Database");
            if (string.IsNullOrEmpty(connectionString))
            {
                o.UseInMemoryDatabase("InMemoryDb");
            }
            else
            {
                o.UseNpgsql(connectionString);
            }
        });

        var app = builder.Build();

        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthentication();
        app.UseAuthorization();
        app.MapControllers();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.Run();
    }
}