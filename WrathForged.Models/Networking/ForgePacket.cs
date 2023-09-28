using WrathForged.Serialization;
using WrathForged.Serialization.Models;

namespace WrathForged.Models.Networking
{
    [ForgedSerializable]
    public class ForgePacket
    {
        [SerializableProperty(0)]
        public PacketScope Scope { get; set; }

        [SerializableProperty(1)]
        public uint Size { get; set; }

        [SerializableProperty(2, CollectionSizeIndex = 1)]
        public byte[] Data { get; set; } = Array.Empty<byte>();
    }
}
