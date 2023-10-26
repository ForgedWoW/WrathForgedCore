namespace DotRecast.Detour.Crowd;

/// Provides neighbor data for agents managed by the crowd.
/// @ingroup crowd
/// @see dtCrowdAgent::neis, dtCrowd
/// < The distance between the current agent and the neighbor.
public readonly struct DtCrowdNeighbour(DtCrowdAgent agent, float dist)
{
    public readonly DtCrowdAgent agent = agent;

    /// < The index of the neighbor in the crowd.
    public readonly float dist = dist;
};