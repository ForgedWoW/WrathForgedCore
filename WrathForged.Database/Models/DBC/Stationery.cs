// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.DBC;

public partial class Stationery
{
    public int Id { get; set; }

    public int? ItemId { get; set; }

    public string? Texture { get; set; }

    public int Flags { get; set; }

    public virtual Item? Item { get; set; }
}
