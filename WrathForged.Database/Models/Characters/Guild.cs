// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.Characters;

/// <summary>
/// Guild System
/// </summary>
public partial class Guild
{
    public uint Guildid { get; set; }

    public string Name { get; set; } = null!;

    public uint Leaderguid { get; set; }

    public byte EmblemStyle { get; set; }

    public byte EmblemColor { get; set; }

    public byte BorderStyle { get; set; }

    public byte BorderColor { get; set; }

    public byte BackgroundColor { get; set; }

    public string Info { get; set; } = null!;

    public string Motd { get; set; } = null!;

    public uint Createdate { get; set; }

    public ulong BankMoney { get; set; }
}
