// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class SpelldifficultyDbc
{
    public uint Id { get; set; }

    public uint Spellid0 { get; set; }

    public uint Spellid1 { get; set; }

    public uint Spellid2 { get; set; }

    public uint Spellid3 { get; set; }
}
