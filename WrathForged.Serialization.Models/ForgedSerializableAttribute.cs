// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Serialization.Models
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ForgedSerializableAttribute : Attribute
    {
        public ForgedSerializableAttribute(PacketScope packetScope = PacketScope.System)
        {
            Scope = packetScope;
            PacketIDs = new[] { 0u };
        }

        public ForgedSerializableAttribute(PacketScope packetScope, params uint[] packetIDs)
        {
            Scope = packetScope;
            PacketIDs = packetIDs;
        }
        public PacketScope Scope { get; set; }

        public uint[] PacketIDs { get; set; }
    }
}