// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Net;
using WrathForged.Serialization.Models;

namespace WrathForged.Models.Core.Comm
{
    [ForgedSerializable(PacketScope.System, ForgedCoreOpCode.AddInstanceServer)]
    public class InstanceServerRegistration
    {
        [SerializableProperty(0)]
        public uint Id { get; set; }

        [SerializableProperty(1)]
        public IPAddress Address { get; set; } = IPAddress.Any;

        [SerializableProperty(2)]
        public ushort Port { get; set; }

        [SerializableProperty(3)]
        public List<InstanceMapInfo> MapIDs { get; set; } = new List<InstanceMapInfo>();
    }
}
