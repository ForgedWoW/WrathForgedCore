// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Account.Packets;

[ForgedSerializable(Serialization.Models.PacketScope.RealmToClient, Realm.Enum.RealmServerOpCode.SMSG_ACCOUNT_DATA_TIMES)]
public class AccountDataTimesResponse
{
    [SerializableProperty(0)]
    public DateTime Time { get; set; }

    [SerializableProperty(1)]
    public byte Unk { get; set; } = 1;

    [SerializableProperty(2)]
    public uint Mask { get; set; }

    [SerializableProperty(3)]
    public List<uint> Times { get; set; } = [];
}
