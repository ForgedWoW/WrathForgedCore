using System.Reflection;
using WrathForged.Serialization;

namespace WrathForged.Common.Serialization
{
    internal class PropertyMeta : IComparable<PropertyMeta>
    {
        internal PropertyMeta(SerializablePropertyAttribute attribute, PropertyInfo property)
        {
            Attribute = attribute;
            Property = property;
        }

        internal SerializablePropertyAttribute Attribute { get; set; }
        internal PropertyInfo Property { get; set; }

        public int CompareTo(PropertyMeta? other)
        {
            return other == null
                ? 1
                : Attribute == null && other.Attribute == null
                ? 0
                : Attribute == null ? -1 : other.Attribute == null ? 1 : Attribute.Index.CompareTo(other.Attribute.Index);
        }
    }
}