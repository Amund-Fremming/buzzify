using Core.src.Shared.Abstractions;
using System.Text.Json.Serialization;

namespace Core.src.Features.Auth0;

public record Auth0RegisterResponse : ITypeScriptModel
{
    [JsonPropertyName("_id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("email")]
    public string Email { get; set; } = string.Empty;

    [JsonPropertyName("email_verified")]
    public bool EmailVerified { get; set; }
}