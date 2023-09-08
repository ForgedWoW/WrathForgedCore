// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;

namespace WrathForged.Serialization
{
    public class SerializablePropertyAttribute : Attribute
    {
        public SerializablePropertyAttribute(uint index) => Index = index;

        /// <summary>
        ///     The index of the property in the serialized stream.
        /// </summary>
        public uint Index { get; set; }

        /// <summary>
        ///    The type code to use when serializing this property. Defaults to <see cref="TypeCode.Empty" /> this will use the strongly typed type code.
        /// </summary>
        public ForgedTypeCode OverrideType { get; set; }

        /// <summary>
        ///     Collection size length type. <see cref="TypeCode.Empty" /> will use the default type of the collection length.
        ///     For example for array length or list count the default is <see cref="TypeCode.Int32" />.
        /// </summary>
        public TypeCode CollectionSizeLengthType { get; set; } = TypeCode.Empty;

        /// <summary>
        ///    The index of the property that contains the size of the collection. Only use this if the collection size is not written to the stream immediately before the collection items.
        /// </summary>
        public uint CollectionSizeIndex { get; set; }

        /// <summary>
        ///     Set when the array or list has a fixed size and is not written to the stream.
        /// </summary>
        public uint FixedCollectionSize { get; set; }

        /// <summary>
        ///     If this property is default value then it will not be serialized and sent to the stream.
        /// </summary>
        public bool DontSerializeWhenDefaultValue { get; set; }

        /// <summary>
        ///    If the value of the property index is default value then this property will not be serialized and sent to the stream.
        ///    The index must apper before this property in the serialized stream.
        /// </summary>
        public uint DontSerializeWhenIndexIsDefaultValue { get; set; } = uint.MaxValue;

        /// <summary>
        ///     If the string is reversed then it will be reversed after being deserialized.
        /// </summary>
        public bool ReversedString { get; set; }
    }
}