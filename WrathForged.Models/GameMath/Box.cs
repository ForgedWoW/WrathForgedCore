// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;

namespace WrathForged.Models.GameMath;
public class Box
{
    public float Area { get; set; }
    public Vector3 Center;
    public Vector3[] EdgeVector { get; set; } = new Vector3[3];
    public float Volume { get; set; }

    public Box(Vector3 min, Vector3 max)
    {
        Center = (max + min) * 0.5f;

        var bounds = new Vector3(max.X - min.X, max.Y - min.Y, max.Z - min.Z);
        EdgeVector[0] = new Vector3(bounds.X, 0, 0);
        EdgeVector[1] = new Vector3(0, bounds.Y, 0);
        EdgeVector[2] = new Vector3(0, 0, bounds.Z);
        var finiteExtent = true;

        for (var i = 0; i < 3; ++i)
            if (!float.IsFinite(EdgeVector[i].Length()))
            {
                finiteExtent = false;
                // If the extent is infinite along an axis, make the center zero to avoid NaNs
                Center.SetAt(0, i);
            }

        Volume = finiteExtent ? bounds.X * bounds.Y * bounds.Z : float.PositiveInfinity;

        Area = 2 *
                ((bounds.X * bounds.Y) +
                 (bounds.Y * bounds.Z) +
                 (bounds.Z * bounds.X));
    }

    public bool Contains(Vector3 point)
    {
        var u = EdgeVector[2];
        var v = EdgeVector[1];
        var w = EdgeVector[0];

        Matrix4x4 M = new(u.X, v.X, w.X, 0.0f, u.Y, v.Y, w.Y, 0.0f, u.Z, v.Z, w.Z, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f);

        // M^-1 * (point - _corner[0]) = point in unit cube's object space
        // compute the inverse of M
        _ = Matrix4x4.Invert(M, out M);
        var osPoint = M.Multiply(point - Corner(0));

        return (osPoint.X >= 0) &&
               (osPoint.Y >= 0) &&
               (osPoint.Z >= 0) &&
               (osPoint.X <= 1) &&
               (osPoint.Y <= 1) &&
               (osPoint.Z <= 1);
    }

    public bool IsFinite() => float.IsFinite(Volume);

    private Vector3 Corner(int i)
    {
        return i switch
        {
            0 => Center + (0.5f * (-EdgeVector[0] - EdgeVector[1] - EdgeVector[2])),
            1 => Center + (0.5f * (EdgeVector[0] - EdgeVector[1] - EdgeVector[2])),
            2 => Center + (0.5f * (-EdgeVector[0] + EdgeVector[1] - EdgeVector[2])),
            3 => Center + (0.5f * (EdgeVector[0] + EdgeVector[1] - EdgeVector[2])),
            4 => Center + (0.5f * (-EdgeVector[0] - EdgeVector[1] + EdgeVector[2])),
            5 => Center + (0.5f * (EdgeVector[0] - EdgeVector[1] + EdgeVector[2])),
            6 => Center + (0.5f * (-EdgeVector[0] + EdgeVector[1] + EdgeVector[2])),
            _ => Center + (0.5f * (EdgeVector[0] + EdgeVector[1] + EdgeVector[2])),//case 7
        };
    }
}