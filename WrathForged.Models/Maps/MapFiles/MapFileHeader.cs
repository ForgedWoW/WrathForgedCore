// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Maps.MapFiles;

[ForgedSerializable]
public class MapFileHeader
{
    [SerializableProperty(0)]
    public uint MapMagic { get; set; }

    [SerializableProperty(1)]
    public uint VersionMagic { get; set; }

    [SerializableProperty(2)]
    public uint BuildMagic { get; set; }

    [SerializableProperty(3)]
    public uint AreaMapOffset { get; set; }

    [SerializableProperty(4)]
    public uint AreaMapSize { get; set; }

    [SerializableProperty(5)]
    public uint HeightMapOffset { get; set; }

    [SerializableProperty(6)]
    public uint HeightMapSize { get; set; }

    [SerializableProperty(7)]
    public uint LiquidMapOffset { get; set; }

    [SerializableProperty(8)]
    public uint LiquidMapSize { get; set; }

    [SerializableProperty(9)]
    public uint HolesOffset { get; set; }

    [SerializableProperty(10)]
    public uint HolesSize { get; set; }
}
