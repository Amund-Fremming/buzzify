using Core.src.Shared.TypeScript;

namespace Core.src.Features.Spin;

public record SpinChallenge : ITypeScriptModel
{
    public int Id { get; set; }
    public int RoundId { get; set; }
    public string Challenge { get; set; } = string.Empty;
    public int Weight { get; set; }

    // round
}