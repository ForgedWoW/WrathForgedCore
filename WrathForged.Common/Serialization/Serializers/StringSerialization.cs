using WrathForged.Common.Networking;
using WrathForged.Serialization;

namespace WrathForged.Common.Serialization.Serializers
{
    public class StringSerialization : IForgedTypeSerialization
    {
        public HashSet<Type> SupportedTypes { get; } = new HashSet<Type>()
        {
        };

        public HashSet<ForgedTypeCode> SupportedForgedTypeCodes => throw new NotImplementedException();

        public object? Deserialize(PacketBuffer packetBuffer, SerializablePropertyAttribute serializableProperty)
        {
        }
    }
}