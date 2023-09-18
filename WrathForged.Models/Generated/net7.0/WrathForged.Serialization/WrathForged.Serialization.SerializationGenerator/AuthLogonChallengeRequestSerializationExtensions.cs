using System.Net;
using WrathForged.Models.Auth.Enum;
using WrathForged.Models.Auth;
using WrathForged.Serialization;
using System.Linq;
using System;
namespace WrathForged.Models.Auth
{
    public partial record AuthLogonChallengeRequestSerializationExtensions
    {

#pragma warning disable CS8602
#pragma warning disable CS8604

        public void Serialize(System.IO.BinaryWriter writer)
        {
            Dictionary<uint, bool> hasDefaultValue = new Dictionary<uint, bool>();
            hasDefaultValue[0] = Protocol == default;
            writer.Write((int)Protocol);
            hasDefaultValue[1] = Size == default;
            writer.Write(Size);
            hasDefaultValue[2] = ClientType == default;
            writer.Write((int)ClientType.ToString().Length);
            writer.Write(ClientType.ToString().ToCharArray());

            hasDefaultValue[3] = Major == default;
            writer.Write((int)Major);
            hasDefaultValue[4] = Minor == default;
            writer.Write(Minor);
            hasDefaultValue[5] = Revision == default;
            writer.Write(Revision);
            hasDefaultValue[6] = Build == default;
            writer.Write(Build);
            hasDefaultValue[7] = Architecture == default;
            writer.Write((int)Architecture.ToString().Reverse().ToString().Length);
            writer.Write(Architecture.ToString().Reverse().ToString().ToCharArray());

            hasDefaultValue[8] = OperatingSystem == default;
            writer.Write((int)OperatingSystem.ToString().Reverse().ToString().Length);
            writer.Write(OperatingSystem.ToString().Reverse().ToString().ToCharArray());

            hasDefaultValue[9] = Locale == default;
            writer.Write((int)Locale.ToString().Reverse().ToString().Length);
            writer.Write(Locale.ToString().Reverse().ToString().ToCharArray());

            hasDefaultValue[10] = TimeZoneBias == default;
            writer.Write(TimeZoneBias);
            hasDefaultValue[11] = IpAddress == default;
            if (IpAddress != null) { writer.Write(IpAddress.GetAddressBytes()); } else { writer.Write(IPAddress.Loopback.GetAddressBytes()); }
            hasDefaultValue[12] = Identity == default;
            if (Identity != null)
            {
                writer.Write((int)Identity.Length);
                writer.Write(Identity.ToCharArray());
            }
            else
            {
                writer.Write((int)0);
                writer.Write(new char[0]);
            }

        }
        [DeserializeDefinition(PacketScope.Auth, 0, 2)]
        public DeserializationResult Read(System.IO.BinaryReader reader)
        {
            try
            {
                var cachedSizes = new Dictionary<uint, int>();
                Protocol = (ProtocolVersion)reader.ReadByte();
                Size = reader.ReadUInt16();
                if (System.Enum.TryParse(typeof(ClientType), new string(reader.ReadChars((int)reader.ReadByte())).TrimEnd('\0'), out var ClientTypeVal)) { ClientType = (ClientType)ClientTypeVal; }
                Major = (ExpansionType)reader.ReadByte();
                Minor = reader.ReadByte();
                Revision = reader.ReadByte();
                Build = reader.ReadByte();
                if (System.Enum.TryParse(typeof(ProcessorArchitecture), new string(reader.ReadChars((int)reader.ReadByte())).TrimEnd('\0').Reverse().ToString(), out var ArchitectureVal)) { Architecture = (ProcessorArchitecture)ArchitectureVal; }
                if (System.Enum.TryParse(typeof(OperatingSystemType), new string(reader.ReadChars((int)reader.ReadByte())).TrimEnd('\0').Reverse().ToString(), out var OperatingSystemVal)) { OperatingSystem = (OperatingSystemType)OperatingSystemVal; }
                if (System.Enum.TryParse(typeof(ClientLocale), new string(reader.ReadChars((int)reader.ReadByte())).TrimEnd('\0').Reverse().ToString(), out var LocaleVal)) { Locale = (ClientLocale)LocaleVal; }
                TimeZoneBias = reader.ReadUInt32();
                IpAddress = new IPAddress(reader.ReadBytes(4));
                Identity = new string(reader.ReadChars((int)reader.ReadByte())).TrimEnd('\0');
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
