﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.World;

public partial class GameobjectQueststarter
{
    public uint Id { get; set; }

    /// <summary>
    /// Quest Identifier
    /// </summary>
    public uint Quest { get; set; }
}
