// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
namespace WrathForged.Serialization.Models;

/// <summary>
///     Flags for specific serialization behaviors
/// </summary>
[Flags]
public enum SerializationFlags
{
    None = 0,

    /// <summary>
    ///     If the string is reversed then it will be reversed after being deserialized.
    /// </summary>
    ReversedString = 1 << 0,

    /// <summary>
    ///     Most strings in WoTLK are ASCII, but some are UTF8. This flag will force the serializer to read/write the string as UTF8.
    /// </summary>
    UTF8CString = 1 << 1,

    /// <summary>
    ///    If the <see cref="BigInteger"/> is prefixed with the length of the BigInteger then it will be read/written.
    ///    Most cases this is not needed as the size of the BigInteger is known.
    /// </summary>
    BigIntegerWithLength = 1 << 2,

    /// <summary>
    ///     Big Endian Network Order
    /// </summary>
    BENetworkOrder = 1 << 3,

    /// <summary>
    ///     The default behavior of the serializer is to not send/read FixedCollectionSize. This flag will force the serializer to send/read the FixedCollectionSize.
    /// </summary>
    SendFixedSize = 1 << 4,

    /// <summary>
    ///     Set the size of the collection to the rest of the packet.
    /// </summary>
    ReadRestOfPacket = 1 << 5,

    DontSerializeCollectionSize = 1 << 6,

    /// <summary>
    ///    Will compress/decompress the collection using ZLib using the raw byte[]
    ///    The underlying collection must be a byte[] for this to work. This means if the size is defined in the packet or FixedCollectionSize is used this size MUST be the size of the byte[] NOT the length of the collection of objects you are deserializing.
    ///    Optionally you can define BitRange if the range of the packets is known as an alternative to FixedCollectionSize or size being written in the stream.
    ///    The actual type of the property can be the deserialized type of the decompressed data.
    /// </summary>
    ZLibCompressedCollection = 1 << 7,

    /// <summary>
    ///     When reading the property from the stream use the BitRangeStart and BitRangeEnd to read the property.
    /// </summary>
    UseBitRange = 1 << 8,

    /// <summary>
    ///     If this property is default value then it will not be serialized and sent to the stream.
    /// </summary>
    DontSerializeWhenDefaultValue = 1 << 9,

    DictionaryKeyIsIndex = 1 << 10,

    DictionaryValueIsIndex = 1 << 11
}