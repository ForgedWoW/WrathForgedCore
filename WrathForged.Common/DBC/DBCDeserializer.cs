// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.

using System.Reflection;
using System.Text;
using Serilog;
using WrathForged.Database.DBC;

namespace WrathForged.Common.DBC
{
    public class DBCDeserializer
    {
        private readonly ILogger _logger;

        public DBCDeserializer(ILogger logger) => _logger = logger;

        public IEnumerable<T> Deserialize<T>(string filePath) where T : class, new()
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

                    object? value;
                    switch (attribute.BindingType)
                    {
                        case DBCBindingType.INT32:
                            value = reader.ReadInt32();
                            break;

                        case DBCBindingType.UINT32:
                            value = reader.ReadUInt32();
                            break;

                        case DBCBindingType.UINT8:
                            value = reader.ReadByte();
                            break;

                        case DBCBindingType.FLOAT:
                            value = reader.ReadSingle();
                            break;

                        case DBCBindingType.DOUBLE:
                            value = reader.ReadDouble();
                            break;

                        case DBCBindingType.STRING:
                            value = Encoding.UTF8.GetString(stringBlock, reader.ReadInt32(), (int)(stringBlock.Length - reader.BaseStream.Position));
                            break;

                        case DBCBindingType.UNKNOWN:
                        case DBCBindingType.IGNORE_ORDER:
                        default:
                            _logger.Warning("Unsupported binding type {BindingType}", attribute.BindingType);
                            value = null;
                            break;
                    }

                    if (value != null)
                        property.SetValue(item, value);
                }

                items.Add(item);
            }

            return items;
        }
    }
}