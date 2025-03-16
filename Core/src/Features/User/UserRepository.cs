using Core.src.Shared.Abstractions;
using Core.src.Shared.AppData;

namespace Core.src.Features.User;

public class UserRepository(ILogger<UserRepository> logger, AppDbContext context) : RepositoryBase<UserEntity>(logger, context), IUserRepository
{
}