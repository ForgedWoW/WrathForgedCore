// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Reflection;
using WrathForged.Models;

namespace WrathForged.Common.Serialization
{
    public class PropertyMeta : IComparable<PropertyMeta>
    {
        public PropertyMeta(SerializablePropertyAttribute attribute, PropertyInfo property)
        {
            SerializationMetadata = attribute;
            ReflectedProperty = property;
        }

        public SerializablePropertyAttribute SerializationMetadata { get; set; }
        public PropertyInfo ReflectedProperty { get; set; }

        public int CompareTo(PropertyMeta? other)
        {
            return other == null
                ? 1
                : SerializationMetadata == null && other.SerializationMetadata == null
                ? 0
                : SerializationMetadata == null ? -1 : other.SerializationMetadata == null ? 1 : SerializationMetadata.Index.CompareTo(other.SerializationMetadata.Index);
        }
    }
}