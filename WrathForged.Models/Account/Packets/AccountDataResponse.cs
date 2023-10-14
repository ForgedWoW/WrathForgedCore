// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Serialization.Models;

namespace WrathForged.Models.Account.Packets;

[ForgedSerializable(PacketScope.RealmToClient, Realm.Enum.RealmServerOpCode.SMSG_UPDATE_ACCOUNT_DATA)]
public class AccountDataResponse
{
    [SerializableProperty(0)]
    public EntityId PlayerId { get; set; }

    [SerializableProperty(1)]
    public uint AccountDataType { get; set; }

    [SerializableProperty(2)]
    public uint Time { get; set; }

    [SerializableProperty(3)]
    public uint Size { get; set; }

    [SerializableProperty(4, OverrideType = ForgedTypeCode.CString, Flags = SerializationFlags.ZLibCompressedCollection)]
    public byte[] Data { get; set; } = null!;
}
