// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using System;

namespace WrathForged.Serialization
{
    public class ForgedSerializableAttribute : Attribute
    {
        public uint[] PacketIDs { get; set; }
    }
}