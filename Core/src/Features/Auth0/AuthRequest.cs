using Core.src.Shared.TypeScript;

namespace Core.src.Features.Auth0;

public record AuthRequest(string Email, string Password) : ITypeScriptModel;