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

            var recordSize = 0u; // Initialize the total record size
            var stringSize = 0u; // Initialize the total string size
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
                        case DBCBindingType.INT32:
                            recordSize += sizeof(int);
                            break;

                        case DBCBindingType.UINT32:
                            recordSize += sizeof(uint);
                            break;

                        case DBCBindingType.UINT8:
                            recordSize += sizeof(byte);
                            break;

                        case DBCBindingType.FLOAT:
                            recordSize += sizeof(float);
                            break;

                        case DBCBindingType.DOUBLE:
                            recordSize += sizeof(double);
                            break;

                        case DBCBindingType.STRING:
                            var stringValue = value != null ? (string)value : string.Empty;
                            stringSize += (uint)Encoding.UTF8.GetByteCount(stringValue) + 1; // Size of the string
                            break;

                        case DBCBindingType.UNKNOWN:
                        case DBCBindingType.IGNORE_ORDER:
                        default:
                            _logger.Warning("Unsupported binding type {BindingType}", attribute.BindingType);
                            break;
                    }
                }
            }

            var header = new DBCHeader
            {
                Magic = 0x43424457, // 'WDBC'
                RecordCount = (uint)items.Count,
                FieldCount = (uint)properties.Count,
                RecordSize = recordSize,
                StringBlockSize = stringSize
            };

            writer.Write(header.Magic);
            writer.Write(header.RecordCount);
            writer.Write(header.FieldCount);
            writer.Write(header.RecordSize);
            writer.Write(header.StringBlockSize);

            var stringBlock = new List<byte>();
            var stringBlockOffset = 0;

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
                        case DBCBindingType.INT32:
                            writer.Write(value != null ? (int)value : 0);
                            break;

                        case DBCBindingType.UINT32:
                            writer.Write(value != null ? (uint)value : 0u);
                            break;

                        case DBCBindingType.UINT8:
                            writer.Write(value != null ? (byte)value : (byte)0);
                            break;

                        case DBCBindingType.FLOAT:
                            writer.Write(value != null ? (float)value : 0f);
                            break;

                        case DBCBindingType.DOUBLE:
                            writer.Write(value != null ? (double)value : 0d);
                            break;

                        case DBCBindingType.STRING:
                            var stringValue = value != null ? (string)value : string.Empty;
                            writer.Write(stringBlockOffset);
                            stringBlock.AddRange(Encoding.UTF8.GetBytes(stringValue));
                            stringBlock.Add(0);
                            stringBlockOffset += Encoding.UTF8.GetByteCount(stringValue) + 1;
                            break;

                        case DBCBindingType.UNKNOWN:
                        case DBCBindingType.IGNORE_ORDER:
                        default:
                            _logger.Warning("Unsupported binding type {BindingType}", attribute.BindingType);
                            break;
                    }
                }
            }

            writer.Write(stringBlock.ToArray());
        }
    }
}