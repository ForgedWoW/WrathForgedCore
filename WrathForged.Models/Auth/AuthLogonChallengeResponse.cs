// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using WrathForged.Models.Auth.Enum;
using WrathForged.Models.ConditionalSerializers;

namespace WrathForged.Models.Auth
{
    [ForgedSerializable(Serialization.Models.PacketScope.AuthToClient, AuthServerOpCode.AUTH_LOGON_CHALLENGE)]
    public class AuthLogonChallengeResponse
    {
        private static readonly byte[] _versionChallangeConst = [0xBA, 0xA3, 0x1E, 0x99, 0xA0, 0x0B, 0x21, 0x57, 0xFC, 0x37, 0x3F, 0xB3, 0x69, 0xCD, 0xD2, 0xF1];

        [SerializableProperty(0)]
        public AuthStatus Status { get; set; }

        [SerializableProperty(1)]
        public byte GruntCommand { get; set; }

        [SerializableProperty(2)]
        public byte Unknown { get; set; }

        [SerializableProperty(3, FixedCollectionSize = 32)]
        public BigInteger B { get; set; }

        [SerializableProperty(4, FixedCollectionSize = 1)]
        public BigInteger Generator { get; set; }

        [SerializableProperty(5, FixedCollectionSize = 32)]
        public BigInteger Modulus { get; set; }

        [SerializableProperty(6)]
        public BigInteger Salt { get; set; }

        [SerializableProperty(7)]
        public byte[] VersionChallange { get; set; } = _versionChallangeConst;

        [SerializableProperty(8)]
        public byte SecurityFlags { get; set; }

        [SerializableProperty(9)]
        [BitwiseCondition(8, BitwiseCondition.BitwiseOperation.And, 1, BitwiseCondition.EqualityOperation.Equal, 1)]
        public RequiredPin? Pin { get; set; }

        [SerializableProperty(10)]
        [BitwiseCondition(8, BitwiseCondition.BitwiseOperation.And, 2, BitwiseCondition.EqualityOperation.Equal, 2)]
        public MaxtrixInput? Matrix { get; set; }

        [SerializableProperty(11)]
        [BitwiseCondition(8, BitwiseCondition.BitwiseOperation.And, 4, BitwiseCondition.EqualityOperation.Equal, 4)]
        public byte RequireSecurityToken { get; set; }
    }

    [ForgedSerializable]
    public class RequiredPin
    {
        [SerializableProperty(0)]
        public uint PIN { get; set; }

        [SerializableProperty(1, FixedCollectionSize = 16)]
        public byte[] Hash { get; set; } = Array.Empty<byte>();
    }

    [ForgedSerializable]
    public class MaxtrixInput
    {
        [SerializableProperty(0)]
        public byte A { get; set; }

        [SerializableProperty(1)]
        public byte B { get; set; }

        [SerializableProperty(2)]
        public byte C { get; set; }

        [SerializableProperty(3)]
        public byte D { get; set; }

        [SerializableProperty(4)]
        public ulong E { get; set; }
    }
}