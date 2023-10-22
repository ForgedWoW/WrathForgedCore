// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Collections;
using System.Diagnostics.Metrics;
using System.Reflection;
using Elskom.Generic.Libs;
using Serilog;
using WrathForged.Common.Caching;
using WrathForged.Common.Networking;
using WrathForged.Common.Observability;
using WrathForged.Common.Scripting;
using WrathForged.Common.Serialization.Serializers;
using WrathForged.Models;
using WrathForged.Serialization.Models;

namespace WrathForged.Common.Serialization;

public class ForgedModelSerializer
{
    private readonly ILogger _logger;

    /// <summary>
    ///     A cache of all the deserialization definitions for each object and their properties
    /// </summary>
    // Scope OpCode ObjType PropertyName, SerializationMetadata
    private readonly Dictionary<PacketScope, Dictionary<uint, (Type, ModelInfo)>> _deserializationMethodsCache = [];
    private readonly Dictionary<Type, ModelInfo> _deserializationMethodsCacheByType = [];
    private readonly Dictionary<Type, ModelInfo> _systemScope = [];
    private readonly Dictionary<Type, IForgedTypeSerialization> _serializers = [];
    private readonly Dictionary<ForgedTypeCode, IForgedTypeSerialization> _forgedTypeCodeSerializers = [];
    private readonly Dictionary<Type, Histogram<double>> _classDeserializationHistograms = [];
    private readonly Dictionary<Type, Histogram<double>> _classSerializationHistograms = [];
    private readonly Meter _meter;

    public ForgedModelSerializer(ILogger logger, ScriptLoader assemblyLoader, ClassFactory classFactory, MeterFactory meterFactory,
                                 AttributeCache<ForgedSerializableAttribute> forgedSerializableAttributeCache, AttributeCache<SerializablePropertyAttribute> serializableAttributeCache)
    {
        var classesWithAttribute = assemblyLoader.GetAllTypesWithClassAttribute<ForgedSerializableAttribute>();
        _meter = meterFactory.GetOrCreateMeter(MeterKeys.WRATHFORGED_COMMON);

        // Build the deserialization cache
        foreach (var cls in classesWithAttribute)
        {
            _classDeserializationHistograms[cls] = _meter.CreateHistogram<double>($"{cls.FullName}.Deserialization");
            _classSerializationHistograms[cls] = _meter.CreateHistogram<double>($"{cls.FullName}.Serialization");
            var attribute = forgedSerializableAttributeCache.GetAttribute(cls);

            if (attribute == null)
                continue;

            var propertyAttributes = new List<PropertyMeta>();
            var estimatedSize = 0; // get a rough idea if we have enough data to read the packet. This is mainly for packets that dont send the size.

            foreach (var prop in cls.GetProperties())
            {
                var propAtt = serializableAttributeCache.GetAttribute(prop);
                IConditionalSerialization? conditionalAtt = null;
                var hasConditional = false;

                foreach (var att in prop.GetCustomAttributes())
                    if (att is IConditionalSerialization conditionalSerialization)
                    {
                        hasConditional = true;
                        conditionalAtt = conditionalSerialization;
                        break;
                    }

                if (propAtt != null)
                {
                    propertyAttributes.Add(new PropertyMeta(propAtt, prop, conditionalAtt));

                    if (!hasConditional) // we don't want to count conditional properties in the size.
                        estimatedSize += GetPropertySize(prop, propAtt);
                }
            }

            propertyAttributes.Sort();
            var mi = new ModelInfo(cls, propertyAttributes, estimatedSize);
            _deserializationMethodsCacheByType[cls] = mi;

            if (!_systemScope.TryGetValue(cls, out var propertyAttr))
                _systemScope[cls] = mi;

            Queue<PacketScope> scopes = new();
            scopes.Enqueue(attribute.Scope);

            // cache all scopes.
            while (scopes.TryDequeue(out var scope))
            {
                if (scope == PacketScope.All)
                {
                    foreach (var s in (PacketScope[])Enum.GetValues(typeof(PacketScope)))
                    {
                        if (s == PacketScope.All)
                            continue;

                        scopes.Enqueue(s);
                    }
                }

                if (!_deserializationMethodsCache.TryGetValue(attribute.Scope, out var scopeDictionary))
                {
                    scopeDictionary = [];
                    _deserializationMethodsCache[attribute.Scope] = scopeDictionary;
                }

                foreach (var packetId in attribute.PacketIDs)
                    scopeDictionary[packetId] = (cls, mi);
            }
        }

        var serializers = classFactory.LocateAll<IForgedTypeSerialization>();

        foreach (var s in serializers)
        {
            foreach (var t in s.SupportedTypes)
                _serializers[t] = s;

            foreach (var tc in s.SupportedForgedTypeCodes)
                _forgedTypeCodeSerializers[tc] = s;
        }

        _logger = logger;
    }

