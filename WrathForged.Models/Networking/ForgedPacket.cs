// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Core.Comm;
using WrathForged.Serialization.Models;

namespace WrathForged.Models.Networking
{
    [ForgedSerializable(PacketScope.System)]
    public class ForgedPacket
    {
        [SerializableProperty(0)]
        public PacketScope Scope { get; set; }

        [SerializableProperty(1)]
        public ForgedCoreOpCode OpCode { get; set; }

        [SerializableProperty(2)]
        public int Size { get; set; }

        [SerializableProperty(3, CollectionSizeIndex = 2)]
        public byte[] Data { get; set; } = [];
    }
}
