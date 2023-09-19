// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore> Licensed under
// GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Extensions.Configuration;
using Serilog;
using WrathForged.Database.DBC;

namespace WrathForged.Common.DBC
{
    public class DBCSerializer
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;

        public DBCSerializer(IConfiguration configuration, ILogger logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public static void Serialize<T>(IEnumerable<T> items, string filePath) where T : class
        {
            if (typeof(T).GetCustomAttribute(typeof(DBCBoundAttribute)) is not DBCBoundAttribute dbcAtt)
                return;

            using var writer = new BinaryWriter(File.Open(Path.Combine(filePath, dbcAtt.Name), FileMode.Create));
            var type = typeof(T);
            var properties = type.GetProperties()
                                 .Where(p => Attribute.IsDefined(p, typeof(DBCPropertyBindingAttribute)))
                                 .OrderBy(p => (p.GetCustomAttribute(typeof(DBCPropertyBindingAttribute)) as DBCPropertyBindingAttribute)?.ColumnIndex)
                                 .ToArray();

            var header = new DBCHeader
            {
                Magic = 0x43424457, // 'WDBC'
                RecordCount = (uint)items.Count(),
                FieldCount = (uint)properties.Length,
                RecordSize = (uint)properties.Sum(p => Marshal.SizeOf(p.PropertyType)),
                StringBlockSize = (uint)items.SelectMany(item => properties.Select(p => p.GetValue(item)?.ToString() ?? string.Empty))
                                       .Sum(value => Encoding.UTF8.GetByteCount(value) + 1)
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
                            throw new InvalidOperationException("Unsupported binding type");
                    }
                }
            }

            writer.Write(stringBlock.ToArray());
        }
    }
}