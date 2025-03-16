using Core.src.Shared.TypeScript;
using System.ComponentModel.DataAnnotations;

namespace Core.src.Features.Spin;

public record SpinGamePlayer : ITypeScriptModel
{
    [Key]
    public int Id { get; set; }
    public int GameId { get; set; }
    public int PlayerId { get; set; }
    public bool IsActive { get; set; }
}