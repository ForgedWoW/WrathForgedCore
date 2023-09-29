// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

/// <summary>
/// SpellInfo custom attributes
/// </summary>
public partial class SpellCustomAttr
{
    /// <summary>
    /// spell id
    /// </summary>
    public uint Entry { get; set; }

    /// <summary>
    /// SpellCustomAttributes
    /// </summary>
    public uint Attributes { get; set; }
}
