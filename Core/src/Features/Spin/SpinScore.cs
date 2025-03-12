using Core.src.Shared.Abstractions;

namespace Core.src.Features.Spin;

public record SpinScore : IIdentity, ITypeScriptModel
{
    public int Id { get; set; }
    public int PlayerId { get; set; }
    public int GameId { get; set; }
    public int Score { get; set; }

    // player
    // game
}