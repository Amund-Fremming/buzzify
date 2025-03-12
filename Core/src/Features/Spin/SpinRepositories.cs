using Core.src.Infrastructure;
using Core.src.Shared.Abstractions;

namespace Core.src.Features.Spin;

public class SpinGameRepository(ILogger<SpinGameRepository> logger, AppDbContext context)
    : RepositoryBase<SpinGame>(logger, context);

public class SpinChallengeRepository(ILogger<SpinChallengeRepository> logger, AppDbContext context)
    : RepositoryBase<SpinChallenge>(logger, context);

public class SpinRoundRepository(ILogger<SpinRoundRepository> logger, AppDbContext context)
    : RepositoryBase<SpinRound>(logger, context);

public class SpinScoreRepository(ILogger<SpinScoreRepository> logger, AppDbContext context)
    : RepositoryBase<SpinScore>(logger, context);