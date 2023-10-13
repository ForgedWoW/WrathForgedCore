// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Auth.Enum;
using WrathForged.Models.ConditionalSerializers;

namespace WrathForged.Models.Auth;

[ForgedSerializable(Serialization.Models.PacketScope.ClientToRealm, Realm.Enum.RealmServerOpCode.SMSG_AUTH_RESPONSE)]
public class RealmAuthResponse
{
    [SerializableProperty(0)]
    public ResponseCodes Code { get; set; }

    [SerializableProperty(1)]
    public int BillingTimeRemaining { get; set; }

    [SerializableProperty(2)]
    public BillingPlanFlags BillingPlanFlags { get; set; }

    [SerializableProperty(3)]
    public int BillingTimeRested { get; set; }

    [SerializableProperty(4)]
    public byte Expansion { get; set; } = 2; // Wrath of the Lich King

    [SerializableProperty(5)]
    [ValueDoesNotEqualSerializerCondition(5, 0)]
    public int QueuePosition { get; set; }

    [SerializableProperty(6)]
    [ValueDoesNotEqualSerializerCondition(5, 0)]
    public bool RealmHasFreeCharacterMigration { get; set; }
}
