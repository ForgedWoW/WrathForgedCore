// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Account.Packets;

[ForgedSerializable(Serialization.Models.PacketScope.ClientToRealm, Realm.Enum.RealmServerOpCode.CMSG_REQUEST_ACCOUNT_DATA)]
public class AccountDataRequest
{
    [SerializableProperty(0)]
    public uint AccountDataType { get; set; }
}
