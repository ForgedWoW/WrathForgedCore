using System.Reflection;
using SSDI.Parameters;

namespace SSDI.Builder
{
    internal class CachedConstructor
    {
        internal ConstructorInfo Constructor { get; }
        internal ParameterInfo[] Parameters { get; }
        internal List<IDIParameter> ParameterValues { get; }

        internal CachedConstructor(ConstructorInfo constructor, List<IDIParameter> parameterValues)
        {
            Constructor = constructor;
            Parameters = constructor.GetParameters();
            ParameterValues = parameterValues;
        }
    }
}
