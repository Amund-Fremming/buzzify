using Core.src.Shared.TypeScript;
using System.ComponentModel.DataAnnotations;

namespace Core.src.Features.Spin;

public record SpinChallenge : ITypeScriptModel
{
    [Key]
    public int Id { get; set; }
    public int RoundId { get; set; }
    public string Text { get; set; } = string.Empty;
    public string NumberOfParticipants { get; set; } = string.Empty;
    public bool ReadBeforeSpin { get; set; }
    public int Weight { get; set; } // ????
}