// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.DBC;

public partial class Spellrunecost
{
    public int Id { get; set; }

    public int Blood { get; set; }

    public int Unholy { get; set; }

    public int Frost { get; set; }

    public int RunicPower { get; set; }

    public virtual ICollection<Spell> Spells { get; set; } = new List<Spell>();
}
