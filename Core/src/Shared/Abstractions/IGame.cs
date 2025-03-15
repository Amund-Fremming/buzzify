namespace Core.src.Shared.Abstractions;

public interface IGame
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public void StartGame();

    public void EndGame();

    public void UpdateState();

    public void GetCurrentState();
}