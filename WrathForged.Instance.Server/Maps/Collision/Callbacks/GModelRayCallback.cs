// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Numerics;
using WrathForged.Instance.Server.Maps.Collision.Interface;
using WrathForged.Models.GameMath;
using WrathForged.Models.Maps;

namespace WrathForged.Instance.Server.Maps.Collision.Callbacks;
public class GModelRayCallback(List<MeshTriangle> tris, List<Vector3> vert) : IRayIntersect
{
    public bool Hit;

    private readonly List<MeshTriangle> _triangles = tris;
    private readonly List<Vector3> _vertices = vert;

    public bool DidRayHit(Ray ray, int idx, ref float maxDistance, bool stopAtFirstHit)
    {
        Hit = IntersectTriangle(_triangles[idx], _vertices, ray, ref maxDistance) || Hit;

        return Hit;
    }

    private static bool IntersectTriangle(MeshTriangle tri, List<Vector3> points, Ray ray, ref float distance)
    {
        const float eps = 1e-5f;

        // See RTR2 ch. 13.7 for the algorithm.

        var e1 = points[tri.Idx1] - points[tri.Idx0];
        var e2 = points[tri.Idx2] - points[tri.Idx0];
        var p = Vector3.Cross(ray.Direction, e2);
        var a = Vector3.Dot(e1, p);

        if (Math.Abs(a) < eps)
            // Determinant is ill-conditioned; abort early
            return false;

        var f = 1.0f / a;
        var s = ray.Origin - points[tri.Idx0];
        var u = f * Vector3.Dot(s, p);

        if (u is < 0.0f or > 1.0f)
            // We hit the plane of the m_geometry, but outside the m_geometry
            return false;

        var q = Vector3.Cross(s, e1);
        var v = f * Vector3.Dot(ray.Direction, q);

        if (v < 0.0f || u + v > 1.0f)
            // We hit the plane of the triangle, but outside the triangle
            return false;

        var t = f * Vector3.Dot(e2, q);

        if (!(t > 0.0f) || !(t < distance))
            return false;

        // This is a new hit, closer than the previous one
        distance = t;

        return true;

        // This hit is after the previous hit, so ignore it
    }
}
