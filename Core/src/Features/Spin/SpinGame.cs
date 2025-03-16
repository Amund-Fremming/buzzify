using Core.src.Shared.Abstractions;
using Core.src.Shared.TypeScript;

namespace Core.src.Features.Spin;

public class SpinGame : GameBase, ITypeScriptModel
{
    public int NumberOfRounds { get; set; }
    public int CurrentRound { get; set; }
    public SpinGameState State { get; set; }
}