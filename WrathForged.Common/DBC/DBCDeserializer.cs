// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Reflection;
using System.Text;
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Database.DBC;

namespace WrathForged.Common.DBC
{
    public class DBCDeserializer
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;

        public DBCDeserializer(IConfiguration configuration, ILogger logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public static IEnumerable<T> Deserialize<T>(string filePath) where T : class, new()
        {
            if (typeof(T).GetCustomAttribute(typeof(DBCBoundAttribute)) is not DBCBoundAttribute dbcAtt)
                return Enumerable.Empty<T>();

            using var reader = new BinaryReader(File.Open(filePath, FileMode.Open));
            var type = typeof(T);
            var properties = type.GetProperties()
                                 .Where(p => Attribute.IsDefined(p, typeof(DBCPropertyBindingAttribute)))
                                 .ToArray();

            var header = new DBCHeader
            {
                Magic = reader.ReadUInt32(),
                RecordCount = reader.ReadUInt32(),
                FieldCount = reader.ReadUInt32(),
                RecordSize = reader.ReadUInt32(),
                StringBlockSize = reader.ReadUInt32()
            };

            if (header.Magic != 0x43424457)
            {
                throw new InvalidOperationException("Invalid DBC file");
            }

            var stringBlock = reader.ReadBytes((int)header.StringBlockSize);
            var items = new List<T>();

            for (var i = 0; i < header.RecordCount; i++)
            {
                var item = new T();

                foreach (var property in properties)
                {
                    if (property.GetCustomAttribute(typeof(DBCPropertyBindingAttribute)) is not DBCPropertyBindingAttribute attribute)
                        continue;

                    object value = attribute.BindingType switch
                    {
                        DBCBindingType.INT32 => reader.ReadInt32(),
                        DBCBindingType.UINT32 => reader.ReadUInt32(),
                        DBCBindingType.UINT8 => reader.ReadByte(),
                        DBCBindingType.FLOAT => reader.ReadSingle(),
                        DBCBindingType.DOUBLE => reader.ReadDouble(),
                        DBCBindingType.STRING => Encoding.UTF8.GetString(stringBlock, reader.ReadInt32(), (int)(stringBlock.Length - reader.BaseStream.Position)),
                        DBCBindingType.UNKNOWN or DBCBindingType.IGNORE_ORDER or _ => throw new InvalidOperationException("Unsupported binding type"),
                    };

                    property.SetValue(item, value);
                }

                items.Add(item);
            }

            return items;
        }
    }
}