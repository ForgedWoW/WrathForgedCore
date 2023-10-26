namespace DotRecast.Detour.Extras.Jumplink
{
    public class JumpLinkBuilderConfig(float cellSize, float cellHeight, float agentRadius, float agentHeight,
        float agentClimb, float groundTolerance, float startDistance, float endDistance, float minHeight,
        float maxHeight, float jumpHeight)
    {
        public readonly float cellSize = cellSize;
        public readonly float cellHeight = cellHeight;
        public readonly float agentClimb = agentClimb;
        public readonly float agentRadius = agentRadius;
        public readonly float groundTolerance = groundTolerance;
        public readonly float agentHeight = agentHeight;
        public readonly float startDistance = startDistance;
        public readonly float endDistance = endDistance;
        public readonly float jumpHeight = jumpHeight;
        public readonly float minHeight = minHeight;
        public readonly float heightRange = maxHeight - minHeight;
    }
}