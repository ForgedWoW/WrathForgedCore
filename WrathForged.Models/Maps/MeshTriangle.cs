// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Models.Maps;

public readonly struct MeshTriangle(int na, int nb, int nc)
{
    public int Idx0 { get; } = na;
    public int Idx1 { get; } = nb;
    public int Idx2 { get; } = nc;
}
