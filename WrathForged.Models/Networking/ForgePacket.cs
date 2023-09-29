using WrathForged.Models.Core.Comm;
using WrathForged.Serialization.Models;

namespace WrathForged.Models.Networking
{
    [ForgedSerializable]
    public class ForgePacket
    {
        [SerializableProperty(0)]
        public PacketScope Scope { get; set; }

        [SerializableProperty(1)]
        public ForgedCoreOpCode OpCode { get; set; }

        [SerializableProperty(2)]
        public uint Size { get; set; }

        [SerializableProperty(3, CollectionSizeIndex = 2)]
        public byte[] Data { get; set; } = Array.Empty<byte>();
    }
}
