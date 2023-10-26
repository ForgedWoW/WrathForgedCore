namespace DotRecast.Detour.Crowd;

public class DtCrowdTimerLabel
{
    public static readonly DtCrowdTimerLabel CheckPathValidity = new(nameof(CheckPathValidity));
    public static readonly DtCrowdTimerLabel UpdateMoveRequest = new(nameof(UpdateMoveRequest));
    public static readonly DtCrowdTimerLabel PathQueueUpdate = new(nameof(PathQueueUpdate));
    public static readonly DtCrowdTimerLabel UpdateTopologyOptimization = new(nameof(UpdateTopologyOptimization));
    public static readonly DtCrowdTimerLabel BuildProximityGrid = new(nameof(BuildProximityGrid));
    public static readonly DtCrowdTimerLabel BuildNeighbours = new(nameof(BuildNeighbours));
    public static readonly DtCrowdTimerLabel FindCorners = new(nameof(FindCorners));
    public static readonly DtCrowdTimerLabel TriggerOffMeshConnections = new(nameof(TriggerOffMeshConnections));
    public static readonly DtCrowdTimerLabel CalculateSteering = new(nameof(CalculateSteering));
    public static readonly DtCrowdTimerLabel PlanVelocity = new(nameof(PlanVelocity));
    public static readonly DtCrowdTimerLabel Integrate = new(nameof(Integrate));
    public static readonly DtCrowdTimerLabel HandleCollisions = new(nameof(HandleCollisions));
    public static readonly DtCrowdTimerLabel MoveAgents = new(nameof(MoveAgents));
    public static readonly DtCrowdTimerLabel UpdateOffMeshConnections = new(nameof(UpdateOffMeshConnections));

    public readonly string Label;

    private DtCrowdTimerLabel(string labelName) => Label = labelName;
}