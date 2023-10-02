// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Reflection;
using WrathForged.Serialization.Models;

namespace WrathForged.Models
{
    public class PropertyMeta : IComparable<PropertyMeta>
    {
        public PropertyMeta(SerializablePropertyAttribute attribute, PropertyInfo property, IConditionalSerialization? conditionalSerialization)
        {
            SerializationMetadata = attribute;
            ReflectedProperty = property;
            ConditionalSerialization = conditionalSerialization;
        }

        public SerializablePropertyAttribute SerializationMetadata { get; set; }
        public PropertyInfo ReflectedProperty { get; set; }
        public IConditionalSerialization? ConditionalSerialization { get; set; }

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