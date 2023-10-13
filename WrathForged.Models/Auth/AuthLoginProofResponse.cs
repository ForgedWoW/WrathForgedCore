// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Realm.Enum;

namespace WrathForged.Models.Auth;

[ForgedSerializable(Serialization.Models.PacketScope.AuthToClient, Enum.AuthServerOpCode.AUTH_LOGON_PROOF)]
public class AuthLoginProofResponse
{
    [SerializableProperty(0)]
    public AccountStatus Status { get; set; }

    [SerializableProperty(1, FixedCollectionSize = 20)]
    public byte[] Proof { get; set; } = [];

    /// <summary>
    /// 0x01 = GM, 0x08 = Trial, 0x00800000 = Pro pass (arena tournament)
    /// </summary>
    [SerializableProperty(2)]
    public int AccountFlags { get; set; }

    [SerializableProperty(3)]
    public int SurveyId { get; set; }

    /// <summary>
    ///     1 for account has a message
    /// </summary>
    [SerializableProperty(4)]
    public short LoginFlags { get; set; }
}
