// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System;

namespace WrathForged.Serialization
{
    public class SerializablePropertyAttribute : Attribute
    {
        public SerializablePropertyAttribute(uint index,
                                                ForgedTypeCode overrideType = default,
                                                TypeCode collectionSizeLengthType = default,
                                                uint collectionSizeIndex = 0,
                                                uint fixedCollectionSize = 0)
        {
            Index = index;
            OverrideType = overrideType;
            CollectionSizeLengthType = collectionSizeLengthType;
            CollectionSizeIndex = collectionSizeIndex;
            FixedCollectionSize = fixedCollectionSize;
        }

        /// <summary>
        ///     The index of the property in the serialized stream.
        /// </summary>
        public uint Index { get; }

        /// <summary>
        ///    The type code to use when serializing this property. Defaults to <see cref="TypeCode.Empty" /> this will use the strongly typed type code.
        /// </summary>
        public ForgedTypeCode OverrideType { get; }

        /// <summary>
        ///     Collection size length type. <see cref="TypeCode.Empty" /> will use the default type of the collection length.
        ///     For example for array length or list count the default is <see cref="TypeCode.Int32" />.
        /// </summary>
        public TypeCode CollectionSizeLengthType { get; } = TypeCode.Empty;

        /// <summary>
        ///    The index of the property that contains the size of the collection. Only use this if the collection size is not written to the stream immediately before the collection items.
        /// </summary>
        public uint CollectionSizeIndex { get; }

        /// <summary>
        ///     Set when the array or list has a fixed size and is not written to the stream.
        /// </summary>
        public uint FixedCollectionSize { get; }
    }
}