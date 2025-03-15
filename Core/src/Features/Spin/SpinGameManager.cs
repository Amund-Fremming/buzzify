using Core.src.Shared.Abstractions;

namespace Core.src.Features.Spin;

public class SpinGameManager(IGenericRepository genericRepository) : ISpinGameManager
{
    public void Test()
    {
        genericRepository.Create(new SpinHub() { });
        genericRepository.Create(new SpinGame() { });
    }
}