    public void Serialize<T>(PrimitiveWriter writer, T obj)
    {
        if (obj == null)
            return;

        var t = obj.GetType();
        if (_deserializationMethodsCacheByType.TryGetValue(t, out var deserializationDefinition))
            Serialize(writer, obj, deserializationDefinition);
    }

    public void Serialize(PacketScope scope, uint packetId, PrimitiveWriter writer, object obj)
    {
        if (!_deserializationMethodsCache.TryGetValue(scope, out var scopeDictionary) ||
            !scopeDictionary.TryGetValue(packetId, out var deserializationDefinition))
        {
            return;
        }

        Serialize(writer, obj, deserializationDefinition.Item2);
    }

    private void Serialize(PrimitiveWriter writer, object obj, ModelInfo deserializationDefinition)
    {
        var startTimestamp = DateTime.UtcNow;
        foreach (var prop in deserializationDefinition.Properties)
        {
            if (prop.ConditionalSerialization != null && !prop.ConditionalSerialization.ShouldDeserialize(obj, prop, deserializationDefinition.Properties))
                continue;

            try
            {
                var propertyValue = prop.ReflectedProperty.GetValue(obj);

                if (prop.SerializationMetadata.Flags.HasFlag(SerializationFlags.DontSerializeWhenDefaultValue) &&
                    (propertyValue == null ||
                    propertyValue == prop.ReflectedProperty.PropertyType.GetDefault()))
                    continue;

                if (prop.SerializationMetadata.Flags.HasFlag(SerializationFlags.ZLibCompressedCollection) ||
                    prop.ReflectedProperty.PropertyType.IsArray ||
                    (prop.ReflectedProperty.PropertyType.IsGenericType && prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(List<>)) ||
                    (prop.ReflectedProperty.PropertyType.IsGenericType && prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(HashSet<>)))
                {
                    SerializeCollection(writer, prop, deserializationDefinition, obj, propertyValue);
                    continue;
                }

                SerializeProperty(writer, prop, deserializationDefinition, obj, propertyValue);
            }
            catch
            {
                _logger.Error("Failed to serialize property {PropertyName} for packet {Name}.", prop.ReflectedProperty.Name, obj.GetType().Name);
                throw;
            }
        }

        _classSerializationHistograms[obj.GetType()].Record((DateTime.UtcNow - startTimestamp).TotalMilliseconds);
    }

    public DeserializationResult TryDeserialize<T>(PacketBuffer buffer, out T packet)
    {
        var t = typeof(T);
        var result = TryDeserialize(buffer, t, out var obj);

        packet = result == DeserializationResult.Success ? (T)obj! : default!;

        return result;
    }

