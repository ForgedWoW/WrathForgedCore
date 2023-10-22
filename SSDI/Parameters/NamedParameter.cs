namespace SSDI.Parameters
{
    public class NamedParameter : IDIParameter
    {
        public NamedParameter(string name, object value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; }
        public object Value { get; }

        public bool GetParameterValue(string parameterName, int parameterPosition, Type parameterType) => parameterName == Name;
    }
}
