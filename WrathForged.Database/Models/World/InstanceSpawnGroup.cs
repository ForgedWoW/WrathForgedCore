// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Database.Models.World;

public partial class InstanceSpawnGroup
{
    public ushort InstanceMapId { get; set; }

    public byte BossStateId { get; set; }

    public byte BossStates { get; set; }

    public uint SpawnGroupId { get; set; }

    public byte Flags { get; set; }
}
