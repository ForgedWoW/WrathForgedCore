// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;

namespace WrathForged.Serialization
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class DeserializeDefinitionAttribute : Attribute
    {
        public PacketScope Scope { get; }
        public int[] PacketIDs { get; }

        public DeserializeDefinitionAttribute(PacketScope scope, params int[] packetIDs)
        {
            Scope = scope;
            PacketIDs = packetIDs;
        }
    }
}