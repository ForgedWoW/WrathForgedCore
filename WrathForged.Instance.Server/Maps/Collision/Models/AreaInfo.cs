// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Instance.Server.Maps.Collision.Models;

public class AreaInfo
{
    public int AdtId { get; set; }
    public uint Flags { get; set; }
    public float GroundZ { get; set; } = float.NegativeInfinity;
    public uint GroupId { get; set; }
    public bool Result { get; set; }
    public uint RootId { get; set; }
}
