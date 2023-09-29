// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Auth.Enum;
using WrathForged.Models.Realm.Enum;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Networking
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public sealed class PacketHandlerAttribute : Attribute
    {
        public PacketHandlerAttribute(PacketScope scope, uint id)
        {
            Scope = scope;
            Id = id;
        }

        public PacketHandlerAttribute(PacketScope scope, AuthServerOpCode id)
        {
            Scope = scope;
            Id = (uint)id;
        }

        public PacketHandlerAttribute(PacketScope scope, RealmServerOpCode id)
        {
            Scope = scope;
            Id = (uint)id;
        }

        public PacketScope Scope { get; }
        public uint Id { get; }
    }
}