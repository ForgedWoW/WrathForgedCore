using System;
using System.Collections.Generic;

namespace WrathForged.Database.Models.World;

public partial class InstanceSpawnGroup
{
    public ushort InstanceMapId { get; set; }

    public byte BossStateId { get; set; }

    public byte BossStates { get; set; }

    public uint SpawnGroupId { get; set; }

    public byte Flags { get; set; }
}
