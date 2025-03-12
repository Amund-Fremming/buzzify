using Core.src.Shared.Abstractions;

namespace Core.src.Features.Spin;

public static class ServiceCollectionExtentions
{
    public static IServiceCollection AddSpinGameSupport(this IServiceCollection services)
    {
        services.AddScoped<ISpinService, SpinService>();
        services.AddScoped<IRepository<SpinGame>, SpinGameRepository>();
        services.AddScoped<IRepository<SpinChallenge>, SpinChallengeRepository>();
        services.AddScoped<IRepository<SpinRound>, SpinRoundRepository>();
        services.AddScoped<IRepository<SpinScore>, SpinScoreRepository>();

        return services;
    }
}