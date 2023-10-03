// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Auth.Enum;
using WrathForged.Models.Core.Comm;
using WrathForged.Models.Instance.Enum;
using WrathForged.Models.Realm.Enum;
using WrathForged.Serialization.Models;

namespace WrathForged.Models.Networking
{
    public readonly struct PacketId
    {
        public enum PacketIdType
        {
            Auth,
            Realm,
            Instance
        }

        public PacketScope Scope { get; }
        public AuthServerOpCode AuthOpCode { get; }
        public RealmServerOpCode RealmOpCode { get; }
        public InstanceServerOpCode InstanceOpCode { get; }
        public ForgedCoreOpCode ForgeCoreOpCode { get; }
        public PacketIdType Type => Scope switch
        {
            PacketScope.ClientToAuth => PacketIdType.Auth,
            PacketScope.ClientToInstance => PacketIdType.Realm,
            PacketScope.InstanceToRealm => PacketIdType.Instance,
            PacketScope.RealmToInstance => PacketIdType.Realm,
            _ => PacketIdType.Realm
        };
        public uint Id { get; }

        public PacketId(AuthServerOpCode opCode, PacketScope packetScope)
        {
            Scope = packetScope;
            AuthOpCode = opCode;
            Id = (uint)opCode;
        }

        public PacketId(RealmServerOpCode opCode, PacketScope packetScope)
        {
            Scope = packetScope;
            RealmOpCode = opCode;
            Id = (uint)opCode;
        }

        public PacketId(InstanceServerOpCode opCode, PacketScope packetScope)
        {
            Scope = packetScope;
            InstanceOpCode = opCode;
            Id = (uint)opCode;
        }

        public PacketId(ForgedCoreOpCode opCode, PacketScope packetScope)
        {
            Scope = packetScope;
            ForgeCoreOpCode = opCode;
            Id = (uint)opCode;
        }

        public PacketId(uint id, PacketScope packetScope)
        {
            Scope = packetScope;
            Id = id;
            switch (packetScope)
            {
                case PacketScope.ClientToAuth:
                    AuthOpCode = (AuthServerOpCode)id;
                    break;

                case PacketScope.RealmToInstance:
                    InstanceOpCode = (InstanceServerOpCode)id;
                    break;

                default:
                    RealmOpCode = (RealmServerOpCode)id;
                    break;
            }
        }

        public PacketId(int id, PacketScope packetScope)
        {
            Scope = packetScope;
            Id = (uint)id;
            switch (packetScope)
            {
                case PacketScope.ClientToAuth:
                    AuthOpCode = (AuthServerOpCode)id;
                    break;

                case PacketScope.RealmToInstance:
                    InstanceOpCode = (InstanceServerOpCode)id;
                    break;

                default:
                    RealmOpCode = (RealmServerOpCode)id;
                    break;
            }
        }

        public static implicit operator PacketId(AuthServerOpCode val) => new(val, PacketScope.ClientToAuth);

        public static implicit operator PacketId(RealmServerOpCode val) => new(val, PacketScope.ClientToInstance);

        public static implicit operator PacketId(InstanceServerOpCode val) => new(val, PacketScope.RealmToInstance);

        public static implicit operator PacketId(ForgedCoreOpCode val) => new(val, PacketScope.System);

        public static implicit operator uint(PacketId val) => val.Id;

        public static implicit operator AuthServerOpCode(PacketId val) => val.AuthOpCode;

        public static implicit operator RealmServerOpCode(PacketId val) => val.RealmOpCode;

        public static implicit operator InstanceServerOpCode(PacketId val) => val.InstanceOpCode;

        public static implicit operator ForgedCoreOpCode(PacketId val) => val.ForgeCoreOpCode;

        public static implicit operator PacketScope(PacketId val) => val.Scope;

        public static bool operator ==(PacketId a, PacketId b)
        {
            return a.Id == b.Id &&
                ((a.Scope == PacketScope.ClientToAuth && b.Scope == PacketScope.ClientToAuth) || // if both are auth packets, they are equal
                (a.Scope != PacketScope.ClientToAuth && b.Scope != PacketScope.ClientToAuth && a.Scope != b.Scope) || // if both are realm packets, they are equal event if they are different realm scopes
                a.Scope == b.Scope); // if both are equal
        }

        public static bool operator !=(PacketId a, PacketId b) => !(a == b);

        public override string ToString()
        {
            var packetName = Scope == PacketScope.ClientToAuth ? AuthOpCode.ToString() : RealmOpCode.ToString();
            return $"{Scope} {packetName}:{Id}";
        }

        public override bool Equals(object? obj) => obj != null && obj is PacketId packetId && this == packetId;

        public override int GetHashCode() => Id.GetHashCode() ^ (int.MaxValue * (int)Scope);
    }
}