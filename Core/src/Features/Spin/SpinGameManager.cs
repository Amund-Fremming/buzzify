using Core.src.Shared.Abstractions;

namespace Core.src.Features.Spin;

public class SpinGameManager(IGenericRepository genericRepository) : ISpinGameManager
{
    public async Task Test()
    {
        await genericRepository.Create(new SpinGame() { });
        await genericRepository.Create(new SpinGame() { });
        await genericRepository.Create(new SpinGame() { });
        await genericRepository.Create(new SpinGame() { });
        await genericRepository.Create(new SpinGame() { });

        var result = await genericRepository.GetAll<SpinGame>();
        var all = result.Data;

        Console.WriteLine();
    }
}