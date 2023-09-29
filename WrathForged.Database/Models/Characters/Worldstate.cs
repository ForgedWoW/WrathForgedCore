// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Variable Saves
/// </summary>
public partial class Worldstate
{
    public uint Entry { get; set; }

    public uint Value { get; set; }

    public string? Comment { get; set; }
}
