// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

public partial class CharacterDeclinedname
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    public string Genitive { get; set; } = null!;

    public string Dative { get; set; } = null!;

    public string Accusative { get; set; } = null!;

    public string Instrumental { get; set; } = null!;

    public string Prepositional { get; set; } = null!;
}
