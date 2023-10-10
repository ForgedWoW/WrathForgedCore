// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Player System
/// </summary>
public partial class CharacterQueststatusDaily
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// Quest Identifier
    /// </summary>
    public uint Quest { get; set; }

    public uint Time { get; set; }
}
