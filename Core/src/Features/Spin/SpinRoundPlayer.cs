using Core.src.Shared.TypeScript;
using System.ComponentModel.DataAnnotations;

namespace Core.src.Features.Spin;

public record SpinRoundPlayer : ITypeScriptModel
{
    [Key]
    public int Id { get; set; }
}