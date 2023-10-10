// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.World;

public partial class InstanceTemplate
{
    public ushort Map { get; set; }

    public ushort Parent { get; set; }

    public string Script { get; set; } = null!;

    public byte AllowMount { get; set; }
}
