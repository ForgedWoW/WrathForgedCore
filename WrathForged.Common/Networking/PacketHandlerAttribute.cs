// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Serialization;

namespace WrathForged.Common.Networking
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public sealed class PacketHandlerAttribute : Attribute
    {
        public PacketHandlerAttribute(PacketScope scope, int id)
        {
            Scope = scope;
            Id = id;
        }

        public PacketScope Scope { get; }
        public int Id { get; }
    }
}