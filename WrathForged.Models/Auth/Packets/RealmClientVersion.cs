// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Auth.Packets;

[ForgedSerializable]
public class RealmClientVersion
{
    [SerializableProperty(0)]
    public byte Major { get; set; }

    [SerializableProperty(1)]
    public byte Minor { get; set; }

    [SerializableProperty(2)]
    public byte Revision { get; set; }

    [SerializableProperty(3)]
    public short Build { get; set; }
}
