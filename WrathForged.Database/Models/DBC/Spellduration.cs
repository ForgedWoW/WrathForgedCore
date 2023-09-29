// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Spellduration
{
    public int Id { get; set; }

    public int Duration { get; set; }

    public int DurationPerLevel { get; set; }

    public int MaxDuration { get; set; }

    public virtual ICollection<Spell> Spells { get; set; } = new List<Spell>();
}
