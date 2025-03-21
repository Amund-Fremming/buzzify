﻿using System.ComponentModel.DataAnnotations;

namespace Core.src.Shared.Abstractions
{
    public abstract class GameBase : IGame
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; } = string.Empty;
    }
}