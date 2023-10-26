using DotRecast.Core.Numerics;

namespace DotRecast.Recast.Toolset.Tools
{
    public class RcCrowdAgentData(RcCrowdAgentType type, RcVec3f home)
    {
        public readonly RcCrowdAgentType type = type;
        public readonly RcVec3f home = home;
    }
}