using Core.src.Shared.Abstractions;
using Core.src.Shared.TypeScript;

namespace Core.src.Features.Spin;

public class SpinGame : GameBase, ITypeScriptModel
{
    public int NumRounds { get; set; }

    public override void EndGame()
    {
        throw new NotImplementedException();
    }

    public override void GetCurrentState()
    {
        throw new NotImplementedException();
    }

    public override void StartGame()
    {
        throw new NotImplementedException();
    }

    public override void UpdateState()
    {
        throw new NotImplementedException();
    }

    // players
    // rounds
    // scores
}