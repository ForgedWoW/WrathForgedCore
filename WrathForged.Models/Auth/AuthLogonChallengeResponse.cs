// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Auth.Enum;
using WrathForged.Models.ConditionalSerializers;
using WrathForged.Serialization.Models;

namespace WrathForged.Models.Auth;

[ForgedSerializable(PacketScope.AuthToClient, AuthServerOpCode.AUTH_LOGON_CHALLENGE)]
public class AuthLogonChallengeResponse
{
    private static readonly byte[] _versionChallengeConst = [0xBA, 0xA3, 0x1E, 0x99, 0xA0, 0x0B, 0x21, 0x57, 0xFC, 0x37, 0x3F, 0xB3, 0x69, 0xCD, 0xD2, 0xF1];

    [SerializableProperty(0)] // 3
    public AuthStatus Status { get; set; }

    [SerializableProperty(1, FixedCollectionSize = 32)] // 35
    public byte[] ServerEphemeral { get; set; } = [];

    [SerializableProperty(2, CollectionSizeLengthType = TypeCode.Byte, FixedCollectionSize = 1, Flags = SerializationFlags.SendFixedSize)] // 37
    public byte[] Generator { get; set; } = [];

    [SerializableProperty(3, CollectionSizeLengthType = TypeCode.Byte, FixedCollectionSize = 32, Flags = SerializationFlags.SendFixedSize)] // 70
    public byte[] Modulus { get; set; } = [];

    [SerializableProperty(4, FixedCollectionSize = 32)] // 102
    public byte[] Salt { get; set; } = [];

    [SerializableProperty(5, FixedCollectionSize = 16)] // 118
    public byte[] VersionChallenge { get; set; } = _versionChallengeConst;

    [SerializableProperty(6)] // 119
    public byte SecurityFlags { get; set; }

    [SerializableProperty(7)]
    [SerializerConditionBitwise(6, SerializerConditionBitwise.BitwiseOperation.And, 1, SerializerConditionBitwise.EqualityOperation.Equal, 1)]
    public RequiredPin? Pin { get; set; }

    [SerializableProperty(8)]
    [SerializerConditionBitwise(6, SerializerConditionBitwise.BitwiseOperation.And, 2, SerializerConditionBitwise.EqualityOperation.Equal, 2)]
    public MatrixInput? Matrix { get; set; }

    [SerializableProperty(9)]
    [SerializerConditionBitwise(6, SerializerConditionBitwise.BitwiseOperation.And, 4, SerializerConditionBitwise.EqualityOperation.Equal, 4)]
    public byte RequireSecurityToken { get; set; }
}

[ForgedSerializable]
public class RequiredPin
{
    [SerializableProperty(0)]
    public uint PIN { get; set; }

    [SerializableProperty(1, FixedCollectionSize = 16)]
    public byte[] Hash { get; set; } = [];
}

[ForgedSerializable]
public class MatrixInput
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