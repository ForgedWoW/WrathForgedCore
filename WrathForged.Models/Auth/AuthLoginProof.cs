// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.ConditionalSerializers;

namespace WrathForged.Models.Auth
{
    [ForgedSerializable(Serialization.Models.PacketScope.ClientToAuth, Enum.AuthServerOpCode.AUTH_LOGON_PROOF)]
    public class AuthLoginProof
    {
        [SerializableProperty(0, FixedCollectionSize = 32)]
        public byte[] A { get; set; } = [];

        [SerializableProperty(1, FixedCollectionSize = 20)]
        public byte[] ClientM { get; set; } = [];

        [SerializableProperty(2, FixedCollectionSize = 20)]
        public byte[] CRCHash { get; set; } = [];

        [SerializableProperty(3, CollectionSizeLengthType = TypeCode.Byte)]
        public List<SHA1Key> PublicEphemeralKeys { get; set; } = [];

        [SerializableProperty(4)]
        public byte SecurityFlags { get; set; }

        [SerializableProperty(5)]
        [BitwiseCondition(4, BitwiseCondition.BitwiseOperation.And, 1, BitwiseCondition.EqualityOperation.NotEqual, 0)]
        public AuthPIN? Pin { get; set; }

        [SerializableProperty(6, FixedCollectionSize = 20)]
        [BitwiseCondition(4, BitwiseCondition.BitwiseOperation.And, 2, BitwiseCondition.EqualityOperation.NotEqual, 0)]
        public byte[] Unk1 { get; set; } = [];

        [SerializableProperty(7, CollectionSizeLengthType = TypeCode.Byte)]
        [BitwiseCondition(4, BitwiseCondition.BitwiseOperation.And, 4, BitwiseCondition.EqualityOperation.NotEqual, 0)]
        public byte[] Unk2 { get; set; } = [];
    }

    [ForgedSerializable]
    public class SHA1Key
    {
        [SerializableProperty(0)]
        public ushort Key { get; set; }

        [SerializableProperty(1)]
        public uint Value { get; set; }

        [SerializableProperty(2, FixedCollectionSize = 4)]
        public byte[] Unk1 { get; set; } = [];

        [SerializableProperty(3, FixedCollectionSize = 20)]
        public byte[] SHA { get; set; } = [];
    }

    [ForgedSerializable]
    public class AuthPIN
    {
        [SerializableProperty(0, FixedCollectionSize = 16)]
        public byte[] PIN { get; set; } = [];

        [SerializableProperty(1, FixedCollectionSize = 20)]
        public byte[] PIN2 { get; set; } = [];
    }
}
