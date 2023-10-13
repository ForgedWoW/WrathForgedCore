// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Serialization.Models;

namespace WrathForged.Models;

[AttributeUsage(AttributeTargets.Property)]
public class SerializablePropertyAttribute(uint index) : Attribute
{

    /// <summary>
    ///     The index of the property in the serialized stream.
    /// </summary>
    public uint Index { get; set; } = index;

    /// <summary>
    ///     The type code to use when serializing this property. Defaults to <see
    ///     cref="TypeCode.Empty"/> this will use the strongly typed type code.
    /// </summary>
    public ForgedTypeCode OverrideType { get; set; }

    /// <summary>
    ///     Collection size length type. <see cref="TypeCode.Empty"/> will use the default type
    ///     of the collection length. For example for array length or list count the default is
    ///     <see cref="TypeCode.Int32"/>.
    /// </summary>
    public TypeCode CollectionSizeLengthType { get; set; } = TypeCode.Empty;

    /// <summary>
    ///     The index of the property that contains the size of the collection. Only use this if
    ///     the collection size is not written to the stream immediately before the collection items.
    /// </summary>
    public uint CollectionSizeIndex { get; set; }

    /// <summary>
    ///     Set when the array or list has a fixed size and is not written to the stream.
    /// </summary>
    public int FixedCollectionSize { get; set; }

    /// <summary>
    ///     If this property is default value then it will not be serialized and sent to the stream.
    /// </summary>
    public bool DontSerializeWhenDefaultValue { get; set; }

    /// <summary>
    ///     If the value of the property index is default value then this property will not be
    ///     serialized and sent to the stream. The index must appear before this property in the
    ///     serialized stream.
    /// </summary>
    public uint DontSerializeWhenIndexIsDefaultValue { get; set; } = uint.MaxValue;

    /// <summary>
    ///     Read the property from a known index in the stream. If start is a negative number, start will be from the end of the stream, if -1 for end then the end of the stream will be used.
    ///     The stream position will be advanced to the end of the read property. This is useful for skipping bytes in the stream.
    ///     <see cref="SerializationFlags.UseBitRange"/> must be set in the <see cref="Flags"/> property.
    ///     <code>
    ///         BitRange = (start: 0, end: 1) // Read the first byte of the stream
    ///         BitRange = (start: -4, end: -1) // Read the last 4 bytes of the stream
    ///     </code>
    /// </summary>
    public int BitRangeStart { get; set; }

    /// <summary>
    ///     Read the property from a known index in the stream. If start is a negative number, start will be from the end of the stream, if -1 for end then the end of the stream will be used.
    ///     The stream position will be advanced to the end of the read property. This is useful for skipping bytes in the stream.
    ///     <see cref="SerializationFlags.UseBitRange"/> must be set in the <see cref="Flags"/> property.
    ///     <code>
    ///         BitRange = (start: 0, end: 1) // Read the first byte of the stream
    ///         BitRange = (start: -4, end: -1) // Read the last 4 bytes of the stream
    ///     </code>
    /// </summary>
    public int BitRangeEnd { get; set; }

    /// <summary>
    ///     Flags for specific serialization behaviors
    /// </summary>
    public SerializationFlags Flags { get; set; } = SerializationFlags.None;

}