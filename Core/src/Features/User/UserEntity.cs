using Core.src.Shared.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace Core.src.Features.User;

public class UserEntity : IIdentity, ITypeScriptModel
{
    [Key]
    public int Id { get; set; }

    public string Auth0Id { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public UserEntity()
    { }
}