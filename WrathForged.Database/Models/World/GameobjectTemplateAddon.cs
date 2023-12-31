﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.World;

public partial class GameobjectTemplateAddon
{
    public uint Entry { get; set; }

    public ushort Faction { get; set; }

    public uint Flags { get; set; }

    public uint Mingold { get; set; }

    public uint Maxgold { get; set; }

    public int Artkit0 { get; set; }

    public int Artkit1 { get; set; }

    public int Artkit2 { get; set; }

    public int Artkit3 { get; set; }
}
