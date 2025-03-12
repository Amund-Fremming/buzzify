using Core.src.Infrastructure;
using Core.src.Shared.Abstractions;

namespace Core.src.Features.User;

public class UserRepository(ILogger<UserRepository> logger, AppDbContext context) : RepositoryBase<UserEntity>(logger, context), IUserRepository
{
}