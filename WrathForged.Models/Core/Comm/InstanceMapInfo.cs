namespace WrathForged.Models.Core.Comm
{
    [ForgedSerializable]
    public class InstanceMapInfo
    {
        [SerializableProperty(0)]
        public uint MapId { get; set; }

        [SerializableProperty(1)]
        public List<uint> Difficulties { get; set; } = [];
    }
}
