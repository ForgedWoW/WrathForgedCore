// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Auth.Enum;

namespace WrathForged.Models.Auth.Packets;

[ForgedSerializable(Serialization.Models.PacketScope.AuthToClient, AuthServerOpCode.AUTH_RECONNECT_PROOF)]
public class AuthReconnectProofResponse
{
    [SerializableProperty(0)]
    public AuthStatus Status { get; set; }

    /// <summary>
    ///     1 for account has a message
    /// </summary>
    [SerializableProperty(1)]
    public short LoginFlags { get; set; }
}
