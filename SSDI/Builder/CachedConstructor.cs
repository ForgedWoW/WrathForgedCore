using System.Linq.Expressions;
using System.Reflection;
using SSDI.Parameters;

namespace SSDI.Builder;

internal class CachedConstructor
{
    internal ConstructorInfo Constructor { get; }
    internal ParameterInfo[] Parameters { get; }
    internal List<IDIParameter> ParameterValues { get; }
    internal Delegate ConstructorDelegate { get; }

    internal CachedConstructor(ConstructorInfo constructor, List<IDIParameter> parameterValues)
    {
        Constructor = constructor;
        Parameters = constructor.GetParameters();
        ParameterValues = parameterValues;

        var parametersExpressions = new List<ParameterExpression>();

        foreach (var parameter in Parameters)
        {
            var parameterExpression = Expression.Parameter(parameter.ParameterType, parameter.Name);
            parametersExpressions.Add(parameterExpression);
        }

        var expression = Expression.New(constructor, parametersExpressions);
        ConstructorDelegate = Expression.Lambda(expression, parametersExpressions).Compile();
    }
}
