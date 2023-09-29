// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Auth.Enum;
using WrathForged.Models.Core.Comm;
using WrathForged.Models.Instance.Enum;
using WrathForged.Models.Realm.Enum;
using WrathForged.Serialization.Models;

namespace WrathForged.Models
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ForgedSerializableAttribute : Attribute
    {
        public ForgedSerializableAttribute(PacketScope packetScope = PacketScope.System)
        {
            Scope = packetScope;
            PacketIDs = Array.Empty<uint>();
        }

        public ForgedSerializableAttribute(PacketScope packetScope, params uint[] packetIDs)
        {
            Scope = packetScope;
            PacketIDs = packetIDs;
        }

        public ForgedSerializableAttribute(PacketScope packetScope, params ForgedCoreOpCode[] packetIDs)
        {
            Scope = packetScope;
            PacketIDs = packetIDs.Cast<uint>().ToArray();
        }

        public ForgedSerializableAttribute(PacketScope packetScope, params AuthServerOpCode[] packetIDs)
        {
            Scope = packetScope;
            PacketIDs = packetIDs.Cast<uint>().ToArray();
        }

        public ForgedSerializableAttribute(PacketScope packetScope, params RealmServerOpCode[] packetIDs)
        {
            Scope = packetScope;
            PacketIDs = packetIDs.Cast<uint>().ToArray();
        }

        public ForgedSerializableAttribute(PacketScope packetScope, params InstanceServerOpCode[] packetIDs)
        {
            Scope = packetScope;
            PacketIDs = packetIDs.Cast<uint>().ToArray();
        }

        public PacketScope Scope { get; set; }

        public uint[] PacketIDs { get; set; }
    }
}