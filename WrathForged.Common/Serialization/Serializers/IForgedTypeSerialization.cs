using WrathForged.Common.Networking;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Serialization.Serializers
{
    public interface IForgedTypeSerialization
    {
        object? Serialize(PacketBuffer packetBuffer, ForgedSerializableAttribute forgedSerializableAttribute);
    }
}
