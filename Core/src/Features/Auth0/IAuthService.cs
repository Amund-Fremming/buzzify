using Core.src.Shared.ResultPattern;

namespace Core.src.Features.Auth0;

public interface IAuthService
{
    // Remove after testing
    Task<Result<string>> RefreshAccessToken(string refreshToken);

    Task<Result<Auth0RegisterResponse>> Register(AuthRequest request);

    Task<Result<Auth0LoginResponse>> Login(AuthRequest request);
}