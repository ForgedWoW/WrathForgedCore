// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

namespace WrathForged.Serialization.Models
{
    public class ForgedSerializableAttribute : Attribute
    {
        public PacketScope Scope { get; set; }

        public uint[] PacketIDs { get; set; } = Array.Empty<uint>();
    }
}