namespace Core.src.Features.Spin;

public static class ServiceCollectionExtentions
{
    public static IServiceCollection AddSpinGameSupport(this IServiceCollection services)
    {
        services.AddScoped<ISpinService, SpinService>();
    }
}