﻿// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Core.Enum;
using WrathForged.Serialization.Models;

namespace WrathForged.Models.Core.Packets;

[ForgedSerializable(PacketScope.System, ForgedCoreOpCode.RemoveInstanceServer)]
public class InstanceServerShutdown
{
    [SerializableProperty(0)]
    public uint Id { get; set; }
}