    public DeserializationResult TryDeserialize(PacketBuffer buffer, Type t, out object packet)
    {
        var startTimestamp = DateTime.UtcNow;

        if (!_systemScope.TryGetValue(t, out var propertyMetas))
        {
            packet = default!;
            return DeserializationResult.UnknownPacket;
        }

        if (!buffer.CanReadLength(propertyMetas.EstimatedSize))
        {
            packet = default!;
            return DeserializationResult.EndOfStream;
        }

        try
        {
            var instance = Activator.CreateInstance(t);

            if (instance == null)
            {
                packet = default!;
                return DeserializationResult.Error;
            }

            Dictionary<uint, int> collectionSizes = [];
            foreach (var prop in propertyMetas.Properties)
            {
                try
                {
                    if (prop.ConditionalSerialization != null && !prop.ConditionalSerialization.ShouldDeserialize(instance, prop, propertyMetas.Properties))
                        continue;

                    // we need to decompress the collection before we can read it. This means even if its a object or a list of objects, the underlying type is a byte array.
                    var isCollection = prop.SerializationMetadata.Flags.HasFlag(SerializationFlags.ZLibCompressedCollection) ||
                                       prop.ReflectedProperty.PropertyType.IsArray ||
                                       (prop.ReflectedProperty.PropertyType.IsGenericType && prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(List<>)) ||
                                       (prop.ReflectedProperty.PropertyType.IsGenericType && prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(HashSet<>));

                    var result = isCollection ? DeserializeCollection(buffer, prop, collectionSizes)
                                     : prop.ReflectedProperty.PropertyType.IsEnum && !IsStringEnum(prop)
                                         ? _forgedTypeCodeSerializers[ForgedTypeCode.Enum].Deserialize(buffer, prop, collectionSizes)
                                         : DeserializeProperty(buffer, prop, collectionSizes);

                    if (result != null)
                        prop.ReflectedProperty.SetValue(instance, EvaluateSpecialCasting(prop, result));
                }
                catch (EndOfStreamException)
                {
                    _logger.Verbose("Failed to deserialize property {PropertyName} for packet {Name}. End of stream.", prop.ReflectedProperty.Name, t.Name);
                    throw;
                }
                catch
                {
                    _logger.Error("Failed to deserialize property {PropertyName} for packet {Name}.", prop.ReflectedProperty.Name, t.Name);
                    throw;
                }
            }

            packet = instance;
            var ms = (DateTime.UtcNow - startTimestamp).TotalMilliseconds;
            _classDeserializationHistograms[t].Record(ms);
            return DeserializationResult.Success;
        }
        catch (EndOfStreamException eos)
        {
            _logger.Verbose(eos, "Failed to deserialize packet {Name} end of stream.", t.Name);
            packet = default!;
            return DeserializationResult.EndOfStream;
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Failed to deserialize packet {PacketId}", t.Name);
        }

        packet = default!;
        return DeserializationResult.Error;
    }

    public DeserializationResult TryDeserialize(PacketScope scope, uint packetId, PacketBuffer buffer, out object packet)
    {
        var startTimestamp = DateTime.UtcNow;
        if (!_deserializationMethodsCache.TryGetValue(scope, out var scopeDictionary))
        {
            packet = default!;
            return DeserializationResult.UnknownPacket;
        }

        if (!scopeDictionary.TryGetValue(packetId, out var deserializationDefinition))
        {
            packet = default!;
            return DeserializationResult.UnknownPacket;
        }

        if (!buffer.CanReadLength(deserializationDefinition.Item2.EstimatedSize))
        {
            packet = default!;
            return DeserializationResult.EndOfStream;
        }

        try
        {
            var instance = Activator.CreateInstance(deserializationDefinition.Item1);

            if (instance == null)
            {
                packet = default!;
                return DeserializationResult.Error;
            }

            Dictionary<uint, int> collectionSizes = [];
            foreach (var prop in deserializationDefinition.Item2.Properties)
            {
                try
                {
                    if (prop.ConditionalSerialization != null && !prop.ConditionalSerialization.ShouldDeserialize(instance, prop, deserializationDefinition.Item2.Properties))
                        continue;

                    var isCollection = prop.SerializationMetadata.Flags.HasFlag(SerializationFlags.ZLibCompressedCollection) ||
                                        prop.ReflectedProperty.PropertyType.IsArray ||
                                       (prop.ReflectedProperty.PropertyType.IsGenericType && prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(List<>)) ||
                                       (prop.ReflectedProperty.PropertyType.IsGenericType && prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(HashSet<>));

                    var result = isCollection ? DeserializeCollection(buffer, prop, collectionSizes)
                                     : prop.ReflectedProperty.PropertyType.IsEnum && !IsStringEnum(prop)
                                         ? _forgedTypeCodeSerializers[ForgedTypeCode.Enum].Deserialize(buffer, prop, collectionSizes)
                                         : DeserializeProperty(buffer, prop, collectionSizes);

                    if (result != null)
                        prop.ReflectedProperty.SetValue(instance, EvaluateSpecialCasting(prop, result));
                }
                catch (EndOfStreamException)
                {
                    _logger.Verbose("Failed to deserialize property {PropertyName} for packet {PacketId} for scope {Scope}. End of stream.", prop.ReflectedProperty.Name, packetId, scope);
                    throw;
                }
                catch
                {
                    _logger.Error("Failed to deserialize property {PropertyName} for packet {PacketId} for scope {Scope}", prop.ReflectedProperty.Name, packetId, scope);
                    throw;
                }
            }

            packet = instance ?? default!;
            var ms = (DateTime.UtcNow - startTimestamp).TotalMilliseconds;
            _classDeserializationHistograms[deserializationDefinition.Item1].Record(ms);
            return DeserializationResult.Success;
        }
        catch (EndOfStreamException eos)
        {
            _logger.Verbose(eos, "Failed to deserialize packet {Name} with packet id: {PacketId} for scope: {Scope}. End of stream.", deserializationDefinition.Item1.Name, packetId, scope);
            packet = default!;
            return DeserializationResult.EndOfStream;
        }
        catch (Exception ex)
        {
            _logger.Error(ex, "Failed to deserialize packet {Name} with packet id: {PacketId} for scope {Scope}", deserializationDefinition.Item1.Name, packetId, scope);
        }

        packet = default!;
        return DeserializationResult.Error;
    }

