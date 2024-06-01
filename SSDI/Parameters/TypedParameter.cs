namespace SSDI.Parameters;

public class TypedParameter(object value) : IDIParameter
{
    public object Value { get; } = value;
    public Type ValueType { get; } = value.GetType();

    public bool GetParameterValue(string parameterName, int parameterPosition, Type parameterType) => parameterType == ValueType || ValueType.IsAssignableTo(parameterType);
}
