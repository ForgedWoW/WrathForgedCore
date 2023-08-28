using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WrathForged.Serialization;

namespace WrathForged.Models.Auth
{
    [ForgedSerializable]
    public class RealmIdentification
    {
        [SerializableProperty(0)]
        public uint RegionID { get; } = 0;

        [SerializableProperty(1)]
        public uint BattlegroupID { get; } = 0;

        [SerializableProperty(2)]
        public uint RealmID { get; }
    }
}
