/*
Copyright (c) 2009-2010 Mikko Mononen memon@inside.org
recast4j copyright (c) 2015-2019 Piotr Piastucki piotr@jtilia.org
DotRecast Copyright (c) 2023 Choi Ikpil ikpil@naver.com

This software is provided 'as-is', without any express or implied
warranty.  In no event will the authors be held liable for any damages
arising from the use of this software.
Permission is granted to anyone to use this software for any purpose,
including commercial applications, and to alter it and redistribute it
freely, subject to the following restrictions:
1. The origin of this software must not be misrepresented; you must not
 claim that you wrote the original software. If you use this software
 in a product, an acknowledgment in the product documentation would be
 appreciated but is not required.
2. Altered source versions must be plainly marked as such, and must not be
 misrepresented as being the original software.
3. This notice may not be removed or altered from any source distribution.
*/

using System;
using System.Collections.Generic;
using DotRecast.Core.Numerics;

namespace DotRecast.Detour.Crowd;

/// Represents an agent managed by a #dtCrowd object.
/// @ingroup crowd
public class DtCrowdAgent(int idx)
{
    public readonly long idx = idx;

    /// The type of mesh polygon the agent is traversing. (See: #CrowdAgentState)
    public DtCrowdAgentState state;

    /// True if the agent has valid path (targetState == DT_CROWDAGENT_TARGET_VALID) and the path does not lead to the
    /// requested position, else false.
    public bool partial;

    /// The path corridor the agent is using.
    public DtPathCorridor corridor = new DtPathCorridor();

    /// The local boundary data for the agent.
    public DtLocalBoundary boundary = new DtLocalBoundary();

    /// Time since the agent's path corridor was optimized.
    public float topologyOptTime;

    /// The known neighbors of the agent.
    public List<DtCrowdNeighbour> neis = [];

    /// The desired speed.
    public float desiredSpeed;

    public RcVec3f npos = new();

    /// < The current agent position. [(x, y, z)]
    public RcVec3f disp = new();

    /// < A temporary value used to accumulate agent displacement during iterative
    /// collision resolution. [(x, y, z)]
    public RcVec3f dvel = new();

    /// < The desired velocity of the agent. Based on the current path, calculated
    /// from
    /// scratch each frame. [(x, y, z)]
    public RcVec3f nvel = new();

    /// < The desired velocity adjusted by obstacle avoidance, calculated from scratch each
    /// frame. [(x, y, z)]
    public RcVec3f vel = new();

    /// < The actual velocity of the agent. The change from nvel -> vel is
    /// constrained by max acceleration. [(x, y, z)]
    /// The agent's configuration parameters.
    public DtCrowdAgentParams option;

    /// The local path corridor corners for the agent.
    public List<DtStraightPath> corners = [];

    public DtMoveRequestState targetState;

    /// < State of the movement request.
    public long targetRef;

    /// < Target polyref of the movement request.
    public RcVec3f targetPos = new();

    /// < Target position of the movement request (or velocity in case of
    /// DT_CROWDAGENT_TARGET_VELOCITY).
    public DtPathQueryResult targetPathQueryResult;

    /// < Path finder query
    public bool targetReplan;

    /// < Flag indicating that the current path is being replanned.
    public float targetReplanTime;

    /// <Time since the agent's target was replanned.
    public float targetReplanWaitTime;

    public DtCrowdAgentAnimation animation = new DtCrowdAgentAnimation();

    public void Integrate(float dt)
    {
        // Fake dynamic constraint.
        var maxDelta = option.maxAcceleration * dt;
        var dv = RcVec3f.Subtract(nvel, vel);
        var ds = dv.Length();
        if (ds > maxDelta)
            dv = dv.Scale(maxDelta / ds);
        vel = RcVec3f.Add(vel, dv);

        // Integrate
        if (vel.Length() > 0.0001f)
            npos = RcVecUtils.Mad(npos, vel, dt);
        else
            vel = RcVec3f.Zero;
    }

    public bool OverOffmeshConnection(float radius)
    {
        if (0 == corners.Count)
            return false;

        var offMeshConnection = (corners[^1].flags
                                   & DtStraightPathFlags.DT_STRAIGHTPATH_OFFMESH_CONNECTION) != 0;
        if (offMeshConnection)
        {
            var distSq = RcVecUtils.Dist2DSqr(npos, corners[^1].pos);
            if (distSq < radius * radius)
                return true;
        }

        return false;
    }

    public float GetDistanceToGoal(float range)
    {
        if (0 == corners.Count)
            return range;

        var endOfPath = (corners[^1].flags & DtStraightPathFlags.DT_STRAIGHTPATH_END) != 0;
        return endOfPath ? Math.Min(RcVecUtils.Dist2D(npos, corners[^1].pos), range) : range;
    }

    public RcVec3f CalcSmoothSteerDirection()
    {
        var dir = new RcVec3f();
        if (0 < corners.Count)
        {
            var ip0 = 0;
            var ip1 = Math.Min(1, corners.Count - 1);
            var p0 = corners[ip0].pos;
            var p1 = corners[ip1].pos;

            var dir0 = RcVec3f.Subtract(p0, npos);
            var dir1 = RcVec3f.Subtract(p1, npos);
            dir0.Y = 0;
            dir1.Y = 0;

            var len0 = dir0.Length();
            var len1 = dir1.Length();
            if (len1 > 0.001f)
                dir1 = dir1.Scale(1.0f / len1);

            dir.X = dir0.X - (dir1.X * len0 * 0.5f);
            dir.Y = 0;
            dir.Z = dir0.Z - (dir1.Z * len0 * 0.5f);
            dir = RcVec3f.Normalize(dir);
        }

        return dir;
    }

    public RcVec3f CalcStraightSteerDirection()
    {
        var dir = new RcVec3f();
        if (0 < corners.Count)
        {
            dir = RcVec3f.Subtract(corners[0].pos, npos);
            dir.Y = 0;
            dir = RcVec3f.Normalize(dir);
        }

        return dir;
    }

    public void SetTarget(long refs, RcVec3f pos)
    {
        targetRef = refs;
        targetPos = pos;
        targetPathQueryResult = null;
        targetState = targetRef != 0 ? DtMoveRequestState.DT_CROWDAGENT_TARGET_REQUESTING : DtMoveRequestState.DT_CROWDAGENT_TARGET_FAILED;
    }
}