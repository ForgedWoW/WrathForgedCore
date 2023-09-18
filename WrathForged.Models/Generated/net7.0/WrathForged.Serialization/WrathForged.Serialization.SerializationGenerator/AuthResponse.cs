using WrathForged.Models.Auth.Enum;
using WrathForged.Serialization;
using System.Linq;
using System;
namespace WrathForged.Models.Auth {
    public partial record AuthResponse
    {

#pragma warning disable CS8602
#pragma warning disable CS8604

public void Serialize(System.IO.BinaryWriter writer)
{
Dictionary<uint, bool> hasDefaultValue = new Dictionary<uint, bool>();
hasDefaultValue[0] = Status == default;
writer.Write((int)Status);
hasDefaultValue[1] = QueuePosition == default;
if(QueuePosition != default) { writer.Write(QueuePosition); }
hasDefaultValue[2] = Unknown == default;
if(!hasDefaultValue[1]) { writer.Write(Unknown); }
}
public DeserializationResult Read(System.IO.BinaryReader reader)
{
try
{
var cachedSizes = new Dictionary<uint, int>();
Status = (AuthStatus)reader.ReadInt32();
QueuePosition = reader.ReadUInt32();
Unknown = reader.ReadByte();
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
