using WrathForged.Serialization;
using System.Linq;
using System;
namespace WrathForged.Models {
    public partial record SRPToken
    {

#pragma warning disable CS8602
#pragma warning disable CS8604

public void Serialize(System.IO.BinaryWriter writer)
{
Dictionary<uint, bool> hasDefaultValue = new Dictionary<uint, bool>();
hasDefaultValue[1] = B == default;
if(B != null){writer.Write(B);}
hasDefaultValue[2] = G == default;

                if (G == null || G.Length == 0) { writer.Write((byte)0); } else { writer.Write((byte)G.Length); }
if(G != null){writer.Write(G);}
hasDefaultValue[3] = N == default;

                if (N == null || N.Length == 0) { writer.Write((byte)0); } else { writer.Write((byte)N.Length); }
if(N != null){writer.Write(N);}
hasDefaultValue[4] = Salt == default;
if(Salt != null){writer.Write(Salt);}
}
public DeserializationResult Read(System.IO.BinaryReader reader)
{
try
{
var cachedSizes = new Dictionary<uint, int>();
var collectionSize = 32;

B = reader.ReadBytes(collectionSize);
collectionSize = reader.ReadByte();

G = reader.ReadBytes(collectionSize);
collectionSize = reader.ReadByte();

N = reader.ReadBytes(collectionSize);
collectionSize = 32;

Salt = reader.ReadBytes(collectionSize);
return DeserializationResult.Success;
}
catch (EndOfStreamException)
{
return DeserializationResult.EndOfStream;
}
catch (Exception)
{
return DeserializationResult.Error;
}
}
    }
}
