// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Auth.Enum;
using WrathForged.Models.Realm.Enum;
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

        public PacketHandlerAttribute(PacketScope scope, AuthServerOpCode id)
        {
            Scope = scope;
            Id = (int)id;
        }

        public PacketHandlerAttribute(PacketScope scope, RealmServerOpCode id)
        {
            Scope = scope;
            Id = (int)id;
        }

        public PacketScope Scope { get; }
        public int Id { get; }
    }
}