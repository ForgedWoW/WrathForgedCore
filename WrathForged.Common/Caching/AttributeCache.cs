// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Reflection;

namespace WrathForged.Common.Caching
{
    public class AttributeCache<T> where T : Attribute
    {
        // we cache the attributes so we don't have to use reflection every time, c# creates a new instance of the attribute every time you use GetCustomAttribute
        // we dont need a lock as we only ever read from this dictionary and we only add to it.
        private readonly Dictionary<Type, T> _cachedAttributes = [];

        public T? GetAttribute(Type type)
        {
            if (_cachedAttributes.TryGetValue(type, out var attribute))
                return attribute;

            attribute = type.GetCustomAttribute<T>(false);

            if (attribute == null)
                return null;

            _cachedAttributes[type] = attribute;

            return attribute;
        }

        public T? GetAttribute(PropertyInfo property)
        {
            return GetAttribute(property.PropertyType);
        }

        public T? GetAttribute(FieldInfo field)
        {
            return GetAttribute(field.FieldType);
        }

        public T? GetAttribute(MethodInfo method)
        {
            return GetAttribute(method.ReturnType);
        }

        public T? GetAttribute(EventInfo evnt)
        {
            if (evnt.EventHandlerType == null)
                return null;

            return GetAttribute(evnt.EventHandlerType);
        }

        public T? GetAttribute(ParameterInfo parameter)
        {
            return GetAttribute(parameter.ParameterType);
        }

        public T? GetAttribute(ConstructorInfo constructor)
        {
            if (constructor.DeclaringType == null)
                return null;

            return GetAttribute(constructor.DeclaringType);
        }

        public T? GetAttributeFromObject(object obj)
        {
            return GetAttribute(obj.GetType());
        }

        public bool TryGetAttribute(Type type, out T attribute)
        {
            attribute = GetAttribute(type) ?? default!;

            return attribute != default!;
        }

        public bool TryGetAttribute(PropertyInfo property, out T attribute)
        {
            attribute = GetAttribute(property) ?? default!;

            return attribute != default!;
        }

        public bool TryGetAttribute(FieldInfo field, out T attribute)
        {
            attribute = GetAttribute(field) ?? default!;

            return attribute != default!;
        }

        public bool TryGetAttribute(MethodInfo method, out T attribute)
        {
            attribute = GetAttribute(method) ?? default!;

            return attribute != null;
        }

        public bool TryGetAttribute(EventInfo evnt, out T attribute)
        {
            attribute = GetAttribute(evnt) ?? default!;

            return attribute != default!;
        }

        public bool TryGetAttribute(ParameterInfo parameter, out T attribute)
        {
            attribute = GetAttribute(parameter) ?? default!;

            return attribute != default!;
        }

        public bool TryGetAttribute(ConstructorInfo constructor, out T attribute)
        {
            attribute = GetAttribute(constructor) ?? default!;

            return attribute != default!;
        }

        public bool TryGetAttributeFromObject(object obj, out T attribute)
        {
            attribute = GetAttributeFromObject(obj) ?? default!;

            return attribute != default!;
        }
    }
}
