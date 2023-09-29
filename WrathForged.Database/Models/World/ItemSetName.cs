// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class ItemSetName
{
    public uint Entry { get; set; }

    public string Name { get; set; } = null!;

    public byte InventoryType { get; set; }

    public int? VerifiedBuild { get; set; }
}
