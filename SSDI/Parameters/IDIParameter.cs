namespace SSDI.Parameters
{
    public interface IDIParameter
    {
        object Value { get; }
        bool GetParameterValue(string parameterName, int parameterPosition, Type parameterType);
    }
}
