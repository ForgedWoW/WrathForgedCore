// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Models.Maps.MapFiles;

namespace WrathForged.Models.Maps;

[ForgedSerializable]
public class VMapTileData
{
    [SerializableProperty(0, OverrideType = Serialization.Models.ForgedTypeCode.CharArray, FixedCollectionSize = 8)]
    public string Magic { get; set; } = string.Empty;

    [SerializableProperty(1)]
    public CollisionModelSpawn[] ModelSpawns { get; set; } = [];
}
