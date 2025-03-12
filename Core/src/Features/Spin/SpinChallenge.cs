using Core.src.Shared.Abstractions;

namespace Core.src.Features.Spin;

public record SpinChallenge : IIdentity, ITypeScriptModel
{
    public int Id { get; set; }
    public string Challenge { get; set; } = string.Empty;
    public int Weight { get; set; }
}