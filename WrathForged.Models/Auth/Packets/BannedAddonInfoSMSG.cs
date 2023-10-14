// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Auth.Packets;

[ForgedSerializable]
public class BannedAddonInfoSMSG
{
    [SerializableProperty(0)]
    public uint Id { get; set; }

    [SerializableProperty(1)]
    public byte[] NameMD5 { get; set; } = [];

    [SerializableProperty(2)]
    public byte[] VersionMD5 { get; set; } = [];

    [SerializableProperty(3)]
    public uint Timestamp { get; set; }

    [SerializableProperty(4)]
    public uint IsBanned { get; set; }
}
