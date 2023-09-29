// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Database.Models.World;

public partial class SpellScript
{
    public uint Id { get; set; }

    public byte EffIndex { get; set; }

    public uint Delay { get; set; }

    public uint Command { get; set; }

    public uint Datalong { get; set; }

    public uint Datalong2 { get; set; }

    public int Dataint { get; set; }

    public float X { get; set; }

    public float Y { get; set; }

    public float Z { get; set; }

    public float O { get; set; }

    public string Comment { get; set; } = null!;
}
