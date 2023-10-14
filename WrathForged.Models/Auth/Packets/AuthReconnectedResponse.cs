// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Auth.Enum;

namespace WrathForged.Models.Auth.Packets;

[ForgedSerializable(Serialization.Models.PacketScope.AuthToClient, AuthServerOpCode.AUTH_RECONNECT_CHALLENGE)]
public class AuthReconnectedResponse
{
    private static readonly byte[] _versionChallengeConst = [0xBA, 0xA3, 0x1E, 0x99, 0xA0, 0x0B, 0x21, 0x57, 0xFC, 0x37, 0x3F, 0xB3, 0x69, 0xCD, 0xD2, 0xF1];

    [SerializableProperty(0)]
    public AuthStatus Status { get; set; }

    [SerializableProperty(1, FixedCollectionSize = 16)]
    public byte[] ReconnectProof { get; set; } = [];

    [SerializableProperty(3)]
    public byte[] VersionChallenge { get; set; } = _versionChallengeConst;
}