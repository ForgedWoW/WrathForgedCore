// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Auth.Packets;

[ForgedSerializable(Serialization.Models.PacketScope.ClientToRealm, Realm.Enum.RealmServerOpCode.CMSG_AUTH_SESSION)]
public class RealmAuthSessionRequest
{
    [SerializableProperty(0)]
    public uint Build { get; set; }

    [SerializableProperty(1)]
    public uint LoginServerId { get; set; }

    [SerializableProperty(2, OverrideType = Serialization.Models.ForgedTypeCode.CString)]
    public string AccountName { get; set; } = string.Empty;

    [SerializableProperty(3)]
    public uint LoginServerType { get; set; }

    [SerializableProperty(4, FixedCollectionSize = 4)]
    public byte[] LocalChallenge { get; set; } = [];

    [SerializableProperty(5)]
    public uint RegionId { get; set; }

    [SerializableProperty(6)]
    public uint BattlegroupId { get; set; }

    [SerializableProperty(7)]
    public uint RealmId { get; set; }

    [SerializableProperty(8)]
    public ulong DosResponse { get; set; }

    [SerializableProperty(9)]
    public byte[] Digest { get; set; } = [];

    [SerializableProperty(11, CollectionSizeLengthType = TypeCode.UInt64, Flags = Serialization.Models.SerializationFlags.ZLibCompressedCollection)]
    public ClientAddons? AddonInfo { get; set; }
}
