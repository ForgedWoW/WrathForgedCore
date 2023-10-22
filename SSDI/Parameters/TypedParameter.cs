namespace SSDI.Parameters;

public class TypedParameter : IDIParameter
{
    public TypedParameter(object value)
    {
        Value = value;
        ValueType = value.GetType();
    }

    public object Value { get; }
    public Type ValueType { get; }

    public bool GetParameterValue(string parameterName, int parameterPosition, Type parameterType) => parameterType == ValueType || ValueType.IsAssignableTo(parameterType);
}
