﻿using Core.src.Shared.TypeScript;
using System.ComponentModel.DataAnnotations;

namespace Core.src.Features.Spin;

public record SpinRound : ITypeScriptModel
{
    [Key]
    public int Id { get; set; }
    public int GameId { get; set; }
    public bool Completed { get; set; }
}