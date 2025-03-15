using Core.src.Shared.TypeScript;

namespace Core.src.Features.Spin;

public record SpinRound : ITypeScriptModel
{
    public int Id { get; set; }
}