    private object? DeserializeCollection(PacketBuffer oldBuffer, PropertyMeta prop, Dictionary<uint, int> collectionSizes)
    {
        var buffer = oldBuffer;
        var collectionSize = buffer.GetCollectionSize(prop, collectionSizes);
        var targetType = prop.ReflectedProperty.PropertyType;

        if (prop.SerializationMetadata.Flags.HasFlag(SerializationFlags.ZLibCompressedCollection))
        {
            byte[] compressedData = [];

            if (prop.SerializationMetadata.Flags.HasFlag(SerializationFlags.UseBitRange))
            {
                var end = prop.SerializationMetadata.BitRangeEnd == -1 ? (int)buffer.Reader.BaseStream.Length : prop.SerializationMetadata.BitRangeEnd;
                var start = prop.SerializationMetadata.BitRangeStart < 0 ? prop.SerializationMetadata.BitRangeStart + (int)buffer.Reader.BaseStream.Length : prop.SerializationMetadata.BitRangeStart;
                compressedData = buffer.GetBuffer().Slice(start, end).ToArray();
                oldBuffer.Reader.BaseStream.Position = end;
            }
            else
            {
                compressedData = buffer.Reader.ReadBytes(collectionSize);
            }

            MemoryZlib.Decompress(compressedData, out var decompressedData);
            buffer = new PacketBuffer(decompressedData, _logger);

            var isCollection = targetType.IsArray ||
                               (targetType.IsGenericType && targetType.GetGenericTypeDefinition() == typeof(List<>)) ||
                               (targetType.IsGenericType && targetType.GetGenericTypeDefinition() == typeof(HashSet<>));

            if (!isCollection) // even though it was a byte buffer, the property is not a collection, so we need to deserialize it as a normal property.
                return DeserializeProperty(buffer, prop, collectionSizes);

            collectionSize = buffer.GetCollectionSize(prop, collectionSizes); // get the collection size from the decompressed data.
        }

        if (targetType.IsArray)
        {
            var elementType = targetType.GetElementType();

            if (elementType == null)
                return null;

            // common case that can save a lot of time.
            if (elementType == typeof(byte))
                return buffer.Reader.ReadBytes(collectionSize);

            var array = Array.CreateInstance(elementType, collectionSize);
            for (var i = 0; i < collectionSize; i++)
            {
                array.SetValue(EvaluateSpecialCasting(prop, DeserializeProperty(buffer, prop, collectionSizes)), i);
            }

            return array;
        }
        else if (targetType.IsGenericType && targetType.GetGenericTypeDefinition() == typeof(List<>))
        {
            var elementType = targetType.GetGenericArguments()[0];
            var listType = typeof(List<>).MakeGenericType(elementType);

            if (Activator.CreateInstance(listType) is not IList list)
                return null;

            for (var i = 0; i < collectionSize; i++)
            {
                _ = list.Add(EvaluateSpecialCasting(prop, DeserializeProperty(buffer, prop, collectionSizes)));
            }

            return list;
        }
        else if (targetType.IsGenericType && targetType.GetGenericTypeDefinition() == typeof(HashSet<>))
        {
            var elementType = targetType.GetGenericArguments()[0];
            var hashSetType = typeof(HashSet<>).MakeGenericType(elementType);
            var hashSet = Activator.CreateInstance(hashSetType) as dynamic;

            if (hashSet == null)
                return null;

            for (var i = 0; i < collectionSize; i++)
            {
                hashSet.Add(EvaluateSpecialCasting(prop, DeserializeProperty(buffer, prop, collectionSizes)));
            }

            return hashSet;
        }
        else
        {
            return null;
        }
    }

