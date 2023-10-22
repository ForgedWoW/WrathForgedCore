
namespace SSDI.Parameters
{
    public class PositionalParameter : IDIParameter
    {
        private readonly int _position;

        public PositionalParameter(int position, object value)
        {
            _position = position;
            Value = value;
        }

        public object Value { get; }

        public bool GetParameterValue(string parameterName, int parameterPosition, Type parameterType) => parameterPosition == _position;
    }
}