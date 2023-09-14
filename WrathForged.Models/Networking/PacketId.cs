// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Auth.Enum;
using WrathForged.Models.Realm.Enum;
using WrathForged.Serialization;

namespace WrathForged.Models.Networking
{
    public readonly struct PacketId
    {
        public PacketScope Scope { get; }
        public AuthServerOpCode AuthOpCode { get; }
        public RealmServerOpCode RealmOpCode { get; }
        public int Id { get; }

        public PacketId(AuthServerOpCode opCode)
        {
            Scope = PacketScope.Auth;
            AuthOpCode = opCode;
            Id = (int)opCode;
        }

        public PacketId(RealmServerOpCode opCode, PacketScope packetScope)
        {
            Scope = packetScope;
            RealmOpCode = opCode;
            Id = (int)opCode;
        }

        public PacketId(int id, PacketScope packetScope)
        {
            Scope = packetScope;
            Id = id;
            switch (packetScope)
            {
                case PacketScope.Auth:
                    AuthOpCode = (AuthServerOpCode)id;
                    break;

                default:
                    RealmOpCode = (RealmServerOpCode)id;
                    break;
            }
        }

        public static implicit operator PacketId(AuthServerOpCode val) => new(val);

        public static implicit operator PacketId(RealmServerOpCode val) => new(val, PacketScope.ClientToInstance);

        public static bool operator ==(PacketId a, PacketId b)
        {
            return a.Id == b.Id &&
                ((a.Scope == PacketScope.Auth && b.Scope == PacketScope.Auth) || // if both are auth packets, they are equal
                (a.Scope != PacketScope.Auth && b.Scope != PacketScope.Auth && a.Scope != b.Scope) || // if both are realm packets, they are equal event if they are different realm scopes
                a.Scope == b.Scope); // if both are equil
        }

        public static bool operator !=(PacketId a, PacketId b) => !(a == b);

        public override string ToString()
        {
            var packetName = Scope == PacketScope.Auth ? AuthOpCode.ToString() : RealmOpCode.ToString();
            return $"{Scope} {packetName}:{Id}";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;

            return obj is PacketId packetId && this == packetId;
        }

        public override int GetHashCode() => Id.GetHashCode() ^ (int.MaxValue * (int)Scope);
    }
}