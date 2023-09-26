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

            var recordSize = sizeof(uint); // Initialize the record size
            var stringSize = 0u; // Initialize the total string size
            var recordCount = 0; // Initialize the total record count
            var stringCount = 0u; // Initialize the total string count

            var headerSize = 4 + (sizeof(uint) * 4); // 4 bytes for the magic, 4 uints for the header
            writer.BaseStream.Position = headerSize; // Skip the header for now, we write it last after we know the sizes

            using MemoryStream stringWriter = new();

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
                            writer.Write(BitConverter.GetBytes(value != null ? (sbyte)value : 0), 0, recordSize);
                            recordCount++;
                            break;

                        case DBCBindingType.BYTE:
                            writer.Write(BitConverter.GetBytes(value != null ? (byte)value : 0u), 0, recordSize);
                            recordCount++;
                            break;

                        case DBCBindingType.INT32:
                            writer.Write(BitConverter.GetBytes(value != null ? (int)value : 0), 0, recordSize);
                            recordCount++;
                            break;

                        case DBCBindingType.UINT32:
                            writer.Write(BitConverter.GetBytes(value != null ? (uint)value : 0u), 0, recordSize);
                            recordCount++;
                            break;

                        case DBCBindingType.FLOAT:
                            writer.Write(BitConverter.GetBytes(value != null ? (float)value : 0f), 0, recordSize);
                            recordCount++;
                            break;

                        case DBCBindingType.DOUBLE:
                            writer.Write(BitConverter.GetBytes(value != null ? (double)value : 0d), 0, recordSize);
                            recordCount++;
                            break;

                        case DBCBindingType.STRING:
                            var stringValue = value != null ? (string)value : string.Empty;
                            writer.Write((int)stringWriter.Position);
                            stringValue = stringValue.Replace("\r\n", "\n").Replace(Environment.NewLine, "\n");

                            if (stringValue == string.Empty) // empty string is just a null terminator
                            {
                                stringWriter.WriteByte(0);
                                stringSize++;
                                stringCount++;
                                break;
                            }

                            var strBytes = Encoding.UTF8.GetBytes(stringValue);
                            stringWriter.Write(strBytes, 0, strBytes.Length);
                            stringWriter.WriteByte(0);
                            stringSize += (uint)strBytes.Length + 1u; // Size of the string + null terminator
                            stringCount++; // Count of the string
                            break;

                        case DBCBindingType.UNKNOWN:
                        case DBCBindingType.IGNORE_ORDER:
                        default:
                            _logger.Warning("Unsupported binding type {BindingType}", attribute.BindingType);
                            break;
                    }
                }
            }

            _logger.Debug("Record Size: {RecordSize} String Size: {StringSize} Record Count: {RecordCount} String Count: {StringCount}", recordSize, stringSize, recordCount, stringCount);

            stringWriter.CopyTo(writer.BaseStream);
            writer.BaseStream.Position = 0;

            writer.Write(Encoding.UTF8.GetBytes("WDBC")); // 4 bytes
            writer.Write(recordCount);
            writer.Write((uint)properties.Count);
            writer.Write(recordSize);
            writer.Write(stringSize);
        }
    }
}