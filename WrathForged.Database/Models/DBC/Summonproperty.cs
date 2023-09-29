// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.DBC;

public partial class Summonproperty
{
    public int Id { get; set; }

    public int Control { get; set; }

    public int Faction { get; set; }

    public int Title { get; set; }

    public int Slot { get; set; }

    public int Flags { get; set; }
}
