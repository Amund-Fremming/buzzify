﻿using Core.src.Shared.Abstractions;
using System.Text.Json.Serialization;

namespace Core.src.Features.Auth0;

public record Auth0LoginResponse : ITypeScriptModel
{
    [JsonPropertyName("access_token")]
    public string? AccessToken { get; init; }

    [JsonPropertyName("refresh_token")]
    public string? RefreshToken { get; init; }

    [JsonPropertyName("scope")]
    public string? Scope { get; init; }

    [JsonPropertyName("expires_in")]
    public int ExpiresIn { get; init; }

    [JsonPropertyName("token_type")]
    public string? TokenType { get; init; }
}