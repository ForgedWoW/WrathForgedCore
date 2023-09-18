using WrathForged.Serialization;
using System.Linq;
using System;
namespace WrathForged.Models.Auth
{
    public partial record RealmIdentificationSerializationExtensions
    {

#pragma warning disable CS8602
#pragma warning disable CS8604

        public void Serialize(System.IO.BinaryWriter writer)
        {
            Dictionary<uint, bool> hasDefaultValue = new Dictionary<uint, bool>();
            hasDefaultValue[0] = RegionID == default;
            writer.Write(RegionID);
            hasDefaultValue[1] = BattlegroupID == default;
            writer.Write(BattlegroupID);
            hasDefaultValue[2] = RealmID == default;
            writer.Write(RealmID);
        }
        public DeserializationResult Read(System.IO.BinaryReader reader)
        {
            try
            {
                var cachedSizes = new Dictionary<uint, int>();
                RegionID = reader.ReadUInt32();
                BattlegroupID = reader.ReadUInt32();
                RealmID = reader.ReadUInt32();
                return DeserializationResult.Success;
            }
            catch (EndOfStreamException)
            {
                instance = null;
                return DeserializationResult.EndOfStream;
            }
            catch (Exception)
            {
                instance = null;
                return DeserializationResult.Error;
            }
        }
    }
}
