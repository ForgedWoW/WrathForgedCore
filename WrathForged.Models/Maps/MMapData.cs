// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using DotRecast.Detour;

namespace WrathForged.Models.Maps;

public class MMapData(DtNavMesh navMesh)
{
    public DtNavMesh NavMesh { get; } = navMesh;
    public Dictionary<uint, long> LoadedTileRefs { get; } = [];
    public Dictionary<uint, DtNavMeshQuery> NavMeshQueries { get; } = [];
}
