// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.DBC;

public partial class Uisoundlookup
{
    public int Id { get; set; }

    public int? SoundId { get; set; }

    public string? Name { get; set; }

    public virtual Soundentry? Sound { get; set; }
}
