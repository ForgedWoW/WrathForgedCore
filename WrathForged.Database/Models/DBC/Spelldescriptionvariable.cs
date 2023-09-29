// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.DBC;

public partial class Spelldescriptionvariable
{
    public int Id { get; set; }

    public string? Variables { get; set; }

    public virtual ICollection<Spell> Spells { get; set; } = new List<Spell>();
}
