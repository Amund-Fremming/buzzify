using Core.src.Shared.Abstractions;

namespace Core.src.Features.Spin;

public record SpinRound : IIdentity, ITypeScriptModel
{
    public int Id { get; set; }
}