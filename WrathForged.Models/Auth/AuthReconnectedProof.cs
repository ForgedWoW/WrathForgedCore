// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Auth.Enum;

namespace WrathForged.Models.Auth
{
    [ForgedSerializable(Serialization.Models.PacketScope.ClientToAuth, AuthServerOpCode.AUTH_RECONNECT_PROOF)]
    public class AuthReconnectedProof
    {
        /// <summary>
        ///     R1
        /// </summary>
        [SerializableProperty(0, FixedCollectionSize = 16)]
        public byte[] ReconnectProof { get; set; } = [];

        /// <summary>
        ///    R2
        /// </summary>
        [SerializableProperty(1, FixedCollectionSize = 20)]
        public byte[] ClientProof { get; set; } = [];

        [SerializableProperty(2, FixedCollectionSize = 20)]
        public byte[] R3 { get; set; } = [];

        [SerializableProperty(3)]
        public byte NumberOfKeys { get; set; }
    }

}