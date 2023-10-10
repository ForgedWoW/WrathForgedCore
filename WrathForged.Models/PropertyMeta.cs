// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Reflection;

namespace WrathForged.Models
{
    public class PropertyMeta(SerializablePropertyAttribute attribute, PropertyInfo property, IConditionalSerialization? conditionalSerialization) : IComparable<PropertyMeta>
    {
        public SerializablePropertyAttribute SerializationMetadata { get; set; } = attribute;
        public PropertyInfo ReflectedProperty { get; set; } = property;
        public IConditionalSerialization? ConditionalSerialization { get; set; } = conditionalSerialization;

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