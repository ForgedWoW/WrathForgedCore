// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Maps.MapFiles;
[ForgedSerializable]
public class MapHolesData
{
    [SerializableProperty(0, FixedCollectionSize = 16 * 16)]
    public ushort[]? Holes { get; set; }
}
