using Core.src.Shared.Abstractions;

namespace Core.src.Features.Spin;

public static class SpinGameServiceExtensions
{
    public static IServiceCollection AddSpinGameSupport(this IServiceCollection services)
    {
        services.AddScoped<ISpinGameManager, SpinGameManager>();
        services.AddScoped<IGenericRepository, GenericRepository>();

        return services;
    }
}