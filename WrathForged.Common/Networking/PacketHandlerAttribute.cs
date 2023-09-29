// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Auth.Enum;
using WrathForged.Models.Core.Comm;
using WrathForged.Models.Instance.Enum;
using WrathForged.Models.Networking;
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
            Id = new PacketId(id, scope);
        }

        public PacketHandlerAttribute(PacketScope scope, AuthServerOpCode id)
        {
            Scope = scope;
            Id = new PacketId(id);
        }

        public PacketHandlerAttribute(PacketScope scope, RealmServerOpCode id)
        {
            Scope = scope;
            Id = new PacketId(id, scope);
        }

        public PacketHandlerAttribute(PacketScope scope, InstanceServerOpCode id)
        {
            Scope = scope;
            Id = new PacketId(id, scope);
        }

        public PacketHandlerAttribute(PacketScope scope, ForgedCoreOpCode id)
        {
            Scope = scope;
            Id = new PacketId(id, scope);
        }

        public PacketScope Scope { get; }
        public PacketId Id { get; }
    }
}