    private void SerializeCollection(PrimitiveWriter oldWriter, PropertyMeta prop, ModelInfo otherMeta, object obj, object? val)
    {
        var i = 0;
        var writer = oldWriter;

        _ = writer.SerializeCollectionSize(prop, otherMeta.Properties, obj);

        if (prop.SerializationMetadata.Flags.HasFlag(SerializationFlags.ZLibCompressedCollection))
        {

            if (prop.SerializationMetadata.Flags.HasFlag(SerializationFlags.UseBitRange))
                writer.BaseStream.Position = prop.SerializationMetadata.BitRangeStart < 0 ? prop.SerializationMetadata.BitRangeStart + (int)writer.BaseStream.Length : prop.SerializationMetadata.BitRangeStart;

            var isCollection = prop.ReflectedProperty.PropertyType.IsArray ||
                               (prop.ReflectedProperty.PropertyType.IsGenericType && prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(List<>)) ||
                               (prop.ReflectedProperty.PropertyType.IsGenericType && prop.ReflectedProperty.PropertyType.GetGenericTypeDefinition() == typeof(HashSet<>));

            writer = new PrimitiveWriter();

            if (!isCollection)
            {
                SerializeProperty(writer, prop, otherMeta, obj, val);
                MemoryZlib.Compress(((MemoryStream)writer.BaseStream).GetBuffer(), out var compressedData);
                oldWriter.Write(compressedData);
                return;
            }
        }

        // common case that can save a lot of time.
        if (prop.ReflectedProperty.PropertyType == typeof(byte[]))
        {
            if (val is byte[] bytes)
                writer.Write(bytes);
            return;
        }

        var elementType = prop.ReflectedProperty.PropertyType.GenericTypeArguments.Length != 0
                            ? prop.ReflectedProperty.PropertyType.GenericTypeArguments[0]
                            : prop.ReflectedProperty.PropertyType.GetElementType();

        if (val is IEnumerable collection)
            foreach (var item in collection)
            {
                SerializeProperty(writer, prop, otherMeta, obj, item);
                i++;
            }

        if (prop.SerializationMetadata.FixedCollectionSize > i)
        {
            for (; i < prop.SerializationMetadata.FixedCollectionSize; i++)
                SerializeProperty(writer, prop, otherMeta, obj, elementType.GetDefault());
        }

        if (prop.SerializationMetadata.Flags.HasFlag(SerializationFlags.ZLibCompressedCollection))
        {
            MemoryZlib.Compress(((MemoryStream)writer.BaseStream).GetBuffer(), out var compressedData);
            oldWriter.Write(compressedData);
        }
    }

    private object? DeserializeProperty(PacketBuffer buffer, PropertyMeta prop, Dictionary<uint, int> collectionSizes)
    {
        if (!TryGetSerializerFromType(prop, out var forgedTypeSerialization))
        {
            return _deserializationMethodsCacheByType.ContainsKey(prop.ReflectedProperty.PropertyType)
                ? TryDeserialize(buffer, prop.ReflectedProperty.PropertyType, out var obj) == DeserializationResult.Success ? obj : null
                : null;
        }

        if (prop.SerializationMetadata.Flags.HasFlag(SerializationFlags.UseBitRange) && !prop.SerializationMetadata.Flags.HasFlag(SerializationFlags.ZLibCompressedCollection))
        {
            var end = prop.SerializationMetadata.BitRangeEnd == -1 ? (int)buffer.Reader.BaseStream.Length : prop.SerializationMetadata.BitRangeEnd;
            var start = prop.SerializationMetadata.BitRangeStart < 0 ? prop.SerializationMetadata.BitRangeStart + (int)buffer.Reader.BaseStream.Length : prop.SerializationMetadata.BitRangeStart;
            var newBuffer = new PacketBuffer(buffer.GetBuffer().Slice(start, end), _logger);
            buffer.Reader.BaseStream.Position = end;
            return forgedTypeSerialization?.Deserialize(newBuffer, prop, collectionSizes);
        }

        return forgedTypeSerialization?.Deserialize(buffer, prop, collectionSizes);
    }

