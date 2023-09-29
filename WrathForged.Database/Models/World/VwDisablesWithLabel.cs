// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class VwDisablesWithLabel
{
    public string SourceType { get; set; } = null!;

    public uint Entry { get; set; }

    public short Flags { get; set; }

    public string Params0 { get; set; } = null!;

    public string Params1 { get; set; } = null!;

    public string Comment { get; set; } = null!;
}
