// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using WrathForged.Models.Auth.Enum;
using WrathForged.Models.ConditionalSerializers;

namespace WrathForged.Models.Auth
{
    [ForgedSerializable(Serialization.Models.PacketScope.ClientToAuth, AuthServerOpCode.AUTH_RECONNECT_PROOF)]
    public class AuthReconnectedProof
    {
        [SerializableProperty(0)]
        public AuthStatus Status { get; set; }

        [SerializableProperty(1, FixedCollectionSize = 16)]
        public byte[] ReconnectProof { get; set; } = [];

        [SerializableProperty(3, FixedCollectionSize = 20)]
        public byte[] R2 { get; set; } = [];

        [SerializableProperty(4, FixedCollectionSize = 20)]
        public byte[] R3 { get; set; } = [];

        [SerializableProperty(5)]
        public byte NumberOfKeys { get; set; }
    }

}