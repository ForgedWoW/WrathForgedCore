// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Maps.MapFiles;

[ForgedSerializable]
public class MmapTileHeader
{
    [SerializableProperty(0)]
    public uint DtVersion { get; set; }

    [SerializableProperty(1)]
    public uint MMAPMagic { get; set; }

    [SerializableProperty(2)]
    public uint MMAPVersion { get; set; }

    [SerializableProperty(3)]
    public uint Size { get; set; }

    [SerializableProperty(4)]
    public byte UsesLiquids { get; set; }
}
