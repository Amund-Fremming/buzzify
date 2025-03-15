using Core.src.Shared.TypeScript;

namespace Core.src.Features.Spin;

public record SpinScore : ITypeScriptModel
{
    public int Id { get; set; }
    public int PlayerId { get; set; }
    public int GameId { get; set; }
    public int Score { get; set; }

    // player
    // game
}