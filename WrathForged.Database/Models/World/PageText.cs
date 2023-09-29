// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

/// <summary>
/// Item System
/// </summary>
public partial class PageText
{
    public uint Id { get; set; }

    public string Text { get; set; } = null!;

    public uint NextPageId { get; set; }

    public int VerifiedBuild { get; set; }
}