    private void SerializeProperty(PrimitiveWriter writer, PropertyMeta prop, ModelInfo otherMeta, object obj, object? val)
    {
        if (TryGetSerializerFromType(prop, out var forgedTypeSerialization))
        {
            forgedTypeSerialization?.Serialize(writer, prop, otherMeta.Properties, obj, val);
        }
        else if (val != null && _deserializationMethodsCacheByType.ContainsKey(val.GetType())) // its an object, so serialize it.
            Serialize(writer, val);
    }

#pragma warning disable CS8601
    private bool TryGetSerializerFromType(PropertyMeta prop, out IForgedTypeSerialization forgedTypeSerialization)
    {
        var propertyType = prop.ReflectedProperty.PropertyType;

        if (propertyType.IsArray)
        {
            var elementType = propertyType.GetElementType() ?? typeof(int); // this should never happen, its to keep the compiler happy.

            return _serializers.TryGetValue(elementType, out forgedTypeSerialization);
        }
        else if (propertyType.IsGenericType &&
                 (propertyType.GetGenericTypeDefinition() == typeof(List<>) ||
                  propertyType.GetGenericTypeDefinition() == typeof(HashSet<>)))
        {
            return _serializers.TryGetValue(propertyType.GetGenericArguments()[0], out forgedTypeSerialization);
        }
        else if (propertyType.IsEnum)
        {
            forgedTypeSerialization = _forgedTypeCodeSerializers[ForgedTypeCode.Enum];
            return true;
        }
        else
        {
            return _forgedTypeCodeSerializers.TryGetValue(prop.SerializationMetadata.OverrideType, out forgedTypeSerialization) ||
                   _serializers.TryGetValue(propertyType, out forgedTypeSerialization);
        }
    }

#pragma warning restore CS8601

    private static object? EvaluateSpecialCasting(PropertyMeta prop, object? val)
    {
        if (val == null)
            return null;

        if (IsStringEnum(prop))
        {
            if (Enum.TryParse(prop.ReflectedProperty.PropertyType, val.ToString(), true, out var result) && result != null)
                return result;
            else
                return Activator.CreateInstance(prop.ReflectedProperty.PropertyType); // default enum value if we fail to parse.
        }

        return val;
    }

    private static bool IsStringEnum(PropertyMeta prop)
    {
        return prop.ReflectedProperty.PropertyType.IsEnum &&
                       (prop.SerializationMetadata.OverrideType is ForgedTypeCode.String or
                                                                   ForgedTypeCode.ASCIIString or
                                                                   ForgedTypeCode.CString or
                                                                   ForgedTypeCode.PascalString or
                                                                   ForgedTypeCode.FourCCString);
    }

    public static int GetPropertySize(PropertyInfo property, SerializablePropertyAttribute attribute)
    {
        var size = 0;
        var typeCode = attribute.CollectionSizeLengthType != TypeCode.Empty ? attribute.CollectionSizeLengthType : Type.GetTypeCode(property.PropertyType);

        if (attribute.Flags.HasFlag(SerializationFlags.DontSerializeWhenDefaultValue))

            switch (typeCode)
            {
                case TypeCode.Boolean:
                    size = sizeof(bool);
                    break;
                case TypeCode.Byte:
                    size = sizeof(byte);
                    break;
                case TypeCode.Char:
                    size = sizeof(char);
                    break;
                case TypeCode.Decimal:
                    size = sizeof(decimal);
                    break;
                case TypeCode.Double:
                    size = sizeof(double);
                    break;
                case TypeCode.Int16:
                    size = sizeof(short);
                    break;
                case TypeCode.Int32:
                    size = sizeof(int);
                    break;
                case TypeCode.Int64:
                    size = sizeof(long);
                    break;
                case TypeCode.SByte:
                    size = sizeof(sbyte);
                    break;
                case TypeCode.Single:
                    size = sizeof(float);
                    break;
                case TypeCode.UInt16:
                    size = sizeof(ushort);
                    break;
                case TypeCode.UInt32:
                    size = sizeof(uint);
                    break;
                case TypeCode.UInt64:
                    size = sizeof(ulong);
                    break;
                case TypeCode.String:
                    size = 2; // Assuming string length as short
                    break;
                case TypeCode.Empty:
                case TypeCode.Object:
                case TypeCode.DBNull:
                case TypeCode.DateTime:

                    break;
            }

        return size;
    }
}