// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Reflection;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Serilog;
using WrathForged.Database.DBC;

namespace WrathForged.Common.DBC
{
    public class DBCSerializer
    {
        private readonly ILogger _logger;

        public DBCSerializer(ILogger logger) => _logger = logger;

        public void Serialize<T>(IEnumerable<T> itemsEn, string filePath, PropertyInfo prop) where T : class, IDBCRecord
        {
            var type = typeof(T);

            if (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>))
                type = prop.PropertyType.GetGenericArguments()[0];
            else
                return;

            if (type.GetCustomAttribute(typeof(DBCBoundAttribute)) is not DBCBoundAttribute dbcAtt)
                return;

            using var writer = new BinaryWriter(File.Open(Path.Combine(filePath, dbcAtt.Name), FileMode.Create));

            var properties = type.GetProperties()
                                 .Where(p => Attribute.IsDefined(p, typeof(DBCPropertyBindingAttribute)))
                                 .OrderBy(p => (p.GetCustomAttribute(typeof(DBCPropertyBindingAttribute)) as DBCPropertyBindingAttribute)?.ColumnIndex)
                                 .ToList();

            var items = itemsEn.ToList(); // execute the sql query, load all into memory

            _logger.Debug("Serializing {Count} records for {DBCName}", items.Count, dbcAtt.Name);

            var recordSize = 0; // Initialize the record size 248
            var stringSize = 0u; // Initialize the total string size
            var recordCount = items.Count; // Initialize the total record count

            foreach (var property in properties)
            {
                if (property.GetCustomAttribute(typeof(DBCPropertyBindingAttribute)) is not DBCPropertyBindingAttribute attribute)
                    continue;

                switch (attribute.BindingType)
                {
                    case DBCBindingType.SBYTE:
                        recordSize += sizeof(sbyte);
                        break;

                    case DBCBindingType.BYTE:
                        recordSize += sizeof(byte);
                        break;

                    case DBCBindingType.INT32:
                        recordSize += sizeof(int);
                        break;

                    case DBCBindingType.UINT32:
                        recordSize += sizeof(uint);
                        break;

                    case DBCBindingType.FLOAT:
                        recordSize += sizeof(float);
                        break;

                    case DBCBindingType.DOUBLE:
                        recordSize += sizeof(double);
                        break;

                    case DBCBindingType.STRING:
                        recordSize += sizeof(int);
                        break;
                    case DBCBindingType.UNKNOWN:
                    default:
                        break;
                }
            }

            var headerSize = 4 + (sizeof(uint) * 4); // 4 bytes for the magic, 4 uints for the header
            writer.BaseStream.Position = headerSize; // Skip the header for now, we write it last after we know the sizes

            using MemoryStream stringWriter = new();
            stringWriter.WriteByte(0);
            foreach (var item in items)
            {
                foreach (var property in properties)
                {
                    if (property.GetCustomAttribute(typeof(DBCPropertyBindingAttribute)) is not DBCPropertyBindingAttribute attribute)
                        continue;

                    var value = property.GetValue(item);

                    if (value == default && attribute.DefaultValue != null)
                    {
                        value = attribute.DefaultValue;
                    }

                    if (value == default && attribute.Nullable)
                    {
                        value = null;
                    }

                    switch (attribute.BindingType)
                    {

                        case DBCBindingType.SBYTE:
                            writer.Write(value != null ? (sbyte)value : (sbyte)0);
                            break;

                        case DBCBindingType.BYTE:
                            writer.Write(value != null ? (byte)value : (byte)0);
                            break;

                        case DBCBindingType.INT32:
                            writer.Write(value != null ? (int)value : 0);
                            break;

                        case DBCBindingType.UINT32:
                            writer.Write(value != null ? (uint)value : 0u);
                            break;

                        case DBCBindingType.FLOAT:
                            writer.Write(value != null ? (float)value : 0f);
                            break;

                        case DBCBindingType.DOUBLE:
                            writer.Write(value != null ? (double)value : 0d);
                            break;

                        case DBCBindingType.STRING:
                            var stringValue = value != null ? (string)value : string.Empty;

                            if (stringValue == string.Empty) // empty string is just a null terminator
                            {
                                writer.Write(0);
                                break;
                            }

                            stringValue = stringValue.Replace("\r\n", "\n").Replace(Environment.NewLine, "\n");

                            var strBytes = Encoding.UTF8.GetBytes(stringValue);
                            writer.Write((int)stringWriter.Position);

                            stringWriter.Write(strBytes, 0, strBytes.Length);
                            stringWriter.WriteByte(0);

                            stringSize += (uint)strBytes.Length + 1u; // Size of the string + null terminator
                            break;

                        case DBCBindingType.UNKNOWN:
                        default:
                            _logger.Warning("Unsupported binding type {BindingType}", attribute.BindingType);
                            break;
                    }
                }
            }

            _logger.Debug("Record Size: {RecordSize} String Size: {StringSize} Record Count: {RecordCount}", recordSize, stringSize, recordCount);

            stringWriter.Position = 0;
            writer.BaseStream.Position = writer.BaseStream.Length;
            stringWriter.CopyTo(writer.BaseStream);
            writer.BaseStream.Position = 0;

            writer.Write(Encoding.UTF8.GetBytes("WDBC")); // 4 bytes
            writer.Write(recordCount);
            writer.Write(properties.Count);
            writer.Write(recordSize);
            writer.Write(stringSize);
        }
    }
}