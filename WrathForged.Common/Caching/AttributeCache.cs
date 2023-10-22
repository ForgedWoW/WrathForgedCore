// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using System.Reflection;

namespace WrathForged.Common.Caching;

public class AttributeCache<T> where T : Attribute
{
    // we cache the attributes so we don't have to use reflection every time, c# creates a new instance of the attribute every time you use GetCustomAttribute
    // we dont need a lock as we only ever read from this dictionary and we only add to it.
    private readonly Dictionary<Type, T> _cachedAttributes = [];
    private readonly Dictionary<PropertyInfo, T> _cachedPropertyAttributes = [];
    private readonly Dictionary<FieldInfo, T> _cachedFieldAttributes = [];
    private readonly Dictionary<MethodInfo, T> _cachedMethodAttributes = [];
    private readonly Dictionary<EventInfo, T> _cachedEventAttributes = [];
    private readonly Dictionary<ParameterInfo, T> _cachedParameterAttributes = [];
    private readonly Dictionary<ConstructorInfo, T> _cachedConstructorAttributes = [];

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
        if (_cachedPropertyAttributes.TryGetValue(property, out var attribute))
            return attribute;

        attribute = property.GetCustomAttribute<T>(false);

        if (attribute == null)
            return null;

        _cachedPropertyAttributes[property] = attribute;
        return attribute;
    }

    public T? GetAttribute(FieldInfo field)
    {
        if (_cachedFieldAttributes.TryGetValue(field, out var attribute))
            return attribute;

        attribute = field.GetCustomAttribute<T>(false);

        if (attribute == null)
            return null;

        _cachedFieldAttributes[field] = attribute;
        return attribute;
    }

    public T? GetAttribute(MethodInfo method)
    {
        if (_cachedMethodAttributes.TryGetValue(method, out var attribute))
            return attribute;

        attribute = method.GetCustomAttribute<T>(false);

        if (attribute == null)
            return null;

        _cachedMethodAttributes[method] = attribute;
        return attribute;
    }

    public T? GetAttribute(EventInfo evnt)
    {
        if (_cachedEventAttributes.TryGetValue(evnt, out var attribute))
            return attribute;

        attribute = evnt.GetCustomAttribute<T>(false);

        if (attribute == null)
            return null;

        _cachedEventAttributes[evnt] = attribute;
        return attribute;
    }

    public T? GetAttribute(ParameterInfo parameter)
    {
        if (_cachedParameterAttributes.TryGetValue(parameter, out var attribute))
            return attribute;

        attribute = parameter.GetCustomAttribute<T>(false);

        if (attribute == null)
            return null;

        _cachedParameterAttributes[parameter] = attribute;
        return attribute;
    }

    public T? GetAttribute(ConstructorInfo constructor)
    {
        if (_cachedConstructorAttributes.TryGetValue(constructor, out var attribute))
            return attribute;

        attribute = constructor.GetCustomAttribute<T>(false);

        if (attribute == null)
            return null;

        _cachedConstructorAttributes[constructor] = attribute;
        return attribute;
    }

    public T? GetAttributeFromObject(object obj) => GetAttribute(obj.GetType());

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
