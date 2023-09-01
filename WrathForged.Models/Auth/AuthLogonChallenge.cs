// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Net;
using WrathForged.Models.Auth.Enum;
using WrathForged.Serialization;

namespace WrathForged.Models.Auth
{
    [ForgedSerializable(Scope = PacketScope.Auth, PacketIDs = new[] { (uint)AuthServerOpCode.AUTH_LOGON_CHALLENGE, (uint)AuthServerOpCode.AUTH_RECONNECT_CHALLENGE })]
    public class AuthLogonChallenge
    {
        [SerializableProperty(0)]
        public byte Cmd { get; set; }

        [SerializableProperty(1)]
        public ProtocolVersion Protocol { get; set; }

        [SerializableProperty(2)]
        public ushort Size { get; set; }

        [SerializableProperty(3, OverrideType = ForgedTypeCode.ASCIIString, FixedCollectionSize = 4)]
        public string GameName { get; set; }

        [SerializableProperty(4)]
        public ExpansionType Expansion { get; set; }

        [SerializableProperty(5)]
        public byte MajorPatchVersion { get; set; }

        [SerializableProperty(6)]
        public byte MinorPatchVersion { get; set; }

        [SerializableProperty(7)]
        public ushort Build { get; set; }

        [SerializableProperty(8, OverrideType = ForgedTypeCode.ASCIIString, FixedCollectionSize = 4)]
        public string Platform { get; set; }

        [SerializableProperty(9, OverrideType = ForgedTypeCode.ASCIIString, FixedCollectionSize = 4)]
        public string OperatingSystem { get; set; }

        [SerializableProperty(10, OverrideType = ForgedTypeCode.ASCIIString, FixedCollectionSize = 4)]
        public string Country { get; set; }

        [SerializableProperty(11)]
        public uint TimezoneBias { get; set; }

        [SerializableProperty(12)]
        public IPAddress IP { get; set; }

        [SerializableProperty(13)]
        public byte[] Identity { get; set; }
    }
}