using System.ComponentModel.DataAnnotations;

namespace Core.src.Shared.Abstractions
{
    public abstract class GameBase : IGame
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; } = string.Empty;

        public abstract void EndGame();

        public abstract void GetCurrentState();

        public abstract void StartGame();

        public abstract void UpdateState();
    }
}