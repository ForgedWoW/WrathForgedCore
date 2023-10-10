// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Debug System
/// </summary>
public partial class Bugreport
{
    /// <summary>
    /// Identifier
    /// </summary>
    public uint Id { get; set; }

    public string Type { get; set; } = null!;

    public string Content { get; set; } = null!;
}
